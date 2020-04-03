namespace MasterSports
{
    partial class Formconsproduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formconsproduto));
            this.txconsulta = new System.Windows.Forms.TextBox();
            this.cbopcoes = new System.Windows.Forms.ComboBox();
            this.gbprin = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewproduto = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmarca = new System.Windows.Forms.ComboBox();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.gbstatus = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.gbvalores = new System.Windows.Forms.GroupBox();
            this.txprecofinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txprecoinicial = new System.Windows.Forms.TextBox();
            this.gbpesquisa = new System.Windows.Forms.GroupBox();
            this.rbcontem = new System.Windows.Forms.RadioButton();
            this.rbinicio = new System.Windows.Forms.RadioButton();
            this.btsair = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.gbprin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproduto)).BeginInit();
            this.gbstatus.SuspendLayout();
            this.gbvalores.SuspendLayout();
            this.gbpesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // txconsulta
            // 
            this.txconsulta.Location = new System.Drawing.Point(241, 58);
            this.txconsulta.Multiline = true;
            this.txconsulta.Name = "txconsulta";
            this.txconsulta.Size = new System.Drawing.Size(167, 24);
            this.txconsulta.TabIndex = 0;
            // 
            // cbopcoes
            // 
            this.cbopcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopcoes.FormattingEnabled = true;
            this.cbopcoes.Location = new System.Drawing.Point(47, 58);
            this.cbopcoes.Name = "cbopcoes";
            this.cbopcoes.Size = new System.Drawing.Size(158, 24);
            this.cbopcoes.TabIndex = 1;
            this.cbopcoes.SelectedIndexChanged += new System.EventHandler(this.cbopcoes_SelectedIndexChanged);
            // 
            // gbprin
            // 
            this.gbprin.Controls.Add(this.label6);
            this.gbprin.Controls.Add(this.label5);
            this.gbprin.Controls.Add(this.dataGridViewproduto);
            this.gbprin.Controls.Add(this.label4);
            this.gbprin.Controls.Add(this.label3);
            this.gbprin.Controls.Add(this.cbmarca);
            this.gbprin.Controls.Add(this.cbcategoria);
            this.gbprin.Controls.Add(this.gbstatus);
            this.gbprin.Controls.Add(this.gbvalores);
            this.gbprin.Controls.Add(this.gbpesquisa);
            this.gbprin.Controls.Add(this.cbopcoes);
            this.gbprin.Controls.Add(this.txconsulta);
            this.gbprin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbprin.Location = new System.Drawing.Point(12, 12);
            this.gbprin.Name = "gbprin";
            this.gbprin.Size = new System.Drawing.Size(741, 418);
            this.gbprin.TabIndex = 2;
            this.gbprin.TabStop = false;
            this.gbprin.Text = "Selecione um tipo de Consulta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(60, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(594, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Para Atualizar ou Excluir um Produto selecione um Produto e clique no Botão Edita" +
    "r !!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(44, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 53;
            // 
            // dataGridViewproduto
            // 
            this.dataGridViewproduto.AllowUserToAddRows = false;
            this.dataGridViewproduto.AllowUserToDeleteRows = false;
            this.dataGridViewproduto.AllowUserToResizeColumns = false;
            this.dataGridViewproduto.AllowUserToResizeRows = false;
            this.dataGridViewproduto.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewproduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproduto.Location = new System.Drawing.Point(20, 271);
            this.dataGridViewproduto.MultiSelect = false;
            this.dataGridViewproduto.Name = "dataGridViewproduto";
            this.dataGridViewproduto.ReadOnly = true;
            this.dataGridViewproduto.RowHeadersVisible = false;
            this.dataGridViewproduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewproduto.Size = new System.Drawing.Size(715, 141);
            this.dataGridViewproduto.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Categoria";
            // 
            // cbmarca
            // 
            this.cbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmarca.FormattingEnabled = true;
            this.cbmarca.Location = new System.Drawing.Point(293, 215);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(121, 24);
            this.cbmarca.TabIndex = 27;
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(108, 215);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(121, 24);
            this.cbcategoria.TabIndex = 26;
            // 
            // gbstatus
            // 
            this.gbstatus.Controls.Add(this.rbinativo);
            this.gbstatus.Controls.Add(this.rbativo);
            this.gbstatus.Location = new System.Drawing.Point(427, 104);
            this.gbstatus.Name = "gbstatus";
            this.gbstatus.Size = new System.Drawing.Size(244, 81);
            this.gbstatus.TabIndex = 4;
            this.gbstatus.TabStop = false;
            this.gbstatus.Text = "Status";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(100, 49);
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
            this.rbativo.Location = new System.Drawing.Point(18, 49);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(61, 20);
            this.rbativo.TabIndex = 0;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // gbvalores
            // 
            this.gbvalores.Controls.Add(this.txprecofinal);
            this.gbvalores.Controls.Add(this.label2);
            this.gbvalores.Controls.Add(this.label1);
            this.gbvalores.Controls.Add(this.txprecoinicial);
            this.gbvalores.Location = new System.Drawing.Point(20, 104);
            this.gbvalores.Name = "gbvalores";
            this.gbvalores.Size = new System.Drawing.Size(394, 81);
            this.gbvalores.TabIndex = 3;
            this.gbvalores.TabStop = false;
            this.gbvalores.Text = "Valores";
            // 
            // txprecofinal
            // 
            this.txprecofinal.Location = new System.Drawing.Point(298, 44);
            this.txprecofinal.Multiline = true;
            this.txprecofinal.Name = "txprecofinal";
            this.txprecofinal.Size = new System.Drawing.Size(90, 23);
            this.txprecofinal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Peço inicial:";
            // 
            // txprecoinicial
            // 
            this.txprecoinicial.Location = new System.Drawing.Point(105, 44);
            this.txprecoinicial.Multiline = true;
            this.txprecoinicial.Name = "txprecoinicial";
            this.txprecoinicial.Size = new System.Drawing.Size(90, 23);
            this.txprecoinicial.TabIndex = 1;
            // 
            // gbpesquisa
            // 
            this.gbpesquisa.Controls.Add(this.rbcontem);
            this.gbpesquisa.Controls.Add(this.rbinicio);
            this.gbpesquisa.Location = new System.Drawing.Point(427, 21);
            this.gbpesquisa.Name = "gbpesquisa";
            this.gbpesquisa.Size = new System.Drawing.Size(244, 72);
            this.gbpesquisa.TabIndex = 2;
            this.gbpesquisa.TabStop = false;
            this.gbpesquisa.Text = "Tipo de Pesquisa";
            // 
            // rbcontem
            // 
            this.rbcontem.AutoSize = true;
            this.rbcontem.Location = new System.Drawing.Point(100, 38);
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
            this.rbinicio.Location = new System.Drawing.Point(18, 38);
            this.rbinicio.Name = "rbinicio";
            this.rbinicio.Size = new System.Drawing.Size(63, 20);
            this.rbinicio.TabIndex = 0;
            this.rbinicio.TabStop = true;
            this.rbinicio.Text = "Inicio";
            this.rbinicio.UseVisualStyleBackColor = true;
            // 
            // btsair
            // 
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.Location = new System.Drawing.Point(641, 436);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(112, 55);
            this.btsair.TabIndex = 51;
            this.btsair.Text = "Sair";
            this.btsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // bteditar
            // 
            this.bteditar.Image = ((System.Drawing.Image)(resources.GetObject("bteditar.Image")));
            this.bteditar.Location = new System.Drawing.Point(12, 436);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(114, 55);
            this.bteditar.TabIndex = 52;
            this.bteditar.Text = "Editar";
            this.bteditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btpesquisar
            // 
            this.btpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btpesquisar.Image")));
            this.btpesquisar.Location = new System.Drawing.Point(148, 436);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(114, 55);
            this.btpesquisar.TabIndex = 53;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // Formconsproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 505);
            this.ControlBox = false;
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.gbprin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formconsproduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produto";
            this.Load += new System.EventHandler(this.Formconsproduto_Load);
            this.gbprin.ResumeLayout(false);
            this.gbprin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproduto)).EndInit();
            this.gbstatus.ResumeLayout(false);
            this.gbstatus.PerformLayout();
            this.gbvalores.ResumeLayout(false);
            this.gbvalores.PerformLayout();
            this.gbpesquisa.ResumeLayout(false);
            this.gbpesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txconsulta;
        private System.Windows.Forms.ComboBox cbopcoes;
        private System.Windows.Forms.GroupBox gbprin;
        private System.Windows.Forms.GroupBox gbpesquisa;
        private System.Windows.Forms.GroupBox gbstatus;
        private System.Windows.Forms.RadioButton rbinativo;
        private System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.GroupBox gbvalores;
        private System.Windows.Forms.TextBox txprecofinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txprecoinicial;
        private System.Windows.Forms.RadioButton rbcontem;
        private System.Windows.Forms.RadioButton rbinicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmarca;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.DataGridView dataGridViewproduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btpesquisar;
    }
}