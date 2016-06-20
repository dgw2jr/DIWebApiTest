using System.Collections.Generic;

namespace DIWebApiTest.Models
{

    public class Partner
    {
        public int PartnerId { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }

}