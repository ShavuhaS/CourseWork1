namespace FunctionParser
{
    public class InvalidSyntaxException : Exception
    {
        public InvalidSyntaxException(string message)
            : base($"Invalid syntax: {message}") { }
    }
}
