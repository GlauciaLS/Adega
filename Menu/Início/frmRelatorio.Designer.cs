namespace Menu.Início
{
    partial class frmRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPessoa = new Menu.DataSetPessoa();
            this.dataSetPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new Menu.DataSetPessoaTableAdapters.VendasTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "Vendas";
            this.vendasBindingSource.DataSource = this.dataSetPessoa;
            // 
            // dataSetPessoa
            // 
            this.dataSetPessoa.DataSetName = "DataSetPessoa";
            this.dataSetPessoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetPessoaBindingSource
            // 
            this.dataSetPessoaBindingSource.DataSource = this.dataSetPessoa;
            this.dataSetPessoaBindingSource.Position = 0;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vendasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Menu.Início.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(573, 336);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 336);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorio";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetPessoa dataSetPessoa;
        private System.Windows.Forms.BindingSource dataSetPessoaBindingSource;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private DataSetPessoaTableAdapters.VendasTableAdapter vendasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}