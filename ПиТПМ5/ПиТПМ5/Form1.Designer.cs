namespace ПиТПМ5
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
            tabControl1 = new TabControl();
            linAlg = new TabPage();
            pictureBox1 = new PictureBox();
            Vivod1 = new TextBox();
            label1 = new Label();
            txtZL = new TextBox();
            label2 = new Label();
            txtYL = new TextBox();
            label3 = new Label();
            txtXL = new TextBox();
            razAlg = new TabPage();
            Vivod2 = new TextBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            expX = new RadioButton();
            sqrX = new RadioButton();
            cosX = new RadioButton();
            txtYr = new TextBox();
            txtXr = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnCalc = new Button();
            button1 = new Button();
            tabControl1.SuspendLayout();
            linAlg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            razAlg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(linAlg);
            tabControl1.Controls.Add(razAlg);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(607, 426);
            tabControl1.TabIndex = 0;
            // 
            // linAlg
            // 
            linAlg.Controls.Add(button1);
            linAlg.Controls.Add(pictureBox1);
            linAlg.Controls.Add(Vivod1);
            linAlg.Controls.Add(label1);
            linAlg.Controls.Add(txtZL);
            linAlg.Controls.Add(label2);
            linAlg.Controls.Add(txtYL);
            linAlg.Controls.Add(label3);
            linAlg.Controls.Add(txtXL);
            linAlg.Location = new Point(4, 24);
            linAlg.Name = "linAlg";
            linAlg.Padding = new Padding(3);
            linAlg.Size = new Size(599, 398);
            linAlg.TabIndex = 0;
            linAlg.Text = "Линейный алгоритм";
            linAlg.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Для_5_ПиТПМ;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 71);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Vivod1
            // 
            Vivod1.Location = new Point(6, 228);
            Vivod1.Multiline = true;
            Vivod1.Name = "Vivod1";
            Vivod1.ReadOnly = true;
            Vivod1.Size = new Size(447, 111);
            Vivod1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 96);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите значение X";
            // 
            // txtZL
            // 
            txtZL.Location = new Point(151, 171);
            txtZL.Name = "txtZL";
            txtZL.Size = new Size(100, 23);
            txtZL.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 135);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 2;
            label2.Text = "Введите значение Y";
            // 
            // txtYL
            // 
            txtYL.Location = new Point(151, 132);
            txtYL.Name = "txtYL";
            txtYL.Size = new Size(100, 23);
            txtYL.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 171);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 3;
            label3.Text = "Введите значение Z";
            // 
            // txtXL
            // 
            txtXL.Location = new Point(151, 93);
            txtXL.Name = "txtXL";
            txtXL.Size = new Size(100, 23);
            txtXL.TabIndex = 4;
            // 
            // razAlg
            // 
            razAlg.Controls.Add(btnCalc);
            razAlg.Controls.Add(Vivod2);
            razAlg.Controls.Add(pictureBox2);
            razAlg.Controls.Add(groupBox1);
            razAlg.Controls.Add(txtYr);
            razAlg.Controls.Add(txtXr);
            razAlg.Controls.Add(label5);
            razAlg.Controls.Add(label4);
            razAlg.Location = new Point(4, 24);
            razAlg.Name = "razAlg";
            razAlg.Padding = new Padding(3);
            razAlg.Size = new Size(599, 398);
            razAlg.TabIndex = 1;
            razAlg.Text = "Разветлвляющийся алгоритм";
            razAlg.UseVisualStyleBackColor = true;
            // 
            // Vivod2
            // 
            Vivod2.Location = new Point(15, 218);
            Vivod2.Multiline = true;
            Vivod2.Name = "Vivod2";
            Vivod2.ReadOnly = true;
            Vivod2.Size = new Size(392, 97);
            Vivod2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Для_5_ПиТПМ_2;
            pictureBox2.Location = new Point(24, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(233, 84);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(expX);
            groupBox1.Controls.Add(sqrX);
            groupBox1.Controls.Add(cosX);
            groupBox1.Location = new Point(231, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 99);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбор функции";
            // 
            // expX
            // 
            expX.AutoSize = true;
            expX.Location = new Point(6, 72);
            expX.Name = "expX";
            expX.Size = new Size(58, 19);
            expX.TabIndex = 2;
            expX.TabStop = true;
            expX.Text = "exp(x)";
            expX.UseVisualStyleBackColor = true;
            // 
            // sqrX
            // 
            sqrX.AutoSize = true;
            sqrX.Location = new Point(6, 47);
            sqrX.Name = "sqrX";
            sqrX.Size = new Size(55, 19);
            sqrX.TabIndex = 1;
            sqrX.TabStop = true;
            sqrX.Text = "sqr(x)";
            sqrX.UseVisualStyleBackColor = true;
            // 
            // cosX
            // 
            cosX.AutoSize = true;
            cosX.Location = new Point(6, 22);
            cosX.Name = "cosX";
            cosX.Size = new Size(57, 19);
            cosX.TabIndex = 0;
            cosX.TabStop = true;
            cosX.Text = "cos(x)";
            cosX.UseVisualStyleBackColor = true;
            // 
            // txtYr
            // 
            txtYr.Location = new Point(59, 163);
            txtYr.Name = "txtYr";
            txtYr.Size = new Size(100, 23);
            txtYr.TabIndex = 3;
            // 
            // txtXr
            // 
            txtXr.Location = new Point(59, 113);
            txtXr.Name = "txtXr";
            txtXr.Size = new Size(100, 23);
            txtXr.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 166);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 1;
            label5.Text = "Y = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 116);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 0;
            label4.Text = "X = ";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(436, 319);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(106, 50);
            btnCalc.TabIndex = 1;
            btnCalc.Text = "Рассчитать";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalcBranch_Click;
            // 
            // button1
            // 
            button1.Location = new Point(461, 318);
            button1.Name = "button1";
            button1.Size = new Size(106, 50);
            button1.TabIndex = 7;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalcLinear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            linAlg.ResumeLayout(false);
            linAlg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            razAlg.ResumeLayout(false);
            razAlg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage linAlg;
        private TabPage razAlg;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtXL;
        private TextBox txtYL;
        private TextBox txtZL;
        private TextBox Vivod1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton expX;
        private RadioButton sqrX;
        private RadioButton cosX;
        private TextBox txtYr;
        private TextBox txtXr;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private TextBox Vivod2;
        private Button btnCalc;
        private Button button1;
    }
}
