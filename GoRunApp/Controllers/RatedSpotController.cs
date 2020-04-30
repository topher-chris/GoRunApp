using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoRunApp.Data;
using GoRunApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace GoRunApp.Controllers
{
    public class RatedSpotController : Controller
    {//constructor
        private GoRunAppContext _context;

        //constructor
        public RatedSpotController(GoRunAppContext context)
        {
            this._context = context;
        }       //end of contructor

        //action to return a data query

        public IActionResult Index()                //was not routed until i changed view folder name form ratedspotdata to ratedspot
        {
            return View("Index");
        }
        public IActionResult Data()     //return a set of object that have the zone number and count how many of them
        {                           //return [{zone:1,count:3],{}]
            var result = _context.RunningSpot
                .GroupBy(x => new { group = x.Rate })
                .Select(group => new
                {
                    rate = group.Key.group,
                    locationName = group.Count()
                }
        ).OrderByDescending(o => o.rate).ToList();
            // return Json(result);
            var labels = result.Select(x => x.locationName).ToArray();
            var values = result.Select(x => x.rate).ToArray();
            var max = values[0];
            List<object> list1 = new List<object>();
            list1.Add(labels);
            list1.Add(values);
            list1.Add(max);
            return Json(list1);
                    
        }
    }//ec
}