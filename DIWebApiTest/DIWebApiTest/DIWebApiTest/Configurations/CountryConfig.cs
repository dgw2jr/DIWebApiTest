using System.Data.Entity.ModelConfiguration;
using DIWebApiTest.Models;

namespace DIWebApiTest.Configurations
{
    public class CountryConfig : EntityTypeConfiguration<Country>
    {
        public CountryConfig()
        {
            HasMany(c => c.Regions)
                .WithRequired(r => r.Country)
                .HasForeignKey(r => r.CountryId);
        }
    }
}