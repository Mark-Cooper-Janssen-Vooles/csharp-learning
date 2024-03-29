﻿using System;
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
        //these are called "fields" in c#. They become properties when they have the c# setter or getter functionality.
		public string Name;
		public int Grade;
		public string Birthday;
		public string Address;
		private int phone;

        //using a c# property:
        public int Phone
        {
            set {
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