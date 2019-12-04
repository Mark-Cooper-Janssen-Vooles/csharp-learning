using System;

namespace _03_out_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = 2;
            //Console.WriteLine(x);
            //Five(x);
            //Console.WriteLine(x);
            ////logs 2, 5, 2

            var x = 2;
            Console.WriteLine(x);
            Five(out x);
            Console.WriteLine(x);
            ////logs 2, 5, 5.
            ////out lets us reference the variable that is passed in. We are able to set it in the function, outputting or sending changes back out to the variable that was referenced.

            Double(ref x);
            Console.WriteLine(x);

        }

        //static void Five(int a)
        //{
        //    a = 5;
        //    Console.WriteLine(a);
        //}

        static void Five(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        //double can't use out with a = a * 2 ,unassigned error.
        //out requires to assign or initialise the value passed in, the paramater.
        // ??? need to use "ref" instead lol.
        static void Double(ref int a)
        {
            a = a * 2;
            Console.WriteLine(a);
        }
    }
}
