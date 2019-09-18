using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_obch_Click(object sender, EventArgs e)
        {try
            {
                double x = Convert.ToDouble(textBox_x.Text);
                double y = Convert.ToDouble(textBox_y.Text);
                double z = Convert.ToDouble(textBox_z.Text);
                double r;
                r = ((2 * Math.Cos(Math.Pow(x, 2)) - 0.5) / (0.5 + Math.Sin(Math.Pow(y, 2 - z)))) + (Math.Pow(z, 2)) / (7 - (z / 3));
                textBox_r.Text = r.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка введення коефіціента", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        }
    }
}
