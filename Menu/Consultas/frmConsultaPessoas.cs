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
    public partial class frmConsultaPessoas : Form
    {
        public frmConsultaPessoas()
        {
            InitializeComponent();
        }

        private void frmConsultaPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPessoa.pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoasTableAdapter.Fill(this.dataSetPessoa.pessoas);
            cmbPesquisa.SelectedItem = "ID";

            //if (cmbPesquisa.SelectedItem == "ID")
            //{
            // pessoasBindingSource.Filter = "idPessoa.Contains('" + txtPesquisa.Text + "');" ;
            //}

            

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedItem == "Nome")
            {
                pessoasBindingSource2.Filter = "nomePessoa Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Endereço")
            {
                pessoasBindingSource2.Filter = "enderecoPessoa Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Telefone")
            {
                pessoasBindingSource2.Filter = "telefonePessoa Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "CPF")
            {
                pessoasBindingSource2.Filter = "cpfPessoa Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Débito")
            {
                pessoasBindingSource2.Filter = "fiado Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "ID")
            {
                pessoasBindingSource2.Filter = "Convert(idPessoa, 'System.String') like '%" + txtPesquisa.Text + "%'";
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedItem == "Nome")
            {
                pessoasBindingSource2.Filter = "nomePessoa Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Endereço")
            {
                pessoasBindingSource2.Filter = "enderecoPessoa Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Telefone")
            {
                pessoasBindingSource2.Filter = "telefonePessoa Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "CPF")
            {
                pessoasBindingSource2.Filter = "cpfPessoa Like '%" + txtPesquisa.Text + "%'";
            }
            else if (cmbPesquisa.SelectedItem == "Débito")
            {
                pessoasBindingSource2.Filter = "fiado Like '%" + txtPesquisa.Text + "%'";
            }
        }

        private void frmConsultaPessoas_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
