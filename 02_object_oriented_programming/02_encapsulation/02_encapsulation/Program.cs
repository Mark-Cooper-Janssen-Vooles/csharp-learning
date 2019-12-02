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

                //encapsulation: make phone number unavailable after its initially set.


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
                //.Phone is inaccessible now, need to use function .setPhone
                //newStudent.Phone = int.Parse(Console.ReadLine());
                newStudent.setPhone(int.Parse(Console.ReadLine()));

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
	//phone changed to private
	class Student
	{
		public string Name;
		public int Grade;
		public string Birthday;
		public string Address;
        //private Phone makes in inacessable above using the .Phone setter, need to make function 
        //public int Phone;
        //common practice to indicate if the variable is public or private, by changing the casing of the first character. for private its lower case:
        private int phone;

        public void setPhone(int number)
        {
            phone = number;
        }
	}
}