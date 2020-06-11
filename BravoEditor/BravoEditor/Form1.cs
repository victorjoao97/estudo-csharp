using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BravoEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnNovo.Image = IconChar.Save.ToBitmap(30, Color.Black);
            btnAbrir.Image = IconChar.FileArchive.ToBitmap(30, Color.Black);
            HabilitaSalvar();
        }

        private void Salvar()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, "");
                FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Flush();
                streamWriter.Write(string.Empty);
                streamWriter.Write(rtbTexto.Text);
                streamWriter.Close();
                this.Text = saveFileDialog1.FileName;
            }
        }

        private void Abrir()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbTexto.Text = "";
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                rtbTexto.Text = streamReader.ReadToEnd();
                this.Text = openFileDialog1.FileName;
            }
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {
            HabilitaSalvar();
        }

        private void HabilitaSalvar()
        {
            btnNovo.Enabled = rtbTexto.Text.Length > 0;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }
    }
}
