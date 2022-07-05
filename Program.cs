using System;
using System.Collections.Generic;
using System.Linq;


namespace Solution
{

    class Program
    {
        static void Main(string[] args)
        {
            Order manager = new Order();

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                string city = Console.ReadLine();


                manager.Customer.Add(new Customer(id, name, age, city));
            }

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string a = Console.ReadLine();
                    int x = manager.CountCustomerByCity(a);
                    if (x > 0)
                    {
                        Console.WriteLine(x);
                    }
                    else
                    {
                        Console.WriteLine("No Customer with given city found");
                    }
                    break;
                case 2:
                    Console.WriteLine(manager.findTotalAgeOfCustomer());
                    break;
            }
        }

        class Customer
        {
            public int id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public string city { get; set; }

            public Customer(int id, string name, int age, string city)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.city = city;
            }
        }
        class Order
        {
            public List<Customer> Customer = new List<Customer>();
            public int CountCustomerByCity(string inputCity)
            {
                int count = 0;
                foreach (var co in Customer)
                {
                    if (co.city.Equals(inputCity))
                    {
                        count++;
                    }
                }
                return count;
            }
            public int findTotalAgeOfCustomer()
            {
                int sum = 0;
                foreach (var co in Customer)
                {
                    sum = sum + co.age;
                }
                return sum;
            }
        }
    }
}