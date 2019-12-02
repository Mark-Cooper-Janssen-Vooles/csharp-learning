using System;
using System.Collections.Generic;

namespace _01_introduction_to_OOP
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

				Console.Write("Student Name: ");
				newStudent.Name = Console.ReadLine();
				Console.Write("Student Grade: ");
				newStudent.Grade = int.Parse(Console.ReadLine());
				Console.Write("Student Birthday: ");
				newStudent.Birthday = Console.ReadLine();
				Console.Write("Student Address: ");
				newStudent.Address = Console.ReadLine();
				Console.Write("Student Phone number: ");
				//using property
				newStudent.Phone = (int.Parse(Console.ReadLine()));

				students.Add(newStudent);
                //accessed through the class, not an instance of the student
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
	}
	class Student
	{
        //client wants to know how many students are enrolled without having to manually count.
        //a static field is not associated with any instance of object created in the class. i.e. the field is share accross all instances of students.
        //we access the count field through the class, and not the instanciated object.
        //intialize so that it starts at zero on quick glance.
        static public int Count = 0;
		public string Name;
		public int Grade;
		public string Birthday;
		public string Address;
		private int phone;

		//using a c# property:
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