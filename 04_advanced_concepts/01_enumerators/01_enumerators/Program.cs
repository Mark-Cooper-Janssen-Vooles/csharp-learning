using System;
using System.Collections.Generic;

namespace _05_namespaces
{

    //creating enum:
    enum School
    {
        //Hogwarts = 0,
        //Harvard = 1,
        //MIT = 2

        //enums default behaviour: the first should be zero, 2nd one, etc. will behave the same as above:
        Hogwarts,
        Harvard,
        MIT
    }


    class Program
    {
        //can't use var unless its a local variable decleration.
        //var students = new List<Student>();
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            //students is just a local list in Main. move it to class Program to access it anywhere in the class!
            //var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");
                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");
                    //added student school.
                    //the  \n makes a new line.
                    //newStudent.School = Util.Console.AskInt("School name (type the corresponding number): \n 0: Hogwarts High \n 1: Harvard \n 2: MIT ");

                    //even though enum has an underlying number, it can't explicity convert that without a cast.
                    //takes integer from AskInt and casts it over (or converts it into) a school enum.
                    newStudent.School = (School) Util.Console.AskInt("School name (type the corresponding number): \n 0: Hogwarts High \n 1: Harvard \n 2: MIT ");

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
                switch(student.School)
                {
                    //case 0:
                    //    Console.WriteLine("Exporting to Hogwarts");
                    //    break;
                    //case 1:
                    //    Console.WriteLine("Exporting to Harvard");
                    //    break;
                    //case 2:
                    //    Console.WriteLine("Exporting to MIT");
                    //    break;

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

    class Teacher : Member
    {
        public string Subject;
    }
}