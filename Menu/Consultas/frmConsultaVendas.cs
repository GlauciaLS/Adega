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
    public partial class frmConsultaVendas : Form
    {
        public frmConsultaVendas()
        {
            InitializeComponent();
        }

        private void frmConsultaVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPessoa.Vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.dataSetPessoa.Vendas);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPessoa.Venda'. Você pode movê-la ou removê-la conforme necessário.
            //this.vendaTableAdapter.Fill(this.dataSetPessoa.Venda);
            cmbPesquisa.SelectedItem = "ID da Venda";

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedItem == "Valor")
            {
                vendasBindingSource.Filter = "valorVenda Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "ID da Pessoa")
            {
                vendasBindingSource.Filter = "idPessoa Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Descrição dos Produtos")
            {
                vendasBindingSource.Filter = "descricaoProdutos Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Data")
            {
                vendasBindingSource.Filter = "dataVenda Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "ID da Venda")
            {
                vendasBindingSource.Filter = "Convert(codVenda, 'System.String') like'%" + txtPesquisa.Text + "%'";
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedItem == "Valor")
            {
                vendasBindingSource.Filter = "valorVenda Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "ID da Pessoa")
            {
                vendasBindingSource.Filter = "idPessoa Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Descrição dos Produtos")
            {
                vendasBindingSource.Filter = "descricaoProdutos Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Data")
            {
                vendasBindingSource.Filter = "dataVenda Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "ID da Venda")
            {
                vendasBindingSource.Filter = "Convert(codVenda, 'System.String') like'%" + txtPesquisa.Text + "%'";
            }
        }
    }
}
