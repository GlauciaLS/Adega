using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu.Venda;
using Menu.Cadastros;
using Menu.Consultas;

namespace Menu
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void executarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frmVenda = new frmVenda();
            frmVenda.ShowDialog();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoa frmCadastroPessoa = new frmCadastroPessoa();
            frmCadastroPessoa.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmCadastroProduto = new frmCadastroProduto();
            frmCadastroProduto.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEstoque frmConsultaEstoque = new frmConsultaEstoque();
            frmConsultaEstoque.ShowDialog();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPessoas frmConsultaPessoas = new frmConsultaPessoas();
            frmConsultaPessoas.ShowDialog();
        }
    }
}
