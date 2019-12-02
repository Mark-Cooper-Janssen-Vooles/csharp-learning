using System;
using System.Collections.Generic;

namespace _08_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //a list is like a dynamic array, where we don't need to specify the size and we can just keep adding items to it.
            //a list is one of many options in .nets collections library. There are many more collection types with their own unique behaviours, but list is one of the most common.


            //when you specify list, it gives an error. you need to hover over it and select "potential fixes", then the top one "using". This allows us to use the list collection.
            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            var adding = true;

            while (adding)
            {
                Console.Write("Student Name: ");
                studentNames.Add(Console.ReadLine());
                Console.Write("Student Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another y/n");

                if(Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }


			//display results back to console.
			for (int i = 0; i < studentNames.Count; i++)
			{
				//Console.WriteLine($"Name: {studentNames[i]}, Grade: {studentGrades[i]}");

				//or write like this:
				Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
			}
		}
    }
}
