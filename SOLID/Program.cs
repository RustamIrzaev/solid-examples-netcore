using System;
using System.Collections.Generic;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Hello SOLID ;)");

			Console.WriteLine("Send email to my team");

			EmailSender sender = new EmailSender(new NetworkLogger());
			sender.SendEmail("r.irzaev@mobidev.biz", "dotnet@mobidev.biz",
							 "it is all about SOLID", "just use it");

			Console.WriteLine("Sent");

			var customers = new List<IDatabase>();
			customers.Add(new GoldCustomer());
			customers.Add(new AwesomeCustomer());

			foreach (var customer in customers)
			{
				customer.Save();
			}
        }
    }
}
