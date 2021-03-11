using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranteDBTB.visao
{
    public partial class FormPrincipal : Form
    {
        public FormProduto produto = null;
        public visao.FormFichaUsuario usuario = null;
        public FormMesas mesas  = null;

        public FormCardapio cardapios = null;

        public string Usuario { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mnProduto_Click(object sender, EventArgs e)
        {
            if (produto == null)
            {
                produto = new FormProduto();
                produto.MdiParent = this;
                produto.Show();
                produto.Location = new Point(0, 0);
            }
        }

        private void mnUsuarios_Click(object sender, EventArgs e)
        {
            if (!Usuario.Equals("admin"))
            {
                MessageBox.Show(
                    "Acesso negado. Somente usuário administrador!",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (usuario == null)
            {
                usuario = new visao.FormFichaUsuario();
                usuario.MdiParent = this;
                usuario.Show();
                usuario.Location = new Point(0, 0);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            string[] cores = controle.Registro.ler("restaurante", "cor").Split(',');

            Controls.OfType<MdiClient>().
                FirstOrDefault().BackColor = Color.FromArgb(
                Int16.Parse(cores[0]),
                Int16.Parse(cores[1]),
                Int16.Parse(cores[2]));

            string caminho = Environment.CurrentDirectory + "\\fundo.png";

            if (File.Exists(caminho))
            {
                this.BackgroundImage = Image.FromFile(caminho);
            }

            lblConexao.Text += " : " + DateTime.Now.ToShortDateString()
                + " as " + DateTime.Now.ToShortTimeString();
            lblConexao.Text += " Maquina: " + Environment.MachineName;
            lblUsuario.Text += Usuario.ToUpper();
        }

        private void mnConfRelatorio_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            if (Directory.Exists(folderBrowserDialog1.SelectedPath))
            {
                if (File.Exists(@folderBrowserDialog1.SelectedPath + @"\rdproduto.rdlc"))
                {
                    controle.Registro.gravar("restaurante", "relatorio",
                        folderBrowserDialog1.SelectedPath);
                    MessageBox.Show("Caminho gravado com sucesso!", "ALERTA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Arquivo RDLC não encontrado!", "ALERTA",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void mnConfCorFundo_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
              controle.Registro.gravar("restaurante", "cor",
                  colorDialog1.Color.R + "," + colorDialog1.Color.G +
                  "," + colorDialog1.Color.B);
              MessageBox.Show("Cor de fundo salva com sucesso!", "ALERTA",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
              Controls.OfType<MdiClient>().
                  FirstOrDefault().BackColor = colorDialog1.Color;
        }

        private void mnConfImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "imagens|*.png";
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName))
            {
                this.BackgroundImage = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();

                string caminho = Environment.CurrentDirectory + "\\fundo.png";
                if (File.Exists(caminho))
                {

                    File.Delete(caminho);
                }
                File.Copy(openFileDialog1.FileName, caminho);
                this.BackgroundImage = Image.FromFile(caminho);
            }
        }

        private void mnMesa_Click(object sender, EventArgs e)
        {
            if (mesas == null)
            {
                mesas = new FormMesas();
                mesas.MdiParent = this;
                mesas.Show();
                mesas.Location = new Point(0, 0);
            }
        }

        private void mnCardapio_Click(object sender, EventArgs e)
        {
            if (cardapios == null)
            {
                cardapios = new FormCardapio();
                cardapios.MdiParent = this;
                cardapios.Show();
                cardapios.Location = new Point(0, 0);
            }
        }
    }
}
