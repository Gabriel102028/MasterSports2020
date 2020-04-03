namespace MasterSports
{
    partial class fmrPrincipal
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
            System.Windows.Forms.ToolStripMenuItem menuconsultas;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrPrincipal));
            this.categoriaTS = new System.Windows.Forms.ToolStripMenuItem();
            this.tscliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsprodutos = new System.Windows.Forms.ToolStripMenuItem();
            this.TStfuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaTS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menucadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menucategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menucliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuproduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menufuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menumarca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuvenda = new System.Windows.Forms.ToolStripMenuItem();
            this.stvenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menurelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.rtscategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.clientestm = new System.Windows.Forms.ToolStripMenuItem();
            this.produtostm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsrelvenda = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioTSm = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaTSt = new System.Windows.Forms.ToolStripMenuItem();
            this.menusair = new System.Windows.Forms.ToolStripMenuItem();
            this.menustatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.tshora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            menuconsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.menustatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuconsultas
            // 
            menuconsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaTS,
            this.tscliente,
            this.tsprodutos,
            this.TStfuncionario,
            this.marcaTS});
            menuconsultas.Image = ((System.Drawing.Image)(resources.GetObject("menuconsultas.Image")));
            menuconsultas.Name = "menuconsultas";
            menuconsultas.Size = new System.Drawing.Size(100, 28);
            menuconsultas.Text = "Consultas";
            // 
            // categoriaTS
            // 
            this.categoriaTS.Image = ((System.Drawing.Image)(resources.GetObject("categoriaTS.Image")));
            this.categoriaTS.Name = "categoriaTS";
            this.categoriaTS.Size = new System.Drawing.Size(151, 30);
            this.categoriaTS.Text = "Categoria";
            this.categoriaTS.Click += new System.EventHandler(this.categoriaTS_Click);
            // 
            // tscliente
            // 
            this.tscliente.Image = ((System.Drawing.Image)(resources.GetObject("tscliente.Image")));
            this.tscliente.Name = "tscliente";
            this.tscliente.Size = new System.Drawing.Size(151, 30);
            this.tscliente.Text = "Clientes";
            this.tscliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tscliente.Click += new System.EventHandler(this.tscliente_Click);
            // 
            // tsprodutos
            // 
            this.tsprodutos.Image = ((System.Drawing.Image)(resources.GetObject("tsprodutos.Image")));
            this.tsprodutos.Name = "tsprodutos";
            this.tsprodutos.Size = new System.Drawing.Size(151, 30);
            this.tsprodutos.Text = "Produtos";
            this.tsprodutos.Click += new System.EventHandler(this.tsprodutos_Click);
            // 
            // TStfuncionario
            // 
            this.TStfuncionario.Image = ((System.Drawing.Image)(resources.GetObject("TStfuncionario.Image")));
            this.TStfuncionario.Name = "TStfuncionario";
            this.TStfuncionario.Size = new System.Drawing.Size(151, 30);
            this.TStfuncionario.Text = "Funcionario";
            this.TStfuncionario.Click += new System.EventHandler(this.TStfuncionario_Click);
            // 
            // marcaTS
            // 
            this.marcaTS.Image = ((System.Drawing.Image)(resources.GetObject("marcaTS.Image")));
            this.marcaTS.Name = "marcaTS";
            this.marcaTS.Size = new System.Drawing.Size(151, 30);
            this.marcaTS.Text = "Marca";
            this.marcaTS.Click += new System.EventHandler(this.marcaTS_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.White;
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menucadastro,
            menuconsultas,
            this.menuvenda,
            this.menurelatorios,
            this.menusair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1020, 32);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menucadastro
            // 
            this.menucadastro.AutoSize = false;
            this.menucadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menucategoria,
            this.menucliente,
            this.menuproduto,
            this.menufuncionario,
            this.menumarca});
            this.menucadastro.Image = ((System.Drawing.Image)(resources.GetObject("menucadastro.Image")));
            this.menucadastro.Name = "menucadastro";
            this.menucadastro.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.menucadastro.Size = new System.Drawing.Size(94, 28);
            this.menucadastro.Text = "Cadastro";
            // 
            // menucategoria
            // 
            this.menucategoria.Image = ((System.Drawing.Image)(resources.GetObject("menucategoria.Image")));
            this.menucategoria.Name = "menucategoria";
            this.menucategoria.Size = new System.Drawing.Size(151, 30);
            this.menucategoria.Text = "Categoria";
            this.menucategoria.Click += new System.EventHandler(this.menucategoria_Click);
            // 
            // menucliente
            // 
            this.menucliente.Image = ((System.Drawing.Image)(resources.GetObject("menucliente.Image")));
            this.menucliente.Name = "menucliente";
            this.menucliente.Size = new System.Drawing.Size(151, 30);
            this.menucliente.Text = "Cliente";
            this.menucliente.Click += new System.EventHandler(this.menucliente_Click);
            // 
            // menuproduto
            // 
            this.menuproduto.Image = ((System.Drawing.Image)(resources.GetObject("menuproduto.Image")));
            this.menuproduto.Name = "menuproduto";
            this.menuproduto.Size = new System.Drawing.Size(151, 30);
            this.menuproduto.Text = "Produto";
            this.menuproduto.Click += new System.EventHandler(this.menuproduto_Click);
            // 
            // menufuncionario
            // 
            this.menufuncionario.Image = ((System.Drawing.Image)(resources.GetObject("menufuncionario.Image")));
            this.menufuncionario.Name = "menufuncionario";
            this.menufuncionario.Size = new System.Drawing.Size(151, 30);
            this.menufuncionario.Text = "Funcionario";
            this.menufuncionario.Click += new System.EventHandler(this.menufuncionario_Click);
            // 
            // menumarca
            // 
            this.menumarca.Image = ((System.Drawing.Image)(resources.GetObject("menumarca.Image")));
            this.menumarca.Name = "menumarca";
            this.menumarca.Size = new System.Drawing.Size(151, 30);
            this.menumarca.Text = "Marca";
            this.menumarca.Click += new System.EventHandler(this.menumarca_Click);
            // 
            // menuvenda
            // 
            this.menuvenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stvenda});
            this.menuvenda.Image = ((System.Drawing.Image)(resources.GetObject("menuvenda.Image")));
            this.menuvenda.Name = "menuvenda";
            this.menuvenda.Size = new System.Drawing.Size(80, 28);
            this.menuvenda.Text = "Venda";
            // 
            // stvenda
            // 
            this.stvenda.Image = ((System.Drawing.Image)(resources.GetObject("stvenda.Image")));
            this.stvenda.Name = "stvenda";
            this.stvenda.Size = new System.Drawing.Size(120, 30);
            this.stvenda.Text = "Venda";
            this.stvenda.Click += new System.EventHandler(this.stvenda_Click);
            // 
            // menurelatorios
            // 
            this.menurelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rtscategoria,
            this.clientestm,
            this.produtostm,
            this.tsrelvenda,
            this.funcionarioTSm,
            this.marcaTSt});
            this.menurelatorios.Image = ((System.Drawing.Image)(resources.GetObject("menurelatorios.Image")));
            this.menurelatorios.Name = "menurelatorios";
            this.menurelatorios.Size = new System.Drawing.Size(103, 28);
            this.menurelatorios.Text = "Relatórios";
            // 
            // rtscategoria
            // 
            this.rtscategoria.Image = ((System.Drawing.Image)(resources.GetObject("rtscategoria.Image")));
            this.rtscategoria.Name = "rtscategoria";
            this.rtscategoria.Size = new System.Drawing.Size(151, 30);
            this.rtscategoria.Text = "Categoria";
            this.rtscategoria.Click += new System.EventHandler(this.rtscategoria_Click);
            // 
            // clientestm
            // 
            this.clientestm.Image = ((System.Drawing.Image)(resources.GetObject("clientestm.Image")));
            this.clientestm.Name = "clientestm";
            this.clientestm.Size = new System.Drawing.Size(151, 30);
            this.clientestm.Text = "Clientes";
            this.clientestm.Click += new System.EventHandler(this.clientestm_Click);
            // 
            // produtostm
            // 
            this.produtostm.Image = ((System.Drawing.Image)(resources.GetObject("produtostm.Image")));
            this.produtostm.Name = "produtostm";
            this.produtostm.Size = new System.Drawing.Size(151, 30);
            this.produtostm.Text = "Produtos";
            this.produtostm.Click += new System.EventHandler(this.produtostm_Click);
            // 
            // tsrelvenda
            // 
            this.tsrelvenda.Image = ((System.Drawing.Image)(resources.GetObject("tsrelvenda.Image")));
            this.tsrelvenda.Name = "tsrelvenda";
            this.tsrelvenda.Size = new System.Drawing.Size(151, 30);
            this.tsrelvenda.Text = "Vendas";
            this.tsrelvenda.Click += new System.EventHandler(this.tsrelvenda_Click);
            // 
            // funcionarioTSm
            // 
            this.funcionarioTSm.Image = ((System.Drawing.Image)(resources.GetObject("funcionarioTSm.Image")));
            this.funcionarioTSm.Name = "funcionarioTSm";
            this.funcionarioTSm.Size = new System.Drawing.Size(151, 30);
            this.funcionarioTSm.Text = "Funcionario";
            this.funcionarioTSm.Click += new System.EventHandler(this.funcionarioTSm_Click);
            // 
            // marcaTSt
            // 
            this.marcaTSt.Image = ((System.Drawing.Image)(resources.GetObject("marcaTSt.Image")));
            this.marcaTSt.Name = "marcaTSt";
            this.marcaTSt.Size = new System.Drawing.Size(151, 30);
            this.marcaTSt.Text = "Marca";
            this.marcaTSt.Click += new System.EventHandler(this.marcaTSt_Click);
            // 
            // menusair
            // 
            this.menusair.Image = ((System.Drawing.Image)(resources.GetObject("menusair.Image")));
            this.menusair.Name = "menusair";
            this.menusair.Size = new System.Drawing.Size(66, 28);
            this.menusair.Text = "Sair";
            this.menusair.Click += new System.EventHandler(this.menusair_Click);
            // 
            // menustatusStrip
            // 
            this.menustatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsdata,
            this.tshora});
            this.menustatusStrip.Location = new System.Drawing.Point(0, 656);
            this.menustatusStrip.Name = "menustatusStrip";
            this.menustatusStrip.Size = new System.Drawing.Size(1020, 22);
            this.menustatusStrip.TabIndex = 3;
            this.menustatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(199, 17);
            this.toolStripStatusLabel1.Text = "Bem-Vindo ao Sistema MasterSports";
            // 
            // tsdata
            // 
            this.tsdata.Name = "tsdata";
            this.tsdata.Size = new System.Drawing.Size(31, 17);
            this.tsdata.Text = "Data";
            // 
            // tshora
            // 
            this.tshora.Name = "tshora";
            this.tshora.Size = new System.Drawing.Size(33, 17);
            this.tshora.Text = "Hora";
            this.tshora.Click += new System.EventHandler(this.tshora_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Location = new System.Drawing.Point(994, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(26, 624);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 678);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menustatusStrip);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "fmrPrincipal";
            this.Text = "MasterSports Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.menustatusStrip.ResumeLayout(false);
            this.menustatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menucadastro;
        private System.Windows.Forms.ToolStripMenuItem menucategoria;
        private System.Windows.Forms.ToolStripMenuItem menucliente;
        private System.Windows.Forms.ToolStripMenuItem menurelatorios;
        private System.Windows.Forms.ToolStripMenuItem menusair;
        private System.Windows.Forms.ToolStripMenuItem menuproduto;
        private System.Windows.Forms.ToolStripMenuItem menufuncionario;
        private System.Windows.Forms.ToolStripMenuItem menumarca;
        private System.Windows.Forms.StatusStrip menustatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsdata;
        private System.Windows.Forms.ToolStripStatusLabel tshora;
        private System.Windows.Forms.ToolStripMenuItem tscliente;
        private System.Windows.Forms.ToolStripMenuItem tsprodutos;
        private System.Windows.Forms.ToolStripMenuItem menuvenda;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem rtscategoria;
        private System.Windows.Forms.ToolStripMenuItem clientestm;
        private System.Windows.Forms.ToolStripMenuItem produtostm;
        private System.Windows.Forms.ToolStripMenuItem stvenda;
        private System.Windows.Forms.ToolStripMenuItem tsrelvenda;
        private System.Windows.Forms.ToolStripMenuItem TStfuncionario;
        private System.Windows.Forms.ToolStripMenuItem funcionarioTSm;
        private System.Windows.Forms.ToolStripMenuItem categoriaTS;
        private System.Windows.Forms.ToolStripMenuItem marcaTS;
        private System.Windows.Forms.ToolStripMenuItem marcaTSt;
    }
}

