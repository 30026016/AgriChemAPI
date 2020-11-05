using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgriChemAPI.Model
{
    public class AgriChemicalApplication
    {
        [Key]
        public Int64 AgriChemAppId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }
        public String Region { get; set; }
        public String Contractor { get; set; }
        public String ContractManager { get; set; }
        public String Comments { get; set; }
        public String Location { get; set; }
        public String Method { get; set; }
        public String Reason { get; set; }
        public String ReasonComments { get; set; }
        public String AgriChemical1 { get; set; }
        public String AgriChemical1Volume { get; set; }
        public String AgriChemical1Unit { get; set; }
        public String AgriChemical2 { get; set; }
        public String AgriChemical2Volume { get; set; }
        public String AgriChemical2Unit { get; set; }
        public String AgriChemical3 { get; set; }
        public String AgriChemical3Volume { get; set; }
        public String AgriChemical3Unit { get; set; }
        public String PostComments { get; set; }
        public String Status { get; set; }
    }
}
