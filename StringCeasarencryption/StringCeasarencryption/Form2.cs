using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringCeasarencryption
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                }
                else{ sb.Append(c); }
            }
            textBox1.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            text = text.Replace('*',' ');
            textBox1.Text = text;
        }
    }
}
