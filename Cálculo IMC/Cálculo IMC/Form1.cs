using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtAltura.Text = "";
            TxtIMC.Text = "";
            TxtPeso.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, resultado;

            peso = Convert.ToDouble(TxtPeso.Text);
            altura = Convert.ToDouble(TxtAltura.Text);

            resultado = peso / (altura * altura);

            TxtIMC.Text = resultado.ToString("F");

            if (resultado <= 18.49)
            {
                MessageBox.Show("Você está abaixo do peso.");
            }else if(resultado <= 24.99)
            {
                MessageBox.Show("Você está com peso dentro da normalidade.");
            }
            else if (resultado <= 29.99)
            {
                MessageBox.Show("Você está acima do peso.");
            }
            else if (resultado <= 34.99)
            {
                MessageBox.Show("Atenção, você está com Obesidade Grau I.");
            }
            else if (resultado <= 39.99)
            {
                MessageBox.Show("Atenção, você está com Obesidade Grau II (severa).");
            }else
            {
                MessageBox.Show("Atenção, você está com Obesidade Grau III (mórbida).");
            }
        }
    }
}
