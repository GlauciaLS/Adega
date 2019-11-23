using Menu.Início;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string testeUsuario = "AdminAdega";
            string testeSenha = "1234";

            if (txtUsuario.Text == testeUsuario && txtSenha.Text == testeSenha)
            {
                
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
                frmBemVindo frmBemVindo = new frmBemVindo();
                frmBemVindo.Show();
                this.Hide();
                
                
            }
            else
            {
                MessageBox.Show("Dados incorretos, tente novamente.");
                txtSenha.Text = "";
            }

            
        }
    }
}
