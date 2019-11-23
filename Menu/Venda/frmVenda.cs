using Menu.DataSetPessoaTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Venda
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
            VendasTableAdapter taVenda = new VendasTableAdapter();
            string novoCodigo;
            int valorCodigo;
            txtDesconto.Text = "R$0";
            try
            {
                novoCodigo = taVenda.UltimoID().ToString();

                if (int.TryParse(novoCodigo.ToString(), out valorCodigo))
                {
                    txtCodVenda.Text = (valorCodigo + 1).ToString();
                }
                else
                {
                    MessageBox.Show("Código com valor errado. Tente novamente.");
                }
            }
            catch
            {
                txtCodVenda.Text = "1";
            }
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPessoa.pessoas'. Você pode movê-la ou removê-la conforme necessário.
            //this.pessoasTableAdapter.Fill(this.dataSetPessoa.pessoas);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPessoa.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dataSetPessoa.produto);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisaID_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                pessoasTableAdapter taPessoa = new pessoasTableAdapter();

                DataTable dtPessoa;
                dtPessoa = taPessoa.PesquisaPorNomeCliente(txtCliente.Text);

                if (dtPessoa.Rows.Count == 0)
                {
                    MessageBox.Show("Pessoa não cadastrada. Verifique se a mesma foi cadastrada ou digitada corretamente.");
                }
                else
                {
                    txtID.Text = dtPessoa.Rows[0]["idPessoa"].ToString();
                    txtCliente.Text = dtPessoa.Rows[0]["nomePessoa"].ToString();
                    txtAtualFiado.Text =  dtPessoa.Rows[0]["fiado"].ToString();
                }
            }
            else if (txtCliente.Text == "")
            {
                pessoasTableAdapter taPessoa = new pessoasTableAdapter();

                DataTable dtPessoa;
                dtPessoa = taPessoa.PesquisaPessoa(txtID.Text);

                if (dtPessoa.Rows.Count == 0)
                {
                    MessageBox.Show("Pessoa não cadastrada. Verifique se a mesma foi cadastrada ou digitada corretamente.");
                }
                else
                {
                    txtID.Text = dtPessoa.Rows[0]["idPessoa"].ToString();
                    txtCliente.Text = dtPessoa.Rows[0]["nomePessoa"].ToString();
                    txtAtualFiado.Text = dtPessoa.Rows[0]["fiado"].ToString();
                }
            }
    }

        private void btnPesquisaCodigo_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == "")
            {
                produtoTableAdapter taProduto = new produtoTableAdapter();

                DataTable dtProduto;
                dtProduto = taProduto.PesquisaProduto(txtCodigo.Text);                

                if (dtProduto.Rows.Count == 0)
                {
                    MessageBox.Show("Produto não encontrado. Verifique se o mesmo foi cadastrado ou digitado corretamente.");
                }
                else
                {
                    txtCodigo.Text = dtProduto.Rows[0]["codProduto"].ToString();
                    txtProduto.Text = dtProduto.Rows[0]["nomeProduto"].ToString();
                    txtEstoque.Text = dtProduto.Rows[0]["qtdProduto"].ToString();
                    txtPreco.Text =  dtProduto.Rows[0]["precoProduto"].ToString();
                }
            }
            else if (txtCodigo.Text == "")
            {
                produtoTableAdapter taProduto = new produtoTableAdapter();

                DataTable dtProduto;
                dtProduto = taProduto.PesquisaPorNomeProduto(txtProduto.Text);

                if (dtProduto.Rows.Count == 0)
                {
                    MessageBox.Show("Produto não encontrado. Verifique se o mesmo foi cadastrado ou digitado corretamente.");
                }
                else
                {
                    txtCodigo.Text = dtProduto.Rows[0]["codProduto"].ToString();
                    txtProduto.Text = dtProduto.Rows[0]["nomeProduto"].ToString();
                    txtEstoque.Text = dtProduto.Rows[0]["qtdProduto"].ToString();
                    txtPreco.Text =  dtProduto.Rows[0]["precoProduto"].ToString();
                }
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try { int quantidade = int.Parse(txtQtd.Text);
            int estoque = int.Parse(txtEstoque.Text);
            if (quantidade <= estoque ){string descricao = txtDescricaoProdutos.Text;            
                    string preco = txtPreco.Text;
                    preco = preco.Replace("R$", "");                    

                    string desconto = txtDesconto.Text;
                    desconto = desconto.Replace("R$", "");                    

                    double precoComDesconto = Convert.ToDouble(preco) - Convert.ToDouble(desconto);
                    double subtotal =  precoComDesconto * Convert.ToDouble(txtQtd.Text);
                   
                               
            
            dgvProdutos.Rows.Add(txtCodigo.Text, txtProduto.Text, txtQtd.Text, txtPreco.Text, txtDesconto.Text, subtotal);
            { 
            decimal total = 0;
            int i = 0;
            for (i = 0; i < dgvProdutos.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgvProdutos.Rows[i].Cells["Subtotal"].Value);
            }
            txtTotal.Text = "R$" + (total).ToString();

            string novoEstoque = (Convert.ToDecimal(txtEstoque.Text) - Convert.ToDecimal(txtQtd.Text)).ToString();
            produtoTableAdapter taProduto = new produtoTableAdapter();
            taProduto.UpdateEstoque(novoEstoque, txtCodigo.Text);                
                string produtoNovo = txtProduto.Text;

                if (txtDescricaoProdutos.Text != "")
                {
                    txtDescricaoProdutos.Text = descricao + ", " + txtProduto.Text;
                }
                else if (txtDescricaoProdutos.Text == "")
                {
                    txtDescricaoProdutos.Text = txtProduto.Text;
                }

            }

            txtQtd.Text = "";
            txtPreco.Text = "";
            txtProduto.Text = "";
            txtCodigo.Text = "";
            txtEstoque.Text = "";
            txtDesconto.Text = "R$0";
            
            }
            else {
                MessageBox.Show("A quantidade ultrapassa o estoque.");
            }
            }
            catch
            {
                MessageBox.Show("Favor completar os espaços em branco.");
            }


        }        

        private void Limpar_Caixas()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    (ctr as TextBox).Clear();
                }
            }

            dgvProdutos.Rows.Clear();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja adicionar ao valor de débito?", "Adicionando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                pessoasTableAdapter taPessoa = new pessoasTableAdapter();

                DataTable dtPessoa;
                taPessoa.UpdateQuery1(txtTotal.Text, txtID.Text);
                MessageBox.Show("Operação realizada com sucesso!");

                string data = DateTime.Now.ToString();
                string produtos = txtDescricaoProdutos.Text;

                VendasTableAdapter taVenda = new VendasTableAdapter();
                taVenda.Insert(txtCodVenda.Text, txtTotal.Text, txtID.Text, produtos, data);

                string novoCodigo;
                int valorCodigo;

                try
                {
                    novoCodigo = taVenda.UltimoID().ToString();

                    if (int.TryParse(novoCodigo.ToString(), out valorCodigo))
                    {
                        txtCodVenda.Text = (valorCodigo + 1).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Código com valor errado. Tente novamente.");
                    }
                }
                catch
                {
                    txtCodVenda.Text = "1";
                }

                
            }
            else 
            {
                VendasTableAdapter taVenda = new VendasTableAdapter();
                string data = DateTime.Now.ToString();
                string produtos = txtDescricaoProdutos.Text;               
                

                taVenda.Insert(txtCodVenda.Text, txtTotal.Text, txtID.Text, produtos, data);

                string novoCodigo;
                int valorCodigo;

                try
                {
                    novoCodigo = taVenda.UltimoID().ToString();

                    if (int.TryParse(novoCodigo.ToString(), out valorCodigo))
                    {
                        txtCodVenda.Text = (valorCodigo + 1).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Código com valor errado. Tente novamente.");
                    }
                }
                catch
                {
                    txtCodVenda.Text = "1";
                }

                

                MessageBox.Show("Venda realizada com sucesso.");
            }

            txtDescricaoProdutos.Text = "";
            txtTotal.Text = "";
            txtCliente.Text = "";
            txtID.Text = "";
            txtAtualFiado.Text = "";
            txtDesconto.Text = "R$0";
            txtDescricaoProdutos.Text = "";
            dgvProdutos.Rows.Clear();
        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            try {string qtdCancelada = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
            
            dgvProdutos.Rows.Remove(dgvProdutos.CurrentRow);
            decimal total = 0;
            int i = 0;
            for (i = 0; i < dgvProdutos.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgvProdutos.Rows[i].Cells["Subtotal"].Value);
            }
            txtTotal.Text = "R$" + (total).ToString();              

                }
            catch{
                MessageBox.Show("Favor selecionar uma linha para ser cancelada.");
            }

        }
    }
}



