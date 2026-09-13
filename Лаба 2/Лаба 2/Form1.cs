using System;

namespace Лаба_2
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random();
        private List<Label> lblsEx5 = new List<Label>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // строки для 1 задачи:
            this.BackColor = Color.Gray;
            ForEx2.Text = "Начало работы";
            // строки для 5 задачи:
            lblsEx5.Add(lbl1Ex5);
            lblsEx5.Add(lbl2Ex5);
            lblsEx5.Add(lbl3Ex5);
            lblsEx5.Add(lbl4Ex5);
            // строки для 6 задачи:
            lbl1Ex6.Visible = false;
            lbl2Ex6.Visible = false;
            lbl3Ex6.Visible = false;
            // строки для 7 задачи:
            btn1Ex7.Tag = textBox1Ex7;
            btn2Ex7.Tag = textBox2Ex7;
            btn3Ex7.Tag = textBox3Ex7;
        }
        private void ChangeTwoRandomLabels(Color targetColor) // Если хотим, чтобы окраска была в рандомные цвета, то убираем отсюда слова в скобках
        {
            if (lblsEx5.Count < 2)
            {
                MessageBox.Show("На форме должно быть минимум 2 метки (Label)!");
                return;
            }
            int index1 = _random.Next(lblsEx5.Count);
            int index2;
            do
            {
                index2 = _random.Next(lblsEx5.Count);
            } while (index1 == index2);
            /*     Color randomColor = Color.FromArgb(
            _random.Next(256),                                                                //  а вот эти строки раскомментировать
            _random.Next(256),
            _random.Next(256)
        ); */
            lblsEx5[index1].BackColor = targetColor;                            // а потом вот тут и на самих кнопках сменить слово targetcolor на randoncolor
            lblsEx5[index2].BackColor = targetColor;
        }
        private void knopkaEx7(object sender, EventArgs e)
        {
            Button knopka = sender as Button;

            if (knopka != null && knopka.Tag is TextBox targetBox)
            {
                this.Text = targetBox.Text;
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Hello_Click(object sender, EventArgs e)
        {
            ForEx2.Text = Hello.Text;
        }

        private void Goodbye_Click(object sender, EventArgs e)
        {
            ForEx2.Text = Goodbye.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Message_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblEx3.Text = textBox1Ex3.Text;
        }

        private void btn2Ex3_Click(object sender, EventArgs e)
        {
            lblEx3.Text = textBox2Ex3.Text;
        }

        private void btn3Ex3_Click(object sender, EventArgs e)
        {
            lblEx3.Text = textBox3Ex3.Text;
        }

        private void textBox1Ex3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForEx3_Click(object sender, EventArgs e)
        {

        }

        private void btn1Ex4_Click(object sender, EventArgs e)
        {
            btn1Ex4.Text = textBox1Ex4.Text;
        }

        private void btn2Ex4_Click(object sender, EventArgs e)
        {
            btn2Ex4.Text = textBox1Ex4.Text;
        }

        private void btn3Ex4_Click(object sender, EventArgs e)
        {
            btn3Ex4.Text = textBox1Ex4.Text;
        }

        private void lbl4Ex5_Click(object sender, EventArgs e)
        {

        }

        private void btn1Ex5_Click(object sender, EventArgs e)
        {
            ChangeTwoRandomLabels(Color.Red);
        }

        private void btn2Ex5_Click(object sender, EventArgs e)
        {
            ChangeTwoRandomLabels(Color.Green);
        }

        private void btn3Ex5_Click(object sender, EventArgs e)
        {
            ChangeTwoRandomLabels(Color.Blue);
        }

        private void btn1Ex6_Click(object sender, EventArgs e)
        {
            lbl1Ex6.Visible = !lbl1Ex6.Visible;
        }

        private void btn2Ex6_Click(object sender, EventArgs e)
        {
            lbl2Ex6.Visible = !lbl2Ex6.Visible;
        }

        private void btn3Ex6_Click(object sender, EventArgs e)
        {
            lbl3Ex6.Visible = !lbl3Ex6.Visible;
        }

        private void btn1Ex7_Click(object sender, EventArgs e)
        {
        //    this.Text = textBox1Ex7.Text;
        }

        private void btn2Ex7_Click(object sender, EventArgs e)
        {
            //   this.Text = textBox2Ex7.Text;
        }

        private void btn3Ex7_Click(object sender, EventArgs e)
        {
       //     this.Text = textBox3Ex7.Text;
        }
    }
}
