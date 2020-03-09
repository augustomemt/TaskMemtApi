using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskMemtApi.Business;
using TaskMemtApi.Data.VO;

namespace TaskMemtApi.Controllers
{
    public class EmployeesController : Controller
    {
        //Injeção de dependencia 
        private IEmployeesBusiness _employeesBusiness;

        public EmployeesController(IEmployeesBusiness employee)
        {
            _employeesBusiness = employee;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employeesBusiness.FindAll());
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
            var employee = _employeesBusiness.FindById(id);
            if (employee == null) return NotFound();
            return Ok(employee);
        }

        // POST api/<controller>
        [HttpPost]

        public IActionResult Post([FromBody]EmployeesVO employee)
        {
            if (employee == null) return BadRequest();

            return new ObjectResult(_employeesBusiness.Create(employee));


        }
        // PUT api/<controller>/5
        [HttpPut("{id}")]

        public IActionResult Put([FromBody]EmployeesVO employee)
        {


            if (employee == null) return BadRequest();

            return new ObjectResult(_employeesBusiness.Update(employee));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            _employeesBusiness.Delete(id);
            return NoContent();
        }
    }
}