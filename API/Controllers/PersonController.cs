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
        public void Add(Person person)
        {
            _personService.Add(person);
        }
        
       
        [HttpGet("getAll")]
        public List<Person> GetAll()
        {
            var result = _personService.GetAll();
            return result;
        }



    }
}
