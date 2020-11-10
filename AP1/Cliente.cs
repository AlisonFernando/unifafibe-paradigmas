using System;
using System.Collections.Generic;


namespace Paradigmas_AP1
{
    class Client : Address
    {
        string name;
        string cpf;

        public void setClientName(string name) { this.name = name; }
        public string getClientName() { return this.name; }

        public void printOutDetails()
        {
            Console.WriteLine("Nome: " + name);
            Console.WriteLine("Cpf: " + cpf);

            Console.WriteLine("Rua: " + getStreetName());
            Console.WriteLine("Numero: " + getPropertyNumber());
            Console.WriteLine("Bairro: " + getNeighborhood());
            Console.WriteLine("CEP: " + getZipCode());

            Console.WriteLine("Cidade: " + getCityName());
            Console.WriteLine("Estado: " + getCityState());
            Console.WriteLine("Sigla: "  + getStateAbreviation());
        }

        public Client(string name, string cpf, Address address, City city)
        {
            this.name = name;
            this.cpf = cpf;

            setAddressProperties(address, city);
        }

        public Client(string name, string cpf, string street, int number, string neighborhood, string zipCode, string cityName, string state, string stateAbv)
        {
            this.name = name;
            this.cpf = cpf;

            setStreetName(street);
            setPropertyNumber(number);
            setNeighborhood(neighborhood);
            setZipCode(zipCode);

            setCityName(cityName);
            setCityState(state);
            setStateAbreviation(stateAbv);
        }
    }
}
