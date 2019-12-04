using System;
using System.Collections.Generic;

namespace interfaces
{
    //sometimes you may want the class to have some properties and methods of another class, but not all of them. We can use an interface to do just that. 
    interface IPayee
    {
        void Pay();
    }


    public class PayRoll
    { 
        List<IPayee> payees = new List<IPayee>();

        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }

        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
                Console.WriteLine($"{payee} has been paid.");
            }

        }
    }

}