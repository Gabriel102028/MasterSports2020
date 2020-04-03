namespace MasterSports
{
    partial class Formconsfuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formconsfuncionario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbcpf = new System.Windows.Forms.GroupBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.gbstatus = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.gbsexo = new System.Windows.Forms.GroupBox();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewconfunci = new System.Windows.Forms.DataGridView();
            this.gbtipopesquisa = new System.Windows.Forms.GroupBox();
            this.rbcontem = new System.Windows.Forms.RadioButton();
            this.rbinicio = new System.Windows.Forms.RadioButton();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.cbpesquisa = new System.Windows.Forms.ComboBox();
            this.bteditar = new System.Windows.Forms.Button();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbcpf.SuspendLayout();
            this.gbstatus.SuspendLayout();
            this.gbsexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewconfunci)).BeginInit();
            this.gbtipopesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbcpf);
            this.groupBox1.Controls.Add(this.gbstatus);
            this.groupBox1.Controls.Add(this.gbsexo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dataGridViewconfunci);
            this.groupBox1.Controls.Add(this.gbtipopesquisa);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.cbpesquisa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Consulta";
            // 
            // gbcpf
            // 
            this.gbcpf.Controls.Add(this.txtcpf);
            this.gbcpf.Location = new System.Drawing.Point(18, 105);
            this.gbcpf.Name = "gbcpf";
            this.gbcpf.Size = new System.Drawing.Size(187, 78);
            this.gbcpf.TabIndex = 59;
            this.gbcpf.TabStop = false;
            this.gbcpf.Text = "CPF";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(16, 37);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(153, 22);
            this.txtcpf.TabIndex = 60;
            // 
            // gbstatus
            // 
            this.gbstatus.Controls.Add(this.rbinativo);
            this.gbstatus.Controls.Add(this.rbativo);
            this.gbstatus.Location = new System.Drawing.Point(457, 101);
            this.gbstatus.Name = "gbstatus";
            this.gbstatus.Size = new System.Drawing.Size(249, 82);
            this.gbstatus.TabIndex = 58;
            this.gbstatus.TabStop = false;
            this.gbstatus.Text = "Status";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(105, 43);
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
            this.rbativo.Location = new System.Drawing.Point(18, 43);
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
            this.gbsexo.Location = new System.Drawing.Point(221, 101);
            this.gbsexo.Name = "gbsexo";
            this.gbsexo.Size = new System.Drawing.Size(219, 82);
            this.gbsexo.TabIndex = 57;
            this.gbsexo.TabStop = false;
            this.gbsexo.Text = "Sexo";
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Location = new System.Drawing.Point(120, 43);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(94, 20);
            this.rbfemenino.TabIndex = 1;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Femenino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(18, 43);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(96, 20);
            this.rbmasculino.TabIndex = 0;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(77, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(588, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Para Atualizar ou Excluir um Cliente selecione um Produto e clique no Botão Edita" +
    "r !!";
            // 
            // dataGridViewconfunci
            // 
            this.dataGridViewconfunci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewconfunci.Location = new System.Drawing.Point(18, 227);
            this.dataGridViewconfunci.Name = "dataGridViewconfunci";
            this.dataGridViewconfunci.ReadOnly = true;
            this.dataGridViewconfunci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewconfunci.Size = new System.Drawing.Size(708, 174);
            this.dataGridViewconfunci.TabIndex = 3;
            // 
            // gbtipopesquisa
            // 
            this.gbtipopesquisa.Controls.Add(this.rbcontem);
            this.gbtipopesquisa.Controls.Add(this.rbinicio);
            this.gbtipopesquisa.Location = new System.Drawing.Point(457, 20);
            this.gbtipopesquisa.Name = "gbtipopesquisa";
            this.gbtipopesquisa.Size = new System.Drawing.Size(249, 75);
            this.gbtipopesquisa.TabIndex = 2;
            this.gbtipopesquisa.TabStop = false;
            this.gbtipopesquisa.Text = "Tipo de Pesquisa";
            // 
            // rbcontem
            // 
            this.rbcontem.AutoSize = true;
            this.rbcontem.Location = new System.Drawing.Point(105, 36);
            this.rbcontem.Name = "rbcontem";
            this.rbcontem.Size = new System.Drawing.Size(78, 20);
            this.rbcontem.TabIndex = 3;
            this.rbcontem.TabStop = true;
            this.rbcontem.Text = "Contem";
            this.rbcontem.UseVisualStyleBackColor = true;
            // 
            // rbinicio
            // 
            this.rbinicio.AutoSize = true;
            this.rbinicio.Location = new System.Drawing.Point(18, 36);
            this.rbinicio.Name = "rbinicio";
            this.rbinicio.Size = new System.Drawing.Size(63, 20);
            this.rbinicio.TabIndex = 0;
            this.rbinicio.TabStop = true;
            this.rbinicio.Text = "Inicio";
            this.rbinicio.UseVisualStyleBackColor = true;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(221, 52);
            this.txtnome.Multiline = true;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(219, 24);
            this.txtnome.TabIndex = 1;
            // 
            // cbpesquisa
            // 
            this.cbpesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpesquisa.FormattingEnabled = true;
            this.cbpesquisa.Location = new System.Drawing.Point(18, 52);
            this.cbpesquisa.Name = "cbpesquisa";
            this.cbpesquisa.Size = new System.Drawing.Size(187, 24);
            this.cbpesquisa.TabIndex = 0;
            this.cbpesquisa.SelectedIndexChanged += new System.EventHandler(this.cbpesquisa_SelectedIndexChanged);
            // 
            // bteditar
            // 
            this.bteditar.Image = ((System.Drawing.Image)(resources.GetObject("bteditar.Image")));
            this.bteditar.Location = new System.Drawing.Point(12, 434);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(114, 54);
            this.bteditar.TabIndex = 56;
            this.bteditar.Text = "Editar";
            this.bteditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btpesquisar
            // 
            this.btpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btpesquisar.Image")));
            this.btpesquisar.Location = new System.Drawing.Point(151, 434);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(114, 54);
            this.btpesquisar.TabIndex = 57;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // btsair
            // 
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.Location = new System.Drawing.Point(634, 434);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(114, 54);
            this.btsair.TabIndex = 58;
            this.btsair.Text = "Sair";
            this.btsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // Formconsfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formconsfuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Funcionario";
            this.Load += new System.EventHandler(this.Formconsfuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbcpf.ResumeLayout(false);
            this.gbcpf.PerformLayout();
            this.gbstatus.ResumeLayout(false);
            this.gbstatus.PerformLayout();
            this.gbsexo.ResumeLayout(false);
            this.gbsexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewconfunci)).EndInit();
            this.gbtipopesquisa.ResumeLayout(false);
            this.gbtipopesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.ComboBox cbpesquisa;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.GroupBox gbtipopesquisa;
        private System.Windows.Forms.RadioButton rbcontem;
        private System.Windows.Forms.RadioButton rbinicio;
        private System.Windows.Forms.DataGridView dataGridViewconfunci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbsexo;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.GroupBox gbstatus;
        private System.Windows.Forms.RadioButton rbinativo;
        private System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.GroupBox gbcpf;
        private System.Windows.Forms.TextBox txtcpf;
    }
}