namespace restauranteDBTB.visao
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnCardapio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMesa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConfRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConfCorFundo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConfImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConexao = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnSuperior.SuspendLayout();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.pnSuperior.Controls.Add(this.label1);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSuperior.Location = new System.Drawing.Point(232, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(1046, 68);
            this.pnSuperior.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1046, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROLE DE RESTAURANTE V 1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCardapio,
            this.mnProduto,
            this.mnMesa,
            this.mnUsuarios,
            this.mnConfRelatorio,
            this.mnConfCorFundo,
            this.mnConfImage,
            this.mnSair});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(232, 773);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // mnCardapio
            // 
            this.mnCardapio.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnCardapio.Image = ((System.Drawing.Image)(resources.GetObject("mnCardapio.Image")));
            this.mnCardapio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnCardapio.ImageTransparentColor = System.Drawing.Color.White;
            this.mnCardapio.Name = "mnCardapio";
            this.mnCardapio.Padding = new System.Windows.Forms.Padding(10);
            this.mnCardapio.Size = new System.Drawing.Size(219, 95);
            this.mnCardapio.Text = "CARDAPIO";
            this.mnCardapio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnCardapio.Click += new System.EventHandler(this.mnCardapio_Click);
            // 
            // mnProduto
            // 
            this.mnProduto.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnProduto.Image = ((System.Drawing.Image)(resources.GetObject("mnProduto.Image")));
            this.mnProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnProduto.ImageTransparentColor = System.Drawing.Color.White;
            this.mnProduto.Name = "mnProduto";
            this.mnProduto.Padding = new System.Windows.Forms.Padding(10);
            this.mnProduto.Size = new System.Drawing.Size(219, 95);
            this.mnProduto.Text = "PRODUTOS";
            this.mnProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnProduto.Click += new System.EventHandler(this.mnProduto_Click);
            // 
            // mnMesa
            // 
            this.mnMesa.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnMesa.Image = ((System.Drawing.Image)(resources.GetObject("mnMesa.Image")));
            this.mnMesa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnMesa.ImageTransparentColor = System.Drawing.Color.White;
            this.mnMesa.Name = "mnMesa";
            this.mnMesa.Padding = new System.Windows.Forms.Padding(10);
            this.mnMesa.Size = new System.Drawing.Size(219, 95);
            this.mnMesa.Text = "MESAS";
            this.mnMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnMesa.Click += new System.EventHandler(this.mnMesa_Click);
            // 
            // mnUsuarios
            // 
            this.mnUsuarios.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("mnUsuarios.Image")));
            this.mnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnUsuarios.ImageTransparentColor = System.Drawing.Color.White;
            this.mnUsuarios.Name = "mnUsuarios";
            this.mnUsuarios.Padding = new System.Windows.Forms.Padding(10);
            this.mnUsuarios.Size = new System.Drawing.Size(219, 95);
            this.mnUsuarios.Text = "USUARIOS";
            this.mnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnUsuarios.Click += new System.EventHandler(this.mnUsuarios_Click);
            // 
            // mnConfRelatorio
            // 
            this.mnConfRelatorio.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnConfRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("mnConfRelatorio.Image")));
            this.mnConfRelatorio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnConfRelatorio.ImageTransparentColor = System.Drawing.Color.White;
            this.mnConfRelatorio.Name = "mnConfRelatorio";
            this.mnConfRelatorio.Padding = new System.Windows.Forms.Padding(10);
            this.mnConfRelatorio.Size = new System.Drawing.Size(219, 95);
            this.mnConfRelatorio.Text = "CONF RELATORIO";
            this.mnConfRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnConfRelatorio.Click += new System.EventHandler(this.mnConfRelatorio_Click);
            // 
            // mnConfCorFundo
            // 
            this.mnConfCorFundo.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnConfCorFundo.Image = ((System.Drawing.Image)(resources.GetObject("mnConfCorFundo.Image")));
            this.mnConfCorFundo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnConfCorFundo.ImageTransparentColor = System.Drawing.Color.White;
            this.mnConfCorFundo.Name = "mnConfCorFundo";
            this.mnConfCorFundo.Padding = new System.Windows.Forms.Padding(10);
            this.mnConfCorFundo.Size = new System.Drawing.Size(219, 88);
            this.mnConfCorFundo.Text = "CONF COR FUNDO";
            this.mnConfCorFundo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnConfCorFundo.Click += new System.EventHandler(this.mnConfCorFundo_Click);
            // 
            // mnConfImage
            // 
            this.mnConfImage.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnConfImage.Image = ((System.Drawing.Image)(resources.GetObject("mnConfImage.Image")));
            this.mnConfImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnConfImage.ImageTransparentColor = System.Drawing.Color.White;
            this.mnConfImage.Name = "mnConfImage";
            this.mnConfImage.Padding = new System.Windows.Forms.Padding(10);
            this.mnConfImage.Size = new System.Drawing.Size(219, 85);
            this.mnConfImage.Text = "CONF IMG FUNDO";
            this.mnConfImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnConfImage.Click += new System.EventHandler(this.mnConfImage_Click);
            // 
            // mnSair
            // 
            this.mnSair.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnSair.Image = ((System.Drawing.Image)(resources.GetObject("mnSair.Image")));
            this.mnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnSair.ImageTransparentColor = System.Drawing.Color.White;
            this.mnSair.Name = "mnSair";
            this.mnSair.Padding = new System.Windows.Forms.Padding(10);
            this.mnSair.Size = new System.Drawing.Size(219, 95);
            this.mnSair.Text = "SAIR";
            this.mnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnSair.Click += new System.EventHandler(this.mnSair_Click);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblConexao});
            this.status.Location = new System.Drawing.Point(232, 731);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1046, 42);
            this.status.TabIndex = 4;
            this.status.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = false;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(300, 37);
            this.lblUsuario.Text = "USUÁRIO: ";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConexao
            // 
            this.lblConexao.AutoSize = false;
            this.lblConexao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexao.ForeColor = System.Drawing.Color.Red;
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(600, 37);
            this.lblConexao.Text = "Conexão:";
            this.lblConexao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1278, 773);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "FormPrincipal";
            this.Text = "RESTAURANTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnSuperior.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnCardapio;
        private System.Windows.Forms.ToolStripMenuItem mnProduto;
        private System.Windows.Forms.ToolStripMenuItem mnMesa;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
        private System.Windows.Forms.ToolStripMenuItem mnUsuarios;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblConexao;
        private System.Windows.Forms.ToolStripMenuItem mnConfRelatorio;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnConfCorFundo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnConfImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}