﻿
using System;
using System.Collections.Generic;

namespace interfaces
{
    enum School
    {
        Hogwarts,
        Harvard,
        MIT
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            PayRoll payroll = new PayRoll();
            payroll.PayAll();

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");
                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");
                    newStudent.School = (School)Util.Console.AskInt("School name (type the corresponding number): \n 0: Hogwarts High \n 1: Harvard \n 2: MIT ");

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
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding student, please try again.");
                }

            }

 
                ShowGrade("Tom");

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
            Exports();
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 85, "birthday", "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                }
            }
        }

        //school client wants search functionality, wants to search students by name and display their grade. We'll use the build-in find feature, that comes with collections.
        //static void ShowGrade(string name)
        //{
        //    //need to pass a 'predicate' into find: a predicate is a function that always returns a boolean. i.e. true if the studnt has been found.
        //    var found = students.Find(predicate);
        //    Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        //}

        //static bool predicate(Student student)
        //{
        //    if (student.Name == "Jim")
        //        return true;
        //    else
        //        return false;
        //}

        //above can be reworked to:
        //static bool predicate(Student student)
        //{
        //    return (student.Name == "Jim");
        //}
        //which can be put into show grade itself... doesn't warrant its own function, instead can use a lambda.

        static void ShowGrade(string name)
        {
            //below is called a lamba (a function as an argument written directly in).
            //var found = students.Find((student) =>
            //    {
            //        return (student.Name == "Jim");
            //    });

            //can be refactored to:
            var found = students.Find(student => student.Name == name);
            //a lambda is an anonymous function with short syntax, very convenient to use.

            Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        }

    }
    class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }

    class Student : Member
    {
        static public int Count { get; set; } = 0;
        public int Grade { get; set; }
        public string Birthday { get; set; }
        public School School { get; set; }

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }
}