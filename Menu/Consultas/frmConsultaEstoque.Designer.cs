namespace Menu.Consultas
{
    partial class frmConsultaEstoque
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetPessoa = new Menu.DataSetPessoa();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aDEGA_IRMAOS_BENINHADataSet = new Menu.ADEGA_IRMAOS_BENINHADataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new Menu.DataSetPessoaTableAdapters.produtoTableAdapter();
            this.produtoTableAdapter1 = new Menu.ADEGA_IRMAOS_BENINHADataSetTableAdapters.produtoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDEGA_IRMAOS_BENINHADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(644, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 27);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Quantidade",
            "Preço",
            "Fornecedor"});
            this.cmbPesquisa.Location = new System.Drawing.Point(466, 11);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(172, 28);
            this.cmbPesquisa.TabIndex = 7;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(93, 11);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(367, 26);
            this.txtPesquisa.TabIndex = 6;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Produto:";
            // 
            // dataSetPessoa
            // 
            this.dataSetPessoa.DataSetName = "DataSetPessoa";
            this.dataSetPessoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produto";
            this.produtosBindingSource.DataSource = this.dataSetPessoa;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.qtdProdutoDataGridViewTextBoxColumn,
            this.precoProdutoDataGridViewTextBoxColumn,
            this.fornecedorProdutoDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.produtoBindingSource1;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 89);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(763, 276);
            this.dgvProdutos.TabIndex = 9;
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "codProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            this.codProdutoDataGridViewTextBoxColumn.Width = 120;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.Width = 200;
            // 
            // qtdProdutoDataGridViewTextBoxColumn
            // 
            this.qtdProdutoDataGridViewTextBoxColumn.DataPropertyName = "qtdProduto";
            this.qtdProdutoDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.qtdProdutoDataGridViewTextBoxColumn.Name = "qtdProdutoDataGridViewTextBoxColumn";
            // 
            // precoProdutoDataGridViewTextBoxColumn
            // 
            this.precoProdutoDataGridViewTextBoxColumn.DataPropertyName = "precoProduto";
            this.precoProdutoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoProdutoDataGridViewTextBoxColumn.Name = "precoProdutoDataGridViewTextBoxColumn";
            // 
            // fornecedorProdutoDataGridViewTextBoxColumn
            // 
            this.fornecedorProdutoDataGridViewTextBoxColumn.DataPropertyName = "fornecedorProduto";
            this.fornecedorProdutoDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorProdutoDataGridViewTextBoxColumn.Name = "fornecedorProdutoDataGridViewTextBoxColumn";
            this.fornecedorProdutoDataGridViewTextBoxColumn.Width = 200;
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "produto";
            this.produtoBindingSource1.DataSource = this.aDEGA_IRMAOS_BENINHADataSet;
            // 
            // aDEGA_IRMAOS_BENINHADataSet
            // 
            this.aDEGA_IRMAOS_BENINHADataSet.DataSetName = "ADEGA_IRMAOS_BENINHADataSet";
            this.aDEGA_IRMAOS_BENINHADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.dataSetPessoa;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter1
            // 
            this.produtoTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.cmbPesquisa);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 50);
            this.panel1.TabIndex = 10;
            // 
            // frmConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(791, 377);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsultaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Produtos";
            this.Load += new System.EventHandler(this.frmConsultaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDEGA_IRMAOS_BENINHADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private DataSetPessoa dataSetPessoa;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DataSetPessoaTableAdapters.produtoTableAdapter produtoTableAdapter;
        private ADEGA_IRMAOS_BENINHADataSet aDEGA_IRMAOS_BENINHADataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private ADEGA_IRMAOS_BENINHADataSetTableAdapters.produtoTableAdapter produtoTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorProdutoDataGridViewTextBoxColumn;
    }
}