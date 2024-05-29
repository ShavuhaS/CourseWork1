namespace FunctionParser
{
    public class ExpressionEndException : Exception
    {
        public ExpressionEndException()
            : base($"Unexpected tokens at the end of expression") { }
    }
}
