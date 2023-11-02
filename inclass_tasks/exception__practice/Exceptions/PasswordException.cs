namespace exception__practice.Exceptions
{
    internal class PasswordException : Exception
    {
        public PasswordException(string? message) : base(message)
        {
        }
    }
}
