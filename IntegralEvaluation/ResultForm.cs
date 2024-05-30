using FunctionParser;
using System.Drawing.Configuration;

namespace IntegralEvaluation
{
    public partial class ResultForm : Form
    {
        private const double drawingPrecision = 1e-3;
        private const int pointPrecision = 6;

        private Expression expression;
        private string formula;
        private SolvingMethod method;
        private double a;
        private double b;
        private int intervals;
        private double result;

        public ResultForm(string formula, Expression expression, SolvingMethod method, double a, double b, int intervals)
        {
            this.formula = formula;
            this.expression = expression;
            this.method = method;
            this.a = a;
            this.b = b;
            this.intervals = intervals;

            InitializeComponent();
            double test = 1e100;
            Solve();
            try
            {
                Draw();
            }
            catch
            {
                this.chart.Series.Clear();
                MessageBox.Show("Виникла помилка візуалізації.\nЧисла занадто великі або занадто малі", "Помилка");
            }
        }

        private void Solve()
        {
            double res;
            int complexity = 0;
            switch (method)
            {
                case SolvingMethod.Rectangle:
                    res = IntegralSolving.Rectangle(expression, a, b, intervals);
                    complexity = intervals;
                    break;
                case SolvingMethod.Trapezoid:
                    res = IntegralSolving.Trapezoid(expression, a, b, intervals);
                    complexity = intervals;
                    break;
                case SolvingMethod.Simpson:
                    res = IntegralSolving.Simpson(expression, a, b, intervals);
                    complexity = 3 * intervals;
                    break;
                default:
                    throw new NotImplementedException();
            }

            this.label_ResultComplexity.Text = complexity.ToString();
            this.textBox_Result.Text = res.ToString();
            this.result = res;
        }

        private void Draw()
        {
            this.chart.ChartAreas[0].AxisX.Minimum = a;
            this.chart.ChartAreas[0].AxisX.Maximum = b;
            DrawFunction();
            DrawApproximatedFunction();
        }

        private void DrawFunction()
        {
            FunctionContext ctx = new FunctionContext(a);
            for (double x = a; x <= b; x += drawingPrecision)
            {
                ctx.x = Math.Round(x, pointPrecision);
                double value = this.expression.Evaluate(ctx);
                Convert.ToDecimal(value);
                this.chart.Series[1].Points.AddXY(x, value);
            }
        }

        private void DrawApproximatedFunction()
        {
            FunctionContext ctx = new FunctionContext(a);
            double delta = (b - a) / intervals;
            double x = a;

            switch (method)
            {
                case SolvingMethod.Rectangle:
                    for (int i = 0; i < intervals; i++)
                    {
                        ctx.x = Math.Round(x + delta / 2, pointPrecision);
                        double value = this.expression.Evaluate(ctx);
                        IntegralSolving.ValidateDouble(value);
                        Convert.ToDecimal(value);
                        this.chart.Series[0].Points.AddXY(x, value);
                        x += delta;
                        this.chart.Series[0].Points.AddXY(x, value);
                    }
                    break;
                case SolvingMethod.Trapezoid:
                    for (int i = 0; i <= intervals; i++)
                    {
                        ctx.x = x;
                        double value = this.expression.Evaluate(ctx);
                        Convert.ToDecimal(value);
                        IntegralSolving.ValidateDouble(value);
                        this.chart.Series[0].Points.AddXY(x, value);
                        x = Math.Round(x + delta, pointPrecision);
                    }
                    break;
                case SolvingMethod.Simpson:
                    double start;
                    for (int i = 0; i < intervals; i++)
                    {
                        start = Math.Round(a + delta * i, pointPrecision);
                        double end = Math.Round(start + delta, pointPrecision);
                        Func<double, double> interpolatedFunc = IntegralSolving.QuadraticInterpolation(this.expression, start, end);
                        for (double num = start; num <= end; num += drawingPrecision)
                        {
                            double value = interpolatedFunc(num);
                            IntegralSolving.ValidateDouble(value);
                            Convert.ToDecimal(value);
                            this.chart.Series[0].Points.AddXY(num, value);
                        }
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void button_SaveAsText_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialog = new SaveFileDialog();
            string time = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string generatedFileName = $"Результат_інтегрування_{time}.txt";
            dialog.Filter = "Text files (*.txt)|*.txt";
            dialog.Title = "Оберіть місце збереження файлу";
            dialog.FileName = generatedFileName;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                if (!fileName.EndsWith(".txt"))
                {
                    fileName += ".txt";
                }

                try
                {
                    string result = $"f(x) = {formula}\n";
                    result += $"a = {a}\nb = {b}\n";
                    result += $"intervals = {intervals}\n";
                    result += $"method = {method}\n";
                    result += $"Integral = {this.result}\n";
                    File.WriteAllText(fileName, result);
                    MessageBox.Show($"Файл успішно збережено за шляхом:\n{fileName}", "Успіх");
                } catch
                {
                    MessageBox.Show("Сталася помилка при збереженні файлу.", "Помилка");
                }
            }
        }
    }
}
