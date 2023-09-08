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
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(42, 92);
            textBox1.Margin = new Padding(3, 3, 3, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 43);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(121, 39);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "CASIO";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(217, 316);
            button1.Name = "button1";
            button1.Size = new Size(48, 79);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(217, 182);
            button2.Name = "button2";
            button2.Size = new Size(48, 28);
            button2.TabIndex = 6;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(217, 268);
            button3.Name = "button3";
            button3.Size = new Size(48, 33);
            button3.TabIndex = 7;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(217, 219);
            button4.Name = "button4";
            button4.Size = new Size(48, 37);
            button4.TabIndex = 8;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.Location = new Point(66, 268);
            button5.Name = "button5";
            button5.Size = new Size(45, 33);
            button5.TabIndex = 9;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(66, 315);
            button6.Name = "button6";
            button6.Size = new Size(45, 35);
            button6.TabIndex = 10;
            button6.Text = "1";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.Location = new Point(168, 316);
            button7.Name = "button7";
            button7.Size = new Size(43, 34);
            button7.TabIndex = 11;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Gray;
            button8.Location = new Point(168, 268);
            button8.Name = "button8";
            button8.Size = new Size(43, 33);
            button8.TabIndex = 12;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Gray;
            button9.Location = new Point(117, 268);
            button9.Name = "button9";
            button9.Size = new Size(45, 33);
            button9.TabIndex = 13;
            button9.Text = "5";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Gray;
            button10.Location = new Point(117, 219);
            button10.Name = "button10";
            button10.Size = new Size(45, 37);
            button10.TabIndex = 14;
            button10.Text = "8";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Gray;
            button11.Location = new Point(117, 315);
            button11.Name = "button11";
            button11.Size = new Size(45, 35);
            button11.TabIndex = 15;
            button11.Text = "2";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Gray;
            button12.Location = new Point(66, 219);
            button12.Name = "button12";
            button12.Size = new Size(45, 36);
            button12.TabIndex = 16;
            button12.Text = "7";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Gray;
            button13.ForeColor = SystemColors.ControlLightLight;
            button13.Location = new Point(168, 219);
            button13.Name = "button13";
            button13.Size = new Size(43, 37);
            button13.TabIndex = 17;
            button13.Text = "9";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button15
            // 
            button15.BackColor = Color.Black;
            button15.ForeColor = SystemColors.ControlLightLight;
            button15.Location = new Point(12, 182);
            button15.Name = "button15";
            button15.Size = new Size(54, 28);
            button15.TabIndex = 20;
            button15.Text = "OFF";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.Black;
            button16.ForeColor = SystemColors.ControlLightLight;
            button16.Location = new Point(168, 361);
            button16.Name = "button16";
            button16.Size = new Size(43, 34);
            button16.TabIndex = 21;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Gray;
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(118, 361);
            button17.Name = "button17";
            button17.Size = new Size(44, 34);
            button17.TabIndex = 22;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Gray;
            button18.Location = new Point(66, 361);
            button18.Name = "button18";
            button18.Size = new Size(45, 34);
            button18.TabIndex = 24;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Red;
            button14.ForeColor = SystemColors.ControlLightLight;
            button14.Location = new Point(12, 315);
            button14.Name = "button14";
            button14.Size = new Size(48, 23);
            button14.TabIndex = 25;
            button14.Text = "C";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Red;
            button19.ForeColor = SystemColors.ControlLightLight;
            button19.ImageAlign = ContentAlignment.BottomRight;
            button19.Location = new Point(12, 352);
            button19.Name = "button19";
            button19.Size = new Size(48, 43);
            button19.TabIndex = 26;
            button19.Text = "AC";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.Black;
            button20.ForeColor = SystemColors.ControlLightLight;
            button20.Location = new Point(12, 221);
            button20.Name = "button20";
            button20.Size = new Size(48, 35);
            button20.TabIndex = 27;
            button20.Text = "%";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.Black;
            button21.ForeColor = SystemColors.ControlLightLight;
            button21.Location = new Point(12, 263);
            button21.Name = "button21";
            button21.Size = new Size(48, 43);
            button21.TabIndex = 28;
            button21.Text = ",";
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.Black;
            button22.ForeColor = SystemColors.ControlLightLight;
            button22.Location = new Point(72, 182);
            button22.Name = "button22";
            button22.Size = new Size(55, 28);
            button22.TabIndex = 29;
            button22.Text = "(  ";
            button22.UseVisualStyleBackColor = false;
            button22.Click += button22_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.Black;
            button23.ForeColor = SystemColors.ControlLightLight;
            button23.Location = new Point(147, 182);
            button23.Name = "button23";
            button23.Size = new Size(52, 28);
            button23.TabIndex = 30;
            button23.Text = ")";
            button23.UseVisualStyleBackColor = false;
            button23.Click += button23_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(285, 415);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
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
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
    }
}