namespace CALCULADORA
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
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button14 = new Button();
            button19 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(52, 71);
            textBox1.Margin = new Padding(3, 3, 3, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 43);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(141, 24);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "CASIO";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(246, 367);
            button1.Name = "button1";
            button1.Size = new Size(48, 23);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(246, 215);
            button2.Name = "button2";
            button2.Size = new Size(48, 23);
            button2.TabIndex = 6;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(246, 316);
            button3.Name = "button3";
            button3.Size = new Size(48, 23);
            button3.TabIndex = 7;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(246, 262);
            button4.Name = "button4";
            button4.Size = new Size(48, 23);
            button4.TabIndex = 8;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(165, 262);
            button5.Name = "button5";
            button5.Size = new Size(62, 23);
            button5.TabIndex = 9;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(165, 214);
            button6.Name = "button6";
            button6.Size = new Size(62, 23);
            button6.TabIndex = 10;
            button6.Text = "1";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(83, 262);
            button7.Name = "button7";
            button7.Size = new Size(61, 23);
            button7.TabIndex = 11;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(83, 316);
            button8.Name = "button8";
            button8.Size = new Size(61, 23);
            button8.TabIndex = 12;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(1, 316);
            button9.Name = "button9";
            button9.Size = new Size(55, 23);
            button9.TabIndex = 13;
            button9.Text = "5";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(5, 367);
            button10.Name = "button10";
            button10.Size = new Size(55, 23);
            button10.TabIndex = 14;
            button10.Text = "8";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(1, 262);
            button11.Name = "button11";
            button11.Size = new Size(55, 23);
            button11.TabIndex = 15;
            button11.Text = "2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(165, 316);
            button12.Name = "button12";
            button12.Size = new Size(62, 23);
            button12.TabIndex = 16;
            button12.Text = "7";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(83, 367);
            button13.Name = "button13";
            button13.Size = new Size(61, 23);
            button13.TabIndex = 17;
            button13.Text = "9";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button15
            // 
            button15.Location = new Point(246, 169);
            button15.Name = "button15";
            button15.Size = new Size(48, 23);
            button15.TabIndex = 20;
            button15.Text = "OFF";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(172, 367);
            button16.Name = "button16";
            button16.Size = new Size(55, 23);
            button16.TabIndex = 21;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(5, 214);
            button17.Name = "button17";
            button17.Size = new Size(44, 23);
            button17.TabIndex = 22;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(83, 214);
            button18.Name = "button18";
            button18.Size = new Size(61, 23);
            button18.TabIndex = 24;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button14
            // 
            button14.Location = new Point(52, 169);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 25;
            button14.Text = "CE";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button19
            // 
            button19.Location = new Point(152, 169);
            button19.Name = "button19";
            button19.Size = new Size(75, 23);
            button19.TabIndex = 26;
            button19.Text = "BA";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(306, 427);
            Controls.Add(button19);
            Controls.Add(button14);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private ContextMenuStrip contextMenuStrip1;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button14;
        private Button button19;
    }
}