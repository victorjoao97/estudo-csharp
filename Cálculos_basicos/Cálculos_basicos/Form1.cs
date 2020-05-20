using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculos_basicos
{
    public partial class Form1 : Form
    {

        private double numero1;
        private double numero2;

        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Numero1 = Convert.ToDouble(txtNum1.Text);
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro");
                Numero1 = 0.0;
                txtNum1.Text = Convert.ToString(Numero1);
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Numero2 = Convert.ToDouble(txtNum2.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Digite apenas números");
                Numero2 = 0.0;
                txtNum2.Text = Convert.ToString(Numero2);
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Numero1 + Numero2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Numero1 - Numero2).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "0";
            txtNum2.Text = "0";
            txtResultado.Text = "0";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Numero1 * Numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if(Numero2 != 0)
            {
                txtResultado.Text = (Numero1 / Numero2).ToString();
            }
            else
            {
                MessageBox.Show("Jamais dividirás por 0", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
