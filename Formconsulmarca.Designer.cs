namespace MasterSports
{
    partial class Formconsulmarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formconsulmarca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.btsair = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.cbmarca = new System.Windows.Forms.ComboBox();
            this.dataGridViewmarca = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmarca)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInativo);
            this.groupBox1.Controls.Add(this.rbativo);
            this.groupBox1.Controls.Add(this.btsair);
            this.groupBox1.Controls.Add(this.bteditar);
            this.groupBox1.Controls.Add(this.btpesquisar);
            this.groupBox1.Controls.Add(this.cbmarca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(226, 56);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(72, 20);
            this.rbInativo.TabIndex = 2;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbativo
            // 
            this.rbativo.AutoSize = true;
            this.rbativo.Location = new System.Drawing.Point(226, 21);
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
            this.btsair.Location = new System.Drawing.Point(330, 21);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(105, 55);
            this.btsair.TabIndex = 5;
            this.btsair.Text = "Sair";
            this.btsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // bteditar
            // 
            this.bteditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditar.Image = ((System.Drawing.Image)(resources.GetObject("bteditar.Image")));
            this.bteditar.Location = new System.Drawing.Point(441, 21);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(105, 55);
            this.bteditar.TabIndex = 4;
            this.bteditar.Text = "Editar";
            this.bteditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btpesquisar
            // 
            this.btpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btpesquisar.Image")));
            this.btpesquisar.Location = new System.Drawing.Point(552, 21);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(105, 55);
            this.btpesquisar.TabIndex = 3;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // cbmarca
            // 
            this.cbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmarca.FormattingEnabled = true;
            this.cbmarca.Location = new System.Drawing.Point(22, 37);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(178, 24);
            this.cbmarca.TabIndex = 0;
            this.cbmarca.SelectedIndexChanged += new System.EventHandler(this.cbmarca_SelectedIndexChanged);
            // 
            // dataGridViewmarca
            // 
            this.dataGridViewmarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewmarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmarca.Location = new System.Drawing.Point(12, 111);
            this.dataGridViewmarca.Name = "dataGridViewmarca";
            this.dataGridViewmarca.ReadOnly = true;
            this.dataGridViewmarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewmarca.Size = new System.Drawing.Size(663, 265);
            this.dataGridViewmarca.TabIndex = 1;
            // 
            // Formconsulmarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 388);
            this.Controls.Add(this.dataGridViewmarca);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formconsulmarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formconsulmarca";
            this.Load += new System.EventHandler(this.Formconsulmarca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewmarca;
        private System.Windows.Forms.ComboBox cbmarca;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbativo;
    }
}