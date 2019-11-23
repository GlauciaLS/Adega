using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Consultas
{
    public partial class frmConsultaEstoque : Form
    {
        public frmConsultaEstoque()
        {
            InitializeComponent();
        }

        private void frmConsultaEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPessoa.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dataSetPessoa.produto);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPessoa.Venda'. Você pode movê-la ou removê-la conforme necessário.
            //this.vendaTableAdapter.Fill(this.dataSetPessoa.Venda);
            // TODO: esta linha de código carrega dados na tabela 'aDEGA_IRMAOS_BENINHADataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter1.Fill(this.aDEGA_IRMAOS_BENINHADataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPessoa.produto'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtoTableAdapter.Fill(this.dataSetPessoa.produto);
            cmbPesquisa.SelectedItem = "ID";

        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedItem == "Nome")
            {
                produtoBindingSource1.Filter = "nomeProduto Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Quantidade")
            {
                produtoBindingSource1.Filter = "qtdProduto Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Preço")
            {
                produtoBindingSource1.Filter = "precoProduto Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Fornecedor")
            {
                produtoBindingSource1.Filter = "fornecedorProduto Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "ID")
            {
                produtoBindingSource1.Filter = "Convert(codProduto, 'System.String') like'%" + txtPesquisa.Text + "%'";
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedItem == "Nome")
            {
                produtoBindingSource.Filter = "nomeProduto Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Quantidade")
            {
                produtoBindingSource.Filter = "qtdProduto Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Preço")
            {
                produtoBindingSource.Filter = "precoProduto Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Fornecedor")
            {
                produtoBindingSource.Filter = "fornecedorProduto Like '%" + txtPesquisa.Text + "%'";
            }
        }
    }
}
