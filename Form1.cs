namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        //SUMA
        {
            operador = "+";
            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "+";
            


        }

        private void button3_Click(object sender, EventArgs e)
        //divicion
        {
            operador = "/";
            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        // ocho
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "8";

        }

        private void button18_Click(object sender, EventArgs e)
        //cero
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "0";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        //uno
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "1";

        }

        private void button11_Click(object sender, EventArgs e)
        //dos
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "2";

        }

        private void button7_Click(object sender, EventArgs e)
        //tres
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "3";


        }

        private void button5_Click(object sender, EventArgs e)
        //cuatro
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "4";


        }

        private void button9_Click(object sender, EventArgs e)
        // cinco
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "5";


        }

        private void button8_Click(object sender, EventArgs e)
        // 6
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "6";


        }

        private void button12_Click(object sender, EventArgs e)
        // 7
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "7";

        }

        private void button13_Click(object sender, EventArgs e)
        //nueve
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "9";

        }
        // variables
        string operador = "";
        double Num1 = 0;
        double Num2 = 0;
        private void button14_Click(object sender, EventArgs e)
        //eliminar todos los numeros
        {
            textBox1.Text = "0";
            Num1 = 0;
            Num2 = 0;
            operador = "";
        }

        private void button19_Click(object sender, EventArgs e)
        //eliminar numeros de uno en uno
        {
            if (textBox1.TextLength == 1) textBox1.Text = "0";
            else textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        //resta
        {
            operador = "-";
            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        //multiplicacion
        {
            operador = "*";
            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        //=
        {

            Num2 = Convert.ToDouble(textBox1.Text);


            switch (operador)
            {
                case "+":
                    textBox1.Text = $"{Num1 + Num2}";
                    break;

                case "-":
                    textBox1.Text = $"{Num1 - Num2}";
                    break;

                case "/":
                    textBox1.Text = $"{Num1 / Num2}";
                    break;

                case "*":
                    textBox1.Text = $"{Num1 * Num2}";
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        //punto
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + ".";

        }

        private void button20_Click(object sender, EventArgs e)
        //%
        {
            textBox1.Text = textBox1.Text + "%";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "( ";
        }

        private void button21_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + ",";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " )";

        }
    }
}