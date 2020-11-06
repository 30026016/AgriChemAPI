using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgriChemAPI.Model
{
    public class Login
    {
        [Key]
        public String UserName { get; set; }
        public String PassWord { get; set; }
    }
}
