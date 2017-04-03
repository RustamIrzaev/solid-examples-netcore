using System;

namespace SOLID
{
	public class EmailSender
	{
		private EmailService _emailService = new EmailService();
		private ILogger _logger;

		public EmailSender(ILogger logger)
		{
			_logger = logger;
		}

		public bool SendEmail(string from, string to, 
		                      string subject, string body)
		{
			try
			{
				_emailService.Validate(from);
				_emailService.Validate(to);

				SmtpClient client = new SmtpClient();
				var result = client.Send(new EmailMessage(from, to)
				{
					Subject = subject,
					Body = body
				});

				return result;
			}
			catch (Exception ex)
			{
				_logger.Log(ex);
				return false;
			}
		}
	}
}
