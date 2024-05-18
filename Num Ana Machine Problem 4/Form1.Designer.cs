namespace Num_Ana_Machine_Problem_4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            a_textBox = new TextBox();
            b_textBox = new TextBox();
            label6 = new Label();
            n_textBox = new TextBox();
            predefinedButton = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            predefined_result = new Label();
            deltaPredefined = new Label();
            intergalPredefined = new Label();
            label15 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label17 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label18 = new Label();
            label19 = new Label();
            groupBox1 = new GroupBox();
            UserDefinedButton = new Button();
            EnabledDenom = new RadioButton();
            radioButton1 = new RadioButton();
            integralUserDefined = new Label();
            deltaUserDefined = new Label();
            UserDefinedResult = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 20);
            label1.TabIndex = 0;
            label1.Text = "Part 1: Pre-Defined (Trapezoidal Method)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(342, 9);
            label2.Name = "label2";
            label2.Size = new Size(297, 20);
            label2.TabIndex = 1;
            label2.Text = "Part 2: User Defined (Trapezoidal Method)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 41);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 2;
            label3.Text = "f(x) = x^2 e^sin(x)\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 77);
            label4.Name = "label4";
            label4.Size = new Size(18, 17);
            label4.TabIndex = 3;
            label4.Text = "a:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(51, 106);
            label5.Name = "label5";
            label5.Size = new Size(19, 17);
            label5.TabIndex = 4;
            label5.Text = "b:";
            // 
            // a_textBox
            // 
            a_textBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a_textBox.Location = new Point(76, 74);
            a_textBox.Name = "a_textBox";
            a_textBox.Size = new Size(100, 25);
            a_textBox.TabIndex = 5;
            // 
            // b_textBox
            // 
            b_textBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b_textBox.Location = new Point(76, 103);
            b_textBox.Name = "b_textBox";
            b_textBox.Size = new Size(100, 25);
            b_textBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(51, 137);
            label6.Name = "label6";
            label6.Size = new Size(18, 17);
            label6.TabIndex = 7;
            label6.Text = "n:";
            // 
            // n_textBox
            // 
            n_textBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n_textBox.Location = new Point(76, 132);
            n_textBox.Name = "n_textBox";
            n_textBox.Size = new Size(100, 25);
            n_textBox.TabIndex = 8;
            // 
            // predefinedButton
            // 
            predefinedButton.Location = new Point(88, 174);
            predefinedButton.Name = "predefinedButton";
            predefinedButton.Size = new Size(75, 23);
            predefinedButton.TabIndex = 9;
            predefinedButton.Text = "Calculate";
            predefinedButton.UseVisualStyleBackColor = true;
            predefinedButton.Click += predefinedButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 220);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 10;
            label7.Text = "Result:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 247);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 11;
            label8.Text = "Integral Result:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 276);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 12;
            label9.Text = "Delta (x):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 305);
            label10.Name = "label10";
            label10.Size = new Size(157, 15);
            label10.TabIndex = 13;
            label10.Text = "Result (Trapezoidal Method):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(365, 305);
            label11.Name = "label11";
            label11.Size = new Size(157, 15);
            label11.TabIndex = 18;
            label11.Text = "Result (Trapezoidal Method):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(365, 276);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 17;
            label12.Text = "Delta(x):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(365, 247);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 16;
            label13.Text = "Integral Result:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(342, 220);
            label14.Name = "label14";
            label14.Size = new Size(52, 20);
            label14.TabIndex = 15;
            label14.Text = "Result:";
            // 
            // predefined_result
            // 
            predefined_result.AutoSize = true;
            predefined_result.Location = new Point(215, 305);
            predefined_result.Name = "predefined_result";
            predefined_result.Size = new Size(22, 15);
            predefined_result.TabIndex = 20;
            predefined_result.Text = "---";
            // 
            // deltaPredefined
            // 
            deltaPredefined.AutoSize = true;
            deltaPredefined.Location = new Point(215, 276);
            deltaPredefined.Name = "deltaPredefined";
            deltaPredefined.Size = new Size(22, 15);
            deltaPredefined.TabIndex = 21;
            deltaPredefined.Text = "---";
            // 
            // intergalPredefined
            // 
            intergalPredefined.AutoSize = true;
            intergalPredefined.Location = new Point(215, 247);
            intergalPredefined.Name = "intergalPredefined";
            intergalPredefined.Size = new Size(22, 15);
            intergalPredefined.TabIndex = 22;
            intergalPredefined.Text = "---";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(357, 41);
            label15.Name = "label15";
            label15.Size = new Size(30, 15);
            label15.TabIndex = 23;
            label15.Text = "F(x):";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.5F);
            textBox1.Location = new Point(394, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 24);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.5F);
            textBox2.Location = new Point(6, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(102, 24);
            textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(515, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(490, 149);
            label17.Name = "label17";
            label17.Size = new Size(18, 17);
            label17.TabIndex = 31;
            label17.Text = "n:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(378, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 25);
            textBox4.TabIndex = 30;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(378, 144);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 25);
            textBox5.TabIndex = 29;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(353, 178);
            label18.Name = "label18";
            label18.Size = new Size(19, 17);
            label18.TabIndex = 28;
            label18.Text = "b:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(354, 147);
            label19.Name = "label19";
            label19.Size = new Size(18, 17);
            label19.TabIndex = 27;
            label19.Text = "a:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(EnabledDenom);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(357, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 57);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Denominator";
            // 
            // UserDefinedButton
            // 
            UserDefinedButton.Location = new Point(529, 178);
            UserDefinedButton.Name = "UserDefinedButton";
            UserDefinedButton.Size = new Size(75, 23);
            UserDefinedButton.TabIndex = 34;
            UserDefinedButton.Text = "Calculate";
            UserDefinedButton.UseVisualStyleBackColor = true;
            // 
            // EnabledDenom
            // 
            EnabledDenom.AutoSize = true;
            EnabledDenom.Location = new Point(118, 24);
            EnabledDenom.Name = "EnabledDenom";
            EnabledDenom.Size = new Size(67, 19);
            EnabledDenom.TabIndex = 27;
            EnabledDenom.TabStop = true;
            EnabledDenom.Text = "Enabled";
            EnabledDenom.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(191, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 28;
            radioButton1.TabStop = true;
            radioButton1.Text = "Disabled";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // integralUserDefined
            // 
            integralUserDefined.AutoSize = true;
            integralUserDefined.Location = new Point(548, 247);
            integralUserDefined.Name = "integralUserDefined";
            integralUserDefined.Size = new Size(22, 15);
            integralUserDefined.TabIndex = 37;
            integralUserDefined.Text = "---";
            // 
            // deltaUserDefined
            // 
            deltaUserDefined.AutoSize = true;
            deltaUserDefined.Location = new Point(548, 276);
            deltaUserDefined.Name = "deltaUserDefined";
            deltaUserDefined.Size = new Size(22, 15);
            deltaUserDefined.TabIndex = 36;
            deltaUserDefined.Text = "---";
            // 
            // UserDefinedResult
            // 
            UserDefinedResult.AutoSize = true;
            UserDefinedResult.Location = new Point(548, 305);
            UserDefinedResult.Name = "UserDefinedResult";
            UserDefinedResult.Size = new Size(22, 15);
            UserDefinedResult.TabIndex = 35;
            UserDefinedResult.Text = "---";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 341);
            Controls.Add(integralUserDefined);
            Controls.Add(deltaUserDefined);
            Controls.Add(UserDefinedResult);
            Controls.Add(UserDefinedButton);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Controls.Add(label17);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(textBox1);
            Controls.Add(label15);
            Controls.Add(intergalPredefined);
            Controls.Add(deltaPredefined);
            Controls.Add(predefined_result);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(predefinedButton);
            Controls.Add(n_textBox);
            Controls.Add(label6);
            Controls.Add(b_textBox);
            Controls.Add(a_textBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Numerical Analysis: Machine Problem 4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox a_textBox;
        private TextBox b_textBox;
        private Label label6;
        private TextBox n_textBox;
        private Button predefinedButton;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label predefined_result;
        private Label deltaPredefined;
        private Label intergalPredefined;
        private Label label15;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label17;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label18;
        private Label label19;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton EnabledDenom;
        private Button UserDefinedButton;
        private Label integralUserDefined;
        private Label deltaUserDefined;
        private Label UserDefinedResult;
    }
}
