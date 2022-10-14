using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = 100;
                double vize = Convert.ToDouble(numericUpDown1.Value),
                    final = Convert.ToDouble(numericUpDown2.Value);
                double ort = 0;
                    ort = final * 0.6 + vize * 0.4;
                    label4.Text = "Ders ortalamanız:" + Convert.ToString(ort);
                if (final < 50)
                {
                    label3.Text = "FF harf notu ile dersten kaldınız.";
                    label3.ForeColor = Color.Red;
                }
                else if (ort >= 90)
                {
                    label3.Text = "AA harf notu ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ort >= 85)
                {
                    label3.Text = "BA harf notu ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ort >= 80)
                {
                    label3.Text = "BB harf notu ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ort >= 75)
                {
                    label3.Text = "CB harf notu ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ort >= 70)
                {
                    label3.Text = "CC harf notu ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ort >= 65)
                {
                    label3.Text = "DC harf notu ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ort >= 60)
                {
                    label3.Text = "DD harf notu ile dersi geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ort >= 55)
                {
                    label3.Text = "FD harf notu ile dersten geçtiniz.";
                    label3.ForeColor = Color.Green;
                }
                else if (ort >= 49)
                {
                    label3.Text = "FF harf notu ile dersten kaldınız.";
                    label3.ForeColor = Color.Red;
                }

            




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
        }
    }
}
