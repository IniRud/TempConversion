using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_fer_Click(object sender, EventArgs e)
        {
            // f is the variable and float is the type
            // Converting F to celsius and kelvin
            float f = 0;
            try 
            {
                f = float.Parse(txt_fer.Text);
            }
            catch 
            {
                MessageBox.Show("Insert numbers only");
            };
            
            float c = 5f / 9f * (f - 32);
            float k = c - 273;

            txt_cel.Text = c.ToString();
            txt_kel.Text = k.ToString();
        }

        private void btn_cel_Click(object sender, EventArgs e)
        {
            float c = 0;
            try { c = float.Parse(txt_cel.Text); }
            catch { MessageBox.Show("Insert numbers only"); };
            
            float f = 9f / 5f * c + 32;
            float k = c + 273;

            txt_fer.Text = f.ToString();
            txt_kel.Text = k.ToString();
        }

        private void btn_kel_Click(object sender, EventArgs e)
        {
            double k = 0;
            k = double.Parse( txt_kel.Text);

            double f = ((k - 273.15) * 9/5) + 32;
            double c = k - 273.15;

            txt_fer.Text = f.ToString();
            txt_cel.Text = c.ToString();
        }
    }
}
