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
    public partial class FormMesas : Form
    {
        public FormMesas()
        {
            InitializeComponent();
        }

        private void FormMesas_Load(object sender, EventArgs e)
        {
            controle.MesaDB tabela = new controle.MesaDB();
            tabela.consultar(bs);
            lbIdMesa.DataBindings.Add(new Binding("Text", bs, "idmesa"));
            lbVagas.DataBindings.Add(new Binding("Text", bs, "vagas"));
            Binding bStatus = new Binding("Text", bs, "status");
            bStatus.Format += bStatus_Format;
            lbSituacao.DataBindings.Add(bStatus);
        }

        void bStatus_Format(object sender, ConvertEventArgs e)
        {
            string[] array_status = new string[]{
                "0 - A MESA ESTA LIVRE",
                "1 - A MESA ESTA EM USO",
                "2 - A MESA ESTA RESERVADA",
                "3 - A MESA ESTA INDISPONIVEL"
            };

            try
            {
                int numero = Convert.ToInt16(e.Value);
                e.Value = array_status[numero];
            }
            catch (Exception)
            {
                e.Value = "VALOR INVALIDO";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormFichaMesa fichaMesa = new FormFichaMesa();
            fichaMesa.Registro = null;
            fichaMesa.ShowDialog();

            if (fichaMesa.Registro != null)
            {
                controle.MesaDB tabela = new controle.MesaDB();
                tabela.consultar(bs);
                bs.MoveLast();
                bs.ResetBindings(false);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormFichaMesa fichaMesa = new FormFichaMesa();
            fichaMesa.Registro = (modelo.mesa)bs.Current;

            fichaMesa.ShowDialog();

            if (fichaMesa.Registro != null)
            {
                controle.MesaDB tabela = new controle.MesaDB();
                tabela.consultar(bs);
                bs.ResetBindings(false);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            DialogResult op;
            modelo.mesa Registro = (modelo.mesa)bs.Current;

            op = MessageBox.Show("Deseja excluir mesa número " + 
                 Registro.idmesa + " ?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (op == DialogResult.Yes)
            {
                controle.MesaDB tabela = new controle.MesaDB();
                tabela.excluir(Registro.idmesa);
                bs.RemoveCurrent();
                bs.ResetBindings(false);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            report.FormRelatorio relatorio = new report.FormRelatorio();
            string pasta = controle.Registro.ler("restaurante", "relatorio");
            relatorio.arquivo = @pasta + @"\rdMesa.rdlc";

            if (!File.Exists(relatorio.arquivo))
            {
                MessageBox.Show("Arquivo RDLC não encontrado!", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            controle.MesaDB tabela = new controle.MesaDB();
            relatorio.Ds = tabela.relatorio();
            relatorio.ShowDialog();
        }

    }
}
