using System.Data.Entity.ModelConfiguration;
using DIWebApiTest.Models;

namespace DIWebApiTest.Configurations
{

    public class BusinessPartnerConfig : EntityTypeConfiguration<BusinessPartner>
    {
        public BusinessPartnerConfig()
        {
            HasMany(b => b.Contacts).WithMany()
                .Map(c => c.MapLeftKey("BusinessId").MapRightKey("PersonId").ToTable("BusinessContacts"));
        }
    }

}