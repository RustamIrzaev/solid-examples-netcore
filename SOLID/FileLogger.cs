using System;

namespace SOLID
{
	public interface ILogger
	{
		void Log(Exception exception);
	}

	public class FileLogger : ILogger
	{
		public void Log(Exception exception) { 
			System.IO.File.WriteAllText(@"C:\sender_error.txt", 
			                            exception.ToString());
		}
	}
}
