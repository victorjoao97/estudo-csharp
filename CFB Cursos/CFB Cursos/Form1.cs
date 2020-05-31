using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Cursos
{
    public partial class Form1 : Form
    {
        List<string> carros = new List<string>();
        public Form1()
        {
            InitializeComponent();
            carros.Add("Gol Quadrado");
            carros.Add("Uno");
            carros.Add("Palio");

            carregaDataSource();
        }

        private void carregaDataSource()
        {
            ltbCarros.DataSource = null;
            ltbCarros.DataSource = carros;
        }
        private void carregaDataSource(string carro)
        {
            carros.Add(carro);
            carregaDataSource();
        }
        private void removeDataSource(int index)
        {
            carros.RemoveAt(index);
            carregaDataSource();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            carregaDataSource(txtCarro.Text);
            txtCarro.Text = "";
        }

        private void txtCarro_TextChanged(object sender, EventArgs e)
        {
                btnAdicionar.Enabled = txtCarro.Text.Length > 0;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            removeDataSource(ltbCarros.SelectedIndex);
        }

        private void btnObter_Click(object sender, EventArgs e)
        {
            txtCarro.Text = ltbCarros.SelectedItem.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            carregaDataSource();
            txtCarro.Clear();
        }

        private void ltbCarros_DataSourceChanged(object sender, EventArgs e)
        {
            bool checkCarros = carros.Count > 0;
            btnRemover.Enabled = checkCarros;
            btnObter.Enabled = checkCarros;
            btnLimpar.Enabled = checkCarros;
        }
    }
}
