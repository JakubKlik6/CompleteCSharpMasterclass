using System;
using System.Collections;
using System.Collections.Generic;

namespace completeMasterclass
{
    internal class program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO","Jakub",25,200),
                new Employee("CTO", "Jasiu", 31, 150),
                new Employee("SE","Maciek",22,100)
            };


            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();
            foreach (Employee item in employees)
            {
                employeeDictionary.Add(item.possition, item);
            }

            Console.WriteLine("What role you want to check?");
            string key = Console.ReadLine();

            if (employeeDictionary.ContainsKey(key))
            {
                Employee items = employeeDictionary[key];
                Console.WriteLine("Name: {0}, possition: {1}, age: {2}, salary: {3}", items.name, items.possition, items.age, items.salary);
            }
            else
                Console.WriteLine("Wrong role! Please try again");



            Employee result = null;
            //using TryGetValue() it returns if the operations was successful and fals otherwise
            if (employeeDictionary.TryGetValue("intern",out result))
            {
                Console.WriteLine("Value retrived");

                Console.WriteLine("Employee name: {0}",result.name);
                Console.WriteLine("Employee role: {0}", result.possition);
                Console.WriteLine("Employee age: {0}", result.age);
                Console.WriteLine("Employee salary: {0}", result.salary);
            }
            else
                Console.WriteLine("The key does not exist");


            Console.ReadKey();
        }

        class Employee
        {
            public string possition { get; set; } 

            public string name { get; set; }

            public int age { get; set; }   

            public int rate { get; set; }

            public float salary
            {
                get
                { 
                    return rate * 8 * 5 * 4 * 12; 
                }

            }

            public Employee(string possition, string name, int age, int rate)
            {
                this.possition = possition;
                this.name = name;
                this.age = age;
                this.rate = rate;
            }
        }
    }
}
