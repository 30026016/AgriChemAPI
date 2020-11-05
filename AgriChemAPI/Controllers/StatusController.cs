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
    public class StatusController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public StatusController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Status>> Get()
        {
            return Ok(_context.Status.ToList());
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<Status> Get(int id)
        {
            var status = _context.Status.FirstOrDefault(a => a.StatusId == id);
            return Ok(status);
        }

        [HttpPost]
        public ActionResult<Status> post(Status status)
        {
            _context.Status.Add(status);
            _context.SaveChanges();
            return Ok(status);
        }

        [HttpPut]
        public ActionResult<Status> put(Status status)
        {
            var statusInDb = _context.Status.FirstOrDefault(a => a.StatusId == status.StatusId);
            statusInDb.StatusName = status.StatusName;
            _context.SaveChanges();
            return Ok(status);
        }

        [Route("{id}")]
        [HttpDelete]
        public ActionResult<Status> delete(int id)
        {
            var statusInDb = _context.Status.FirstOrDefault(a => a.StatusId == id);
            _context.Remove(statusInDb);
            _context.SaveChanges();
            return Ok(statusInDb);
        }
    }
}