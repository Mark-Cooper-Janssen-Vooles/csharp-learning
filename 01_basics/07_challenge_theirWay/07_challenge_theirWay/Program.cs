using System;

namespace _07_challenge_theirWay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            //specifies a new array of strings, with studentCount as the length.
            var studentNames = new string[studentCount];
            var studentGrades = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Student Name: ");
                studentNames[i] = Console.ReadLine();
                Console.Write("Student Grade: ");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }

            //display results back to console.
            for (int i = 0; i < studentCount; i++)
            {
                //Console.WriteLine($"Name: {studentNames[i]}, Grade: {studentGrades[i]}");

                //or write like this:
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }
        }
    }
}
