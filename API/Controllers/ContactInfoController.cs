using Business.ContactInfoOps;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class ContactInfoController : ControllerBase
        {
            IContactInfoService _contactInfoService;
            public ContactInfoController(IContactInfoService contactInfoService)
            {
            _contactInfoService = contactInfoService;
            }

            [HttpPost("add")]
            public async Task Add(ContactInfo contactInfo)
            {
            _contactInfoService.Add(contactInfo);
            }


            [HttpGet("getAll")]
            public async Task<List<ContactInfo>> GetAll()
            {
                var result = _contactInfoService.GetAll();
                return result;
            }

            [HttpPost("update")]
            public async Task Update(ContactInfo contactInfo)
            {
            _contactInfoService.Update(contactInfo);
            }

            [HttpGet("find")]
            public ContactInfo Find(Guid id)
            {
                return _contactInfoService.Find(id);
            }

            [HttpPost("delete")]
            public async Task Delete(ContactInfo contactInfo)
            {
            _contactInfoService.Delete(contactInfo);
            }

        }
    
}
