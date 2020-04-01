using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        float num, ans;
        int count;
        private int sign_Indicator;

        public void disable()// Disable Cal
        {
            textBox1.Enabled = false;
            button2.Enabled = false;
            button1.Show();
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Hide();
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
        }

        public void enable()
        {
            textBox1.Enabled = true;
            button2.Enabled = true;
            button1.Hide();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Show();
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;

        }
        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            label2.Text = "";//Clear text on label
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//Clear text on Box
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            disable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label2.Text = num.ToString() + "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label2.Text = num.ToString() + "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label2.Text = num.ToString() + "/";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label2.Text = num.ToString() + "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            compute();//Performs Any Operation
            label2.Text = "";//Clear text on the label
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Black;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Black;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;//Track Length and - 1
            string text = textBox1.Text;
            textBox1.Clear();

            for (int i = 0; i < length; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void button15_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Black;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Black;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Black;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Black;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double s, l;
            l = Convert.ToDouble(textBox1.Text);
            s = Math.Sqrt(l);
            textBox1.Text = Convert.ToString(s);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Round(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Ceiling(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Floor(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
            sign_Indicator = 1;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Tan(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Atan(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Cos(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Acos(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Sin(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Asin(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox TextBox1 = this.ActiveControl as TextBox;
            if (TextBox1.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, TextBox1.SelectedText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox TextBox1 = this.ActiveControl as TextBox;
            if (TextBox1.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, TextBox1.SelectedText);
            TextBox1.SelectedText = string.Empty;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int position = ((TextBox)this.ActiveControl).SelectionStart;
            this.ActiveControl.Text = this.ActiveControl.Text.Insert(position, Clipboard.GetText());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void compute()
        {
            switch (count)//Switch Case
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);//ADD
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox1.Text);//SUB
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox1.Text);//MUL
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBox1.Text);//DIV
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
