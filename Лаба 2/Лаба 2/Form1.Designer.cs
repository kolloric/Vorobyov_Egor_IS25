namespace Лаба_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBlue = new Button();
            btnYellow = new Button();
            btnRed = new Button();
            btnGreen = new Button();
            Goodbye = new Button();
            Hello = new Button();
            ForEx2 = new Label();
            Ex1 = new GroupBox();
            Ex2 = new GroupBox();
            Ex3 = new GroupBox();
            textBox3Ex3 = new TextBox();
            textBox2Ex3 = new TextBox();
            textBox1Ex3 = new TextBox();
            lblEx3 = new Label();
            btn3Ex3 = new Button();
            btn2Ex3 = new Button();
            btn1Ex3 = new Button();
            Ex4 = new GroupBox();
            textBox1Ex4 = new TextBox();
            btn3Ex4 = new Button();
            btn2Ex4 = new Button();
            btn1Ex4 = new Button();
            Ex5 = new GroupBox();
            lbl4Ex5 = new Label();
            lbl3Ex5 = new Label();
            lbl2Ex5 = new Label();
            lbl1Ex5 = new Label();
            btn3Ex5 = new Button();
            btn2Ex5 = new Button();
            btn1Ex5 = new Button();
            Ex6 = new GroupBox();
            lbl2Ex6 = new Label();
            lbl1Ex6 = new Label();
            lbl3Ex6 = new Label();
            btn3Ex6 = new Button();
            btn2Ex6 = new Button();
            btn1Ex6 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Ex7 = new GroupBox();
            textBox3Ex7 = new TextBox();
            textBox2Ex7 = new TextBox();
            textBox1Ex7 = new TextBox();
            btn3Ex7 = new Button();
            btn2Ex7 = new Button();
            btn1Ex7 = new Button();
            Ex8 = new GroupBox();
            Ex9 = new GroupBox();
            btn1Ex8 = new Button();
            btn2Ex8 = new Button();
            label1 = new Label();
            Ex1.SuspendLayout();
            Ex2.SuspendLayout();
            Ex3.SuspendLayout();
            Ex4.SuspendLayout();
            Ex5.SuspendLayout();
            Ex6.SuspendLayout();
            Ex7.SuspendLayout();
            Ex8.SuspendLayout();
            SuspendLayout();
            // 
            // btnBlue
            // 
            btnBlue.Location = new Point(92, 51);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(75, 23);
            btnBlue.TabIndex = 0;
            btnBlue.Text = "сини";
            btnBlue.UseVisualStyleBackColor = true;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnYellow
            // 
            btnYellow.Location = new Point(92, 22);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(75, 23);
            btnYellow.TabIndex = 1;
            btnYellow.Text = "Жёлти";
            btnYellow.UseVisualStyleBackColor = true;
            btnYellow.Click += btnYellow_Click;
            // 
            // btnRed
            // 
            btnRed.Location = new Point(11, 51);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(75, 23);
            btnRed.TabIndex = 2;
            btnRed.Text = "красни";
            btnRed.UseVisualStyleBackColor = true;
            btnRed.Click += btnRed_Click;
            // 
            // btnGreen
            // 
            btnGreen.Location = new Point(11, 22);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(75, 23);
            btnGreen.TabIndex = 0;
            btnGreen.Text = "Зелёни";
            btnGreen.UseVisualStyleBackColor = true;
            btnGreen.Click += btnGreen_Click;
            // 
            // Goodbye
            // 
            Goodbye.Location = new Point(6, 51);
            Goodbye.Name = "Goodbye";
            Goodbye.Size = new Size(84, 23);
            Goodbye.TabIndex = 3;
            Goodbye.Text = "До свидания";
            Goodbye.UseVisualStyleBackColor = true;
            Goodbye.Click += Goodbye_Click;
            // 
            // Hello
            // 
            Hello.Location = new Point(6, 22);
            Hello.Name = "Hello";
            Hello.Size = new Size(84, 23);
            Hello.TabIndex = 4;
            Hello.Text = "Привет";
            Hello.UseVisualStyleBackColor = true;
            Hello.Click += Hello_Click;
            // 
            // ForEx2
            // 
            ForEx2.AutoSize = true;
            ForEx2.Location = new Point(96, 22);
            ForEx2.Name = "ForEx2";
            ForEx2.Size = new Size(38, 15);
            ForEx2.TabIndex = 5;
            ForEx2.Text = "label1";
            ForEx2.Click += Message_Click;
            // 
            // Ex1
            // 
            Ex1.Controls.Add(btnYellow);
            Ex1.Controls.Add(btnBlue);
            Ex1.Controls.Add(btnRed);
            Ex1.Controls.Add(btnGreen);
            Ex1.Location = new Point(12, 12);
            Ex1.Name = "Ex1";
            Ex1.Size = new Size(186, 84);
            Ex1.TabIndex = 6;
            Ex1.TabStop = false;
            Ex1.Text = "Задача 1";
            Ex1.Enter += groupBox1_Enter;
            // 
            // Ex2
            // 
            Ex2.Controls.Add(Hello);
            Ex2.Controls.Add(Goodbye);
            Ex2.Controls.Add(ForEx2);
            Ex2.Location = new Point(204, 12);
            Ex2.Name = "Ex2";
            Ex2.Size = new Size(185, 84);
            Ex2.TabIndex = 7;
            Ex2.TabStop = false;
            Ex2.Text = "Задача 2";
            // 
            // Ex3
            // 
            Ex3.Controls.Add(textBox3Ex3);
            Ex3.Controls.Add(textBox2Ex3);
            Ex3.Controls.Add(textBox1Ex3);
            Ex3.Controls.Add(lblEx3);
            Ex3.Controls.Add(btn3Ex3);
            Ex3.Controls.Add(btn2Ex3);
            Ex3.Controls.Add(btn1Ex3);
            Ex3.Location = new Point(395, 12);
            Ex3.Name = "Ex3";
            Ex3.Size = new Size(200, 158);
            Ex3.TabIndex = 8;
            Ex3.TabStop = false;
            Ex3.Text = "Задача 3";
            // 
            // textBox3Ex3
            // 
            textBox3Ex3.Location = new Point(87, 105);
            textBox3Ex3.Name = "textBox3Ex3";
            textBox3Ex3.Size = new Size(100, 23);
            textBox3Ex3.TabIndex = 6;
            // 
            // textBox2Ex3
            // 
            textBox2Ex3.Location = new Point(87, 61);
            textBox2Ex3.Name = "textBox2Ex3";
            textBox2Ex3.Size = new Size(100, 23);
            textBox2Ex3.TabIndex = 5;
            // 
            // textBox1Ex3
            // 
            textBox1Ex3.Location = new Point(87, 18);
            textBox1Ex3.Name = "textBox1Ex3";
            textBox1Ex3.Size = new Size(100, 23);
            textBox1Ex3.TabIndex = 4;
            textBox1Ex3.TextChanged += textBox1Ex3_TextChanged;
            // 
            // lblEx3
            // 
            lblEx3.AutoSize = true;
            lblEx3.Location = new Point(43, 131);
            lblEx3.Name = "lblEx3";
            lblEx3.Size = new Size(38, 15);
            lblEx3.TabIndex = 3;
            lblEx3.Text = "label1";
            lblEx3.Click += ForEx3_Click;
            // 
            // btn3Ex3
            // 
            btn3Ex3.Location = new Point(6, 105);
            btn3Ex3.Name = "btn3Ex3";
            btn3Ex3.Size = new Size(75, 23);
            btn3Ex3.TabIndex = 2;
            btn3Ex3.Text = "фантазии";
            btn3Ex3.UseVisualStyleBackColor = true;
            btn3Ex3.Click += btn3Ex3_Click;
            // 
            // btn2Ex3
            // 
            btn2Ex3.Location = new Point(6, 61);
            btn2Ex3.Name = "btn2Ex3";
            btn2Ex3.Size = new Size(75, 23);
            btn2Ex3.TabIndex = 1;
            btn2Ex3.Text = "у меня нет";
            btn2Ex3.UseVisualStyleBackColor = true;
            btn2Ex3.Click += btn2Ex3_Click;
            // 
            // btn1Ex3
            // 
            btn1Ex3.Location = new Point(6, 18);
            btn1Ex3.Name = "btn1Ex3";
            btn1Ex3.Size = new Size(75, 23);
            btn1Ex3.TabIndex = 0;
            btn1Ex3.Text = "бубубу";
            btn1Ex3.UseVisualStyleBackColor = true;
            btn1Ex3.Click += button1_Click;
            // 
            // Ex4
            // 
            Ex4.Controls.Add(textBox1Ex4);
            Ex4.Controls.Add(btn3Ex4);
            Ex4.Controls.Add(btn2Ex4);
            Ex4.Controls.Add(btn1Ex4);
            Ex4.Location = new Point(601, 12);
            Ex4.Name = "Ex4";
            Ex4.Size = new Size(250, 158);
            Ex4.TabIndex = 9;
            Ex4.TabStop = false;
            Ex4.Text = "Задача 4";
            // 
            // textBox1Ex4
            // 
            textBox1Ex4.Location = new Point(100, 62);
            textBox1Ex4.Name = "textBox1Ex4";
            textBox1Ex4.Size = new Size(100, 23);
            textBox1Ex4.TabIndex = 3;
            // 
            // btn3Ex4
            // 
            btn3Ex4.Location = new Point(6, 105);
            btn3Ex4.Name = "btn3Ex4";
            btn3Ex4.Size = new Size(75, 23);
            btn3Ex4.TabIndex = 2;
            btn3Ex4.Text = "button3";
            btn3Ex4.UseVisualStyleBackColor = true;
            btn3Ex4.Click += btn3Ex4_Click;
            // 
            // btn2Ex4
            // 
            btn2Ex4.Location = new Point(6, 61);
            btn2Ex4.Name = "btn2Ex4";
            btn2Ex4.Size = new Size(75, 23);
            btn2Ex4.TabIndex = 1;
            btn2Ex4.Text = "button2";
            btn2Ex4.UseVisualStyleBackColor = true;
            btn2Ex4.Click += btn2Ex4_Click;
            // 
            // btn1Ex4
            // 
            btn1Ex4.Location = new Point(6, 18);
            btn1Ex4.Name = "btn1Ex4";
            btn1Ex4.Size = new Size(75, 23);
            btn1Ex4.TabIndex = 0;
            btn1Ex4.Text = "button1";
            btn1Ex4.UseVisualStyleBackColor = true;
            btn1Ex4.Click += btn1Ex4_Click;
            // 
            // Ex5
            // 
            Ex5.Controls.Add(lbl4Ex5);
            Ex5.Controls.Add(lbl3Ex5);
            Ex5.Controls.Add(lbl2Ex5);
            Ex5.Controls.Add(lbl1Ex5);
            Ex5.Controls.Add(btn3Ex5);
            Ex5.Controls.Add(btn2Ex5);
            Ex5.Controls.Add(btn1Ex5);
            Ex5.Location = new Point(857, 12);
            Ex5.Name = "Ex5";
            Ex5.Size = new Size(294, 158);
            Ex5.TabIndex = 10;
            Ex5.TabStop = false;
            Ex5.Text = "Задача 5";
            // 
            // lbl4Ex5
            // 
            lbl4Ex5.BackColor = Color.Blue;
            lbl4Ex5.Location = new Point(194, 62);
            lbl4Ex5.Name = "lbl4Ex5";
            lbl4Ex5.Size = new Size(94, 23);
            lbl4Ex5.TabIndex = 6;
            lbl4Ex5.Text = "label4";
            lbl4Ex5.Click += lbl4Ex5_Click;
            // 
            // lbl3Ex5
            // 
            lbl3Ex5.BackColor = Color.Green;
            lbl3Ex5.Location = new Point(87, 105);
            lbl3Ex5.Name = "lbl3Ex5";
            lbl3Ex5.Size = new Size(100, 23);
            lbl3Ex5.TabIndex = 5;
            lbl3Ex5.Text = "label3";
            // 
            // lbl2Ex5
            // 
            lbl2Ex5.BackColor = Color.Yellow;
            lbl2Ex5.Location = new Point(87, 61);
            lbl2Ex5.Name = "lbl2Ex5";
            lbl2Ex5.Size = new Size(100, 23);
            lbl2Ex5.TabIndex = 4;
            lbl2Ex5.Text = "label2";
            // 
            // lbl1Ex5
            // 
            lbl1Ex5.BackColor = Color.Red;
            lbl1Ex5.Location = new Point(87, 18);
            lbl1Ex5.Name = "lbl1Ex5";
            lbl1Ex5.Size = new Size(100, 23);
            lbl1Ex5.TabIndex = 3;
            lbl1Ex5.Text = "label1";
            // 
            // btn3Ex5
            // 
            btn3Ex5.Location = new Point(6, 105);
            btn3Ex5.Name = "btn3Ex5";
            btn3Ex5.Size = new Size(75, 23);
            btn3Ex5.TabIndex = 2;
            btn3Ex5.Text = "button3";
            btn3Ex5.UseVisualStyleBackColor = true;
            btn3Ex5.Click += btn3Ex5_Click;
            // 
            // btn2Ex5
            // 
            btn2Ex5.Location = new Point(6, 61);
            btn2Ex5.Name = "btn2Ex5";
            btn2Ex5.Size = new Size(75, 23);
            btn2Ex5.TabIndex = 1;
            btn2Ex5.Text = "button2";
            btn2Ex5.UseVisualStyleBackColor = true;
            btn2Ex5.Click += btn2Ex5_Click;
            // 
            // btn1Ex5
            // 
            btn1Ex5.Location = new Point(6, 18);
            btn1Ex5.Name = "btn1Ex5";
            btn1Ex5.Size = new Size(75, 23);
            btn1Ex5.TabIndex = 0;
            btn1Ex5.Text = "button1";
            btn1Ex5.UseVisualStyleBackColor = true;
            btn1Ex5.Click += btn1Ex5_Click;
            // 
            // Ex6
            // 
            Ex6.Controls.Add(lbl2Ex6);
            Ex6.Controls.Add(lbl1Ex6);
            Ex6.Controls.Add(lbl3Ex6);
            Ex6.Controls.Add(btn3Ex6);
            Ex6.Controls.Add(btn2Ex6);
            Ex6.Controls.Add(btn1Ex6);
            Ex6.Location = new Point(23, 213);
            Ex6.Name = "Ex6";
            Ex6.Size = new Size(284, 110);
            Ex6.TabIndex = 11;
            Ex6.TabStop = false;
            Ex6.Text = "Задача 6";
            // 
            // lbl2Ex6
            // 
            lbl2Ex6.AutoSize = true;
            lbl2Ex6.Location = new Point(118, 55);
            lbl2Ex6.Name = "lbl2Ex6";
            lbl2Ex6.Size = new Size(38, 15);
            lbl2Ex6.TabIndex = 4;
            lbl2Ex6.Text = "label2";
            // 
            // lbl1Ex6
            // 
            lbl1Ex6.AutoSize = true;
            lbl1Ex6.Location = new Point(118, 22);
            lbl1Ex6.Name = "lbl1Ex6";
            lbl1Ex6.Size = new Size(38, 15);
            lbl1Ex6.TabIndex = 3;
            lbl1Ex6.Text = "label1";
            // 
            // lbl3Ex6
            // 
            lbl3Ex6.AutoSize = true;
            lbl3Ex6.Location = new Point(118, 84);
            lbl3Ex6.Name = "lbl3Ex6";
            lbl3Ex6.Size = new Size(38, 15);
            lbl3Ex6.TabIndex = 5;
            lbl3Ex6.Text = "label3";
            // 
            // btn3Ex6
            // 
            btn3Ex6.Location = new Point(6, 80);
            btn3Ex6.Name = "btn3Ex6";
            btn3Ex6.Size = new Size(75, 23);
            btn3Ex6.TabIndex = 2;
            btn3Ex6.Text = "button3";
            btn3Ex6.UseVisualStyleBackColor = true;
            btn3Ex6.Click += btn3Ex6_Click;
            // 
            // btn2Ex6
            // 
            btn2Ex6.Location = new Point(6, 51);
            btn2Ex6.Name = "btn2Ex6";
            btn2Ex6.Size = new Size(75, 23);
            btn2Ex6.TabIndex = 1;
            btn2Ex6.Text = "button2";
            btn2Ex6.UseVisualStyleBackColor = true;
            btn2Ex6.Click += btn2Ex6_Click;
            // 
            // btn1Ex6
            // 
            btn1Ex6.Location = new Point(6, 22);
            btn1Ex6.Name = "btn1Ex6";
            btn1Ex6.Size = new Size(75, 23);
            btn1Ex6.TabIndex = 0;
            btn1Ex6.Text = "button1";
            btn1Ex6.UseVisualStyleBackColor = true;
            btn1Ex6.Click += btn1Ex6_Click;
            // 
            // Ex7
            // 
            Ex7.Controls.Add(textBox3Ex7);
            Ex7.Controls.Add(textBox2Ex7);
            Ex7.Controls.Add(textBox1Ex7);
            Ex7.Controls.Add(btn3Ex7);
            Ex7.Controls.Add(btn2Ex7);
            Ex7.Controls.Add(btn1Ex7);
            Ex7.Location = new Point(329, 212);
            Ex7.Name = "Ex7";
            Ex7.Size = new Size(288, 111);
            Ex7.TabIndex = 12;
            Ex7.TabStop = false;
            Ex7.Text = "Задача 7";
            // 
            // textBox3Ex7
            // 
            textBox3Ex7.Location = new Point(97, 78);
            textBox3Ex7.Name = "textBox3Ex7";
            textBox3Ex7.Size = new Size(100, 23);
            textBox3Ex7.TabIndex = 5;
            // 
            // textBox2Ex7
            // 
            textBox2Ex7.Location = new Point(97, 48);
            textBox2Ex7.Name = "textBox2Ex7";
            textBox2Ex7.Size = new Size(100, 23);
            textBox2Ex7.TabIndex = 4;
            // 
            // textBox1Ex7
            // 
            textBox1Ex7.Location = new Point(97, 19);
            textBox1Ex7.Name = "textBox1Ex7";
            textBox1Ex7.Size = new Size(100, 23);
            textBox1Ex7.TabIndex = 3;
            // 
            // btn3Ex7
            // 
            btn3Ex7.Location = new Point(6, 77);
            btn3Ex7.Name = "btn3Ex7";
            btn3Ex7.Size = new Size(75, 23);
            btn3Ex7.TabIndex = 2;
            btn3Ex7.Text = "button3";
            btn3Ex7.UseVisualStyleBackColor = true;
            btn3Ex7.Click += knopkaEx7;
            // 
            // btn2Ex7
            // 
            btn2Ex7.Location = new Point(6, 48);
            btn2Ex7.Name = "btn2Ex7";
            btn2Ex7.Size = new Size(75, 23);
            btn2Ex7.TabIndex = 1;
            btn2Ex7.Text = "button2";
            btn2Ex7.UseVisualStyleBackColor = true;
            btn2Ex7.Click += knopkaEx7;
            // 
            // btn1Ex7
            // 
            btn1Ex7.Location = new Point(6, 19);
            btn1Ex7.Name = "btn1Ex7";
            btn1Ex7.Size = new Size(75, 23);
            btn1Ex7.TabIndex = 0;
            btn1Ex7.Text = "button1";
            btn1Ex7.UseVisualStyleBackColor = true;
            btn1Ex7.Click += knopkaEx7;
            // 
            // Ex8
            // 
            Ex8.Controls.Add(label1);
            Ex8.Controls.Add(btn2Ex8);
            Ex8.Controls.Add(btn1Ex8);
            Ex8.Location = new Point(651, 213);
            Ex8.Name = "Ex8";
            Ex8.Size = new Size(269, 206);
            Ex8.TabIndex = 13;
            Ex8.TabStop = false;
            Ex8.Text = "Задача 8";
            // 
            // Ex9
            // 
            Ex9.Location = new Point(951, 223);
            Ex9.Name = "Ex9";
            Ex9.Size = new Size(200, 100);
            Ex9.TabIndex = 14;
            Ex9.TabStop = false;
            Ex9.Text = "Задача 9";
            // 
            // btn1Ex8
            // 
            btn1Ex8.Location = new Point(3, 19);
            btn1Ex8.Name = "btn1Ex8";
            btn1Ex8.Size = new Size(75, 23);
            btn1Ex8.TabIndex = 0;
            btn1Ex8.Text = "button1";
            btn1Ex8.UseVisualStyleBackColor = true;
            // 
            // btn2Ex8
            // 
            btn2Ex8.Location = new Point(95, 18);
            btn2Ex8.Name = "btn2Ex8";
            btn2Ex8.Size = new Size(75, 23);
            btn2Ex8.TabIndex = 1;
            btn2Ex8.Text = "button2";
            btn2Ex8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 55);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 667);
            Controls.Add(Ex9);
            Controls.Add(Ex8);
            Controls.Add(Ex7);
            Controls.Add(Ex6);
            Controls.Add(Ex5);
            Controls.Add(Ex4);
            Controls.Add(Ex3);
            Controls.Add(Ex2);
            Controls.Add(Ex1);
            Name = "Form1";
            Text = "Лаба 2 (по 01.01)";
            Load += Form1_Load;
            Ex1.ResumeLayout(false);
            Ex2.ResumeLayout(false);
            Ex2.PerformLayout();
            Ex3.ResumeLayout(false);
            Ex3.PerformLayout();
            Ex4.ResumeLayout(false);
            Ex4.PerformLayout();
            Ex5.ResumeLayout(false);
            Ex6.ResumeLayout(false);
            Ex6.PerformLayout();
            Ex7.ResumeLayout(false);
            Ex7.PerformLayout();
            Ex8.ResumeLayout(false);
            Ex8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBlue;
        private Button btnYellow;
        private Button btnRed;
        private Button btnGreen;
        private Button Goodbye;
        private Button Hello;
        private Label ForEx2;
        private GroupBox Ex1;
        private GroupBox Ex2;
        private GroupBox Ex3;
        private Label lblEx3;
        private Button btn3Ex3;
        private Button btn2Ex3;
        private Button btn1Ex3;
        private TextBox textBox3Ex3;
        private TextBox textBox2Ex3;
        private TextBox textBox1Ex3;
        private GroupBox Ex4;
        private TextBox textBox1Ex4;
        private Button btn3Ex4;
        private Button btn2Ex4;
        private Button btn1Ex4;
        private GroupBox Ex5;
        private Label lbl3Ex5;
        private Label lbl2Ex5;
        private Label lbl1Ex5;
        private Button btn3Ex5;
        private Button btn2Ex5;
        private Button btn1Ex5;
        private GroupBox Ex6;
        private Label lbl4Ex5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox Ex7;
        private Label lbl2Ex6;
        private Label lbl1Ex6;
        private Label lbl3Ex6;
        private Button btn3Ex6;
        private Button btn2Ex6;
        private Button btn1Ex6;
        private GroupBox Ex8;
        private TextBox textBox3Ex7;
        private TextBox textBox2Ex7;
        private TextBox textBox1Ex7;
        private Button btn3Ex7;
        private Button btn2Ex7;
        private Button btn1Ex7;
        private Label label1;
        private Button btn2Ex8;
        private Button btn1Ex8;
        private GroupBox Ex9;
    }
}
