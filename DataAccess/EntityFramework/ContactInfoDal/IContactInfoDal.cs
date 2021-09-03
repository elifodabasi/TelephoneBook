using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAcces;
using Entities;

namespace DataAccess.EntityFramework.ContactInfoDal
{
    public interface IContactInfoDal : IEntityRepository<ContactInfo>
    {
    }
}
