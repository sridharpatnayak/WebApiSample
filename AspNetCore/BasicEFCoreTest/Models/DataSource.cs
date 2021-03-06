﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicEFCoreTest.Models
{
    public static class DataSource
    {
        public static IList<Customer> GetCustomers()
        {
            Customer customerA = new Customer
            {
                FirstName = "ZG",
                LastName = "Xu",
                UserName = "Sam",
                Age = 18,
                FavoriateColor = Color.Red,
                HomeAddress = new Address
                {
                    City = "Redmond",
                    Street = "156 AVE NE"
                },
                Order = new Order
                {
                    Price = 101m
                },
            };

            Customer customerB = new Customer
            {
                FirstName = "Jonier",
                LastName = "Alice",
                UserName = "Peter",
                Age = 19,
                FavoriateColor = Color.Red,
                HomeAddress = new Address
                {
                    City = "Bellevue",
                    Street = "Main St NE"
                },
                Order = new Order
                {
                    Price = 104m
                }
            };

            Customer customerC = new Customer
            {
                FirstName = "Jichan",
                LastName = "Zhang",
                UserName = null,
                Age = 29,
                FavoriateColor = Color.Blue,
                HomeAddress = new Address
                {
                    City = "Hollewye",
                    Street = "Main St NE"
                },
                Order = new Order
                {
                    Price = 104m
                }
            };

            return new List<Customer>
            {
                customerA,
                customerB,
                customerC
            };
        }
    }
}
