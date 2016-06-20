using System.Data.Entity.ModelConfiguration;
using DIWebApiTest.Models;

namespace DIWebApiTest.Configurations
{

    public class IndividualPartnerConfig : EntityTypeConfiguration<IndividualPartner>
    {
        public IndividualPartnerConfig()
        {
            ToTable("Person");
        }
    }

}