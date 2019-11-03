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
    public partial class Cadastro : Form
    {
        HashCode hc = new HashCode(); // Para o hash
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar(txtNome.Text, txtEmail.Text, hc.PassHash(txtSenha.Text)); // hc.PassHash para o hash
            MessageBox.Show(cad.mensagem);
        }
    }
}
