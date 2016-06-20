using System.Data.Entity.ModelConfiguration;
using DIWebApiTest.Models;

namespace DIWebApiTest.Configurations
{
    public class OperationConfig : EntityTypeConfiguration<Operation>
    {
        public OperationConfig()
        {
            HasRequired(o => o.PrimaryDecisionMaker).WithMany().HasForeignKey(o => o.PrimaryDecisionMakerId);
        }
    }

}