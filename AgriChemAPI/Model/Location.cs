using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgriChemAPI.Model
{
    public class Location
    {
        [Key]
        public Int64 LocationId { get; set; }
        public String LocationName { get; set; }
    }
}
