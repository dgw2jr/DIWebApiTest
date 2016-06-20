using System;
using System.Linq;
using System.Collections.Generic;

namespace DIWebApiTest.Models
{

    public class BusinessPartner : Partner
    {
        public int BusinessPartnerId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<IndividualPartner> Contacts { get; set; }
    }

}