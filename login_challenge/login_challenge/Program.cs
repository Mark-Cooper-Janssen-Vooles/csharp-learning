using System;

namespace login_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var passcode = "";

            while(passcode != "secret")
            {
                Console.WriteLine("What is the secret passcode?");
                passcode = Console.ReadLine();

                if (passcode != "secret")
                {
                    Console.WriteLine("THOU SHALT NOT PASS!.");
                }
            }

            Console.WriteLine("You shall pass.");
        }
    }
}
