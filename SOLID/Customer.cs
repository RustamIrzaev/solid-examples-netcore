using System;

namespace SOLID
{
	public class Customer : IDiscount, IDatabase
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public virtual double GetDiscount(double basketCost)
		{
			return basketCost;
		}

		public virtual void Save() 
		{
			Console.WriteLine("Customer has been saved");
		}
	}

	public class AwesomeCustomer : IDiscount, IDatabase, IDatabaseSpendings
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public virtual double GetDiscount(double basketCost)
		{
			return basketCost;
		}

		public double GetTotalSpendings()
		{
			return 999.49d;
		}

		public virtual void Save()
		{
			Console.WriteLine("Customer has been saved");
		}
	}
}
