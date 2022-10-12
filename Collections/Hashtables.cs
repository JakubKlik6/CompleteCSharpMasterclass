using System;
using System.Collections;
using System.Collections.Generic;

namespace completeMasterclass
{
    internal class program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            Student student1 = new Student(1, "Jakub", 98);
            Student student2 = new Student(2, "Jasiu", 78);
            Student student3 = new Student(3, "Mateusz", 85);
            Student student4 = new Student(4, "Maciek", 65);

            studentTable.Add(student1.Id, student1);
            studentTable.Add(student2.Id, student2);
            studentTable.Add(student3.Id, student3);
            studentTable.Add(student4.Id, student4);

            Student storedStudentId = (Student)studentTable[student1.Id];

            Console.WriteLine("Student ID: {0}, student name: {1}, student GPA: {2}", storedStudentId.Id, storedStudentId.Name, storedStudentId.GPA);

            //retrive all values from Hashtable
            foreach (DictionaryEntry entry in studentTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID: {0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);
            }

            //Simplify
            foreach (Student value in studentTable.Values)
            {
                Console.WriteLine("Student ID: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }

            Console.ReadKey();
        }

        class Student
        {
            //property called ID
            public int Id { get; set; }

            //property called Name
            public string Name { get; set; }

            //property called Gpa
            public float GPA { get; set; }

            //simple constructor
            public Student(int id, string name, float gPA)
            {
                Id = id;
                Name = name;
                GPA = gPA;
            }
        }
    }
}
