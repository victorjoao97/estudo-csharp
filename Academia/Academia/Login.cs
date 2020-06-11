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
    public partial class Login : Form
    {
        Form1 form1;
        public Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllowLoginButton(object sender, EventArgs e)
        {
            btnLogin.Enabled = txtUsername.TextLength > 0 && txtPassword.TextLength > 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            DataTable  dataTable = Banco.Query($"select * from usuarios where usuario = '{username}' and senha = '{password}'");

            if (dataTable.Rows.Count > 0)
            {
                form1.lbAcesso.Text = dataTable.Rows[0].Field<Int64>("nivel").ToString();
                form1.lbNomeUsuario.Text = dataTable.Rows[0].Field<string>("usuario");
                form1.pbLogado.BackColor = Color.Green;
                form1.btnToolStripLogon.Enabled = false;
                form1.btnToolStripLogoff.Enabled = true;
                Globals.Logon(dataTable.Rows[0].Field<Int64>("nivel"));
                this.Close();
            }
            else
            {
                MessageBox.Show("User not found", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
