namespace DIWebApiTest.Models
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    public class OperationContext : DbContext
    {
        private readonly EntityTypeConfiguration<Region> _regionConfig;
        private readonly EntityTypeConfiguration<Country> _countryConfig;
        private readonly EntityTypeConfiguration<Address> _addressConfig;
        private readonly EntityTypeConfiguration<IndividualPartner> _individualPartnerConfig;
        private readonly EntityTypeConfiguration<BusinessPartner> _businessPartnerConfig;
        private readonly EntityTypeConfiguration<Partner> _partnerConfig;
        private readonly EntityTypeConfiguration<Operation> _operationConfig;
        
        public OperationContext() : base("name=OperationContext") { }

        public OperationContext(IDatabaseInitializer<OperationContext> initializer, 
            EntityTypeConfiguration<Region> regionConfig,
            EntityTypeConfiguration<Country> countryConfig,
            EntityTypeConfiguration<Address> addressConfig,
            EntityTypeConfiguration<IndividualPartner> individualPartnerConfig,
            EntityTypeConfiguration<BusinessPartner> businessPartnerConfig,
            EntityTypeConfiguration<Partner> partnerConfig,
            EntityTypeConfiguration<Operation> operationConfig)
            : this()
        {
            _regionConfig = regionConfig;
            _countryConfig = countryConfig;
            _addressConfig = addressConfig;
            _individualPartnerConfig = individualPartnerConfig;
            _businessPartnerConfig = businessPartnerConfig;
            _partnerConfig = partnerConfig;
            _operationConfig = operationConfig;

            Database.SetInitializer(initializer);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(_regionConfig);
            modelBuilder.Configurations.Add(_countryConfig);
            modelBuilder.Configurations.Add(_addressConfig);
            //modelBuilder.Configurations.Add(_individualPartnerConfig);
            modelBuilder.Configurations.Add(_businessPartnerConfig);
            modelBuilder.Configurations.Add(_partnerConfig);
            modelBuilder.Configurations.Add(_operationConfig);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Operation> Operations { get; set; }

        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<IndividualPartner> IndividualPartners { get; set; }
        public virtual DbSet<BusinessPartner> BusinessPartners { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Country> Countries { get; set; }

    }
}