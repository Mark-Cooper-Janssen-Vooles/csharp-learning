using System;

namespace loopCountingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

			for (int i = 1; i <= 5; i++)
			{
                Console.WriteLine($"This is the {i}st/th time.");
                for (int a = 1; a <= 10; a++)
                {
                    Console.WriteLine(a);
                }

                for (int b = 10; b >= 1; b--)
                {
                    Console.WriteLine(b);
                }
            }

        }
    }
}
