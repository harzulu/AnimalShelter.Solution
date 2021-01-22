using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{

    [Route("api/dogs")]
    [ApiController]
    public class AnimalShelterController : ControllerBase
    {
        private AnimalShelterContext _db; 

        public AnimalShelterController(AnimalShelterContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Dog>> Get()
        {
            return _db.Dogs.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Dog> Get(int id)
        {
            return _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Dog dog)
        {
            _db.Add(dog);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Dog dog)
        {
            dog.DogId = id;
            _db.Entry(dog).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var dogToDelete = _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
            _db.Dogs.Remove(dogToDelete);
            _db.SaveChanges();
        }
    }
}
