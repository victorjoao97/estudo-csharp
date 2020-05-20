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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text)
            {
                case "Domingo":
                    MessageBox.Show("Você selecionou o primeiro dia da semana");
                    break;
                case "Segunda":
                    MessageBox.Show("Você selecionou o segundo dia da semana");
                    break;
                case "Terça":
                    MessageBox.Show("Você selecionou o terceiro dia da semana");
                    break;
                case "Quarta":
                    MessageBox.Show("Você selecionou o quarto dia da semana");
                    break;
                case "Quinta":
                    MessageBox.Show("Você selecionou o quinto dia da semana");
                    break;
                case "Sexta":
                    MessageBox.Show("Você selecionou o sexto dia da semana");
                    break;
                case "Sábado":
                    MessageBox.Show("Você selecionou o sétimo dia da semana");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
            this.Visible = false;
        }
    }
}
