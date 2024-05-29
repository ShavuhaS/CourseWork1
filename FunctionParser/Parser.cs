namespace FunctionParser
{
    public class Parser
    {
        private Tokenizer tokenizer;

        private Parser(Tokenizer tokenizer)
        {
            this.tokenizer = tokenizer;
        }

        public static Expression Parse(string input)
        {
            return (new Parser(new Tokenizer(input))).Parse();
        }

        public Expression Parse()
        {
            Expression expr = ParseTerm();

            if (tokenizer.currToken != TokenType.END)
            {
                throw new ExpressionEndException();
            }

            return expr;
        }

        private Expression ParseTerm()
        {
            Expression left = ParseFactor();

            while (
                tokenizer.currToken == TokenType.Add ||
                tokenizer.currToken == TokenType.Subtract
            )
            {
                Func<double, double, double> op = null;
                if (tokenizer.currToken == TokenType.Add)
                {
                    op = (double a, double b) => a + b;
                }
                else if (tokenizer.currToken == TokenType.Subtract)
                {
                    op = (double a, double b) => a - b;
                }

                this.tokenizer.NextToken();
                Expression right = ParseFactor();

                left = new BinaryExpression(left, right, op);
            }

            return left;
        }

        private Expression ParseFactor()
        {
            Expression left = ParseUnary();

            while (
                tokenizer.currToken == TokenType.Multiply ||
                tokenizer.currToken == TokenType.Divide
            )
            {
                Func<double, double, double> op = null;
                if (tokenizer.currToken == TokenType.Multiply)
                {
                    op = (double a, double b) => a * b;
                }
                else if (tokenizer.currToken == TokenType.Divide)
                {
                    op = (double a, double b) => a / b;
                }

                this.tokenizer.NextToken();
                Expression right = ParseUnary();

                left = new BinaryExpression(left, right, op);
            }

            return left;
        }

        private Expression ParseUnary()
        {
            if(this.tokenizer.currToken == TokenType.Subtract)
            {
                this.tokenizer.NextToken();
                return new UnaryExpression(ParsePrimary(), (double x) => -x);
            }

            return ParsePrimary();
        }

        private Expression ParsePrimary()
        {
            if (this.tokenizer.currToken == TokenType.OpenParenthesis)
            {
                this.tokenizer.NextToken();
                Expression expr = ParseTerm();
                if (this.tokenizer.currToken != TokenType.CloseParenthesis)
                {
                    throw new InvalidSyntaxException("Missing close parenthesis!");
                }
                this.tokenizer.NextToken();

                return expr;
            }

            if (this.tokenizer.currToken == TokenType.Identifier)
            {
                string identifier = this.tokenizer.currIdentifier;
                this.tokenizer.NextToken();

                if (this.tokenizer.currToken == TokenType.OpenParenthesis)
                {
                    List<Expression> args = new List<Expression>();
                    do
                    {
                        this.tokenizer.NextToken();
                        Expression next = ParseTerm();
                        args.Add(next);
                    } while (this.tokenizer.currToken == TokenType.Comma);

                    if (this.tokenizer.currToken != TokenType.CloseParenthesis)
                    {
                        throw new InvalidSyntaxException("Missing close parenthesis!");
                    }

                    this.tokenizer.NextToken();
                    return new FunctionExpression(identifier, args.ToArray());
                }
                else
                {
                    return new VariableExpression(identifier);
                }
            }

            if (this.tokenizer.currToken == TokenType.Number)
            {
                double value = this.tokenizer.currNumber;
                this.tokenizer.NextToken();
                return new NumberExpression(value);
            }

            throw new UnexpectedTokenException(this.tokenizer.currToken);
        }
    }
}
