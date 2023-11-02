namespace exception_task.Exceptions
{
	internal class InvalidPhoneFormat : Exception
	{
		public InvalidPhoneFormat(string? message) : base(message)
		{
		}
	}
}
