using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Login login = new Login(this);
            login.ShowDialog();
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair?", "Atençao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lbAcesso.Text = "0";
                lbNomeUsuario.Text = "...";
                pbLogado.BackColor = Color.Red;
                ToogleLoginButtons();
                Globals.Logoff();
            }
        }

        public void ToogleLoginButtons()
        {
            btnToolStripLogoff.Enabled = !btnToolStripLogoff.Enabled;
            btnToolStripLogon.Enabled = !btnToolStripLogon.Enabled;
        }
    }
}
