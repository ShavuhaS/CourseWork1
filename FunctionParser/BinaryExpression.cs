namespace FunctionParser
{
    public class BinaryExpression : Expression
    {
        private Expression left;
        private Expression right;
        private Func<double, double, double> operation;

        public BinaryExpression(Expression left, Expression right, Func<double, double, double> op)
        {
            this.left = left;
            this.right = right;
            operation = op;
        }

        public override double Evaluate(IContext context)
        {
            return operation(left.Evaluate(context), right.Evaluate(context));
        }
    }
}
