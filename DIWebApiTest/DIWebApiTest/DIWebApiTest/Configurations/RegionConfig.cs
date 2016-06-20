using System.Data.Entity.ModelConfiguration;
using DIWebApiTest.Models;

namespace DIWebApiTest.Configurations
{
    public class RegionConfig : EntityTypeConfiguration<Region>
    {
        public RegionConfig()
        {
            HasRequired(r => r.Country)
                .WithMany(c => c.Regions)
                .HasForeignKey(r => r.CountryId);
        }
    }
}