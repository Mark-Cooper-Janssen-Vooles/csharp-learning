using System;

namespace forEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new int[] { 80, 77, 45, 87, 54, 43, 62 };

            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }
   
        }
    }
}
