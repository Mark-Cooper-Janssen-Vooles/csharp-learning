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


                    //try running the app with debug mode!
                    //click to the left of the line number to add a "breakpoint", in debug mode this will pause the program.
                    //click the > arrow to play the program from here.
                    //click the down arrow with the curve to "step over", and go line-by-line.
                    //click the down arrow to "step into" which takes you into i.e. the class itself.

                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");
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