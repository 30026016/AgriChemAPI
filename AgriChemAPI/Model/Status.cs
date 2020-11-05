using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgriChemAPI.Model
{
    public class Status
    {
        [Key]
        public Int64 StatusId { get; set; }
        public String StatusName { get; set; }
    }
}
