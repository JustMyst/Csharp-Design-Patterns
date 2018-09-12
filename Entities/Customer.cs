using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Customer(Customer customer)
        {
            Id = customer.Id;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
        }
        public Customer() { }
        public object Clone()
        {
            return new Customer(this);
        }
    }
}
