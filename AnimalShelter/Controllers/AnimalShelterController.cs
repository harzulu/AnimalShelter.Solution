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
    public class DogController : ControllerBase
    {
        private AnimalShelterContext _db; 

        public DogController(AnimalShelterContext db)
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

        //GET api/values/searchTerm
        [HttpGet("{searchTerm}")]
        public ActionResult<Dog> Get(string searchTerm)
        {
            return _db.Dogs.FirstOrDefault(entry => entry.Name == searchTerm);
        }
    }

    [Route("api/cats")]
    [ApiController]
    public class CatController : ControllerBase
    {
        private AnimalShelterContext _db; 

        public CatController(AnimalShelterContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cat>> Get()
        {
            return _db.Cats.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Cat> Get(int id)
        {
            return _db.Cats.FirstOrDefault(entry => entry.CatId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Cat cat)
        {
            _db.Add(cat);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cat cat)
        {
            cat.CatId = id;
            _db.Entry(cat).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var catToDelete = _db.Cats.FirstOrDefault(entry => entry.CatId == id);
            _db.Cats.Remove(catToDelete);
            _db.SaveChanges();
        }

        //GET api/values/searchTerm
        [HttpGet("{searchTerm}")]
        public ActionResult<Cat> Get(string searchTerm)
        {
            return _db.Cats.FirstOrDefault(entry => entry.Name == searchTerm);
        }
    }
}
