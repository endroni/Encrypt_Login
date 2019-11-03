using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptLogin
{
    public partial class Login : Form
    { 
        public Login()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro form = new EncryptLogin.Cadastro();
            this.Hide();
            form.Show();
        }
    }
}

