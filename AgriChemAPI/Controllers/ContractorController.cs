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
    public class ContractorController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ContractorController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Contractor>> Get()
        {
            return Ok(_context.Contractor.ToList());
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<Contractor> Get(int id)
        {
            var contractor = _context.Contractor.FirstOrDefault(a => a.ContractorId == id);
            return Ok(contractor);
        }

        [HttpPost]
        public ActionResult<Contractor> post(Contractor contractor)
        {
            _context.Contractor.Add(contractor);
            _context.SaveChanges();
            return Ok(contractor);
        }

        [HttpPut]
        public ActionResult<Contractor> put(Contractor contractor)
        {
            var contractorInDb = _context.Contractor.FirstOrDefault(a => a.ContractorId == contractor.ContractorId);
            contractorInDb.ContractorName = contractor.ContractorName;
            _context.SaveChanges();
            return Ok(contractor);
        }

        [Route("{id}")]
        [HttpDelete]
        public ActionResult<Contractor> delete(int id)
        {
            var contractorInDb = _context.Contractor.FirstOrDefault(a => a.ContractorId == id);
            _context.Remove(contractorInDb);
            _context.SaveChanges();
            return Ok(contractorInDb);
        }
    }
}