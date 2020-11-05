using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgriChemAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgriChemAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AgriChemicalApplicationController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public AgriChemicalApplicationController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<AgriChemicalApplication>> Get()
        {
            return Ok(_context.AgriChemicalApplication.ToList());
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<AgriChemicalApplication> Get(int id)
        {
            var agriChemical = _context.AgriChemicalApplication.FirstOrDefault(a => a.AgriChemAppId == id);
            return Ok(agriChemical);
        }

        [HttpPost]
        public ActionResult<AgriChemicalApplication> post(AgriChemicalApplication agriChemical)
        {
            _context.AgriChemicalApplication.Add(agriChemical);
            _context.SaveChanges();
            return Ok(agriChemical);
        }
    }
}