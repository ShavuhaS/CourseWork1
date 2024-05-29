using System.Reflection.Emit;

namespace FunctionParser
{
    public class UnaryExpression : Expression
    {
        private Expression operand;
        private Func<double, double> operation;

        public UnaryExpression(Expression operand, Func<double, double> operation)
        {
            this.operand = operand;
            this.operation = operation;
        }

        public override double Evaluate(IContext context)
        {
            return operation(operand.Evaluate(context));
        }
    }
}
