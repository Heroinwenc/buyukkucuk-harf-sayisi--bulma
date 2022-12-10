using System;
using System.Windows.Forms;

namespace buyukkucukharfsayisibulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte bs = 0, ks = 0;
            for (int i = 0; i < textBox1.Text.Length - 1; i++)
            {
                if ((textBox1.Text[i] >= 'A') && (textBox1.Text[i] <= 'Z'))
                { bs++; }
                if ((textBox1.Text[i] >= 'a') && (textBox1.Text[i] <= 'z'))
                { ks++; }
            }
            MessageBox.Show(bs + " Tane Büyük Sayı, " + ks + " Tane Küçük Sayı vardır.");
        }
    }
}
