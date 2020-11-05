using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgriChemAPI.Model
{
    public class Reason
    {
        [Key]
        public Int64 ReasonId { get; set; }
        public String ReasonName { get; set; }
    }
}