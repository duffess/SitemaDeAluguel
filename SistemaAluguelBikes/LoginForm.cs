using System;
using System.Windows.Forms;

namespace SistemaAluguelBikes
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if ((usuario == "admin" && senha == "admin123") ||
                (usuario == "recep" && senha == "1234"))
            {
                this.Hide();
                MainForm mainForm = new MainForm(usuario);
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                lblErro.Text = "Usuário ou senha inválidos.";
            }
        }
    }
}
