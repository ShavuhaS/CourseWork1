namespace FunctionParser
{
    public class InvalidFunctionCallException : Exception
    {
        public InvalidFunctionCallException(string name, bool isTooMany) 
            : base($"Invalid function call: {name} ({(isTooMany ? "too many" : "not enough")} arguments)")
        { }
    }
}
