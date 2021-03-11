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
    public partial class FormFichaUsuario : Form
    {
        public FormFichaUsuario()
        {
            InitializeComponent();
        }

        private void FormFichaUsuario_Load(object sender, EventArgs e)
        {
            controle.UsuarioDB tabela = new controle.UsuarioDB();
            bs.DataSource = tabela.listar();
            dgvUsuarios.DataSource = bs;
            
            dgvUsuarios.Columns["senha"].Width = 200;
            dgvUsuarios.Columns["email"].Width = 300;
            dgvUsuarios.Columns["senha"].Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            visao.FormCadastroLogin ficha = new FormCadastroLogin();
            ficha.Usuario = null;
            ficha.ShowDialog();

            if (ficha.Usuario != null) {
                controle.UsuarioDB tabela = new controle.UsuarioDB();
                dgvUsuarios.DataSource = tabela.listar();
                bs.MoveLast();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            visao.FormCadastroLogin ficha = new FormCadastroLogin();
            ficha.Usuario = (modelo.usuarios) bs.Current;
            ficha.ShowDialog();

            if (ficha.Usuario != null)
            {
                controle.UsuarioDB tabela = new controle.UsuarioDB();
                dgvUsuarios.DataSource = tabela.listar();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           modelo.usuarios Usuario = (modelo.usuarios)bs.Current;
           DialogResult op;
           op = MessageBox.Show("Excluir " + Usuario.login, "ALERTA",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (op == DialogResult.Yes)
           {
               controle.UsuarioDB tabela = new controle.UsuarioDB();
               tabela.excluir(Usuario.cod);
               bs.RemoveCurrent();
               bs.ResetBindings(false);
           }
        }

        private void chkVisualizarSenhas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVisualizarSenhas.Checked == true)
            {
                dgvUsuarios.Columns["senha"].Visible = true;
            }
            else
            {
                dgvUsuarios.Columns["senha"].Visible = false;
            }
        }
    }
}
