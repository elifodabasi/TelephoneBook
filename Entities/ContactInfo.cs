using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ContactInfo :IEntity
    {
     
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string InfoContext { get; set; }
        public Guid PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
