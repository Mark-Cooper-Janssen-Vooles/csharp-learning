using System;
using System.Collections.Generic;

namespace _05_namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");
                    //error handling: right now when you type in a letter for grade, the program errors out with "unhandled exception".
                    //i.e. if you try to parse a string into an int which isn't a number, it doesn't work.
                    //newStudent.Grade = int.Parse(Util.Console.Ask("Student Grade: "));

                    //one quick solution is to use TryParse:
                    //if it doesn't parse correctly, it will just set it to the default value of 0.
                    //var result = int.TryParse(Util.Console.Ask("Student Grade: "), out newStudent.Grade);

                    //if (!result)
                    //{
                    //    Console.WriteLine("Error, please enter a number.");
                    //}

                    //changed the other class file to have "AskInt", where the parsing occurs over there. Even if you put a letter, the data gets pushed to here and enters the catch block anyway.
                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");
                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");
                    newStudent.Address = Util.Console.Ask("Student Address: ");
                    newStudent.Phone = Util.Console.AskInt("Student Phone Number: ");

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    Console.WriteLine("Add another y/n");

                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                //handles specifically incorrect format
                catch (FormatException msg)
                {
                    //if you don't use the .Message property, it looks like the program has crashed.
                    Console.WriteLine(msg.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding student, please try again.");
                }
    
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 85, "birthday", "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }
    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set
            {
                phone = value;
            }
        }
    }

    class Student : Member
    {
        static public int Count = 0;
        public int Grade;
        public string Birthday;

        //allows for student to be made with no arguments too
        public Student()
        {

        }
        //constructor: a constructor has the same name as its class name.
        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }

    class Teacher : Member
    {
        public string Subject;
    }
}