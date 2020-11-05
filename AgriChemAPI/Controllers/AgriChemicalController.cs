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
    public class AgriChemicalController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public AgriChemicalController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<AgriChemical>> Get()
        {
            return Ok(_context.AgriChemical.ToList());
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<AgriChemical> Get(int id)
        {
            var agriChemical = _context.AgriChemical.FirstOrDefault(a => a.AgriChemicalId == id);
            return Ok(agriChemical);
        }

        [HttpPost]
        public ActionResult<AgriChemical> post(AgriChemical agriChemical)
        {
            _context.AgriChemical.Add(agriChemical);
            _context.SaveChanges();
            return Ok(agriChemical);
        }

        [HttpPut]
        public ActionResult<AgriChemical> put(AgriChemical agriChemical)
        {
            var agriChemicalInDb = _context.AgriChemical.FirstOrDefault(a => a.AgriChemicalId == agriChemical.AgriChemicalId);
            agriChemicalInDb.AgriChemicalName = agriChemical.AgriChemicalName;
            _context.SaveChanges();
            return Ok(agriChemical);
        }

        [Route("{id}")]
        [HttpDelete]
        public ActionResult<AgriChemical> delete(int id)
        {
            var agriChemicalInDb = _context.AgriChemical.FirstOrDefault(a => a.AgriChemicalId == id);
            _context.Remove(agriChemicalInDb);
            _context.SaveChanges();
            return Ok(agriChemicalInDb);
        }
    }
}