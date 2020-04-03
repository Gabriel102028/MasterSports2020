namespace MasterSports
{
    partial class Formconsulcategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formconsulcategoria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.btsair = new System.Windows.Forms.Button();
            this.cbopcoes = new System.Windows.Forms.ComboBox();
            this.bteditar = new System.Windows.Forms.Button();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.dataGridViewcategoria = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbinativo);
            this.groupBox1.Controls.Add(this.rbativo);
            this.groupBox1.Controls.Add(this.btsair);
            this.groupBox1.Controls.Add(this.cbopcoes);
            this.groupBox1.Controls.Add(this.bteditar);
            this.groupBox1.Controls.Add(this.btpesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(235, 49);
            this.rbinativo.Name = "rbinativo";
            this.rbinativo.Size = new System.Drawing.Size(72, 20);
            this.rbinativo.TabIndex = 2;
            this.rbinativo.TabStop = true;
            this.rbinativo.Text = "Inativo";
            this.rbinativo.UseVisualStyleBackColor = true;
            // 
            // rbativo
            // 
            this.rbativo.AutoSize = true;
            this.rbativo.Location = new System.Drawing.Point(235, 21);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(61, 20);
            this.rbativo.TabIndex = 2;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // btsair
            // 
            this.btsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.Location = new System.Drawing.Point(346, 14);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(105, 55);
            this.btsair.TabIndex = 57;
            this.btsair.Text = "Sair";
            this.btsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // cbopcoes
            // 
            this.cbopcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopcoes.FormattingEnabled = true;
            this.cbopcoes.Location = new System.Drawing.Point(25, 30);
            this.cbopcoes.Name = "cbopcoes";
            this.cbopcoes.Size = new System.Drawing.Size(180, 24);
            this.cbopcoes.TabIndex = 2;
            this.cbopcoes.SelectedIndexChanged += new System.EventHandler(this.cbopcoes_SelectedIndexChanged);
            // 
            // bteditar
            // 
            this.bteditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditar.Image = ((System.Drawing.Image)(resources.GetObject("bteditar.Image")));
            this.bteditar.Location = new System.Drawing.Point(457, 14);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(114, 55);
            this.bteditar.TabIndex = 56;
            this.bteditar.Text = "Editar";
            this.bteditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btpesquisar
            // 
            this.btpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btpesquisar.Image")));
            this.btpesquisar.Location = new System.Drawing.Point(577, 14);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(123, 55);
            this.btpesquisar.TabIndex = 55;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // dataGridViewcategoria
            // 
            this.dataGridViewcategoria.AllowUserToAddRows = false;
            this.dataGridViewcategoria.AllowUserToDeleteRows = false;
            this.dataGridViewcategoria.AllowUserToResizeColumns = false;
            this.dataGridViewcategoria.AllowUserToResizeRows = false;
            this.dataGridViewcategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcategoria.Location = new System.Drawing.Point(12, 97);
            this.dataGridViewcategoria.MultiSelect = false;
            this.dataGridViewcategoria.Name = "dataGridViewcategoria";
            this.dataGridViewcategoria.ReadOnly = true;
            this.dataGridViewcategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewcategoria.Size = new System.Drawing.Size(706, 247);
            this.dataGridViewcategoria.TabIndex = 1;
            // 
            // Formconsulcategoria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(730, 356);
            this.Controls.Add(this.dataGridViewcategoria);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formconsulcategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Categoria";
            this.Load += new System.EventHandler(this.Formconsulcategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewcategoria;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.ComboBox cbopcoes;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.RadioButton rbinativo;
        private System.Windows.Forms.RadioButton rbativo;
    }
}