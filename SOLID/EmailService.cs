using System;

namespace SOLID
{
	public class EmailService
	{
		public void Validate(string email)
		{ 
			if (string.IsNullOrEmpty(email) || 
			    !email.Contains("@") || !email.Contains("."))
			{
				throw new Exception("Email is not valid.");
			}
		}
	}
}
