using System.Data.Entity.ModelConfiguration;
using DIWebApiTest.Models;

namespace DIWebApiTest.Configurations
{
    public class AddressConfig : EntityTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            Map<MailingAddress>(m => m.Requires("AddressTypeId").HasValue((int)AddressType.Mailing));
            Map<StreetAddress>(m => m.Requires("AddressTypeId").HasValue((int)AddressType.Street));
        }
    }
}