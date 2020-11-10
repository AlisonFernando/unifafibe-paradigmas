using System;
using System.Security.Cryptography.X509Certificates;

namespace Paradigmas_AP1
{
    class Program
    {
        static void Main(string[] args)
        {
            City city = new City("Bebedouro", "São Paulo", "SP");
            Address address = new Address("R. Prof. Orlando França de Carvalho", 325, "Centro", "14701-070", city);
            Client client = new Client("Tupac Shakur", "012345679-01", address, city);
            client.printOutDetails();

            client = new Client("Frank White", "97654321-01", "R.Prof.Orlando França de Carvalho", 325, "Centro", "14701-070",
                "Bebedouro", "São Paulo", "SP");
            client.printOutDetails();

            Console.ReadLine();
        }
    }
}
