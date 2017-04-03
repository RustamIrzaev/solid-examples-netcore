namespace SOLID
{
	public class EmailMessage
	{
		public string EmailFrom { get; set; }
		public string EmailTo { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }

		public EmailMessage()
		{
		}

		public EmailMessage(string emailFrom, string emailTo)
		{
			EmailFrom = emailFrom;
			EmailTo = emailTo;
		}
	}
}
