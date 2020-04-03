namespace MasterSports
{
    partial class frmrelcategoria
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewercategoria = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classcategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classcategoriaBindingSource
            // 
            this.classcategoriaBindingSource.DataSource = typeof(MasterSports.classcategoria);
            // 
            // reportViewercategoria
            // 
            this.reportViewercategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewercategoria.DocumentMapWidth = 41;
            reportDataSource1.Name = "dscategoria";
            reportDataSource1.Value = this.classcategoriaBindingSource;
            this.reportViewercategoria.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewercategoria.LocalReport.ReportEmbeddedResource = "MasterSports.Rptcategoria.rdlc";
            this.reportViewercategoria.Location = new System.Drawing.Point(0, 0);
            this.reportViewercategoria.Name = "reportViewercategoria";
            this.reportViewercategoria.Size = new System.Drawing.Size(786, 519);
            this.reportViewercategoria.TabIndex = 0;
            // 
            // frmrelcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 519);
            this.Controls.Add(this.reportViewercategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmrelcategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Categoria";
            this.Load += new System.EventHandler(this.frmrelcategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classcategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewercategoria;
        private System.Windows.Forms.BindingSource classcategoriaBindingSource;
    }
}