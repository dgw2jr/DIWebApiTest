using System.Collections.Generic;

namespace DIWebApiTest.Models
{
    public class Operation
    {
        public int OperationId { get; set; }
        public string Name { get; set; }
        public int PrimaryDecisionMakerId { get; set; }
        public virtual IndividualPartner PrimaryDecisionMaker { get; set; }
        public virtual ICollection<IndividualPartner> IndividualPartners { get; set; }
        public virtual ICollection<BusinessPartner> BusinessPartners { get; set; }
    }

}