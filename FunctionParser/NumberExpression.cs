namespace FunctionParser
{
    public class NumberExpression : Expression
    {
        private readonly double value;

        public NumberExpression(double value)
        {
            this.value = value;
        }

        public override double Evaluate(IContext context)
        {
            return value;
        }
    }
}
