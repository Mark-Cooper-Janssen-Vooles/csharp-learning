using System;

namespace _06_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //update grade tracking. want to insert grades and names into console 1 by 1. once set, display all names and grades. can handle any number of students. 
            Console.WriteLine("How many students would you like to enter data for?");
            var totalStudents = int.Parse(Console.ReadLine());

            var studentArrayName = studentAdder(totalStudents);

            foreach (var student in studentArrayName)
            {
                Console.WriteLine($"Name and grade: {student} ");

            }

        }

        static Array studentAdder(int totalStudents)
        {
            var studentArray = new string[totalStudents];

            for (int i = 0; i < totalStudents; i++)
            {
                Console.WriteLine("Please enter students name");
                var name = Console.ReadLine();
                Console.WriteLine($"Please enter {name}'s grade");
                var grade = Console.ReadLine();

                studentArray[i] = name + ", " + grade;
            }

            return studentArray;
        }
    }
}
