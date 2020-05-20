using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_de_Média
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, media;

            nota1 = Convert.ToDouble(TxtNota1.Text);
            nota2 = Convert.ToDouble(TxtNota2.Text);
            nota3 = Convert.ToDouble(TxtNota3.Text);
            nota3 = Convert.ToDouble(TxtNota3.Text);
            nota3 = Convert.ToDouble(TxtNota3.Text);
            nota3 = Convert.ToDouble(TxtNota3.Text);

            media = (nota1 + nota2 + nota3) / 3;

            if(media < 5)
            {
                MessageBox.Show("Aluno reprovado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(media <= 6)
            {
                MessageBox.Show("Aluno de recuperação", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Aluno aprovado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }

            // passando parametro f para tostring =  5.333333 para 5.33
            TxtMedia.Text = media.ToString("F");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtMedia.Text = "";
            TxtNota1.Text = "";
            TxtNota2.Text = "";
            TxtNota3.Text = "";
        }
    }
}
