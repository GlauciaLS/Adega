namespace Menu.Consultas
{
    partial class frmConsultaPessoas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataSetPessoa = new Menu.DataSetPessoa();
            this.pessoasTableAdapter = new Menu.DataSetPessoaTableAdapters.pessoasTableAdapter();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonePessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(106, 8);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(453, 26);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Telefone",
            "Endereço",
            "CPF",
            "Débito"});
            this.cmbPesquisa.Location = new System.Drawing.Point(565, 8);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(205, 28);
            this.cmbPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(794, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 27);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataSetPessoa
            // 
            this.dataSetPessoa.DataSetName = "DataSetPessoa";
            this.dataSetPessoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn,
            this.nomePessoaDataGridViewTextBoxColumn,
            this.telefonePessoaDataGridViewTextBoxColumn,
            this.enderecoPessoaDataGridViewTextBoxColumn,
            this.cpfPessoaDataGridViewTextBoxColumn,
            this.fiadoDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.pessoasBindingSource2;
            this.dgvClientes.Location = new System.Drawing.Point(30, 75);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(922, 276);
            this.dgvClientes.TabIndex = 4;
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "idPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "ID ";
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            this.idPessoaDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomePessoaDataGridViewTextBoxColumn
            // 
            this.nomePessoaDataGridViewTextBoxColumn.DataPropertyName = "nomePessoa";
            this.nomePessoaDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomePessoaDataGridViewTextBoxColumn.Name = "nomePessoaDataGridViewTextBoxColumn";
            this.nomePessoaDataGridViewTextBoxColumn.Width = 220;
            // 
            // telefonePessoaDataGridViewTextBoxColumn
            // 
            this.telefonePessoaDataGridViewTextBoxColumn.DataPropertyName = "telefonePessoa";
            this.telefonePessoaDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefonePessoaDataGridViewTextBoxColumn.Name = "telefonePessoaDataGridViewTextBoxColumn";
            this.telefonePessoaDataGridViewTextBoxColumn.Width = 130;
            // 
            // enderecoPessoaDataGridViewTextBoxColumn
            // 
            this.enderecoPessoaDataGridViewTextBoxColumn.DataPropertyName = "enderecoPessoa";
            this.enderecoPessoaDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoPessoaDataGridViewTextBoxColumn.Name = "enderecoPessoaDataGridViewTextBoxColumn";
            this.enderecoPessoaDataGridViewTextBoxColumn.Width = 200;
            // 
            // cpfPessoaDataGridViewTextBoxColumn
            // 
            this.cpfPessoaDataGridViewTextBoxColumn.DataPropertyName = "cpfPessoa";
            this.cpfPessoaDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfPessoaDataGridViewTextBoxColumn.Name = "cpfPessoaDataGridViewTextBoxColumn";
            this.cpfPessoaDataGridViewTextBoxColumn.Width = 110;
            // 
            // fiadoDataGridViewTextBoxColumn
            // 
            this.fiadoDataGridViewTextBoxColumn.DataPropertyName = "fiado";
            this.fiadoDataGridViewTextBoxColumn.HeaderText = "Débito";
            this.fiadoDataGridViewTextBoxColumn.Name = "fiadoDataGridViewTextBoxColumn";
            this.fiadoDataGridViewTextBoxColumn.Width = 135;
            // 
            // pessoasBindingSource2
            // 
            this.pessoasBindingSource2.DataMember = "pessoas";
            this.pessoasBindingSource2.DataSource = this.dataSetPessoa;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.cmbPesquisa);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 47);
            this.panel1.TabIndex = 5;
            // 
            // frmConsultaPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(969, 378);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsultaPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Pessoas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultaPessoas_FormClosed);
            this.Load += new System.EventHandler(this.frmConsultaPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private DataSetPessoa dataSetPessoa;
        private DataSetPessoaTableAdapters.pessoasTableAdapter pessoasTableAdapter;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.BindingSource pessoasBindingSource2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonePessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiadoDataGridViewTextBoxColumn;
    }
}