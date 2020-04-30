using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace GoRunApp.Models
{
    public class RatedSpots
    {
        [Key]
        public int Id { get; set; }
        public int Rate { get; set; }
        public string LocationName { get; set; }
    }
}
