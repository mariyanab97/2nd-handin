using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2ndHandInProgramming
{
    public class CustomerDatabase
    {
        private List<Customer> CustomerList;

        public CustomerDatabase()
        {
            CustomerList = new List<Customer>();
        }

        public void AddCustomerToList(Customer ctm)
        {
            CustomerList.Add(ctm);
        }

        public List<Customer> ShowCustomerList()
        {
            return CustomerList;
        }
    }
}