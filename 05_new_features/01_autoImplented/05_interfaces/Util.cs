﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class Console
    {
        static public string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
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
                throw new FormatException("input was not a number.");
            }

        }
    }
}