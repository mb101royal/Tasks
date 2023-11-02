namespace exception__practice.Exceptions
{
    internal class InvalidNameException : Exception
    {
        public InvalidNameException(string? message) : base(message)
        {
        }
    }
}
