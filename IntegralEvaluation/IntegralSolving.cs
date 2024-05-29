using FunctionParser;

namespace IntegralEvaluation
{
    public class IntegralSolving
    {

        public static double Rectangle(Expression expression, double a, double b, int intervals)
        {
            double delta = (b - a) / intervals;
            double x = a;
            double res = 0;
            FunctionContext ctx = new FunctionContext(a);

            for(int i = 0; i < intervals; i++)
            {
                ctx.x = Math.Round(x + delta / 2, 6);
                double value = expression.Evaluate(ctx);
                res += value * delta;
                x += delta;
            }

            ValidateDouble(res);
            return res;
        }

        public static double Trapezoid(Expression expression, double a, double b, int intervals)
        {
            double delta = (b - a) / intervals;
            double x = a;
            double res = 0;
            FunctionContext ctx = new FunctionContext(a);
            double prev = expression.Evaluate(ctx);

            for (int i = 0; i < intervals; i++)
            {

                x = Math.Round(x + delta, 6);
                ctx.x = x;
                double next = expression.Evaluate(ctx);
                res += (prev + next) / 2 * delta;
                prev = next;
            }

            ValidateDouble(res);
            return res;
        }

        public static double Simpson(Expression expression, double a, double b, int intervals)
        {
            double delta = (b - a) / intervals;
            double x = a;
            double res = 0;
            FunctionContext ctx = new FunctionContext(a);
            double prev = expression.Evaluate(ctx);

            for (int i = 0; i < intervals; i++)
            {
                ctx.x = Math.Round(x + delta / 2, 6);
                double middle = expression.Evaluate(ctx);
                x = Math.Round(x + delta, 6);
                ctx.x = x;
                double next = expression.Evaluate(ctx);
                res += (delta / 6) * (prev + 4 * middle + next);
                prev = next;
            }

            ValidateDouble(res);
            return res;
        }

        public static Func<double, double> QuadraticInterpolation(Expression expr, double a, double b)
        {
            FunctionContext ctx = new FunctionContext(a);
            double start = expr.Evaluate(ctx);
            double m = (a + b) / 2;
            ctx.x = m;
            double middle = expr.Evaluate(ctx);
            ctx.x = b;
            double end = expr.Evaluate(ctx);

            return (double x) =>
            {
                double first = start * (x - m) * (x - b) / (a - m) / (a - b);
                double second = middle * (x - a) * (x - b) / (m - a) / (m - b);
                double third = end * (x - a) * (x - m) / (b - a) / (b - m);

                return first + second + third;
            };
        }

        public static void ValidateDouble(double res)
        {
            if (double.IsNaN(res))
            {
                throw new Exception("Результат не є числом (функція не визначена у точці на відрізку)");
            }
            if (double.IsInfinity(res))
            {
                throw new Exception("Результат є нескінченністю (функція не визначена у точці на відрізку або результат занадто великий для зберігання)");
            }
        }
    }
}
