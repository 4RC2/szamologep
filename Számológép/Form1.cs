using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Számológép
{
    public partial class Form1 : Form
    {

        Double szám1;
        Double szám2;
        String művelet;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            művelet = "Összeadás";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            művelet = "Kivonás";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            művelet = "Szorzás";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            művelet = "Osztás";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="" && textBox2.Text != "" && művelet != "")
            {
                szám1 = Convert.ToDouble(textBox1.Text);
                szám2 = Convert.ToDouble(textBox2.Text);

                if (művelet == "Összeadás")
                {
                    label3.Text = szám1 + " + " + szám2 + " =";
                    label4.Text = (szám1 + szám2).ToString();
                }

                if (művelet == "Kivonás")
                {
                    label3.Text = szám1 + " - " + szám2 + " =";
                    label4.Text = (szám1 - szám2).ToString();
                }

                if (művelet == "Szorzás")
                {
                    label3.Text = szám1 + " * " + szám2 +" =";
                    label4.Text = (szám1 * szám2).ToString();
                }

                if (művelet == "Osztás" && textBox2.Text != "0")
                {
                    label3.Text = szám1 + " / " + szám2 + " =";
                    label4.Text = (szám1 / szám2).ToString();
                }
            }

            if (textBox1.Text == "")
                MessageBox.Show("Írja be az 1. számot!", "Számológép");

            if (textBox2.Text == "")
                MessageBox.Show("Írja be a 2. számot!", "Számológép");

            if (művelet == "")
                MessageBox.Show("Válassza ki az elvégzendő műveletet!", "Számológép");

            if (művelet == "Osztás" && szám2 == 0)
                MessageBox.Show("Nullával nem lehet osztani.", "Számológép");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
            label3.Text = "";
            label4.Text = "";
            művelet = "";
        }
    }
}
