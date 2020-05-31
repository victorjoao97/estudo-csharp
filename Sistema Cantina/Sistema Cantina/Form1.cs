using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigoProd_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoProd.Text.Length == 3)
            {
                int indice = 0;

                for(int prod = 0; prod < codigo.Length; prod++)
                {
                    if(txtCodigoProd.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }

                if(indice == 0)
                {
                    MessageBox.Show("Produto não encontrado");
                }
                lstCaixa.Items.Add(txtCodigoProd.Text);
                txtCodigoProd.Text = "";
                txtCodigoProd.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
        }

        private void carregarArray()
        {
            codigo[0] = "001";
            codigo[1] = "002";
            codigo[2] = "003";
            codigo[3] = "004";
            codigo[4] = "005";

            produtos[0] = "Pastel";
            produtos[1] = "Coxinha";
            produtos[2] = "Hot Dog";
            produtos[3] = "Chocolate";
            produtos[4] = "Suco";

            valor[0] = 6;
            valor[1] = 8;
            valor[2] = 7;
            valor[3] = 6;
            valor[4] = 9;
        }
    }
}
