using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIMouseCheck
{
    public partial class Form2 : Form
    {
        private string str = "";
        private string substr = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            label1.Text = "마우스 버튼 놓음: " + "좌표: " + e.X + ", " + e.Y;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "마우스 버튼 누름: " + "좌표: " + e.X + ", " + e.Y;
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "마우스 버튼 클릭: " + "좌표: " + e.X + ", " + e.Y;
        }

        private void Form2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label2.Text = "마우스 버튼 더블클릭: " + "좌표: " + e.X + ", " + e.Y;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }

        


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                substr = str.Substring(str.Length - 1, 1);
                if (char.GetUnicodeCategory(char.Parse(substr)) == System.Globalization.UnicodeCategory.OtherLetter)
                {
                    str = str.Substring(0, str.Length - 1);
                }
            }

            else if (e.KeyCode == Keys.Back && str.Length != 0)
            {
                str = str.Remove(str.Length - 1, 1);
                label3.Text = str;
            }
            */
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar != '\b')
            {
                str += e.KeyChar;
                label3.Text = str;
            }
            */
        }

    }
}
