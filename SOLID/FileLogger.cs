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

	public class CloudLogger : ILogger
	{
		public void Log(Exception exception)
		{
			// save somewhere to Azure (or Amazon)
		}
	}

	public class NetworkLogger : ILogger
	{
		public void Log(Exception exception)
		{
			// save somewhere in local network
		}
	}
}
