namespace FunctionParser
{
    public abstract class Expression
    {
        public abstract double Evaluate(IContext context);
    }
}
