using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cboFinalPlacas.Text)
            {
                case "1 ou 2":
                    lblRes.Text = "Segunda-Feira";
                    break;
                case "3 ou 4":
                    lblRes.Text = "Terça-Feira";
                    break;
                case "5 ou 6":
                    lblRes.Text = "Quarta-Feira";
                    break;
                case "7 ou 8":
                    lblRes.Text = "Quinta-Feira";
                    break;
                case "9 ou 0":
                    lblRes.Text = "Sexta-Feira";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }
    }
}
