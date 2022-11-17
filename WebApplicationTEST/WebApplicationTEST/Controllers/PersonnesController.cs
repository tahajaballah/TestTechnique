using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTEST.Context;
using WebApplicationTEST.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationTEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnesController : ControllerBase
    {
        private PersonneContext _personneContext;
        public PersonnesController(PersonneContext personneContext)
        {
            _personneContext = personneContext;
        }

        // GET: api/<PersonnesController>
        [HttpGet]
        public IEnumerable<Personne> Get()
        {
            return _personneContext.Personnes;
        }

        // GET api/<PersonnesController>/5
        [HttpGet("{id}")]
        public Personne Get(int id)
        {
            return _personneContext.Personnes.FirstOrDefault(s => s.PersonneId == id);
        }

        // POST api/<PersonnesController>
        [HttpPost]
        public void Post([FromBody] Personne value)
        {
            _personneContext.Personnes.Add(value);
            _personneContext.SaveChanges();
        }

        // PUT api/<PersonnesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var personne = _personneContext.Personnes.FirstOrDefault(s => s.PersonneId == id);
            if (personne != null)
            {
                _personneContext.Entry<Personne>(personne).CurrentValues.SetValues(value);
                _personneContext.SaveChanges();
            }
        }

        // DELETE api/<PersonnesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var personne = _personneContext.Personnes.FirstOrDefault(s => s.PersonneId == id);
            if (personne != null)
            {
                _personneContext.Personnes.Remove(personne);
                _personneContext.SaveChanges();
            }
        }
    }
}
