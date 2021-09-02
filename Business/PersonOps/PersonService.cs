using DataAccess.EntityFramework.PersonDal;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PersonOps
{
    public class PersonService : IPersonService
    { 
        IPersonDal _personDal;
        public PersonService(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public void Add(Person entity)
        {
            _personDal.Add(entity);
        }

        public void Delete(Person entity)
        {
            _personDal.Delete(entity);
        }

        public Person Find(Guid id)
        {
           return  _personDal.Find(x=>x.Id==id);
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll(x => x.Surname == "Bostan");

                
        }

        public void Update(Person entity)
        {
            _personDal.Update(entity);
        }
    }
}
