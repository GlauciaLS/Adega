using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu.DataSetPessoaTableAdapters;

namespace Menu.Cadastros
{
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
            txtID.Enabled = true;
            btnOK.Enabled = false;
            produtoTableAdapter taProduto = new produtoTableAdapter();

            string novoID;
            int valorID;

            try
            {
                novoID = taProduto.UltimoID().ToString();

                if (int.TryParse(novoID.ToString(), out valorID))
                {
                    txtID.Text = (valorID + 1).ToString();
                }
                else
                {
                    MessageBox.Show("ID com valor errado. Tente novamente.");
                }
            }
            catch
            {
                txtID.Text = "1";
            }
            txtNome.Enabled = false;
            txtPreco.Enabled = false;
            txtQtd.Enabled = false;
            txtFornecedor.Enabled = false;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNome.Enabled = true;
            txtFornecedor.Enabled = true;
            txtPreco.Enabled = true;
            txtQtd.Enabled = true;
            produtoTableAdapter taProduto = new produtoTableAdapter();
            string novoID;
            int valorID;
            try
            {
                novoID = taProduto.UltimoID().ToString();

                if (int.TryParse(novoID.ToString(), out valorID))
                {
                    txtID.Text = (valorID + 1).ToString();
                }
                else
                {
                    MessageBox.Show("ID com valor errado. Tente novamente.");
                }
            }
            catch
            {
                txtID.Text = "1";
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            btnInserir.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            txtNome.Enabled = false;
            txtFornecedor.Enabled = false;
            txtPreco.Enabled = false;
            txtQtd.Enabled = false;
            txtNome.Text = "";
            txtPreco.Text = "R$";
            txtQtd.Text = "";
            txtFornecedor.Text = "";
            Limpar_Caixas();
            produtoTableAdapter taProduto = new produtoTableAdapter();
            string novoID;
            int valorID;

            try
            {
                novoID = taProduto.UltimoID().ToString();

                if (int.TryParse(novoID.ToString(), out valorID))
                {
                    txtID.Text = (valorID + 1).ToString();
                }
                else
                {
                    MessageBox.Show("ID com valor errado. Tente novamente.");
                }
            }
            catch
            {
                txtID.Text = "1";
            }
            btnCancelar.Enabled = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (btnGravar.Text == "Gravar")
            {
                
                produtoTableAdapter taProduto = new produtoTableAdapter();
                taProduto.Insert(txtID.Text, txtNome.Text, txtQtd.Text, txtPreco.Text, txtFornecedor.Text);
                Limpar_Caixas();
                string novoID;
                int valorID;
                MessageBox.Show("Registrado com sucesso.");

                try
                {
                    novoID = taProduto.UltimoID().ToString();

                    if (int.TryParse(novoID.ToString(), out valorID))
                    {
                        txtID.Text = (valorID + 1).ToString();
                    }
                    else
                    {
                        MessageBox.Show("ID com valor errado. Tente novamente.");
                    }
                }
                catch
                {
                    txtID.Text = "1";
                }
            }
            else if (btnGravar.Text == "Confirmar")
            {
                if (MessageBox.Show("Confirma alteração?", "Alterando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    
                    produtoTableAdapter taProduto = new produtoTableAdapter();
                    taProduto.UpdateQuery(txtID.Text, txtNome.Text, txtQtd.Text, txtPreco.Text, txtFornecedor.Text, txtID.Text);
                    Limpar_Caixas();
                    txtID.Enabled = true;
                    txtNome.Enabled = false;
                    txtPreco.Enabled = false;
                    txtQtd.Enabled = false;
                    txtFornecedor.Enabled = false;
                    btnInserir.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnOK.Enabled = false;
                    string novoID;
                    int valorID;
                    btnGravar.Text = "Gravar";
                    btnGravar.Enabled = false;
                    btnCancelar.Enabled = false;
                    MessageBox.Show("Registrado com sucesso.");
                    try
                    {
                        novoID = taProduto.UltimoID().ToString();

                        if (int.TryParse(novoID.ToString(), out valorID))
                        {
                            txtID.Text = (valorID + 1).ToString();
                        }
                        else
                        {
                            MessageBox.Show("ID com valor errado. Tente novamente.");
                        }
                    }
                    catch
                    {
                        txtID.Text = "1";
                    }
                    
                }
                
            }
            txtNome.Text = "";
            txtPreco.Text = "R$";
            txtQtd.Text = "";
            txtFornecedor.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtPreco.Enabled = true;
            txtQtd.Enabled = true;
            txtID.Enabled = true;
            txtFornecedor.Enabled = true;

            produtoTableAdapter taProduto = new produtoTableAdapter();

            DataTable dtPessoa;
            dtPessoa = taProduto.PesquisaProduto(txtID.Text);

            if (dtPessoa.Rows.Count == 0)
            {
                MessageBox.Show("Produto não cadastrado.");
                txtNome.Enabled = false;
                txtPreco.Enabled = false;
                txtQtd.Enabled = false;
                
                txtFornecedor.Enabled = false;
                txtID.Enabled = true;
            }
            else
            {
                txtID.Text = dtPessoa.Rows[0]["codProduto"].ToString();
                txtNome.Text = dtPessoa.Rows[0]["nomeProduto"].ToString();
                txtQtd.Text = dtPessoa.Rows[0]["qtdProduto"].ToString();
                txtPreco.Text =  dtPessoa.Rows[0]["precoProduto"].ToString();
                txtFornecedor.Text = dtPessoa.Rows[0]["fornecedorProduto"].ToString();

                txtNome.Enabled = true;
                txtPreco.Enabled = true;
                txtQtd.Enabled = true;
                txtID.Enabled = true;
                txtFornecedor.Enabled = true;
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnOK.Enabled = true;
                btnGravar.Text = "Confirmar";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtPreco.Enabled = true;
            lblWUad.Enabled = true;
            txtID.Enabled = true;
            txtFornecedor.Enabled = true;

            produtoTableAdapter taProduto = new produtoTableAdapter();

            DataTable dtPessoa;
            dtPessoa = taProduto.PesquisaProduto(txtID.Text);

            if (dtPessoa.Rows.Count == 0)
            {
                MessageBox.Show("Produto não cadastrado.");
                txtNome.Enabled = false;
                txtPreco.Enabled = false;
                lblWUad.Enabled = false;
                
                txtFornecedor.Enabled = false;
                txtID.Enabled = true;
            }
            else
            {
                txtID.Text = dtPessoa.Rows[0]["codProduto"].ToString();
                txtNome.Text = dtPessoa.Rows[0]["nomeProduto"].ToString();
                txtQtd.Text = dtPessoa.Rows[0]["qtdProduto"].ToString();
                txtPreco.Text = dtPessoa.Rows[0]["precoProduto"].ToString();
                txtFornecedor.Text = dtPessoa.Rows[0]["fornecedorProduto"].ToString();


                txtNome.Enabled = true;
                txtPreco.Enabled = true;
                txtQtd.Enabled = true;
                txtID.Enabled = true;
                txtFornecedor.Enabled = true;

                if (MessageBox.Show("Confirma exclusão?", "Excluindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    taProduto.DeleteQuery(txtID.Text);
                    Limpar_Caixas();
                    txtNome.Enabled = false;
                    txtPreco.Enabled = false;
                    txtQtd.Enabled = false;
                    txtID.Enabled = true;
                    txtFornecedor.Enabled = false;
                    string novoID;
                    int valorID;
                    txtNome.Text = "";
                    txtPreco.Text = "R$";
                    txtQtd.Text = "";
                    txtFornecedor.Text = "";
                    btnCancelar.Enabled = false;
                    MessageBox.Show("Excluído com sucesso.");
                    try
                    {
                        novoID = taProduto.UltimoID().ToString();

                        if (int.TryParse(novoID.ToString(), out valorID))
                        {
                            txtID.Text = (valorID + 1).ToString();
                        }
                        else
                        {
                            MessageBox.Show("ID com valor errado. Tente novamente.");
                        }
                    }
                    catch
                    {
                        txtID.Text = "1";
                    }
                }
                else
                {
                    btnCancelar.Enabled = true;
                    txtNome.Enabled = false;
                    txtPreco.Enabled = false;
                    txtQtd.Enabled = false;
                    txtFornecedor.Enabled = false;
                    txtNome.Text = "";
                    txtPreco.Text = "R$";
                    txtQtd.Text = "";
                    txtFornecedor.Text = "";
                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma alteração?", "Alterando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                produtoTableAdapter taProduto = new produtoTableAdapter();                
                taProduto.UpdateQuery(txtID.Text, txtNome.Text, txtQtd.Text, txtPreco.Text, txtFornecedor.Text, txtID.Text);
                Limpar_Caixas();
                txtID.Enabled = true;
                txtNome.Enabled = false;
                txtPreco.Enabled = false;
                txtQtd.Enabled = false;                
                txtFornecedor.Enabled = false;
                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = false;
                btnOK.Enabled = false;
                string novoID;
                int valorID;
                try
                {
                    novoID = taProduto.UltimoID().ToString();

                    if (int.TryParse(novoID.ToString(), out valorID))
                    {
                        txtID.Text = (valorID + 1).ToString();
                    }
                    else
                    {
                        MessageBox.Show("ID com valor errado. Tente novamente.");
                    }
                }
                catch
                {
                    txtID.Text = "1";
                }
            }
        }
    }
}
