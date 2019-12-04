using System;
namespace interfaces
{
    public class Logger
    {
        //must be a const if its to be used as a default argument.
        const string DefaultSystemName = "SchoolTracker";

        //if provided = afterwards, then it sets a default. things set to default must be at the end of the argument order!
        public static void Log(string msg, string system = DefaultSystemName, int priority = 1)
        {
            Console.WriteLine("System: {0}, Priority: {1}, Msg: {2}", system, priority, msg);
        } 
    }
}
