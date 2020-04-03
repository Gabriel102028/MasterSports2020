namespace MasterSports
{
    partial class frmrelatoriocliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrelatoriocliente));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txidadede = new System.Windows.Forms.TextBox();
            this.txidadeate = new System.Windows.Forms.TextBox();
            this.gbaniversariantes = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmes = new System.Windows.Forms.ComboBox();
            this.cbdia = new System.Windows.Forms.ComboBox();
            this.gbidade = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbstatus = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.gbsexo = new System.Windows.Forms.GroupBox();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.gbcidade = new System.Windows.Forms.GroupBox();
            this.cbcidade = new System.Windows.Forms.ComboBox();
            this.btgerarelatorio = new System.Windows.Forms.Button();
            this.reportViewercliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbopcoes = new System.Windows.Forms.ComboBox();
            this.btsair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.classclienteBindingSource)).BeginInit();
            this.gbaniversariantes.SuspendLayout();
            this.gbidade.SuspendLayout();
            this.gbstatus.SuspendLayout();
            this.gbsexo.SuspendLayout();
            this.gbcidade.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txidadede
            // 
            this.txidadede.Location = new System.Drawing.Point(6, 59);
            this.txidadede.Multiline = true;
            this.txidadede.Name = "txidadede";
            this.txidadede.Size = new System.Drawing.Size(68, 32);
            this.txidadede.TabIndex = 1;
            // 
            // txidadeate
            // 
            this.txidadeate.Location = new System.Drawing.Point(99, 60);
            this.txidadeate.Multiline = true;
            this.txidadeate.Name = "txidadeate";
            this.txidadeate.Size = new System.Drawing.Size(68, 31);
            this.txidadeate.TabIndex = 2;
            // 
            // gbaniversariantes
            // 
            this.gbaniversariantes.Controls.Add(this.label5);
            this.gbaniversariantes.Controls.Add(this.label4);
            this.gbaniversariantes.Controls.Add(this.cbmes);
            this.gbaniversariantes.Controls.Add(this.cbdia);
            this.gbaniversariantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbaniversariantes.Location = new System.Drawing.Point(6, 106);
            this.gbaniversariantes.Name = "gbaniversariantes";
            this.gbaniversariantes.Size = new System.Drawing.Size(248, 116);
            this.gbaniversariantes.TabIndex = 3;
            this.gbaniversariantes.TabStop = false;
            this.gbaniversariantes.Text = "Aniversariantes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mês";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dia";
            // 
            // cbmes
            // 
            this.cbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmes.FormattingEnabled = true;
            this.cbmes.Location = new System.Drawing.Point(85, 67);
            this.cbmes.Name = "cbmes";
            this.cbmes.Size = new System.Drawing.Size(121, 24);
            this.cbmes.TabIndex = 9;
            // 
            // cbdia
            // 
            this.cbdia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdia.FormattingEnabled = true;
            this.cbdia.Location = new System.Drawing.Point(85, 28);
            this.cbdia.Name = "cbdia";
            this.cbdia.Size = new System.Drawing.Size(121, 24);
            this.cbdia.TabIndex = 8;
            // 
            // gbidade
            // 
            this.gbidade.Controls.Add(this.label3);
            this.gbidade.Controls.Add(this.label2);
            this.gbidade.Controls.Add(this.txidadede);
            this.gbidade.Controls.Add(this.txidadeate);
            this.gbidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbidade.Location = new System.Drawing.Point(260, 106);
            this.gbidade.Name = "gbidade";
            this.gbidade.Size = new System.Drawing.Size(186, 116);
            this.gbidade.TabIndex = 4;
            this.gbidade.TabStop = false;
            this.gbidade.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Até";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "De";
            // 
            // gbstatus
            // 
            this.gbstatus.Controls.Add(this.rbinativo);
            this.gbstatus.Controls.Add(this.rbativo);
            this.gbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbstatus.Location = new System.Drawing.Point(640, 106);
            this.gbstatus.Name = "gbstatus";
            this.gbstatus.Size = new System.Drawing.Size(92, 116);
            this.gbstatus.TabIndex = 5;
            this.gbstatus.TabStop = false;
            this.gbstatus.Text = "Status";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(6, 71);
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
            this.rbativo.Location = new System.Drawing.Point(6, 34);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(61, 20);
            this.rbativo.TabIndex = 0;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // gbsexo
            // 
            this.gbsexo.Controls.Add(this.rbfemenino);
            this.gbsexo.Controls.Add(this.rbmasculino);
            this.gbsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsexo.Location = new System.Drawing.Point(733, 106);
            this.gbsexo.Name = "gbsexo";
            this.gbsexo.Size = new System.Drawing.Size(117, 116);
            this.gbsexo.TabIndex = 6;
            this.gbsexo.TabStop = false;
            this.gbsexo.Text = "Sexo";
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Location = new System.Drawing.Point(17, 71);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(89, 20);
            this.rbfemenino.TabIndex = 2;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Feminino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(17, 34);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(96, 20);
            this.rbmasculino.TabIndex = 1;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // gbcidade
            // 
            this.gbcidade.Controls.Add(this.cbcidade);
            this.gbcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcidade.Location = new System.Drawing.Point(452, 106);
            this.gbcidade.Name = "gbcidade";
            this.gbcidade.Size = new System.Drawing.Size(182, 116);
            this.gbcidade.TabIndex = 7;
            this.gbcidade.TabStop = false;
            this.gbcidade.Text = "Cidade";
            // 
            // cbcidade
            // 
            this.cbcidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcidade.FormattingEnabled = true;
            this.cbcidade.Location = new System.Drawing.Point(16, 48);
            this.cbcidade.Name = "cbcidade";
            this.cbcidade.Size = new System.Drawing.Size(149, 24);
            this.cbcidade.TabIndex = 10;
            // 
            // btgerarelatorio
            // 
            this.btgerarelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgerarelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btgerarelatorio.Image")));
            this.btgerarelatorio.Location = new System.Drawing.Point(709, 29);
            this.btgerarelatorio.Name = "btgerarelatorio";
            this.btgerarelatorio.Size = new System.Drawing.Size(141, 57);
            this.btgerarelatorio.TabIndex = 8;
            this.btgerarelatorio.Text = "Gerar Relatorio";
            this.btgerarelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btgerarelatorio.UseVisualStyleBackColor = true;
            this.btgerarelatorio.Click += new System.EventHandler(this.btgerarelatorio_Click);
            // 
            // reportViewercliente
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classclienteBindingSource;
            this.reportViewercliente.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewercliente.LocalReport.ReportEmbeddedResource = "MasterSports.Rptcliente.rdlc";
            this.reportViewercliente.Location = new System.Drawing.Point(12, 248);
            this.reportViewercliente.Name = "reportViewercliente";
            this.reportViewercliente.Size = new System.Drawing.Size(856, 345);
            this.reportViewercliente.TabIndex = 9;
            // 
            // cbopcoes
            // 
            this.cbopcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopcoes.FormattingEnabled = true;
            this.cbopcoes.Location = new System.Drawing.Point(25, 29);
            this.cbopcoes.Name = "cbopcoes";
            this.cbopcoes.Size = new System.Drawing.Size(286, 24);
            this.cbopcoes.TabIndex = 10;
            this.cbopcoes.SelectedIndexChanged += new System.EventHandler(this.cbopcoes_SelectedIndexChanged);
            // 
            // btsair
            // 
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.Location = new System.Drawing.Point(564, 29);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(139, 57);
            this.btsair.TabIndex = 11;
            this.btsair.Text = "Sair";
            this.btsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbopcoes);
            this.groupBox1.Controls.Add(this.btsair);
            this.groupBox1.Controls.Add(this.gbcidade);
            this.groupBox1.Controls.Add(this.gbsexo);
            this.groupBox1.Controls.Add(this.btgerarelatorio);
            this.groupBox1.Controls.Add(this.gbstatus);
            this.groupBox1.Controls.Add(this.gbaniversariantes);
            this.groupBox1.Controls.Add(this.gbidade);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 237);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatorio Cliente";
            // 
            // frmrelatoriocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 597);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewercliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmrelatoriocliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Cliente";
            this.Load += new System.EventHandler(this.frmrelatoriocliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classclienteBindingSource)).EndInit();
            this.gbaniversariantes.ResumeLayout(false);
            this.gbaniversariantes.PerformLayout();
            this.gbidade.ResumeLayout(false);
            this.gbidade.PerformLayout();
            this.gbstatus.ResumeLayout(false);
            this.gbstatus.PerformLayout();
            this.gbsexo.ResumeLayout(false);
            this.gbsexo.PerformLayout();
            this.gbcidade.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txidadede;
        private System.Windows.Forms.TextBox txidadeate;
        private System.Windows.Forms.GroupBox gbaniversariantes;
        private System.Windows.Forms.GroupBox gbidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbstatus;
        private System.Windows.Forms.RadioButton rbinativo;
        private System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.GroupBox gbsexo;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.GroupBox gbcidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmes;
        private System.Windows.Forms.ComboBox cbdia;
        private System.Windows.Forms.ComboBox cbcidade;
        private System.Windows.Forms.Button btgerarelatorio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewercliente;
        private System.Windows.Forms.ComboBox cbopcoes;
        private System.Windows.Forms.BindingSource classclienteBindingSource;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}