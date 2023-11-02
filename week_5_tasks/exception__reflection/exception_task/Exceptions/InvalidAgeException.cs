namespace exception_task.Exceptions
{
	internal class InvalidAgeException : Exception
	{
		public InvalidAgeException(string? message) : base(message)
		{
		}
	}
}
