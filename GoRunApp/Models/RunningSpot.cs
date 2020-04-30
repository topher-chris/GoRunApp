using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoRunApp.Models
{
    public class RunningSpot
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Location Name")]
        public string LocationName { get; set; }

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Required]
        [Display(Name = "Location Type")]
        public string LocationType { get; set; }

        [Range(1, 10)]
        [Display(Name = "Rate This")]
     
        public int Rate { get; set; }


    }
}
