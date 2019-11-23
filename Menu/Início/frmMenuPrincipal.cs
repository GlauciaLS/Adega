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
using System.IO;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Menu.Início;
//using Microsoft.SqlServer.BatchParserClient;


namespace Menu
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToString();
            
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjuda frmAjuda = new frmAjuda();
            frmAjuda.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVendas frmVendas = new frmConsultaVendas();
            frmVendas.ShowDialog();
        }
        

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja escolher o diretório do backup? Caso contrário, será utilizado o padrão do software.", "BACKUP", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                frmBackup frmBackup = new frmBackup();
                frmBackup.ShowDialog();
            }
            else
            {
                string sqlConnectionString = @"Data Source=localhost\SQLEXPRESS01; AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\ADEGA_IRMAOS_BENINHA.mdf;Database=ADEGA_IRMAOS_BENINHA; Trusted_Connection=Yes;";


                SqlConnection conn = new SqlConnection(sqlConnectionString);
                Server server = new Server(new ServerConnection(conn));

                string dia = DateTime.Now.Day.ToString();
                string mes = DateTime.Now.Month.ToString();
                string ano = DateTime.Now.Year.ToString();
                string backup = @"BACKUP DATABASE ADEGA_IRMAOS_BENINHA TO DISK = 'C:\Users\Pichau\Documents\backup\" + dia + "_" + mes + "_" + ano + "_BACKUP.Bak'";
                server.ConnectionContext.ExecuteNonQuery(backup);

                MessageBox.Show("Realizado com sucesso.");
            }
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio frmRelatorio = new frmRelatorio();
            frmRelatorio.ShowDialog();
        }
    }
}
