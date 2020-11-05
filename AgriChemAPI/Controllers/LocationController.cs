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
    public class LocationController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public LocationController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Location>> Get()
        {
            return Ok(_context.Location.ToList());
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<Location> Get(int id)
        {
            var location = _context.Location.FirstOrDefault(a => a.LocationId == id);
            return Ok(location);
        }

        [HttpPost]
        public ActionResult<Location> post(Location location)
        {
            _context.Location.Add(location);
            _context.SaveChanges();
            return Ok(location);
        }

        [HttpPut]
        public ActionResult<Location> put(Location location)
        {
            var locationInDb = _context.Location.FirstOrDefault(a => a.LocationId == location.LocationId);
            locationInDb.LocationName = location.LocationName;
            _context.SaveChanges();
            return Ok(location);
        }

        [Route("{id}")]
        [HttpDelete]
        public ActionResult<Location> delete(int id)
        {
            var locationInDb = _context.Location.FirstOrDefault(a => a.LocationId == id);
            _context.Remove(locationInDb);
            _context.SaveChanges();
            return Ok(locationInDb);
        }
    }
}