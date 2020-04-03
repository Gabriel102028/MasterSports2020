namespace MasterSports
{
    partial class frmrelatorioproduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrelatorioproduto));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btgerarelatorio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmarca = new System.Windows.Forms.ComboBox();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.txprecoinicial = new System.Windows.Forms.TextBox();
            this.txtprecofinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbstatus = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.gbtipoconsulta = new System.Windows.Forms.GroupBox();
            this.rbcontem = new System.Windows.Forms.RadioButton();
            this.rbinicio = new System.Windows.Forms.RadioButton();
            this.txpesquisa = new System.Windows.Forms.TextBox();
            this.cbopcoes = new System.Windows.Forms.ComboBox();
            this.reportViewerproduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbvalor = new System.Windows.Forms.GroupBox();
            this.btsair = new System.Windows.Forms.Button();
            this.gbpesquisa = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.classprodutoBindingSource)).BeginInit();
            this.gbstatus.SuspendLayout();
            this.gbtipoconsulta.SuspendLayout();
            this.gbvalor.SuspendLayout();
            this.gbpesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // classprodutoBindingSource
            // 
            this.classprodutoBindingSource.DataSource = typeof(MasterSports.classproduto);
            // 
            // btgerarelatorio
            // 
            this.btgerarelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgerarelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btgerarelatorio.Image")));
            this.btgerarelatorio.Location = new System.Drawing.Point(744, 162);
            this.btgerarelatorio.Name = "btgerarelatorio";
            this.btgerarelatorio.Size = new System.Drawing.Size(136, 57);
            this.btgerarelatorio.TabIndex = 10;
            this.btgerarelatorio.Text = "Gerar Relatorio";
            this.btgerarelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btgerarelatorio.UseVisualStyleBackColor = true;
            this.btgerarelatorio.Click += new System.EventHandler(this.btgerarelatorio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categoria";
            // 
            // cbmarca
            // 
            this.cbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmarca.FormattingEnabled = true;
            this.cbmarca.Location = new System.Drawing.Point(95, 61);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(121, 24);
            this.cbmarca.TabIndex = 6;
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(95, 25);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(121, 24);
            this.cbcategoria.TabIndex = 5;
            // 
            // txprecoinicial
            // 
            this.txprecoinicial.Location = new System.Drawing.Point(110, 21);
            this.txprecoinicial.Multiline = true;
            this.txprecoinicial.Name = "txprecoinicial";
            this.txprecoinicial.Size = new System.Drawing.Size(90, 23);
            this.txprecoinicial.TabIndex = 7;
            // 
            // txtprecofinal
            // 
            this.txtprecofinal.Location = new System.Drawing.Point(110, 63);
            this.txtprecofinal.Multiline = true;
            this.txtprecofinal.Name = "txtprecofinal";
            this.txtprecofinal.Size = new System.Drawing.Size(90, 23);
            this.txtprecofinal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preço Inicial";
            // 
            // gbstatus
            // 
            this.gbstatus.Controls.Add(this.rbinativo);
            this.gbstatus.Controls.Add(this.rbativo);
            this.gbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbstatus.Location = new System.Drawing.Point(605, 96);
            this.gbstatus.Name = "gbstatus";
            this.gbstatus.Size = new System.Drawing.Size(265, 60);
            this.gbstatus.TabIndex = 3;
            this.gbstatus.TabStop = false;
            this.gbstatus.Text = "Status";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(115, 23);
            this.rbinativo.Name = "rbinativo";
            this.rbinativo.Size = new System.Drawing.Size(72, 20);
            this.rbinativo.TabIndex = 1;
            this.rbinativo.TabStop = true;
            this.rbinativo.Text = "Inativo";
            this.rbinativo.UseVisualStyleBackColor = true;
            // 
            // rbativo
            // 
            this.rbativo.AutoSize = true;
            this.rbativo.Location = new System.Drawing.Point(28, 24);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(61, 20);
            this.rbativo.TabIndex = 0;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // gbtipoconsulta
            // 
            this.gbtipoconsulta.Controls.Add(this.rbcontem);
            this.gbtipoconsulta.Controls.Add(this.rbinicio);
            this.gbtipoconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtipoconsulta.Location = new System.Drawing.Point(605, 21);
            this.gbtipoconsulta.Name = "gbtipoconsulta";
            this.gbtipoconsulta.Size = new System.Drawing.Size(265, 69);
            this.gbtipoconsulta.TabIndex = 2;
            this.gbtipoconsulta.TabStop = false;
            this.gbtipoconsulta.Text = "Tipo de Consulta";
            // 
            // rbcontem
            // 
            this.rbcontem.AutoSize = true;
            this.rbcontem.Location = new System.Drawing.Point(109, 31);
            this.rbcontem.Name = "rbcontem";
            this.rbcontem.Size = new System.Drawing.Size(78, 20);
            this.rbcontem.TabIndex = 1;
            this.rbcontem.TabStop = true;
            this.rbcontem.Text = "Contém";
            this.rbcontem.UseVisualStyleBackColor = true;
            // 
            // rbinicio
            // 
            this.rbinicio.AutoSize = true;
            this.rbinicio.Location = new System.Drawing.Point(26, 31);
            this.rbinicio.Name = "rbinicio";
            this.rbinicio.Size = new System.Drawing.Size(63, 20);
            this.rbinicio.TabIndex = 0;
            this.rbinicio.TabStop = true;
            this.rbinicio.Text = "Inicio";
            this.rbinicio.UseVisualStyleBackColor = true;
            // 
            // txpesquisa
            // 
            this.txpesquisa.Location = new System.Drawing.Point(319, 34);
            this.txpesquisa.Multiline = true;
            this.txpesquisa.Name = "txpesquisa";
            this.txpesquisa.Size = new System.Drawing.Size(270, 24);
            this.txpesquisa.TabIndex = 1;
            // 
            // cbopcoes
            // 
            this.cbopcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopcoes.FormattingEnabled = true;
            this.cbopcoes.Location = new System.Drawing.Point(21, 34);
            this.cbopcoes.Name = "cbopcoes";
            this.cbopcoes.Size = new System.Drawing.Size(275, 24);
            this.cbopcoes.TabIndex = 0;
            this.cbopcoes.SelectedIndexChanged += new System.EventHandler(this.cbopcoes_SelectedIndexChanged);
            // 
            // reportViewerproduto
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classprodutoBindingSource;
            this.reportViewerproduto.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerproduto.LocalReport.ReportEmbeddedResource = "MasterSports.rptproduto.rdlc";
            this.reportViewerproduto.Location = new System.Drawing.Point(12, 228);
            this.reportViewerproduto.Name = "reportViewerproduto";
            this.reportViewerproduto.Size = new System.Drawing.Size(868, 375);
            this.reportViewerproduto.TabIndex = 1;
            // 
            // gbvalor
            // 
            this.gbvalor.Controls.Add(this.txprecoinicial);
            this.gbvalor.Controls.Add(this.label2);
            this.gbvalor.Controls.Add(this.txtprecofinal);
            this.gbvalor.Controls.Add(this.label1);
            this.gbvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbvalor.Location = new System.Drawing.Point(21, 75);
            this.gbvalor.Name = "gbvalor";
            this.gbvalor.Size = new System.Drawing.Size(250, 117);
            this.gbvalor.TabIndex = 13;
            this.gbvalor.TabStop = false;
            this.gbvalor.Text = "Valor";
            // 
            // btsair
            // 
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.Location = new System.Drawing.Point(605, 162);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(133, 57);
            this.btsair.TabIndex = 14;
            this.btsair.Text = "Sair";
            this.btsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click_1);
            // 
            // gbpesquisa
            // 
            this.gbpesquisa.Controls.Add(this.label3);
            this.gbpesquisa.Controls.Add(this.cbcategoria);
            this.gbpesquisa.Controls.Add(this.label4);
            this.gbpesquisa.Controls.Add(this.cbmarca);
            this.gbpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpesquisa.Location = new System.Drawing.Point(314, 95);
            this.gbpesquisa.Name = "gbpesquisa";
            this.gbpesquisa.Size = new System.Drawing.Size(275, 97);
            this.gbpesquisa.TabIndex = 15;
            this.gbpesquisa.TabStop = false;
            this.gbpesquisa.Text = "Pesquisa";
            // 
            // frmrelatorioproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 603);
            this.ControlBox = false;
            this.Controls.Add(this.gbpesquisa);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.gbvalor);
            this.Controls.Add(this.btgerarelatorio);
            this.Controls.Add(this.gbstatus);
            this.Controls.Add(this.reportViewerproduto);
            this.Controls.Add(this.cbopcoes);
            this.Controls.Add(this.txpesquisa);
            this.Controls.Add(this.gbtipoconsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmrelatorioproduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Produto";
            this.Load += new System.EventHandler(this.frmrelatorioproduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classprodutoBindingSource)).EndInit();
            this.gbstatus.ResumeLayout(false);
            this.gbstatus.PerformLayout();
            this.gbtipoconsulta.ResumeLayout(false);
            this.gbtipoconsulta.PerformLayout();
            this.gbvalor.ResumeLayout(false);
            this.gbvalor.PerformLayout();
            this.gbpesquisa.ResumeLayout(false);
            this.gbpesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerproduto;
        private System.Windows.Forms.ComboBox cbopcoes;
        private System.Windows.Forms.TextBox txpesquisa;
        private System.Windows.Forms.GroupBox gbtipoconsulta;
        private System.Windows.Forms.GroupBox gbstatus;
        private System.Windows.Forms.RadioButton rbinativo;
        private System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.RadioButton rbcontem;
        private System.Windows.Forms.RadioButton rbinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txprecoinicial;
        private System.Windows.Forms.TextBox txtprecofinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmarca;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Button btgerarelatorio;
        private System.Windows.Forms.BindingSource classprodutoBindingSource;
        private System.Windows.Forms.GroupBox gbvalor;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.GroupBox gbpesquisa;
    }
}