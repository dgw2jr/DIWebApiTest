using System.Data.Entity.ModelConfiguration;
using DIWebApiTest.Models;

namespace DIWebApiTest.Configurations
{
    public class OperationConfig : EntityTypeConfiguration<Operation>
    {
        public OperationConfig()
        {
            HasRequired(o => o.PrimaryDecisionMaker).WithMany().HasForeignKey(o => o.PrimaryDecisionMakerId);
            HasMany(o => o.BusinessPartners).WithMany().Map(m => m.MapLeftKey("OperationId").MapRightKey("PartnerId"));
            HasMany(o => o.IndividualPartners).WithMany().Map(m=> m.MapLeftKey("OperationId").MapRightKey("PartnerId"));
        }
    }

}