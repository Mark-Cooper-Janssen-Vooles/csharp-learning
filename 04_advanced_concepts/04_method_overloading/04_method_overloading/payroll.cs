using System;
namespace interfaces
{
    //sometimes you may want the class to have some properties and methods of another class, but not all of them. We can use an interface to do just that. 
    interface IPayee
	{
		void Pay();
	}

	class PayRoll
	{
		Teacher teacher1 = new Teacher();
		Teacher teacher2 = new Teacher();
		Principal principal = new Principal();

		void PayAll()
		{
			teacher1.Pay();
			teacher2.Pay();
			principal.Pay();

		}
	}

}
