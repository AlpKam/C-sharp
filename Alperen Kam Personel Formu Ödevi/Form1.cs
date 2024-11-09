namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label3.Text = textBox1.Text;
            label4.Text = maskedTextBox1.Text;
            label7.Text = comboBox1.Text;
            label13.Text = richTextBox1.Text;
            label15.Text = textBox2.Text;

            if (checkBox1.Checked)
            {
                label14.Text = checkBox1.Text;

            }

            if (radioButton3.Checked)
            {
                label16.Text = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                label16.Text = radioButton4.Text;
            }
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
