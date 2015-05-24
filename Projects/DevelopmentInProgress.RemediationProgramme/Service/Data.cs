﻿using System.Collections.Generic;
using DevelopmentInProgress.RemediationProgramme.Model;

namespace DevelopmentInProgress.RemediationProgramme.Service
{
    public static class Data
    {
        public static IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            
            customers.Add(new Customer()
            {
                Name = "Joe Bloggs",
                SortCode = "12-34-56",
                AccountNumber = "11223344",
                Address = "123 Main Street, Hatfield, London, SW1 2AB"
            });

            customers.Add(new Customer()
            {
                Name = "Jane Masters",
                SortCode = "12-56-78",
                AccountNumber = "11556677",
                Address = "987 High Street, Oxford, London, RA1 2QA"
            });

            customers.Add(new Customer()
            {
                Name = "John Doe",
                SortCode = "12-98-32",
                AccountNumber = "11997788",
                Address = "456 Garden Path, Canary Wharf, London, CW1 1WP"
            });

            customers.Add(new Customer()
            {
                Name = "James Blagg",
                SortCode = "12-98-32",
                AccountNumber = "11997788",
                Address = "456 Garden Path, Canary Wharf, London, CW1 1WP"
            });
            
            return customers;
        }
    }
}
