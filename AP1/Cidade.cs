using System;
using System.Collections.Generic;
using System.Text;

namespace Paradigmas_AP1
{
    class City
    {
        string name;
        string state;
        string abreviation;

        public void setCityName(string name) { this.name = name; }
        public string getCityName() { return this.name; }
        public void setCityState(string name) { this.state = name; }
        public string getCityState() { return this.state; }
        public void setStateAbreviation(string a) { this.abreviation = a; }
        public string getStateAbreviation() { return this.abreviation; }

        public void setCityProperties(City city)
        {
            this.name = city.getCityName();
            this.state = city.getCityState();
            this.abreviation = city.getStateAbreviation();
        }

        public City(string name, string state, string stateAbv)
        {
            this.name = name;
            this.state = state;
            this.abreviation = stateAbv;
        }

        public City() { }
    }
}
