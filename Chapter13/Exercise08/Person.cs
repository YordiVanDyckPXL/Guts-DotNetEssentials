using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    public class Person
    {

        public Person(string name, string firstName, string gender, string adres, string phoneNumber, DateTime birthday)
        {
            Name = name;
            FirstName = firstName;
            Gender = gender;
            Adres = adres;
            PhoneNumber = phoneNumber;
            BirthDate = birthday;
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _adres;

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        private string _phoneNumber;



        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private  DateTime _birthDay;

        public  DateTime BirthDate
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }



    }
}
