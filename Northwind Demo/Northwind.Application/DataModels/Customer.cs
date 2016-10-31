using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Application.DataModels
{
    public class Customer
    {
        public Customer()
        {

        }
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
    }
}
