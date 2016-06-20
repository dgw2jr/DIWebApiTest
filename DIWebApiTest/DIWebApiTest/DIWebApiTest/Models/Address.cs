using System;
using static Dapper.SqlMapper;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DIWebApiTest.Models
{
    public enum AddressType
    {
        Mailing = 1,
        Street = 2
    }

    public class Address
    {
        public int AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }

        public int RegionId { get; set; }
        public virtual Region Region { get; set; }
    }

    public class MailingAddress : Address { }
    public class StreetAddress : Address { }

    public class Region
    {
        public int RegionId { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<Address> Addresses { get; set; }
    }

    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Region> Regions { get; set; }
    }
}