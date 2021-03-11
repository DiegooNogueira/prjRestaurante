using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restauranteDBTB.report
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }



        internal string arquivo {get;set;}
        internal DataSet Ds { get; set; }


        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            try
            {
               report.LocalReport.DataSources.Clear();
               ReportDataSource source = null;
               source = new ReportDataSource(Ds.DataSetName, Ds.Tables[0]);
               report.LocalReport.ReportPath = @arquivo;
               report.LocalReport.DataSources.Add(source);
               report.DocumentMapCollapsed = false;
               report.ProcessingMode = ProcessingMode.Local;
               report.RefreshReport();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao abrir o relatório:" + erro.Message,
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
