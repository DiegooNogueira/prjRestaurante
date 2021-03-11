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
    public partial class FormFichaItemProduto : Form
    {
        public FormFichaItemProduto()
        {
            InitializeComponent();
        }

        internal modelo.cardapio Registro { get; set; }

        private void FormFichaItemProduto_Load(object sender, EventArgs e)
        {
            lbIdCardapio.Text = Registro.idcardapio.ToString();
            lbDescricao.Text = Registro.descricao;

            controle.Item_CardapioDB tabela = new controle.Item_CardapioDB();
            tabela.consultar(bs);
            lbidItemCardapio.DataBindings.Add(new Binding("Text", bs, "idproduto"));
            lbDescricaoProduto.DataBindings.Add(new Binding("Text", bs, "produto.nome"));

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pesquisa.FormPesquisaProduto pesquisa = new pesquisa.FormPesquisaProduto();
            pesquisa.ShowDialog();


            if (pesquisa.Codigo != 0)
            {
                controle.Item_CardapioDB tabela = new controle.Item_CardapioDB();

                modelo.item_cardapio item = new modelo.item_cardapio
                {
                    item_cardapio1 = tabela.ProximoCodigo(),
                    idproduto = pesquisa.Codigo,
                    idcardapio = Registro.idcardapio
                };

                tabela.inserir(item);
                tabela.consultar(bs);
                bs.ResetBindings(false);
                bs.MoveLast();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pesquisa.FormPesquisaProduto pesquisa = new pesquisa.FormPesquisaProduto();
            pesquisa.ShowDialog();

            if (pesquisa.Codigo != 0)
            {
                controle.Item_CardapioDB tabela = new controle.Item_CardapioDB();
                modelo.item_cardapio item = (modelo.item_cardapio)bs.Current;
                item.idproduto = pesquisa.Codigo;
                item.idcardapio = Registro.idcardapio;
                tabela.editar(item);
                tabela.consultar(bs);
                bs.ResetBindings(false);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            controle.Item_CardapioDB tabela = new controle.Item_CardapioDB();
            modelo.item_cardapio item = (modelo.item_cardapio)bs.Current;
            tabela.excluir(item.item_cardapio1);
            bs.RemoveCurrent();
            bs.ResetBindings(false);
        }
    }
}
