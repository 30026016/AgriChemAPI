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
    public class ReasonController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ReasonController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Reason>> Get()
        {
            return Ok(_context.Reason.ToList());
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<Reason> Get(int id)
        {
            var reason = _context.Reason.FirstOrDefault(a => a.ReasonId == id);
            return Ok(reason);
        }

        [HttpPost]
        public ActionResult<Reason> post(Reason reason)
        {
            _context.Reason.Add(reason);
            _context.SaveChanges();
            return Ok(reason);
        }

        [HttpPut]
        public ActionResult<Reason> put(Reason reason)
        {
            var reasonInDb = _context.Reason.FirstOrDefault(a => a.ReasonId == reason.ReasonId);
            reasonInDb.ReasonName = reason.ReasonName;
            _context.SaveChanges();
            return Ok(reason);
        }

        [Route("{id}")]
        [HttpDelete]
        public ActionResult<Reason> delete(int id)
        {
            var reasonInDb = _context.Reason.FirstOrDefault(a => a.ReasonId == id);
            _context.Remove(reasonInDb);
            _context.SaveChanges();
            return Ok(reasonInDb);
        }
    }
}