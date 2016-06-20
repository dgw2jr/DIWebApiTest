using Autofac;
using DIWebApiTest.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace DIWebApiTest.Configurations
{
    public class ModelConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Greeter>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<IdProvider>().AsImplementedInterfaces().SingleInstance();
            
            builder.RegisterType<RegionConfig>().As<EntityTypeConfiguration<Region>>().InstancePerRequest();
            builder.RegisterType<CountryConfig>().As<EntityTypeConfiguration<Country>>().InstancePerRequest();
            builder.RegisterType<AddressConfig>().As<EntityTypeConfiguration<Address>>().InstancePerRequest();
            builder.RegisterType<IndividualPartnerConfig>().As<EntityTypeConfiguration<IndividualPartner>>().InstancePerRequest();
            builder.RegisterType<BusinessPartnerConfig>().As<EntityTypeConfiguration<BusinessPartner>>().InstancePerRequest();
            builder.RegisterType<PartnerConfig>().As<EntityTypeConfiguration<Partner>>().InstancePerRequest();
            builder.RegisterType<OperationConfig>().As<EntityTypeConfiguration<Operation>>().InstancePerRequest();

            builder.Register(c => new Migrations.Configuration()).AsImplementedInterfaces().InstancePerRequest();
            //builder.Register(c => new MigrateDatabaseToLatestVersion<OperationContext, Migrations.Configuration>()).AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<OperationContext>().AsSelf().InstancePerRequest();
        }
    }
}