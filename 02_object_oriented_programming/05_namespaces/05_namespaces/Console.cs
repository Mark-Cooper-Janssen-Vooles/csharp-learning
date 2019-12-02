using System;
using System.Collections.Generic;
using System.Text;

//renamed namespace from _05_namespaces to "Util" (short for utility)

    //name spaces can be useful to seperate or group classes together.
namespace Util
{
    class Console
    {
        static public string Ask(string question)
        {
            //its looking for a write function in this class, which we don't have. so to specify a different namespace, we can specify the namespace infront
            //Console.Write(question);

            //namespace in front:
            System.Console.Write(question);
            return System.Console.ReadLine();

        }
    }
}
