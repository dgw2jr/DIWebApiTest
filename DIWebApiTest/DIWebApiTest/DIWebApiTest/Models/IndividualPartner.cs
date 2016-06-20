using System;
using System.Linq;
using System.Collections.Generic;

namespace DIWebApiTest.Models
{

    public class IndividualPartner : Partner
    {
        public int IndividualPartnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}