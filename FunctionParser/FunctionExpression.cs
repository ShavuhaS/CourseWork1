namespace FunctionParser
{
    public class FunctionExpression : Expression
    {
        private Expression[] args;
        private string funcName;

        public FunctionExpression(string funcName, Expression[] args)
        {
            this.args = args;
            this.funcName = funcName;
        }

        public override double Evaluate(IContext context)
        {
            double[] argValues = new double[this.args.Length];

            for (int i = 0; i < this.args.Length; i++)
            {
                argValues[i] = this.args[i].Evaluate(context);
            }

            return context.InvokeFunction(funcName, argValues);
        }
    }
}
