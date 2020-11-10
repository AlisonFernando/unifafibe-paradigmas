using System;
using System.Collections.Generic;
using System.Text;

namespace Paradigmas_AP1
{
    class Address : City
    {
        string street;
        int number;
        string neighborhood;
        string zipCode;

        public void setStreetName(string street) { this.street = street; }
        public string getStreetName() { return this.street; }
        public void setPropertyNumber(int num) { this.number = num; }
        public int getPropertyNumber() { return this.number; }
        public void setNeighborhood(string neighborhood) { this.neighborhood = neighborhood; }
        public string getNeighborhood() { return this.neighborhood; }
        public void setZipCode(string zip) { this.zipCode = zip; }
        public string getZipCode() { return this.zipCode;  }
        public void setAddressProperties(Address address, City city)
        {
            this.street = address.street;
            this.number = address.number;
            this.neighborhood = address.neighborhood;
            this.zipCode = address.zipCode;

            setCityProperties(city);
        }

        public Address(string street, int number, string neighborhood, string zipCode, City city)
        {
            this.street = street;
            this.number = number;
            this.neighborhood = neighborhood;
            this.zipCode = zipCode;
            
            setCityProperties(city);
        }

        public Address() {}
    }
}
