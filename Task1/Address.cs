using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Address
    {
        public string Town {  get; set; }
        public string Street { get; set; }
        public uint House { get; set; }
        public sbyte Apartment { get; set; }
        public Address(string town, string street, uint house, sbyte apartment) 
        {
            Town = town;
            Street = street;
            House = house;
            Apartment = apartment;
        }
        public override string ToString()
        {
            return $"Town: {Town}; Street: {Street}; House: {House}; Apartment: {Apartment}";
        }

    }
}
