namespace restauranteDBTB.visao
{
    partial class FormFichaProduto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFichaProduto));
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lnkNovoTipo = new System.Windows.Forms.LinkLabel();
            this.lnkEditarTipo = new System.Windows.Forms.LinkLabel();
            this.lnkExcluirTIpo = new System.Windows.Forms.LinkLabel();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.pnSuperior.Controls.Add(this.lbTitulo);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(797, 97);
            this.pnSuperior.TabIndex = 1;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitulo.Font = new System.Drawing.Font("Verdana", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(797, 85);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "FICHA PRODUTO";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "DESCRIÇÃO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "PREÇO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "CATEGORIA:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(224, 149);
            this.txtDescricao.MaxLength = 45;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(543, 36);
            this.txtDescricao.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(224, 245);
            this.txtPreco.Mask = "$999.99";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(543, 36);
            this.txtPreco.TabIndex = 4;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(224, 346);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(543, 36);
            this.cbCategoria.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(410, 423);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(357, 139);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "GRAVAR FICHA";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(28, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(357, 139);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 500;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // lnkNovoTipo
            // 
            this.lnkNovoTipo.AutoSize = true;
            this.lnkNovoTipo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNovoTipo.LinkColor = System.Drawing.Color.White;
            this.lnkNovoTipo.Location = new System.Drawing.Point(518, 323);
            this.lnkNovoTipo.Name = "lnkNovoTipo";
            this.lnkNovoTipo.Size = new System.Drawing.Size(56, 20);
            this.lnkNovoTipo.TabIndex = 7;
            this.lnkNovoTipo.TabStop = true;
            this.lnkNovoTipo.Text = "novo";
            this.lnkNovoTipo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNovoTipo_LinkClicked);
            // 
            // lnkEditarTipo
            // 
            this.lnkEditarTipo.AutoSize = true;
            this.lnkEditarTipo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEditarTipo.LinkColor = System.Drawing.Color.White;
            this.lnkEditarTipo.Location = new System.Drawing.Point(602, 323);
            this.lnkEditarTipo.Name = "lnkEditarTipo";
            this.lnkEditarTipo.Size = new System.Drawing.Size(65, 20);
            this.lnkEditarTipo.TabIndex = 7;
            this.lnkEditarTipo.TabStop = true;
            this.lnkEditarTipo.Text = "editar";
            this.lnkEditarTipo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditarTipo_LinkClicked);
            // 
            // lnkExcluirTIpo
            // 
            this.lnkExcluirTIpo.AutoSize = true;
            this.lnkExcluirTIpo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkExcluirTIpo.LinkColor = System.Drawing.Color.White;
            this.lnkExcluirTIpo.Location = new System.Drawing.Point(692, 323);
            this.lnkExcluirTIpo.Name = "lnkExcluirTIpo";
            this.lnkExcluirTIpo.Size = new System.Drawing.Size(73, 20);
            this.lnkExcluirTIpo.TabIndex = 7;
            this.lnkExcluirTIpo.TabStop = true;
            this.lnkExcluirTIpo.Text = "excluir";
            this.lnkExcluirTIpo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExcluirTIpo_LinkClicked);
            // 
            // FormFichaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(797, 583);
            this.Controls.Add(this.lnkExcluirTIpo);
            this.Controls.Add(this.lnkEditarTipo);
            this.Controls.Add(this.lnkNovoTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnSuperior);
            this.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFichaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FICHA";
            this.Load += new System.EventHandler(this.FormFichaProduto_Load);
            this.pnSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.MaskedTextBox txtPreco;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel lnkExcluirTIpo;
        private System.Windows.Forms.LinkLabel lnkEditarTipo;
        private System.Windows.Forms.LinkLabel lnkNovoTipo;
    }
}