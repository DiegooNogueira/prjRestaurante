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
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            barra.Maximum = 100;
            barra.Minimum = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barra.Increment(1);
            lbAcao.Text = "Incializando: " + barra.Value + " %";

            if (barra.Value > 90)
            {
                lbAcao.Text += "(Quase concluido)";
            }

            if (barra.Value == 100)
            {
                lbAcao.Text = "Sistema pronto para uso "; 
                this.Cursor = Cursors.Default;
                timer1.Stop();
            }
        }
    }
}
