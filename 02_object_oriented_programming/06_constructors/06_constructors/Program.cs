﻿using System;
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
                var newStudent = new Student();

                newStudent.Name = Util.Console.Ask("Student Name: ");
                newStudent.Grade = int.Parse(Util.Console.Ask("Student Grade: "));
                newStudent.Birthday = Util.Console.Ask("Student Birthday: ");
                newStudent.Address = Util.Console.Ask("Student Address: ");
                newStudent.Phone = int.Parse(Util.Console.Ask("Student Phone Number: "));

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count: {0}", Student.Count);

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

        static void Import()
        {
            var importedStudent = new Student("Jenny", 85, "birthday", "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }
    }
    class Student
    {
        static public int Count = 0;
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        //empty constructor - allows creation of Student without arguments
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

        public int Phone
        {
            set
            {
                phone = value;
                //Console.WriteLine(phone);
            }
        }

        //using a function:
        public void setPhone(int number)
        {
            phone = number;
        }
    }
}