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
    public class MethodController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public MethodController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Method>> Get()
        {
            return Ok(_context.Method.ToList());
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<Method> Get(int id)
        {
            var method = _context.Method.FirstOrDefault(a => a.MethodId == id);
            return Ok(method);
        }

        [HttpPost]
        public ActionResult<Method> post(Method method)
        {
            _context.Method.Add(method);
            _context.SaveChanges();
            return Ok(method);
        }

        [HttpPut]
        public ActionResult<Method> put(Method method)
        {
            var methodInDb = _context.Method.FirstOrDefault(a => a.MethodId == method.MethodId);
            methodInDb.MethodName = method.MethodName;
            _context.SaveChanges();
            return Ok(method);
        }

        [Route("{id}")]
        [HttpDelete]
        public ActionResult<Method> delete(int id)
        {
            var methodInDb = _context.Method.FirstOrDefault(a => a.MethodId == id);
            _context.Remove(methodInDb);
            _context.SaveChanges();
            return Ok(methodInDb);
        }
    }
}