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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num, ans;
        int count;
        private int sign_Indicator;

        public void disable()// Disable Cal
        {
            textBox1.Enabled = false;
            button2.Show();
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Hide();
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
           
        }

        public void enable()
        {
            textBox1.Enabled = true;
            button2.Hide();
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Show();
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compute();//Performs Any Operation
            label1.Text = "";//Clear text on the label
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Black;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Black;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Black;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Black;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Black;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Black;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Black;
        }

        private void button10_Click(object sender, EventArgs e)//OFF BUTTON
        {
            disable();
        }

        private void button2_Click(object sender, EventArgs e)//ON
        {
            enable();
        }

        private void button21_Click(object sender, EventArgs e)//BackSpace
        {
            int length = textBox1.TextLength - 1;//Track Length and - 1
            string text = textBox1.Text;
            textBox1.Clear();

            for (int i = 0; i < length; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void button19_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//Clear text on Box
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double s, l;
            l = Convert.ToDouble(textBox1.Text);
            s = Math.Sqrt(l);
            textBox1.Text = Convert.ToString(s);
        }

        private void button22_Click(object sender, EventArgs e)
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

        private void button29_Click(object sender, EventArgs e)
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

        private void button26_Click(object sender, EventArgs e)
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

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
            sign_Indicator = 1;
        }

        private void button27_Click(object sender, EventArgs e)
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

        private void button28_Click(object sender, EventArgs e)
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

        private void button23_Click(object sender, EventArgs e)
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


        private void button24_Click(object sender, EventArgs e)
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

        private void button34_Click(object sender, EventArgs e)
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

        private void button33_Click(object sender, EventArgs e)
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
        

        private void button31_Click(object sender, EventArgs e)
        {
            
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            label1.Text = "";//Clear text on label
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
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
