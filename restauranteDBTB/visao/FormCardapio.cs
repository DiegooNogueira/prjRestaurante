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
    public partial class FormCardapio : Form
    {
        public FormCardapio()
        {
            InitializeComponent();
        }

        private void FormCardapio_Load(object sender, EventArgs e)
        {
            controle.CardapioDB tabela = new controle.CardapioDB();
            tabela.consultar(bs);

            lbIdCardapio.DataBindings.Add(new Binding("Text", bs, "idcardapio"));
            lbDescricao.DataBindings.Add(new Binding("Text", bs, "descricao"));

        }

        private void FormCardapio_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal pai = (FormPrincipal)this.MdiParent;
            pai.cardapios = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormFichaCardapio ficha = new FormFichaCardapio();
            ficha.Registro = null;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                controle.CardapioDB tabela = new controle.CardapioDB();
                tabela.consultar(bs);
                bs.MoveLast();
                bs.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormFichaCardapio ficha = new FormFichaCardapio();
            ficha.Registro = (modelo.cardapio)bs.Current;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                controle.CardapioDB tabela = new controle.CardapioDB();
                tabela.consultar(bs);
                bs.ResetBindings(false);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            DialogResult op;
            modelo.cardapio Registro = (modelo.cardapio)bs.Current;

            op = MessageBox.Show("Excluir cardapio: " +
                Registro.descricao, "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                controle.CardapioDB tabela = new controle.CardapioDB();
                tabela.excluir(Registro.idcardapio);
                bs.RemoveCurrent();
                bs.ResetBindings(false);
            }
        }

        private void btnAddItemProduto_Click(object sender, EventArgs e)
        {
            FormFichaItemProduto FichaItemProduto = new FormFichaItemProduto();
            FichaItemProduto.Registro = (modelo.cardapio)bs.Current;
            FichaItemProduto.ShowDialog();
        }
    }
}
