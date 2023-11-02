namespace exception__practice.Exceptions
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string? message) : base(message)
        {
        }
    }
}
