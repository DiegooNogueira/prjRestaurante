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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal pai = (FormPrincipal)this.MdiParent;
            pai.produto = null;
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            tabela.consultar(bs);
            Binding bCodigo = new Binding("Text", bs, "idproduto");
            bCodigo.Format += bCodigo_Format;
            lbIdCodProduto.DataBindings.Add(bCodigo);

            lbNomeProduto.DataBindings.Add(new Binding("Text", bs, "nome"));

            Binding bPreco = new Binding("Text", bs, "preco");
            bPreco.Format += bPreco_Format;
            lbPrecoProduto.DataBindings.Add(bPreco);

            lbTipoProduto.DataBindings.Add(new Binding("Text", bs, "tipo.descricao"));
        }

        void bCodigo_Format(object sender, ConvertEventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(e.Value);
                e.Value = cod.ToString().PadLeft(12, '0');
            }
            catch (Exception)
            {

                e.Value = "000000000000";
            }
        }

        void bPreco_Format(object sender, ConvertEventArgs e)
        {
            try
            {
                double preco = Convert.ToDouble(e.Value);
                e.Value = preco.ToString("C2");
            }
            catch (Exception)
            {
                e.Value = "R$ 00,00";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormFichaProduto ficha = new FormFichaProduto();
            ficha.Registro = null;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                controle.ProdutoDB tabela = new controle.ProdutoDB();
                tabela.consultar(bs);
                bs.MoveLast();
                bs.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormFichaProduto ficha = new FormFichaProduto();

            ficha.Registro = (modelo.produto) bs.Current;
            ficha.ShowDialog();

            if (ficha.Registro != null)
            {
                controle.ProdutoDB tabela = new controle.ProdutoDB();
                tabela.consultar(bs);
                bs.ResetBindings(false);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult op;
            modelo.produto Registro = (modelo.produto)bs.Current;

            op = MessageBox.Show("Excluir Produto: " +
                Registro.nome, "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                controle.ProdutoDB tabela = new controle.ProdutoDB();
                tabela.excluir(Registro.idproduto);
                bs.RemoveCurrent();
                bs.ResetBindings(false);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pesquisa.FormPesquisaProduto pesquisa = new pesquisa.FormPesquisaProduto();
            pesquisa.ShowDialog();

            if (pesquisa.Codigo != 0)
            {
                var lista = bs.List.OfType<modelo.produto>().ToList();
                var consulta = lista.Find(reg => reg.idproduto == pesquisa.Codigo);
                bs.Position = bs.IndexOf(consulta);
                btnEdit_Click(sender, e);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            report.FormRelatorio relatorio = new report.FormRelatorio();
            string pasta = controle.Registro.ler("restaurante", "relatorio");
            relatorio.arquivo =  @pasta +  @"\rdProduto.rdlc";

            if (!File.Exists(relatorio.arquivo))
            {
                MessageBox.Show("Arquivo RDLC não encontrado!", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            controle.ProdutoDB tabela = new controle.ProdutoDB();
            relatorio.Ds = tabela.relatorio();
            relatorio.ShowDialog();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            report.FormRelatorio relatorio = new report.FormRelatorio();
            string pasta = controle.Registro.ler("restaurante", "relatorio");
            relatorio.arquivo =@pasta + @"\rdGraficoProduto.rdlc";

            if (!File.Exists(relatorio.arquivo))
            {
                MessageBox.Show("Arquivo RDLC não encontrado!", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            relatorio.Ds = tabela.Grafico();
            relatorio.ShowDialog();
        }
    }
}
