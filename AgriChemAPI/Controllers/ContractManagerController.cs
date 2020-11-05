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
    public class ContractManagerController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ContractManagerController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<ContractManager>> Get()
        {
            return Ok(_context.ContractManager.ToList());
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<ContractManager> Get(int id)
        {
            var contractor = _context.ContractManager.FirstOrDefault(a => a.ContractManagerId == id);
            return Ok(contractor);
        }

        [HttpPost]
        public ActionResult<ContractManager> post(ContractManager contractmanager)
        {
            _context.ContractManager.Add(contractmanager);
            _context.SaveChanges();
            return Ok(contractmanager);
        }

        [HttpPut]
        public ActionResult<ContractManager> put(ContractManager contractmanager)
        {
            var contractorInDb = _context.ContractManager.FirstOrDefault(a => a.ContractManagerId == contractmanager.ContractManagerId);
            contractorInDb.ContractManagerName = contractmanager.ContractManagerName;
            _context.SaveChanges();
            return Ok(contractmanager);
        }

        [Route("{id}")]
        [HttpDelete]
        public ActionResult<Contractor> delete(int id)
        {
            var contractorInDb = _context.ContractManager.FirstOrDefault(a => a.ContractManagerId == id);
            _context.Remove(contractorInDb);
            _context.SaveChanges();
            return Ok(contractorInDb);
        }
    }
}