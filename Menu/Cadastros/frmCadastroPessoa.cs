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

namespace Menu.Cadastros
{
    public partial class frmCadastroPessoa : Form
    {
        public frmCadastroPessoa()
        {
            InitializeComponent();

            pessoasTableAdapter taPessoa = new pessoasTableAdapter();
            
            string novoID;
            int valorCodigo;

            try
            {
                novoID = taPessoa.UltimoID().ToString();
                if (int.TryParse(novoID.ToString(), out valorCodigo))
                {
                    txtCodigo.Text = (valorCodigo + 1).ToString();
                }
                else
                {
                    MessageBox.Show("Código com valor errado. Tente novamente.");
                }
            }
            catch
            {
                txtCodigo.Text = "1";

            }
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtFiado.Enabled = false;
            btnOK.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnOK.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtFiado.Enabled = true;

            pessoasTableAdapter taPessoa = new pessoasTableAdapter();
            string novoID;
            int valorCodigo;
            try
            {
                novoID = taPessoa.UltimoID().ToString();
                if (int.TryParse(novoID.ToString(), out valorCodigo))
                {
                    txtCodigo.Text = (valorCodigo + 1).ToString();
                }
                else
                {
                    MessageBox.Show("Código com valor errado. Tente novamente.");
                }
            }
            catch
            {
                txtCodigo.Text = "1";

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnInserir.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = true;
            btnOK.Enabled = false;
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtFiado.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtCodigo.Enabled = true;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtFiado.Text = "R$";

            Limpar_Caixas();
            pessoasTableAdapter taPessoa = new pessoasTableAdapter();
            string novoID;
            int valorCodigo;
            try
            {
                novoID = taPessoa.UltimoID().ToString();
                if (int.TryParse(novoID.ToString(), out valorCodigo))
                {
                    txtCodigo.Text = (valorCodigo + 1).ToString();
                }
                else
                {
                    MessageBox.Show("Código com valor errado. Tente novamente.");
                }
            }
            catch
            {
                txtCodigo.Text = "1";

            }
            btnCancelar.Enabled = false;
        }

        private void frmCadastroPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmCadastroPessoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (btnGravar.Text == "Gravar"){
                pessoasTableAdapter taPessoa = new pessoasTableAdapter();
                
                taPessoa.Insert(txtCodigo.Text, txtNome.Text, txtTelefone.Text, txtEndereco.Text, txtCPF.Text, txtFiado.Text);
                Limpar_Caixas();
                txtNome.Text = "";
                txtCPF.Text = "";
                txtEndereco.Text = "";
                txtTelefone.Text = "";
                txtFiado.Text = "R$";
                string novoID;
                int valorCodigo;

                try
                {
                    novoID = taPessoa.UltimoID().ToString();
                    if (int.TryParse(novoID.ToString(), out valorCodigo))
                    {
                        txtCodigo.Text = (valorCodigo + 1).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Código com valor errado. Tente novamente.");
                    }
                }
                catch
                {
                    txtCodigo.Text = "1";

                }
            }
            else if (btnGravar.Text == "Confirmar")
            {
                if (MessageBox.Show("Confirma alteração?", "Alterando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    pessoasTableAdapter taPessoa = new pessoasTableAdapter();
                    //taPessoa.Update(txtCodigo.Text, txtNome.Text, txtEndereco.Text, txtTelefone.Text, txtCPF.Text, txtFiado.Text);
                    taPessoa.UpdateQuery(txtCodigo.Text, txtNome.Text, txtTelefone.Text, txtEndereco.Text, txtCPF.Text, txtFiado.Text, txtCodigo.Text);
                    Limpar_Caixas();
                    txtCodigo.Enabled = true;
                    txtNome.Enabled = false;
                    txtCPF.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtTelefone.Enabled = false;
                    txtFiado.Enabled = false;
                    txtNome.Text = "";
                    txtCPF.Text = "";
                    txtEndereco.Text = "";
                    txtTelefone.Text = "";
                    txtFiado.Text = "R$";
                    btnInserir.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnAlterar.Enabled = true;
                    string novoID;
                    int valorCodigo;
                    novoID = taPessoa.UltimoID().ToString();
                    btnGravar.Text = "Gravar";
                    btnGravar.Enabled = false;
                    btnCancelar.Enabled = false;

                    if (int.TryParse(novoID.ToString(), out valorCodigo))
                    {
                        txtCodigo.Text = (valorCodigo + 1).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Código com valor errado. Tente novamente.");
                    }
                }
            }
        }

        private void Limpar_Caixas()
        {
            foreach(Control ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    (ctr as TextBox).Clear();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtFiado.Enabled = true;

            pessoasTableAdapter taPessoa = new pessoasTableAdapter();

            DataTable dtPessoa;
            dtPessoa = taPessoa.PesquisaPessoa(txtCodigo.Text);

            if (dtPessoa.Rows.Count == 0)
            {
                MessageBox.Show("Pessoa não cadastrada.");
                txtNome.Enabled = false;
                txtCPF.Enabled = false;
                txtEndereco.Enabled = false;
                txtTelefone.Enabled = false;
                txtFiado.Enabled = false;
            }
            else
            {
                txtCodigo.Text = dtPessoa.Rows[0]["idPessoa"].ToString();
                txtNome.Text = dtPessoa.Rows[0]["nomePessoa"].ToString();
                txtEndereco.Text = dtPessoa.Rows[0]["enderecoPessoa"].ToString();
                txtCPF.Text = dtPessoa.Rows[0]["cpfPessoa"].ToString();
                txtTelefone.Text = dtPessoa.Rows[0]["telefonePessoa"].ToString();
                txtFiado.Text = dtPessoa.Rows[0]["fiado"].ToString();

                txtNome.Enabled = true;
                txtCPF.Enabled = true;
                txtEndereco.Enabled = true;
                txtTelefone.Enabled = true;
                txtFiado.Enabled = true;

                if (MessageBox.Show("Confirma exclusão?", "Excluindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try { 
                    taPessoa.DeleteQuery(txtCodigo.Text);
                    Limpar_Caixas();
                    txtNome.Enabled = false;
                    txtCPF.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtTelefone.Enabled = false;
                    txtFiado.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtNome.Text = "";
                    txtCPF.Text = "";
                    txtEndereco.Text = "";
                    txtTelefone.Text = "";
                    txtFiado.Text = "R$";
                    string novoID;
                    int valorCodigo;
                    novoID = taPessoa.UltimoID().ToString();

                    if (int.TryParse(novoID.ToString(), out valorCodigo))
                    {
                        txtCodigo.Text = (valorCodigo + 1).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Código com valor errado. Tente novamente.");
                    }
                    }
                    catch
                    {
                        MessageBox.Show("Não é possível deletar o cliente pois o mesmo já realizou uma compra.");
                        txtNome.Text = "";
                        txtCPF.Text = "";
                        txtEndereco.Text = "";
                        txtTelefone.Text = "";
                        txtFiado.Text = "R$";
                        txtNome.Enabled = false;
                        txtCPF.Enabled = false;
                        txtEndereco.Enabled = false;
                        txtTelefone.Enabled = false;
                        txtFiado.Enabled = false;
                    }
                }
                else
                {
                    btnCancelar.Enabled = true;
                }
            }

            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnGravar.Text = "Confirmar";
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtFiado.Enabled = true;

            pessoasTableAdapter taPessoa = new pessoasTableAdapter();

            DataTable dtPessoa;
            dtPessoa = taPessoa.PesquisaPessoa(txtCodigo.Text);

            if (dtPessoa.Rows.Count == 0)
            {
                MessageBox.Show("Pessoa não cadastrada.");
                txtNome.Enabled = false;
                txtCPF.Enabled = false;
                txtEndereco.Enabled = false;
                txtTelefone.Enabled = false;
                txtFiado.Enabled = false;
            }
            else
            {
                txtCodigo.Text = dtPessoa.Rows[0]["idPessoa"].ToString();
                txtNome.Text = dtPessoa.Rows[0]["nomePessoa"].ToString();
                txtEndereco.Text = dtPessoa.Rows[0]["enderecoPessoa"].ToString();
                txtCPF.Text = dtPessoa.Rows[0]["cpfPessoa"].ToString();
                txtTelefone.Text = dtPessoa.Rows[0]["telefonePessoa"].ToString();
                txtFiado.Text = dtPessoa.Rows[0]["fiado"].ToString();

                txtNome.Enabled = true;
                txtCPF.Enabled = true;
                txtEndereco.Enabled = true;
                txtTelefone.Enabled = true;
                txtFiado.Enabled = true;
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnOK.Enabled = true;                   
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }
    }
}



