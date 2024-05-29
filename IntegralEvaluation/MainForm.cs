using FunctionParser;
using System.Globalization;

namespace IntegralEvaluation
{
    public partial class MainForm : Form
    {
        private const string placeholderFormula = "Введіть функціональний вираз...";
        private const string placeholderA = "Нижня межа";
        private const string placeholderB = "Верхня межа";
        private readonly Color textboxColor = Color.LightBlue;
        private readonly Color errorColor = Color.Red;
        private const double minLimit = -1e3;
        private const double maxLimit = 1e3;
        private const int maxDigits = 6;
        private const int minIntervals = 1;
        private const int maxIntervals = 1000;
        private GuideForm guideForm;

        private Expression expression;
        private double a;
        private double b;
        private int intervals;

        public MainForm()
        {
            InitializeComponent();
            textBox_A.Text = placeholderA;
            textBox_B.Text = placeholderB;
        }


        #region Validation
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Помилка!");
        }

        private bool ValidateFormula()
        {
            try
            {
                expression = Parser.Parse(textBox_Formula.Text);
                expression.Evaluate(new FunctionContext(a));
            }
            catch (Exception ex)
            {
                textBox_Formula.BackColor = errorColor;
                this.ShowError($"Некоректний ввід формули:\n{ex.Message}");
                return false;
            }

            return true;
        }

        private bool ValidateA()
        {
            double val;

            try
            {
                val = double.Parse(textBox_A.Text, CultureInfo.InvariantCulture);
                if (val > maxLimit || val < minLimit)
                    throw new Exception();
                double zeroLimit = Math.Pow(10, -maxDigits);
                if (val != 0 && Math.Abs(val) < zeroLimit)
                    throw new Exception();
            }
            catch (Exception e)
            {
                textBox_A.BackColor = errorColor;
                this.ShowError("Некоректний ввід нижньої межі А");
                return false;
            }

            a = val;
            return true;
        }

        private bool ValidateB()
        {
            double val;

            try
            {
                val = double.Parse(textBox_B.Text, CultureInfo.InvariantCulture);
                if (val > maxLimit || val < minLimit)
                    throw new Exception();
                double zeroLimit = Math.Pow(10, -maxDigits);
                if (val != 0 && Math.Abs(val) < zeroLimit)
                    throw new Exception();
            }
            catch (Exception e)
            {
                textBox_B.BackColor = errorColor;
                this.ShowError("Некоректний ввід верхньої межі B");
                return false;
            }

            b = val;
            return true;
        }

        private bool ValidateAB()
        {
            if (a >= b)
            {
                label_AB_info.ForeColor = errorColor;
                this.ShowError("A повинно бути меншим за B");
                return false;
            }

            return true;
        }

        private bool ValidateIntervals()
        {
            int val;

            try
            {
                val = int.Parse(textBox_Interval.Text, CultureInfo.InvariantCulture);
                if (val > maxIntervals || val < minIntervals)
                    throw new Exception();
            }
            catch (Exception e)
            {
                textBox_Interval.BackColor = errorColor;
                this.ShowError("Некоректний ввід числа відрізків");
                return false;
            }

            intervals = val;
            return true;
        }

        private bool ValidateMethod()
        {
            if (comboBox_Method.SelectedIndex == -1)
            {
                this.ShowError("Будь ласка, оберіть метод обчислення");
                return false;
            }

            return true;
        }
        #endregion

        #region Event Handlers
        private void textBox_Formula_Enter(object sender, EventArgs e)
        {
            textBox_Formula.BackColor = textboxColor;
            if (textBox_Formula.Text == placeholderFormula)
            {
                textBox_Formula.Text = "";
                textBox_Formula.ForeColor = Color.Black;
            }
        }

        private void textBox_Formula_Leave(object sender, EventArgs e)
        {
            if (textBox_Formula.Text == "")
            {
                textBox_Formula.Text = placeholderFormula;
                textBox_Formula.ForeColor = Color.Gray;
            }
        }

        private void textBox_A_Enter(object sender, EventArgs e)
        {
            textBox_A.BackColor = textboxColor;
            label_AB_info.ForeColor = Color.Black;
            if (textBox_A.Text == placeholderA)
            {
                textBox_A.Text = "";
                textBox_A.ForeColor = Color.Black;
            }
        }

        private void textBox_A_Leave(object sender, EventArgs e)
        {
            if (textBox_A.Text == "")
            {
                textBox_A.Text = placeholderA;
                textBox_A.ForeColor = Color.Gray;
            }
        }

        private void textBox_B_Enter(object sender, EventArgs e)
        {
            textBox_B.BackColor = textboxColor;
            label_AB_info.ForeColor = Color.Black;
            if (textBox_B.Text == placeholderB)
            {
                textBox_B.Text = "";
                textBox_B.ForeColor = Color.Black;
            }
        }

        private void textBox_B_Leave(object sender, EventArgs e)
        {
            if (textBox_B.Text == "")
            {
                textBox_B.Text = placeholderB;
                textBox_B.ForeColor = Color.Gray;
            }
        }

        private void textBox_Interval_Enter(object sender, EventArgs e)
        {
            textBox_Interval.BackColor = textboxColor;
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            if (
                !ValidateA() ||
                !ValidateB() ||
                !ValidateAB() ||
                !ValidateFormula() ||
                !ValidateIntervals() ||
                !ValidateMethod()
            ) return;

            try
            {
                (new ResultForm(
                    textBox_Formula.Text,
                    expression,
                    (SolvingMethod) comboBox_Method.SelectedIndex,
                    a,
                    b,
                    intervals
                )).ShowDialog();
            } catch (Exception ex)
            {
                this.ShowError(ex.Message);
            }
        }

        private void pictureBox_FormulaGuide_Click(object sender, EventArgs e)
        {
            (new GuideForm()).ShowDialog();
        }
        #endregion
    }
}
