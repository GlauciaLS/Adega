namespace Menu.Venda
{
    partial class frmVenda
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVenda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnPesquisaID = new System.Windows.Forms.Button();
            this.btnPesquisaCodigo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodVenda = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescricaoProdutos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.txtDesconto = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAtualFiado = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPessoa = new Menu.DataSetPessoa();
            this.produtoTableAdapter = new Menu.DataSetPessoaTableAdapters.produtoTableAdapter();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Qtd:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(262, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Preço/Unid:";
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(605, 12);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(121, 25);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir Produto";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome,
            this.Quantidade,
            this.PreçoUnidade,
            this.Desconto,
            this.Subtotal});
            this.dgvProdutos.Location = new System.Drawing.Point(0, 43);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(915, 191);
            this.dgvProdutos.TabIndex = 9;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 160;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 270;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 110;
            // 
            // PreçoUnidade
            // 
            this.PreçoUnidade.HeaderText = "PreçoUnidade";
            this.PreçoUnidade.Name = "PreçoUnidade";
            this.PreçoUnidade.Width = 110;
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Width = 110;
            // 
            // txtCliente
            // 
            this.txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCliente.Location = new System.Drawing.Point(87, 7);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(242, 20);
            this.txtCliente.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(359, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 20);
            this.txtCodigo.TabIndex = 12;
            // 
            // txtProduto
            // 
            this.txtProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProduto.Location = new System.Drawing.Point(78, 5);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(206, 20);
            this.txtProduto.TabIndex = 13;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(78, 39);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(105, 20);
            this.txtQtd.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Valor Total:";
            // 
            // btnVenda
            // 
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Location = new System.Drawing.Point(722, 8);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(152, 32);
            this.btnVenda.TabIndex = 18;
            this.btnVenda.Text = "Realizar Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(377, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(144, 20);
            this.txtID.TabIndex = 11;
            // 
            // btnPesquisaID
            // 
            this.btnPesquisaID.Location = new System.Drawing.Point(766, 7);
            this.btnPesquisaID.Name = "btnPesquisaID";
            this.btnPesquisaID.Size = new System.Drawing.Size(108, 23);
            this.btnPesquisaID.TabIndex = 20;
            this.btnPesquisaID.Text = "Pesquisar Cliente";
            this.btnPesquisaID.UseVisualStyleBackColor = true;
            this.btnPesquisaID.Click += new System.EventHandler(this.btnPesquisaID_Click);
            // 
            // btnPesquisaCodigo
            // 
            this.btnPesquisaCodigo.Location = new System.Drawing.Point(766, 8);
            this.btnPesquisaCodigo.Name = "btnPesquisaCodigo";
            this.btnPesquisaCodigo.Size = new System.Drawing.Size(108, 23);
            this.btnPesquisaCodigo.TabIndex = 22;
            this.btnPesquisaCodigo.Text = "Pesquisar Produto";
            this.btnPesquisaCodigo.UseVisualStyleBackColor = true;
            this.btnPesquisaCodigo.Click += new System.EventHandler(this.btnPesquisaCodigo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Código da Venda:";
            // 
            // txtCodVenda
            // 
            this.txtCodVenda.Enabled = false;
            this.txtCodVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVenda.Location = new System.Drawing.Point(169, 8);
            this.txtCodVenda.Name = "txtCodVenda";
            this.txtCodVenda.Size = new System.Drawing.Size(100, 29);
            this.txtCodVenda.TabIndex = 23;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(605, 9);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(143, 20);
            this.txtEstoque.TabIndex = 26;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(526, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(73, 20);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "Estoque:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(539, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Débito:";
            // 
            // txtDescricaoProdutos
            // 
            this.txtDescricaoProdutos.Location = new System.Drawing.Point(4, 90);
            this.txtDescricaoProdutos.Name = "txtDescricaoProdutos";
            this.txtDescricaoProdutos.Size = new System.Drawing.Size(236, 20);
            this.txtDescricaoProdutos.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCodVenda);
            this.panel1.Controls.Add(this.btnVenda);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(25, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 51);
            this.panel1.TabIndex = 30;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(391, 11);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(87, 26);
            this.txtTotal.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnCancelarProduto);
            this.panel2.Controls.Add(this.dgvProdutos);
            this.panel2.Controls.Add(this.txtDescricaoProdutos);
            this.panel2.Controls.Add(this.btnInserir);
            this.panel2.Location = new System.Drawing.Point(25, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 234);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.txtPreco);
            this.panel3.Controls.Add(this.txtDesconto);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtEstoque);
            this.panel3.Controls.Add(this.lbl);
            this.panel3.Controls.Add(this.btnPesquisaCodigo);
            this.panel3.Controls.Add(this.txtQtd);
            this.panel3.Controls.Add(this.txtProduto);
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(25, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 71);
            this.panel3.TabIndex = 32;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(360, 39);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 31;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(604, 37);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(72, 20);
            this.txtDesconto.TabIndex = 30;
            this.txtDesconto.Text = "R$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(517, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Desconto:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.txtAtualFiado);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btnPesquisaID);
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Controls.Add(this.txtCliente);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(25, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(891, 38);
            this.panel4.TabIndex = 33;
            // 
            // txtAtualFiado
            // 
            this.txtAtualFiado.Location = new System.Drawing.Point(604, 7);
            this.txtAtualFiado.Name = "txtAtualFiado";
            this.txtAtualFiado.Size = new System.Drawing.Size(143, 20);
            this.txtAtualFiado.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(366, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "VENDA";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.dataSetPessoa;
            // 
            // dataSetPessoa
            // 
            this.dataSetPessoa.DataSetName = "DataSetPessoa";
            this.dataSetPessoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProduto.Location = new System.Drawing.Point(737, 12);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(137, 25);
            this.btnCancelarProduto.TabIndex = 30;
            this.btnCancelarProduto.Text = "Cancelar Produto";
            this.btnCancelarProduto.UseVisualStyleBackColor = true;
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(942, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "frmVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVenda;
        private DataSetPessoa dataSetPessoa;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DataSetPessoaTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnPesquisaID;
        private System.Windows.Forms.Button btnPesquisaCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodVenda;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescricaoProdutos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.MaskedTextBox txtTotal;
        private System.Windows.Forms.MaskedTextBox txtDesconto;
        private System.Windows.Forms.MaskedTextBox txtAtualFiado;
        private System.Windows.Forms.MaskedTextBox txtPreco;
        private System.Windows.Forms.Button btnCancelarProduto;
    }
}