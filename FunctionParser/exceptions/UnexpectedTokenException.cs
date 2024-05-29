namespace FunctionParser
{
    public class UnexpectedTokenException : Exception
    {
        public UnexpectedTokenException(TokenType token)
            : base($"Unexpected token: {token}") { }
    }
}
