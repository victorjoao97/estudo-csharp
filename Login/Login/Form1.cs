using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario, senha;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            txtUsuario.BackColor = Color.White;
            txtSenha.BackColor = Color.White;
            txtUsuario.ForeColor = Color.Black;
            txtSenha.ForeColor = Color.Black;

            if (usuario == "Admin" && senha == "Admin")
            {
                Form2 form2 = new Form2();

                form2.Show();

                this.Visible = false;
            }
            else{
                txtUsuario.BackColor = Color.Red;
                txtUsuario.ForeColor = Color.White;
                txtSenha.BackColor = Color.Red;
                txtSenha.ForeColor = Color.White;
            }
        }
    }
}
