using System.Data.Entity.ModelConfiguration;
using DIWebApiTest.Models;

namespace DIWebApiTest.Configurations
{

    public class PartnerConfig : EntityTypeConfiguration<Partner>
    {
        public PartnerConfig()
        {
            Map<IndividualPartner>(i => i.ToTable("Person"));
            Map<BusinessPartner>(b => b.ToTable("Business"));
            HasMany(i => i.Addresses).WithMany().Map(a => a.MapLeftKey("PartnerId").MapRightKey("AddressId"));
        }
    }

}