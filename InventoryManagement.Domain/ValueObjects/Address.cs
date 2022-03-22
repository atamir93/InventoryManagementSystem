using InventoryManagement.Domain.Common;
using System.Collections.Generic;

namespace InventoryManagement.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string Country { get; }
        public string State { get; }
        public string City { get; }
        public string Street { get; }
        public string PostalCode { get; }
        //public string FullAddress { get; }

        public Address()
        {
        }

        public Address(string country, string state, string city, string street, string postalCode)
        {
            Country = country;
            State = state;
            City = city;
            Street = street;
            PostalCode = postalCode;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Country;
            yield return State;
            yield return City;
            yield return Street;
            yield return PostalCode;
        }
    }
}