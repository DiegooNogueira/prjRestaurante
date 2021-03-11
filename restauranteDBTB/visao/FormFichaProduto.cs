using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranteDBTB.visao
{
    public partial class FormFichaProduto : Form
    {
        public FormFichaProduto()
        {
            InitializeComponent();
        }

        internal modelo.produto Registro { get; set; }
 

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (validacao() == false) return;

            if (Registro == null) novo();
            else editar();

        }

        private bool validacao()
        {
            if (txtDescricao.Text.Equals(""))
            {
                errorProvider1.SetIconPadding(txtDescricao, -30);
                errorProvider1.SetError(txtDescricao, "Descriçao do Produto vazia");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtDescricao, string.Empty);
            }

            try 
            {
                double num = Double.Parse(txtPreco.Text, NumberStyles.Currency);
                errorProvider1.SetError(txtPreco, string.Empty);
            }
            catch (Exception)
            {
                errorProvider1.SetIconPadding(txtPreco, -30);
                errorProvider1.SetError(txtPreco, "Preço não definido");
                return false;
            }

            return true;
        }

        private void novo()
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            try
            {
                Registro = new modelo.produto()
                {
                    nome = txtDescricao.Text.ToUpper(),
                    idtipo = Convert.ToInt16(cbCategoria.SelectedValue),
                    preco = Double.Parse(txtPreco.Text, NumberStyles.Currency),
                    idproduto = tabela.ProximoCodigo()
                };

                tabela.inserir(Registro);
            }

            catch (Exception)
            {
                MessageBox.Show("Falha ao cadastrar");
            }
            
            this.Dispose();

        }

        private void editar()
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            
            try
            {
                Registro.nome = txtDescricao.Text.ToUpper();
                Registro.idtipo = Convert.ToInt16(cbCategoria.SelectedValue);
                Registro.preco = Double.Parse(txtPreco.Text, NumberStyles.Currency);
                tabela.editar(Registro);
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao editar");
            }

            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Registro = null;
            this.Dispose();
        }

        private void FormFichaProduto_Load(object sender, EventArgs e)
        {
            controle.TipoDB tabelaTipo = new controle.TipoDB();
            cbCategoria.DataSource = tabelaTipo.listar();
            cbCategoria.DisplayMember = "descricao";
            cbCategoria.ValueMember = "idtipo";

            if (Registro != null)
            {
                this.Text = "FICHA PRODUTO NUMERO:" +
                Registro.idproduto.ToString().PadLeft(12,'0');
                txtDescricao.Text = Registro.nome;
                txtPreco.Text = string.Format("{0,8:C2}",Registro.preco);
                cbCategoria.SelectedValue = Registro.idtipo;
            }
        }

        private void lnkNovoTipo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormFichaTipo fichaTipo = new FormFichaTipo();

            fichaTipo.Registro = null; 

            fichaTipo.ShowDialog();

            if (fichaTipo.Registro != null)
            {
                controle.TipoDB tabelaTipo = new controle.TipoDB();
                cbCategoria.DataSource = tabelaTipo.listar();
                cbCategoria.SelectedValue = fichaTipo.Registro.idtipo;
            }
        }

        private void lnkEditarTipo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
            FormFichaTipo fichaTipo = new FormFichaTipo();
            fichaTipo.Registro = (modelo.tipo)cbCategoria.SelectedItem;
            fichaTipo.ShowDialog();
            if (fichaTipo.Registro != null)
            {
                controle.TipoDB tabelaTipo = new controle.TipoDB();
                cbCategoria.DataSource = tabelaTipo.listar();
                cbCategoria.SelectedValue = fichaTipo.Registro.idtipo;
            }
        }

        private void lnkExcluirTIpo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Deseja Excluir: " + cbCategoria.Text, "ALERTA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (op == DialogResult.Yes)
            {
                controle.TipoDB tabelaTipo = new controle.TipoDB();
                modelo.tipo item = (modelo.tipo)cbCategoria.SelectedItem;
                if (tabelaTipo.checarExclusao(item.idtipo))
                {
                    tabelaTipo.excluir(item.idtipo);
                    MessageBox.Show("categoria excluida com sucesso!");
                    cbCategoria.DataSource = tabelaTipo.listar();
                }
                else {
                    MessageBox.Show("Tipo não pode ser excluido!");
                }
            }
        }
    }
}
