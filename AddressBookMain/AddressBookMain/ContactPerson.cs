using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookMain
{ 
    public class ContactPerson
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public double Phone_No;
        public string email_id;

        public ContactPerson(string FirstName, string LastName, string Address, string City, string State, int Zip, double Phone_No, string email_id)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.Phone_No = Phone_No;
            this.email_id = email_id;
        }
    }
}
