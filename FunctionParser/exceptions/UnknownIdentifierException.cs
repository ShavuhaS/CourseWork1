namespace FunctionParser
{
    public class UnknownIdentifierException : Exception
    {
        public UnknownIdentifierException(string identifier)
            : base($"Unknown identifier: {identifier}") { }
    }
}
