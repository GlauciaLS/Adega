using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Início
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string sqlConnectionString = @"Data Source=localhost\SQLEXPRESS01; AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\ADEGA_IRMAOS_BENINHA.mdf;Database=ADEGA_IRMAOS_BENINHA; Trusted_Connection=Yes;";


            SqlConnection conn = new SqlConnection(sqlConnectionString);
            Server server = new Server(new ServerConnection(conn));
            
            string diretorio = txtDiretorio.Text + "\\";

            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            string backup = @"BACKUP DATABASE ADEGA_IRMAOS_BENINHA TO DISK = '" + diretorio + "" + dia + "_" + mes + "_" + ano + "_BACKUP.Bak'";
            server.ConnectionContext.ExecuteNonQuery(backup);

            MessageBox.Show("Realizado com sucesso.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string diretorio; 
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                diretorio = fbd.SelectedPath;
                txtDiretorio.Text = diretorio;
            }            
        }
    }
}
