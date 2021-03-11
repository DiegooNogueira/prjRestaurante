using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranteDBTB.pesquisa
{
    public partial class FormPesquisaProduto : Form
    {
        public FormPesquisaProduto()
        {
            InitializeComponent();
        }

        internal int Codigo { get; set; }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            if (txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Campo descriçao vazio");
                return;
            }
            if (rbStartWith.Checked)
            {
                dgvResultado.DataSource = tabela.pesquisar(txtDescricao.Text, "start");
            }
            else 
            {
                dgvResultado.DataSource = tabela.pesquisar(txtDescricao.Text, "contains");
            }

            dgvResultado.Columns["Descricao"].Width = 300;
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnPesquisar_Click(sender, e);
            }
        }

        private void btnRetornaCodigo_Click(object sender, EventArgs e)
        {

            if (dgvResultado.Rows.Count != 0){
                Codigo = Convert.ToInt16(dgvResultado.CurrentRow.Cells["Codigo"].Value);
                this.Dispose();
            }
        }
    }
}
