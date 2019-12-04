using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class Console
    {
        //function (or method) overloading
        static public string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
        //copied and pasted. changed string to int, we've "overloaded" the origional function, by duplicating it but its fine if we have different parameters. 
        static public string Ask(int question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }


        static public int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception ex)
            {
                //with custom message as the paramater
                throw new FormatException("input was not a number.");
            }

        }
    }
}
