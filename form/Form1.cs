using Rational2;

namespace form
{
    public partial class RationalCalc : Form
    {
        public RationalCalc()
        {
            InitializeComponent();
        }
        private void updateForm()
        {
            if (textBox_input2.Text.Length > 0 && textBox_input2.Text.Length > 0 && labelOper.Text != String.Empty)
            { button_getRes.Enabled = true; }
            else { button_getRes.Enabled = false; }
        }

        private void button_getRes_Click(object sender, EventArgs e)
        {
            Rational num1, num2;
            try
            {
                num1 = Rational.Parse(textBox_input1.Text);
                num2 = Rational.Parse(textBox_input2.Text);
            } catch
            {
                return;
            }
            string result;
            switch (labelOper.Text)
            {
                case "+":
                    result = (num1 + num2).ToString();
                    break;
                case "-":
                    result = (num1 - num2).ToString();
                    break;
                case ":":
                    result = (num1 / num2).ToString();
                    break;
                case "*":
                    result = (num1 * num2).ToString();
                    break;
                default:
                    result = "";
                    break;
            }
            textBox_output.Text = result;
        }

        private void textBox_input1_TextChanged(object sender, EventArgs e)
        {
            textBox_output.Text = "";
            updateForm();
        }

        private void textBox_input2_TextChanged(object sender, EventArgs e)
        {
            textBox_output.Text = "";
            updateForm();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            labelOper.Visible = true;
            labelOper.Text = "+";
            updateForm();
        }

        private void button_diff_Click(object sender, EventArgs e)
        {
            labelOper.Visible = true;
            labelOper.Text = "-";
            updateForm();
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            labelOper.Visible = true;
            labelOper.Text = ":";
            updateForm();
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            labelOper.Visible = true;
            labelOper.Text = "*";
            updateForm();
        }
    }
}