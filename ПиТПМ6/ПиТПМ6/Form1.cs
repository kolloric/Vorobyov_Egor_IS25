using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ПиТПМ6
{
    public partial class Form1 : Form
    {
        private double firstOperand = 0;
        private string currentOperation = "";
        private bool isNewNumber = true;
        private List<string> history = new List<string>();
        private static readonly CultureInfo InvariantCulture = CultureInfo.InvariantCulture;
        private TextBox display;

        public Form1()
        {
            InitializeComponent();
            AttachAllHandlers();
        }

        public void Form1_Load( object sender, EventArgs e )
        {

        }

        private void AttachAllHandlers()
        {
            // Находим TextBox на форме (первый попавшийся)
            display = FindTextBox();
            if (display == null)
            {
                MessageBox.Show("TextBox не найден на форме!");
                return;
            }

            // Находим все кнопки и привязываем обработчики по тексту
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Click += UniversalButton_Click;
                }
            }
        }

        private TextBox FindTextBox()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox tb)
                    return tb;
            }
            return null;
        }

        // ========== ЕДИНЫЙ ОБРАБОТЧИК ДЛЯ ВСЕХ КНОПОК ==========
        private void UniversalButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string text = btn.Text;

            try
            {
                if (text == "C" || text == "CE" || text == "Очистить")
                {
                    ClearCalculator();
                }
                else if (text == "⌫" || text == "Backspace" || text == "Delete")
                {
                    Backspace();
                }
                else if (text == "История" || text == "History")
                {
                    ShowHistory();
                }
                else if (text == "=")
                {
                    Calculate();
                }
                else if (text == "+" || text == "-" || text == "*" || text == "/")
                {
                    SetOperation(text);
                }
                else if (text == ".")
                {
                    AddDecimalPoint();
                }
                else
                {
                    // Всё остальное — цифры
                    AddNumber(text);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // ========== ЦИФРЫ ==========
        private void AddNumber(string number)
        {
            if (display.ForeColor == Color.Red)
            {
                display.Text = "0";
                display.ForeColor = Color.Black;
            }

            if (isNewNumber)
            {
                display.Text = number;
                isNewNumber = false;
            }
            else
            {
                if (display.Text == "0")
                    display.Text = number;
                else
                    display.Text += number;
            }
        }

        // ========== ТОЧКА ==========
        private void AddDecimalPoint()
        {
            if (display.ForeColor == Color.Red)
            {
                display.Text = "0";
                display.ForeColor = Color.Black;
            }

            if (isNewNumber)
            {
                display.Text = "0.";
                isNewNumber = false;
            }
            else if (!display.Text.Contains("."))
            {
                display.Text += ".";
            }
        }

        // ========== ОПЕРАЦИИ ==========
        private void SetOperation(string operation)
        {
            if (display.ForeColor == Color.Red)
            {
                display.Text = "0";
                display.ForeColor = Color.Black;
            }

            if (!isNewNumber && currentOperation != "")
            {
                try
                {
                    Calculate();
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                    return;
                }
            }

            firstOperand = double.Parse(display.Text, InvariantCulture);
            currentOperation = operation;
            isNewNumber = true;
        }

        // ========== РАВНО ==========
        private void Calculate()
        {
            if (currentOperation == "" || isNewNumber) return;

            double secondOperand = double.Parse(display.Text, InvariantCulture);
            double result = 0;
            string operationSymbol = "";

            switch (currentOperation)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    operationSymbol = "+";
                    break;
                case "-":
                    result = firstOperand - secondOperand;
                    operationSymbol = "-";
                    break;
                case "*":
                    result = firstOperand * secondOperand;
                    operationSymbol = "×";
                    break;
                case "/":
                    if (secondOperand == 0)
                        throw new DivideByZeroException("Деление на ноль!");
                    result = firstOperand / secondOperand;
                    operationSymbol = "÷";
                    break;
            }

            string historyEntry = $"{firstOperand} {operationSymbol} {secondOperand} = {result}";
            history.Add(historyEntry);

            display.Text = result.ToString(InvariantCulture);
            currentOperation = "";
            isNewNumber = true;
        }

        // ========== ОЧИСТКА ==========
        private void ClearCalculator()
        {
            display.Text = "0";
            display.ForeColor = Color.Black;
            firstOperand = 0;
            currentOperation = "";
            isNewNumber = true;
        }

        // ========== BACKSPACE ==========
        private void Backspace()
        {
            if (display.ForeColor == Color.Red)
            {
                display.Text = "0";
                display.ForeColor = Color.Black;
                return;
            }

            if (display.Text.Length > 1)
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            else
                display.Text = "0";
        }

        // ========== ИСТОРИЯ ==========
        private void ShowHistory()
        {
            if (history.Count == 0)
            {
                MessageBox.Show("История пуста", "История",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string historyText = string.Join("\n", history.ToArray());

            Form historyForm = new Form
            {
                Text = "История операций",
                Size = new Size(300, 400),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false
            };

            TextBox txtHistory = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill,
                Text = historyText,
                Font = new Font("Consolas", 10),
                ScrollBars = ScrollBars.Vertical
            };

            Button btnClearHistory = new Button
            {
                Text = "Очистить историю",
                Dock = DockStyle.Bottom,
                Height = 30
            };
            btnClearHistory.Click += (s, ev) => {
                history.Clear();
                historyForm.Close();
            };

            historyForm.Controls.Add(txtHistory);
            historyForm.Controls.Add(btnClearHistory);
            historyForm.ShowDialog();
        }

        // ========== ПОКАЗ ОШИБКИ ==========
        private void ShowError(string message)
        {
            display.Text = "Ошибка";
            display.ForeColor = Color.Red;
            MessageBox.Show(message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            currentOperation = "";
            isNewNumber = true;
        }
    }
}