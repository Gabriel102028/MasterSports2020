namespace MasterSports
{
    partial class Formconscliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formconscliente));
            this.gbclienprinc = new System.Windows.Forms.GroupBox();
            this.gbsexo = new System.Windows.Forms.GroupBox();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.gbstatus = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.gbcpf = new System.Windows.Forms.GroupBox();
            this.txcpf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewcliente = new System.Windows.Forms.DataGridView();
            this.gbpesquisa = new System.Windows.Forms.GroupBox();
            this.rbcontem = new System.Windows.Forms.RadioButton();
            this.rbinicio = new System.Windows.Forms.RadioButton();
            this.cbopcoespesquisa = new System.Windows.Forms.ComboBox();
            this.txconsulta = new System.Windows.Forms.TextBox();
            this.btsair = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.gbclienprinc.SuspendLayout();
            this.gbsexo.SuspendLayout();
            this.gbstatus.SuspendLayout();
            this.gbcpf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcliente)).BeginInit();
            this.gbpesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbclienprinc
            // 
            this.gbclienprinc.Controls.Add(this.gbsexo);
            this.gbclienprinc.Controls.Add(this.gbstatus);
            this.gbclienprinc.Controls.Add(this.gbcpf);
            this.gbclienprinc.Controls.Add(this.label6);
            this.gbclienprinc.Controls.Add(this.dataGridViewcliente);
            this.gbclienprinc.Controls.Add(this.gbpesquisa);
            this.gbclienprinc.Controls.Add(this.cbopcoespesquisa);
            this.gbclienprinc.Controls.Add(this.txconsulta);
            this.gbclienprinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbclienprinc.Location = new System.Drawing.Point(16, 15);
            this.gbclienprinc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbclienprinc.Name = "gbclienprinc";
            this.gbclienprinc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbclienprinc.Size = new System.Drawing.Size(987, 512);
            this.gbclienprinc.TabIndex = 0;
            this.gbclienprinc.TabStop = false;
            this.gbclienprinc.Text = "Tipo de Consulta";
            // 
            // gbsexo
            // 
            this.gbsexo.Controls.Add(this.rbfemenino);
            this.gbsexo.Controls.Add(this.rbmasculino);
            this.gbsexo.Location = new System.Drawing.Point(304, 142);
            this.gbsexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbsexo.Name = "gbsexo";
            this.gbsexo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbsexo.Size = new System.Drawing.Size(281, 103);
            this.gbsexo.TabIndex = 59;
            this.gbsexo.TabStop = false;
            this.gbsexo.Text = "Sexo";
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Location = new System.Drawing.Point(143, 54);
            this.rbfemenino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(111, 24);
            this.rbfemenino.TabIndex = 1;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Femenino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(8, 54);
            this.rbmasculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(115, 24);
            this.rbmasculino.TabIndex = 0;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // gbstatus
            // 
            this.gbstatus.Controls.Add(this.rbinativo);
            this.gbstatus.Controls.Add(this.rbativo);
            this.gbstatus.Location = new System.Drawing.Point(627, 142);
            this.gbstatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbstatus.Name = "gbstatus";
            this.gbstatus.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbstatus.Size = new System.Drawing.Size(321, 103);
            this.gbstatus.TabIndex = 58;
            this.gbstatus.TabStop = false;
            this.gbstatus.Text = "Status";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(137, 54);
            this.rbinativo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbinativo.Name = "rbinativo";
            this.rbinativo.Size = new System.Drawing.Size(85, 24);
            this.rbinativo.TabIndex = 1;
            this.rbinativo.TabStop = true;
            this.rbinativo.Text = "Inativo";
            this.rbinativo.UseVisualStyleBackColor = true;
            // 
            // rbativo
            // 
            this.rbativo.AutoSize = true;
            this.rbativo.Location = new System.Drawing.Point(25, 53);
            this.rbativo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(72, 24);
            this.rbativo.TabIndex = 0;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // gbcpf
            // 
            this.gbcpf.Controls.Add(this.txcpf);
            this.gbcpf.Location = new System.Drawing.Point(43, 142);
            this.gbcpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbcpf.Name = "gbcpf";
            this.gbcpf.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbcpf.Size = new System.Drawing.Size(231, 103);
            this.gbcpf.TabIndex = 56;
            this.gbcpf.TabStop = false;
            this.gbcpf.Text = "CPF";
            // 
            // txcpf
            // 
            this.txcpf.Location = new System.Drawing.Point(8, 53);
            this.txcpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txcpf.Multiline = true;
            this.txcpf.Name = "txcpf";
            this.txcpf.Size = new System.Drawing.Size(213, 29);
            this.txcpf.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(80, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(730, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Para Atualizar ou Excluir um Cliente selecione um Produto e clique no Botão Edita" +
    "r !!";
            // 
            // dataGridViewcliente
            // 
            this.dataGridViewcliente.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcliente.Location = new System.Drawing.Point(24, 304);
            this.dataGridViewcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewcliente.Name = "dataGridViewcliente";
            this.dataGridViewcliente.ReadOnly = true;
            this.dataGridViewcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewcliente.Size = new System.Drawing.Size(955, 201);
            this.dataGridViewcliente.TabIndex = 53;
            // 
            // gbpesquisa
            // 
            this.gbpesquisa.Controls.Add(this.rbcontem);
            this.gbpesquisa.Controls.Add(this.rbinicio);
            this.gbpesquisa.Location = new System.Drawing.Point(627, 26);
            this.gbpesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbpesquisa.Name = "gbpesquisa";
            this.gbpesquisa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbpesquisa.Size = new System.Drawing.Size(321, 108);
            this.gbpesquisa.TabIndex = 4;
            this.gbpesquisa.TabStop = false;
            this.gbpesquisa.Text = "Tipo de Pesquisa";
            // 
            // rbcontem
            // 
            this.rbcontem.AutoSize = true;
            this.rbcontem.Location = new System.Drawing.Point(155, 38);
            this.rbcontem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbcontem.Name = "rbcontem";
            this.rbcontem.Size = new System.Drawing.Size(94, 24);
            this.rbcontem.TabIndex = 0;
            this.rbcontem.TabStop = true;
            this.rbcontem.Text = "Contem";
            this.rbcontem.UseVisualStyleBackColor = true;
            // 
            // rbinicio
            // 
            this.rbinicio.AutoSize = true;
            this.rbinicio.Location = new System.Drawing.Point(25, 38);
            this.rbinicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbinicio.Name = "rbinicio";
            this.rbinicio.Size = new System.Drawing.Size(75, 24);
            this.rbinicio.TabIndex = 0;
            this.rbinicio.TabStop = true;
            this.rbinicio.Text = "Inicio";
            this.rbinicio.UseVisualStyleBackColor = true;
            // 
            // cbopcoespesquisa
            // 
            this.cbopcoespesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopcoespesquisa.FormattingEnabled = true;
            this.cbopcoespesquisa.Location = new System.Drawing.Point(43, 79);
            this.cbopcoespesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbopcoespesquisa.Name = "cbopcoespesquisa";
            this.cbopcoespesquisa.Size = new System.Drawing.Size(229, 28);
            this.cbopcoespesquisa.TabIndex = 2;
            this.cbopcoespesquisa.SelectedIndexChanged += new System.EventHandler(this.cbopcoespesquisa_SelectedIndexChanged);
            // 
            // txconsulta
            // 
            this.txconsulta.Location = new System.Drawing.Point(304, 79);
            this.txconsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txconsulta.Multiline = true;
            this.txconsulta.Name = "txconsulta";
            this.txconsulta.Size = new System.Drawing.Size(292, 29);
            this.txconsulta.TabIndex = 0;
            // 
            // btsair
            // 
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.Location = new System.Drawing.Point(853, 542);
            this.btsair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(149, 68);
            this.btsair.TabIndex = 52;
            this.btsair.Text = "Sair";
            this.btsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // bteditar
            // 
            this.bteditar.Image = ((System.Drawing.Image)(resources.GetObject("bteditar.Image")));
            this.bteditar.Location = new System.Drawing.Point(16, 540);
            this.bteditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(153, 68);
            this.bteditar.TabIndex = 53;
            this.bteditar.Text = "Editar";
            this.bteditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btpesquisar
            // 
            this.btpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btpesquisar.Image")));
            this.btpesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btpesquisar.Location = new System.Drawing.Point(195, 542);
            this.btpesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(152, 66);
            this.btpesquisar.TabIndex = 54;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btpesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // Formconscliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 635);
            this.ControlBox = false;
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.gbclienprinc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Formconscliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta cliente";
            this.Load += new System.EventHandler(this.Formconscliente_Load);
            this.gbclienprinc.ResumeLayout(false);
            this.gbclienprinc.PerformLayout();
            this.gbsexo.ResumeLayout(false);
            this.gbsexo.PerformLayout();
            this.gbstatus.ResumeLayout(false);
            this.gbstatus.PerformLayout();
            this.gbcpf.ResumeLayout(false);
            this.gbcpf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcliente)).EndInit();
            this.gbpesquisa.ResumeLayout(false);
            this.gbpesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbclienprinc;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.TextBox txconsulta;
        private System.Windows.Forms.ComboBox cbopcoespesquisa;
        private System.Windows.Forms.GroupBox gbpesquisa;
        private System.Windows.Forms.RadioButton rbcontem;
        private System.Windows.Forms.RadioButton rbinicio;
        private System.Windows.Forms.DataGridView dataGridViewcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbcpf;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.GroupBox gbstatus;
        private System.Windows.Forms.RadioButton rbinativo;
        private System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.GroupBox gbsexo;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.TextBox txcpf;
    }
}