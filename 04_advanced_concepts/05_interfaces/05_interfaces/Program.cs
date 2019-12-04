
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
        //added school attribute
        //public int School;
        //instead of using int we can now use the "School" enum type (specified at the top)
        public School School;

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
}