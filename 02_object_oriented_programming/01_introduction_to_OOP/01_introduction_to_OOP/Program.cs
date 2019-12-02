using System;
using System.Collections.Generic;

namespace _01_introduction_to_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //var student = new Student();
            //student.Name = "Jim";
            ////console.Write outputs values to the screen without a new line character
            ////console.WriteLine outputs values with a new line character(subsequent output starts on a new line)
            //Console.Write(student.Name);

            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                Console.Write("Student Name: ");
                newStudent.Name = Console.ReadLine();
                Console.Write("Student Grade: ");
                newStudent.Grade = int.Parse(Console.ReadLine());
                Console.Write("Student Birthday: ");
                newStudent.Birthday = Console.ReadLine();
                Console.Write("Student Address: ");
                newStudent.Address = Console.ReadLine();
                Console.Write("Student Phone number: ");
                newStudent.Phone = int.Parse(Console.ReadLine());

                students.Add(newStudent);

                Console.WriteLine("Add another y/n");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }
    }
    //new class
    class Student
    {
        //public means usable by other classes.
        //we specified the data type for each keyword. in our non-class code we always just used var
        //can't use var keyword for our class variables.
        //part of a bigger concept c# uses called "type safety" -> it enforces the type of data we use 
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        public int Phone;
    }
}