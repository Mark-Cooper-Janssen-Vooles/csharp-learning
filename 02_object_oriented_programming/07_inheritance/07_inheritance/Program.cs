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

    class Member
    {
        public string Name;
        public string Address;
        //needd to change from private to protected for other classes to inherit.
        //private int phone;
        protected int phone;
        //we'll also need the setter, just like student, in order to set our protected phone number.
        public int Phone
        {
            set
            {
                phone = value;
                //Console.WriteLine(phone);
            }
        }
    }


    // : Member means student inherits from Member. Get rid of shared fields, since they already exist in member.
    class Student : Member
    {
        static public int Count = 0;
        public int Grade;
        public string Birthday;
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
    }

    class Teacher : Member
    {
        public string Subject;
    }
}