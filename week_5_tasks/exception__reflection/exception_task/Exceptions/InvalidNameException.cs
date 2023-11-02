namespace exception_task.Exceptions
{
	internal class InvalidNameException : Exception
	{
		public InvalidNameException(string? message) : base(message)
		{
		}
	}
}
