using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskMemtApi.Business;
using TaskMemtApi.Data.VO;

namespace TaskMemtApi.Controllers
{
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        private ITaskBusiness _taskBusiness;

        public TaskController(ITaskBusiness task)
        {
            _taskBusiness = task;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_taskBusiness.FindAll());
        }


        //[HttpGet("find-by-name")]

        //public IActionResult GetByName([FromQuery] string name, [FromQuery] string comprador)
        //{
        //    return Ok(_departamentBusiness.FindByName(name, comprador));
        //}
        // GET api/<controller>/5
        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            var task = _taskBusiness.FindById(id);
            if (task == null) return NotFound();
            return Ok(task);
        }

        // POST api/<controller>
        [HttpPost]

        public IActionResult Post([FromBody]TaskVO task)
        {
            if (task == null) return BadRequest();

            return new ObjectResult(_taskBusiness.Create(task));


        }
        // PUT api/<controller>/5
        [HttpPut("{id}")]

        public IActionResult Put([FromBody]TaskVO task)
        {


            if (task == null) return BadRequest();

            return new ObjectResult(_taskBusiness.Update(task));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            _taskBusiness.Delete(id);
            return NoContent();
        }
    }
}
