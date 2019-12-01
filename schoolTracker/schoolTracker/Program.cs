using System;

namespace schoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {

            //var studentGrades = new int[10];

            //studentGrades[0] = 80;
            //studentGrades[1] = 77;

            //studentGrades[9] = 65;
            ////studentGrades[11] = 9898; //can't do this since its outside of array limit ( it was stipulated as 1-10 or index 0 to index 0)
            ///



            //var studentGrades = new int[10] { 80, 60, 45, 55, 80, 80, 60, 45, 55, 80 };
            //Console.WriteLine(studentGrades[3]);


            // example below removes 10, so no max array length is specified.
            var studentGrades = new int[] { 80, 60, 45, 55, 80, 80, 60, 45, 55, 80, 95 };
            //studentGrades[10] = 63;
            //studentGrades[11] = 95;

            Console.WriteLine(studentGrades[10]);

            Console.WriteLine("Hello World!");

        }
    }
}
