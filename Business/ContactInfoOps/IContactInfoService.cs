using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ContactInfoOps
{
   public interface IContactInfoService
    {
        void Add(ContactInfo entity);
        ContactInfo Find(Guid id);
        List<ContactInfo> GetAll();
        void Update(ContactInfo entity);
        void Delete(ContactInfo entity);
    }
}
