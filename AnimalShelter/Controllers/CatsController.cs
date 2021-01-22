// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using AnimalShelter.Models;

// namespace AnimalShelter.Controllers
// {

//     [Route("api/cats")]
//     [ApiController]
//     public class CatsController : ControllerBase
//     {
//         private CatsContext _db; 

//         public catsController(CatsContext db)
//         {
//             _db = db;
//         }

//         // GET api/values
//         [HttpGet]
//         public ActionResult<IEnumerable<Cat>> Get()
//         {
//             return new string[] { "value1", "value2" };
//         }

//         // GET api/values/5
//         [HttpGet("{id}")]
//         public ActionResult<string> Get(int id)
//         {
//             return "value";
//         }

//         // POST api/values
//         [HttpPost]
//         public void Post([FromBody] string value)
//         {
//         }

//         // PUT api/values/5
//         [HttpPut("{id}")]
//         public void Put(int id, [FromBody] string value)
//         {
//         }

//         // DELETE api/values/5
//         [HttpDelete("{id}")]
//         public void Delete(int id)
//         {
//         }
//     }
// }
