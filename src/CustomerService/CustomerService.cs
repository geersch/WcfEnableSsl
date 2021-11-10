using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CustomerService
{
    [ServiceBehavior]
    public class CustomerService : ICustomerService
    {
        private IEnumerable<Customer> LoadCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Christophe",
                    LastName = "Geers"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Smith"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jane",
                    LastName = "Doe"
                }
            };
            
            return customers;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            customers.AddRange(LoadCustomers());
            return customers;
        }
    }
}
