using System;
namespace PartialDemo
{
    public partial class PartialEmployee
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty ;
        private double _salary;
        private string _gender = string.Empty;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }


        partial void PartialMethod();//partial method

    }
}