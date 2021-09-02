using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person : IEntity
    {
        public Person()
        {
            ContactInfos = new Collection<ContactInfo>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public ICollection<ContactInfo> ContactInfos { get; set; }
    }
}
