using System;

namespace L1HWE1Address
{
    internal class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
    }

    internal class Program
    {
        private static void Main()
        {
            var home = new Address
            {
                Index = "133",
                Country = "Ukraine",
                City = "Berdichev",
                Street = "Chudnovskaya",
                House = "102",
                Apartment = "A1"
            };
            Console.WriteLine(home.Index);
            Console.WriteLine(home.Country);
            Console.WriteLine(home.City);
            Console.WriteLine(home.Street);
            Console.WriteLine(home.House);
            Console.WriteLine(home.Apartment);
            Console.ReadKey();
        }
    }
}
