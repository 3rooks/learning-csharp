using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cs.src
{
    public class Interfaces
    {
        interface IAnimal
        {
            void MakeSound();
        }

        class Dog : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("Woof!");
            }
        }

        class Cat : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("Meow!");
            }
        }

        class Program1
        {
            static void Main(string[] args)
            {
                IAnimal animal = new Dog();
                animal.MakeSound();

                animal = new Cat();
                animal.MakeSound();
            }
        }


        interface IShape
        {
            double Area { get; }
        }

        class Rectangle : IShape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public double Area
            {
                get { return Width * Height; }
            }
        }

        class Circle : IShape
        {
            public double Radius { get; set; }

            public double Area
            {
                get { return Math.PI * Math.Pow(Radius, 2); }
            }
        }

        class Program2
        {
            static void Main(string[] args)
            {
                IShape shape = new Rectangle() { Width = 5, Height = 10 };
                Console.WriteLine($"Area of rectangle: {shape.Area}");

                shape = new Circle() { Radius = 2 };
                Console.WriteLine($"Area of circle: {shape.Area}");
            }
        }

        interface IRepository<T>
        {
            void Add(T item);
            void Remove(T item);
        }

        class CustomerRepository : IRepository<Customer>
        {
            List<Customer> customers = new List<Customer>();

            public void Add(Customer customer)
            {
                customers.Add(customer);
                Console.WriteLine($"Added customer: {customer.Name}");
            }

            public void Remove(Customer customer)
            {
                customers.Remove(customer);
                Console.WriteLine($"Removed customer: {customer.Name}");
            }
        }

        class Customer
        {
            public string? Name { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                IRepository<Customer> customerRepository = new CustomerRepository();
                var customer1 = new Customer() { Name = "John" };
                var customer2 = new Customer() { Name = "Mary" };

                customerRepository.Add(customer1);
            }
        }
    }
}