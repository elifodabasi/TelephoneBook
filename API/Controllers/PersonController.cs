using Business.PersonOps;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("add")]
        public async Task Add(Person person)
        {
            _personService.Add(person);
        }
        
       
        [HttpGet("getAll")]
        public async Task<List<Person>> GetAll()
        {
            var result = _personService.GetAll();
            return result;
        }

        [HttpPost("update")]
        public async Task Update(Person person)
        {
            _personService.Update(person);
        }

        [HttpGet("find")]
        public Person Find(Guid id)
        {
            return _personService.Find(id);
        }

        [HttpPost("delete")]
        public async Task Delete(Person person)
        {
            _personService.Delete(person);
        }

    }
}
