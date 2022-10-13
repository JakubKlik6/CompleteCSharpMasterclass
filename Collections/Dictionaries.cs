using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
                new Employee("SE","Maciek",22,100),
                new Employee("Intern","Mariusz",19,80)
            };


            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();
            foreach (Employee item in employees)
            {
                employeeDictionary.Add(item.possition, item);
            }

            //upadte
            string KeyToUpdate = "SE";
            if (employeeDictionary.ContainsKey(KeyToUpdate))
            {
                employeeDictionary[KeyToUpdate] = new Employee("SE", "Marek", 19, 80);
                Console.WriteLine("Emplyee with key/role {0} was updated!",KeyToUpdate);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", KeyToUpdate);
            }
                

            //Remove
            string KeyToRemove = "Intern";
            if (employeeDictionary.Remove(KeyToRemove))
            {
                Console.WriteLine("Emplyee with key/role {0} was removed!",KeyToRemove);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}",KeyToRemove);
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


            for (int i = 0; i < employeeDictionary.Count; i++)
            {
                //using Element(i) to return key value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeeDictionary.ElementAt(i);
                //print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);
                //storing the value in the emplyee object
                Employee employeeValue = keyValuePair.Value;
                //printing the properties of the emplyee object
                Console.WriteLine("Employee name: {0}", employeeValue.name);
                Console.WriteLine("Employee role: {0}", employeeValue.possition);
                Console.WriteLine("Employee age: {0}", employeeValue.age);
                Console.WriteLine("Employee salary: {0}", employeeValue.salary);
            }


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
