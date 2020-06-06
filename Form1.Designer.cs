namespace GeomCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.GroupBox();
            this.coordinatesY = new System.Windows.Forms.TextBox();
            this.coordinatesX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.baseBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataBox.SuspendLayout();
            this.resultBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(16, 415);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(140, 39);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(281, 415);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 39);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Очистить форму";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберете фигуру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Длина основания фигуры";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Высота фигуры";
            // 
            // dataBox
            // 
            this.dataBox.Controls.Add(this.coordinatesY);
            this.dataBox.Controls.Add(this.coordinatesX);
            this.dataBox.Controls.Add(this.label6);
            this.dataBox.Controls.Add(this.label5);
            this.dataBox.Controls.Add(this.label4);
            this.dataBox.Controls.Add(this.heightBox);
            this.dataBox.Controls.Add(this.baseBox);
            this.dataBox.Controls.Add(this.label2);
            this.dataBox.Controls.Add(this.label3);
            this.dataBox.Location = new System.Drawing.Point(18, 53);
            this.dataBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataBox.Name = "dataBox";
            this.dataBox.Padding = new System.Windows.Forms.Padding(4);
            this.dataBox.Size = new System.Drawing.Size(403, 186);
            this.dataBox.TabIndex = 6;
            this.dataBox.TabStop = false;
            this.dataBox.Text = "Введите данные";
            // 
            // coordinatesY
            // 
            this.coordinatesY.Location = new System.Drawing.Point(296, 157);
            this.coordinatesY.Name = "coordinatesY";
            this.coordinatesY.Size = new System.Drawing.Size(100, 22);
            this.coordinatesY.TabIndex = 11;
            this.coordinatesY.TextChanged += new System.EventHandler(this.coordinatesY_TextChanged);
            this.coordinatesY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coordinatesY_KeyPress);
            // 
            // coordinatesX
            // 
            this.coordinatesX.Location = new System.Drawing.Point(7, 157);
            this.coordinatesX.Name = "coordinatesX";
            this.coordinatesX.Size = new System.Drawing.Size(100, 22);
            this.coordinatesX.TabIndex = 10;
            this.coordinatesX.TextChanged += new System.EventHandler(this.coordinatesX_TextChanged);
            this.coordinatesX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coordinatesX_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Координаты центра";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(225, 73);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(171, 22);
            this.heightBox.TabIndex = 6;
            this.heightBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.heightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // baseBox
            // 
            this.baseBox.Location = new System.Drawing.Point(225, 36);
            this.baseBox.Name = "baseBox";
            this.baseBox.Size = new System.Drawing.Size(171, 22);
            this.baseBox.TabIndex = 5;
            this.baseBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.baseBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // resultBox
            // 
            this.resultBox.Controls.Add(this.textBox6);
            this.resultBox.Controls.Add(this.textBox5);
            this.resultBox.Controls.Add(this.label10);
            this.resultBox.Controls.Add(this.label9);
            this.resultBox.Controls.Add(this.label8);
            this.resultBox.Controls.Add(this.label7);
            this.resultBox.Controls.Add(this.textBox4);
            this.resultBox.Controls.Add(this.textBox3);
            this.resultBox.Location = new System.Drawing.Point(9, 246);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(405, 142);
            this.resultBox.TabIndex = 7;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Результаты";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(228, 105);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(171, 22);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(228, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(171, 22);
            this.textBox5.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Радиус (для круга)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Координаты центра";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Площадь";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Периметр";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(228, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(171, 22);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(228, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(171, 22);
            this.textBox3.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Круг",
            "Треугольник",
            "Четырехугольник"});
            this.comboBox1.Location = new System.Drawing.Point(243, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 458);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.dataBox.ResumeLayout(false);
            this.dataBox.PerformLayout();
            this.resultBox.ResumeLayout(false);
            this.resultBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox dataBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox baseBox;
        private System.Windows.Forms.TextBox coordinatesY;
        private System.Windows.Forms.TextBox coordinatesX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

