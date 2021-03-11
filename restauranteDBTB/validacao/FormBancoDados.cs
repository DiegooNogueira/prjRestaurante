using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranteDBTB.visao
{
    public partial class FormBancoDados : Form
    {
        public FormBancoDados()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            controle.Registro.gravar("restaurante", "servidor", txtServidor.Text);
            controle.Registro.gravar("restaurante", "user", txtUsuario.Text);
            controle.Registro.gravar("restaurante", "senha",
                controle.Cripto.criptografar(txtSenha.Text));
            MessageBox.Show("Dados do MYSQL gravados no registro com sucesso!");
            this.Dispose();
        }
    }
}
