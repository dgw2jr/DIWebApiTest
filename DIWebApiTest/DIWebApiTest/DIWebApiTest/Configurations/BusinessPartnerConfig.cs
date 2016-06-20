using System.Data.Entity.ModelConfiguration;
using DIWebApiTest.Models;

namespace DIWebApiTest.Configurations
{

    public class BusinessPartnerConfig : EntityTypeConfiguration<BusinessPartner>
    {
        public BusinessPartnerConfig()
        {
            ToTable("Business");
        }
    }

}