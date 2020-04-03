namespace MasterSports
{
    partial class frmrelmarca
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
            this.classmarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewermarca = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classmarcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classmarcaBindingSource
            // 
            this.classmarcaBindingSource.DataSource = typeof(MasterSports.classmarca);
            // 
            // reportViewermarca
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.classmarcaBindingSource;
            this.reportViewermarca.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewermarca.LocalReport.ReportEmbeddedResource = "MasterSports.rptrelmarca.rdlc";
            this.reportViewermarca.Location = new System.Drawing.Point(0, 0);
            this.reportViewermarca.Name = "reportViewermarca";
            this.reportViewermarca.Size = new System.Drawing.Size(681, 398);
            this.reportViewermarca.TabIndex = 0;
            // 
            // frmrelmarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 398);
            this.Controls.Add(this.reportViewermarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmrelmarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Marca";
            this.Load += new System.EventHandler(this.frmrelmarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classmarcaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewermarca;
        private System.Windows.Forms.BindingSource classmarcaBindingSource;
    }
}