using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2ndHandInProgramming
{
    public class Customer
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Zipcode { get; set; }
        public string Region { get; set; }
        private int Age { get; set; }
        private string Password { get; set; }

        public Customer (string firstname, string lastname, int zipcode, string region, int age, string password)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Zipcode = zipcode;
            this.Region = region;
            this.Age = age;
            this.Password = password;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} who lives in {Zipcode}, {Region} and is {Age} years old. His password is: {Password}";
        }
    }
}