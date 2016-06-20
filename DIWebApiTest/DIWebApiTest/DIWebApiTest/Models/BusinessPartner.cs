using System.Collections.Generic;

namespace DIWebApiTest.Models
{

    public class BusinessPartner : Partner
    {
        public string Name { get; set; }
        public virtual ICollection<IndividualPartner> Contacts { get; set; }
    }

}