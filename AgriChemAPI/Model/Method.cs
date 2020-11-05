using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgriChemAPI.Model
{
    public class Method
    {
        [Key]
        public Int64 MethodId { get; set; }
        public String MethodName { get; set; }
    }
}
