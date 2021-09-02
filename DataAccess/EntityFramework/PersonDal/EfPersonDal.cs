using Core.DataAcces.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework.PersonDal
{
    public class EfPersonDal : EfRepositoryBase<Person , EfDbContext> , IPersonDal
    {
    }
}
