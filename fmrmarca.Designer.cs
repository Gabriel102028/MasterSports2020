namespace MasterSports
{
    partial class fmrmarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrmarca));
            this.blcadastromarca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnomemarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbdata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bstatus = new System.Windows.Forms.CheckBox();
            this.btcadastro = new System.Windows.Forms.Button();
            this.btatualizar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // blcadastromarca
            // 
            this.blcadastromarca.AutoSize = true;
            this.blcadastromarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blcadastromarca.Location = new System.Drawing.Point(276, 25);
            this.blcadastromarca.Name = "blcadastromarca";
            this.blcadastromarca.Size = new System.Drawing.Size(155, 24);
            this.blcadastromarca.TabIndex = 0;
            this.blcadastromarca.Text = "Cadastro Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Marca";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Enabled = false;
            this.tbcodigo.Location = new System.Drawing.Point(165, 30);
            this.tbcodigo.Multiline = true;
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(80, 30);
            this.tbcodigo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "* Nome Marca";
            // 
            // tbnomemarca
            // 
            this.tbnomemarca.Location = new System.Drawing.Point(165, 96);
            this.tbnomemarca.Multiline = true;
            this.tbnomemarca.Name = "tbnomemarca";
            this.tbnomemarca.Size = new System.Drawing.Size(481, 30);
            this.tbnomemarca.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Cadastro";
            // 
            // tbdata
            // 
            this.tbdata.Enabled = false;
            this.tbdata.Location = new System.Drawing.Point(420, 30);
            this.tbdata.Multiline = true;
            this.tbdata.Name = "tbdata";
            this.tbdata.Size = new System.Drawing.Size(80, 30);
            this.tbdata.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status";
            // 
            // bstatus
            // 
            this.bstatus.AutoSize = true;
            this.bstatus.Checked = true;
            this.bstatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bstatus.Enabled = false;
            this.bstatus.Location = new System.Drawing.Point(584, 40);
            this.bstatus.Name = "bstatus";
            this.bstatus.Size = new System.Drawing.Size(62, 20);
            this.bstatus.TabIndex = 10;
            this.bstatus.Text = "Ativo";
            this.bstatus.UseVisualStyleBackColor = true;
            // 
            // btcadastro
            // 
            this.btcadastro.Image = ((System.Drawing.Image)(resources.GetObject("btcadastro.Image")));
            this.btcadastro.Location = new System.Drawing.Point(26, 289);
            this.btcadastro.Name = "btcadastro";
            this.btcadastro.Size = new System.Drawing.Size(111, 58);
            this.btcadastro.TabIndex = 14;
            this.btcadastro.Text = "  Cadastrar";
            this.btcadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btcadastro.UseVisualStyleBackColor = true;
            this.btcadastro.Click += new System.EventHandler(this.btcadastro_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.Image = ((System.Drawing.Image)(resources.GetObject("btatualizar.Image")));
            this.btatualizar.Location = new System.Drawing.Point(166, 289);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(114, 58);
            this.btatualizar.TabIndex = 15;
            this.btatualizar.Text = " Atualizar";
            this.btatualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btexcluir.Image")));
            this.btexcluir.Location = new System.Drawing.Point(306, 289);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(114, 58);
            this.btexcluir.TabIndex = 16;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Image = ((System.Drawing.Image)(resources.GetObject("btlimpar.Image")));
            this.btlimpar.Location = new System.Drawing.Point(446, 289);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(112, 58);
            this.btlimpar.TabIndex = 17;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btsair
            // 
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.Location = new System.Drawing.Point(580, 289);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(112, 58);
            this.btsair.TabIndex = 18;
            this.btsair.Text = "Sair";
            this.btsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(546, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "* São obrigatorios !!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbcodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbnomemarca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbdata);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bstatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 173);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            // 
            // fmrmarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 369);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btcadastro);
            this.Controls.Add(this.blcadastromarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrmarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.fmrmarca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blcadastromarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btcadastro;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tbcodigo;
        public System.Windows.Forms.TextBox tbnomemarca;
        public System.Windows.Forms.TextBox tbdata;
        public System.Windows.Forms.CheckBox bstatus;
    }
}