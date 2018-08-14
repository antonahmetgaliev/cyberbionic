using System;

namespace L1HWE1Address
{
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

    }
    class Program
    {
        static void Main()
        {
            Address home = new Address();
            home.Index = "133";
            home.Country = "Ukraine";
            home.City = "Berdichev";
            home.Street = "Chudnovskaya";
            home.House = "102";
            home.Apartment = "A1";
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
