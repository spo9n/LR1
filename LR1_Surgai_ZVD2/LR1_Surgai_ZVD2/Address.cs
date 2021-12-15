using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1_Surgai_ZVD2
{
    class Address
    {
        private string Street { get; set; }

        private string Building { get; set; }

        private string Flat { get; set; }

        public Address()
        {
            this.Street = "-";
            this.Building = "-";
            this.Flat = "-";
        }
        public Address(string street, string building, string flat) 
        {
            this.Street = street;
            this.Building = building;
            this.Flat = flat;
        }

        public void SetStreet(string street)
        {
            this.Street = street;
        }

        public void SetBuilding(string building)
        {
            this.Building = building;
        }

        public void SetFlat(string flat)
        {
            this.Flat = flat;
        }

        public string GetStreet()
        {
            return Street;
        }

        public string GetBuilding()
        {
            return Building;
        }

        public string GetFlat()
        {
            return Flat;
        }
    }
}
