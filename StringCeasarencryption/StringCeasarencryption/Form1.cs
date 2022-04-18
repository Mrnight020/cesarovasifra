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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] pismena = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();   //index 51    text lenght - 52

        private void button1_Click(object sender, EventArgs e)
        {
            int posun = Convert.ToInt32(numericUpDown1.Value);
            string heslo = textBox1.Text;
            char[] heslo1 = heslo.ToCharArray();
            char[] zasifrovane = new char[heslo1.Length];

            for (int i = 0;i < heslo1.Length ;i++)
            {
                int pozice = Array.IndexOf(pismena, heslo1[i]);   // bere index
                if(pozice != -1)
                {
                    if ((pozice + posun) < 52) zasifrovane[i] = pismena[pozice + posun];
                    else
                    {
                        zasifrovane[i] = pismena[(pozice + (posun - 1)) - (pismena.Length - 1)];
                    }
                }
                else
                {
                    zasifrovane[i] = heslo1[i];
                }
            }
            //label4.Text = pismena.Length.ToString();
            string zasifrovane1 = new string(zasifrovane);
            label5.Text = zasifrovane1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int posun = Convert.ToInt32(numericUpDown1.Value);
            string heslo = textBox2.Text;
            char[] heslo1 = heslo.ToCharArray();
            char[] zasifrovane = new char[heslo1.Length];

            for (int i = 0; i < heslo1.Length; i++)
            {
                int pozice = Array.IndexOf(pismena, heslo1[i]);   // bere index
                if(pozice != -1)
                {
                    if ((pozice - posun) >= 0) zasifrovane[i] = pismena[pozice - posun];
                    else
                    {
                        zasifrovane[i] = pismena[(pismena.Length - 1) + (pozice - (posun - 1))];
                    }
                }
                else
                {
                    zasifrovane[i] = heslo1[i];
                }

            }
            //label4.Text = pismena.Length.ToString();
            string zasifrovane1 = new string(zasifrovane);
            label6.Text = zasifrovane1;
        }
    }
}
