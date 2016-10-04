namespace DIWebApiTest.Migrations
{
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    internal sealed class Configuration : DropCreateDatabaseAlways<OperationContext>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
            //ContextKey = "DIWebApiTest.Models.OperationContext";
        }

        protected override void Seed(OperationContext context)
        {

            var countries = new List<Country>
            {
                new Country { Name = "US" },
                new Country { Name = "Canada" }
            };

            context.Countries.AddRange(countries);

            var regions = new List<Region>
            {
                new Region { Country = countries.First(c => c.Name == "US"), Name = "Iowa" },
                new Region { Country = countries.First(c => c.Name == "US"), Name = "Minnesota" },
                new Region { Country = countries.First(c => c.Name == "Canada"), Name = "Quebec" },
                new Region { Country = countries.First(c => c.Name == "Canada"), Name = "Ontario" }
            };

            context.Regions.AddRange(regions);

            var addresses = new List<Address>
            {
                new StreetAddress { City = "Ankeny", Line1 = "1234 NW Hickory Lane", Region = regions.First(r => r.Name == "Iowa") },
                new MailingAddress { City = "Dixon", Line1 = "PO Box 1234", Region = regions.First(r => r.Name == "Iowa") }
            };

            //context.Addresses.AddRange(addresses);
            var primaryGuy = new IndividualPartner
            {
                Addresses = addresses,
                FirstName = "Bob",
                LastName = "Scheister"
            };

            context.IndividualPartners.Add(primaryGuy);
            context.SaveChanges();

            var operation = new Operation
            {
                Name = "My Operation",
                PrimaryDecisionMaker = context.IndividualPartners.First(),
                BusinessPartners = new List<BusinessPartner>
                {
                    new BusinessPartner
                    {
                        Name = "Scheisters Inc.",
                        Contacts = new List<IndividualPartner>
                        {
                            context.IndividualPartners.First()
                        }
                    }
                },
                IndividualPartners = context.IndividualPartners.ToList()
            };

            context.Operations.Add(operation);

            base.Seed(context);
        }
    }
}
