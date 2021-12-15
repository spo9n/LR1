using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1_Surgai_ZVD2
{
    class Worker
    {
        private string Surname { get; set; }
        private string Name { get; set; }
        private string Patronymic { get; set; }
        private Address Addr { get; set; }

        public Worker() 
        {
            this.Surname = "-";
            this.Name = "-";
            this.Patronymic = "-";
            this.Addr = new Address();
        }

        public Worker(string surname, string name, string patronymic, string street, string building, string flat)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.Addr = new Address(street, building, flat);
        }

        public string GetName()
        {
            return Name;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public string GetPatronymic()
        {
            return Patronymic;
        }
        public Address GetAddress()
        {
            return Addr;
        }

        public void SetSurname(string surname)
        {
            this.Surname = surname;
        }

        public void SetName(string name) 
        { 
            this.Name = name; 
        }

        public void SetPatronymic(string patronymic)
        {
            this.Patronymic = patronymic;
        }
        
        public void SetAddress(string street, string building, string flat)
        {
            this.Addr.SetStreet(street);
            this.Addr.SetBuilding(building);
            this.Addr.SetFlat(flat);
        }
    }
}
