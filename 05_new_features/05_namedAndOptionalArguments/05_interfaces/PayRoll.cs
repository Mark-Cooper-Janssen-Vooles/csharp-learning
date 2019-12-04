using System;
using System.Collections.Generic;

namespace interfaces
{
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

            Logger.Log("PayRoll started", "PayRoll");
        }

        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
                Console.WriteLine($"{payee} has been paid.");
            }

            Logger.Log("PayAll Completed", "PayRoll", 2);

        }
    }

}