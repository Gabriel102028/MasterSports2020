namespace MasterSports
{
    partial class formrelfuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formrelfuncionario));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classfuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbfeminino = new System.Windows.Forms.RadioButton();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.btsair = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbcidade = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtate = new System.Windows.Forms.TextBox();
            this.txtde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmes = new System.Windows.Forms.ComboBox();
            this.cbdia = new System.Windows.Forms.ComboBox();
            this.btgerar = new System.Windows.Forms.Button();
            this.cbopcoesp = new System.Windows.Forms.ComboBox();
            this.reportViewerfuncio = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classfuncionarioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // classfuncionarioBindingSource
            // 
            this.classfuncionarioBindingSource.DataSource = typeof(MasterSports.classfuncionario);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btsair);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btgerar);
            this.groupBox1.Controls.Add(this.cbopcoesp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatorio Funcionario";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbfeminino);
            this.groupBox6.Controls.Add(this.rbmasculino);
            this.groupBox6.Location = new System.Drawing.Point(712, 112);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(111, 89);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sexo";
            // 
            // rbfeminino
            // 
            this.rbfeminino.AutoSize = true;
            this.rbfeminino.Location = new System.Drawing.Point(6, 61);
            this.rbfeminino.Name = "rbfeminino";
            this.rbfeminino.Size = new System.Drawing.Size(89, 20);
            this.rbfeminino.TabIndex = 1;
            this.rbfeminino.TabStop = true;
            this.rbfeminino.Text = "Feminino";
            this.rbfeminino.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(6, 31);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(96, 20);
            this.rbmasculino.TabIndex = 0;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbinativo);
            this.groupBox5.Controls.Add(this.rbativo);
            this.groupBox5.Location = new System.Drawing.Point(624, 112);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(82, 89);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Status";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(6, 63);
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
            this.rbativo.Location = new System.Drawing.Point(6, 31);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(61, 20);
            this.rbativo.TabIndex = 0;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // btsair
            // 
            this.btsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.Location = new System.Drawing.Point(520, 29);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(141, 59);
            this.btsair.TabIndex = 14;
            this.btsair.Text = "Sair";
            this.btsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbcidade);
            this.groupBox4.Location = new System.Drawing.Point(460, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 89);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cidade";
            // 
            // cbcidade
            // 
            this.cbcidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcidade.FormattingEnabled = true;
            this.cbcidade.Location = new System.Drawing.Point(6, 43);
            this.cbcidade.Name = "cbcidade";
            this.cbcidade.Size = new System.Drawing.Size(133, 24);
            this.cbcidade.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtate);
            this.groupBox3.Controls.Add(this.txtde);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(254, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 94);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Idade";
            // 
            // txtate
            // 
            this.txtate.Location = new System.Drawing.Point(97, 48);
            this.txtate.Multiline = true;
            this.txtate.Name = "txtate";
            this.txtate.Size = new System.Drawing.Size(65, 31);
            this.txtate.TabIndex = 3;
            // 
            // txtde
            // 
            this.txtde.Location = new System.Drawing.Point(17, 48);
            this.txtde.Multiline = true;
            this.txtde.Name = "txtde";
            this.txtde.Size = new System.Drawing.Size(65, 31);
            this.txtde.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "De";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbmes);
            this.groupBox2.Controls.Add(this.cbdia);
            this.groupBox2.Location = new System.Drawing.Point(6, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aniversariantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mês";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dia";
            // 
            // cbmes
            // 
            this.cbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmes.FormattingEnabled = true;
            this.cbmes.Location = new System.Drawing.Point(84, 60);
            this.cbmes.Name = "cbmes";
            this.cbmes.Size = new System.Drawing.Size(121, 24);
            this.cbmes.TabIndex = 2;
            // 
            // cbdia
            // 
            this.cbdia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdia.FormattingEnabled = true;
            this.cbdia.Location = new System.Drawing.Point(84, 21);
            this.cbdia.Name = "cbdia";
            this.cbdia.Size = new System.Drawing.Size(121, 24);
            this.cbdia.TabIndex = 1;
            // 
            // btgerar
            // 
            this.btgerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgerar.Image = ((System.Drawing.Image)(resources.GetObject("btgerar.Image")));
            this.btgerar.Location = new System.Drawing.Point(667, 29);
            this.btgerar.Name = "btgerar";
            this.btgerar.Size = new System.Drawing.Size(141, 59);
            this.btgerar.TabIndex = 13;
            this.btgerar.Text = "Gerar Relatorio";
            this.btgerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btgerar.UseVisualStyleBackColor = true;
            this.btgerar.Click += new System.EventHandler(this.btgerar_Click);
            // 
            // cbopcoesp
            // 
            this.cbopcoesp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopcoesp.FormattingEnabled = true;
            this.cbopcoesp.Location = new System.Drawing.Point(21, 43);
            this.cbopcoesp.Name = "cbopcoesp";
            this.cbopcoesp.Size = new System.Drawing.Size(270, 24);
            this.cbopcoesp.TabIndex = 0;
            this.cbopcoesp.SelectedIndexChanged += new System.EventHandler(this.cbopcoes_SelectedIndexChanged);
            // 
            // reportViewerfuncio
            // 
            this.reportViewerfuncio.DocumentMapWidth = 38;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classfuncionarioBindingSource;
            this.reportViewerfuncio.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerfuncio.LocalReport.ReportEmbeddedResource = "MasterSports.rptrelfuncionario.rdlc";
            this.reportViewerfuncio.Location = new System.Drawing.Point(12, 219);
            this.reportViewerfuncio.Name = "reportViewerfuncio";
            this.reportViewerfuncio.Size = new System.Drawing.Size(829, 282);
            this.reportViewerfuncio.TabIndex = 1;
            // 
            // formrelfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 506);
            this.Controls.Add(this.reportViewerfuncio);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formrelfuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Funcionario";
            this.Load += new System.EventHandler(this.formrelfuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classfuncionarioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbopcoesp;
        private System.Windows.Forms.Button btgerar;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbmes;
        private System.Windows.Forms.ComboBox cbdia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbcidade;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbinativo;
        private System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbfeminino;
        private System.Windows.Forms.RadioButton rbmasculino;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerfuncio;
        private System.Windows.Forms.BindingSource classfuncionarioBindingSource;
    }
}