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
    public class DepartamentController : Controller
    {
       
         //Injeção de dependencia 
            private IDepartamentBusiness _departamentBusiness;

            public DepartamentController(IDepartamentBusiness departament)
            {
                _departamentBusiness = departament;
            }
            // GET: api/<controller>
            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_departamentBusiness.FindAll());
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
                var contract = _departamentBusiness.FindById(id);
                if (contract == null) return NotFound();
                return Ok(contract);
            }

            // POST api/<controller>
            [HttpPost]

            public IActionResult Post([FromBody]DepartamentVO contrado)
            {
                if (contrado == null) return BadRequest();

                return new ObjectResult(_departamentBusiness.Create(contrado));


            }
            // PUT api/<controller>/5
            [HttpPut("{id}")]

            public IActionResult Put([FromBody]DepartamentVO contrado)
            {


                if (contrado == null) return BadRequest();

                return new ObjectResult(_departamentBusiness.Update(contrado));
            }

            // DELETE api/<controller>/5
            [HttpDelete("{id}")]

            public IActionResult Delete(int id)
            {
                _departamentBusiness.Delete(id);
                return NoContent();
            }
        }
    
}