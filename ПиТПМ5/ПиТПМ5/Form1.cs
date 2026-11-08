namespace ПиТПМ5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // ========== ЛИНЕЙНЫЙ АЛГОРИТМ ==========
        // u = tg²(x+y) - e^(y-z) * √(cos(x²) + sin(z²))

        private void btnCalcLinear_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtXL.Text.Replace('.', ','));
                double y = double.Parse(txtYL.Text.Replace('.', ','));
                double z = double.Parse(txtZL.Text.Replace('.', ','));

                // tg²(x+y)
                double tanSum = Math.Tan(x + y);
                double tgSquared = tanSum * tanSum;

                // e^(y-z)
                double expTerm = Math.Exp(y - z);

                // √(cos(x²) + sin(z²))
                double innerSqrt = Math.Cos(x * x) + Math.Sin(z * z);
                if (innerSqrt < 0)
                    throw new ArgumentException("Выражение под корнем отрицательно: cos(x²) + sin(z²) < 0");
                double sqrtTerm = Math.Sqrt(innerSqrt);

                double u = tgSquared - expTerm * sqrtTerm;

                Vivod1.Text = $"u = {u:F6}";
                Vivod1.ForeColor = Color.Black;
            }
            catch (FormatException)
            {
                Vivod1.Text = "Ошибка: введите корректные числа";
                Vivod1.ForeColor = Color.Red;
            }
            catch (ArgumentException ex)
            {
                Vivod1.Text = $"Ошибка: {ex.Message}";
                Vivod1.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Vivod1.Text = $"Ошибка: {ex.Message}";
                Vivod1.ForeColor = Color.Red;
            }
        }

        // ========== РАЗВЕТВЛЯЮЩИЙСЯ АЛГОРИТМ ==========
        // c = f³(x) + ctg(y),           если xy > 12
        // c = sh(f³(x)) + y²,           если xy < 7
        // c = cos(x - f³(x)),           иначе (7 ≤ xy ≤ 12)

        private void btnCalcBranch_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtXr.Text.Replace('.', ','));
                double y = double.Parse(txtYr.Text.Replace('.', ','));

                // Вычисляем f(x) в зависимости от выбранного RadioButton
                double fx;
                if (cosX.Checked)
                    fx = Math.Cos(x);
                else if (sqrX.Checked)
                    fx = x * x;
                else // expX.Checked
                    fx = Math.Exp(x);

                // f³(x) = (f(x))³
                double fxCubed = fx * fx * fx;

                double xy = x * y;
                double c;
                string condition;

                if (xy > 12)
                {
                    c = fxCubed + Ctg(y);
                    condition = "xy > 12 → c = f³(x) + ctg(y)";
                }
                else if (xy < 7)
                {
                    c = Math.Sinh(fxCubed) + y * y;
                    condition = "xy < 7 → c = sh(f³(x)) + y²";
                }
                else
                {
                    c = Math.Cos(x - fxCubed);
                    condition = "7 ≤ xy ≤ 12 → c = cos(x - f³(x))";
                }

                Vivod2.Text = $"c = {c:F6}\nУсловие: {condition}";
                Vivod2.ForeColor = Color.Black;
            }
            catch (FormatException)
            {
                Vivod2.Text = "Ошибка: введите корректные числа";
                Vivod2.ForeColor = Color.Red;
            }
            catch (DivideByZeroException)
            {
                Vivod2.Text = "Ошибка: ctg(y) не определён (sin(y) = 0)";
                Vivod2.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Vivod2.Text = $"Ошибка: {ex.Message}";
                Vivod2.ForeColor = Color.Red;
            }
        }
        // Вспомогательный метод: котангенс
        private double Ctg(double y)
        {
            double sinY = Math.Sin(y);
            if (Math.Abs(sinY) < 1e-10)
                throw new DivideByZeroException();
            return Math.Cos(y) / sinY;
        }
    }
}