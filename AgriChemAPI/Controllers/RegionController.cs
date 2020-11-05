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
    public class RegionController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public RegionController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Region>> Get()
        {
            return Ok(_context.Region.ToList());
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<Region> Get(int id)
        {
            var region = _context.Region.FirstOrDefault(a => a.RegionId == id);
            return Ok(region);
        }

        [HttpPost]
        public ActionResult<Region> post(Region region)
        {
            _context.Region.Add(region);
            _context.SaveChanges();
            return Ok(region);
        }

        [HttpPut]
        public ActionResult<Region> put(Region region)
        {
            var regionInDb = _context.Region.FirstOrDefault(a => a.RegionId == region.RegionId);
            regionInDb.RegionName = region.RegionName;
            _context.SaveChanges();
            return Ok(region);
        }

        [Route("{id}")]
        [HttpDelete]
        public ActionResult<Region> delete(int id)
        {
            var regionInDb = _context.Region.FirstOrDefault(a => a.RegionId == id);
            _context.Remove(regionInDb);
            _context.SaveChanges();
            return Ok(regionInDb);
        }
    }
}