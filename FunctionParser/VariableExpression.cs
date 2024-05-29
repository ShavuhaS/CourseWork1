namespace FunctionParser
{
    public class VariableExpression : Expression
    {
        private string name;

        public VariableExpression(string name)
        {
            this.name = name;
        }

        public override double Evaluate(IContext context)
        {
            return context.GetVariable(name);
        }
    }
}
