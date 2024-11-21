using System;
using System.Windows.Forms;
using OctagonHelpdesk.Helpers;
using OctagonHelpdesk.Models;

namespace OctagonHelpdesk
{
    public partial class LoginFrm : Form
    {
        public UserModel CurrentUser { get; private set; }
        private bool submitted = false;

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string inputuser = txbuser.Text.Trim();
            string inputpassword = txbpassword.Text.Trim();

            if (string.IsNullOrEmpty(inputuser) || string.IsNullOrEmpty(inputpassword))
            {
                MessageBox.Show("Credenciales vacías", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Verificar las credenciales utilizando AuthenticationService
                if (AuthenticationService.ValidateCredentials(inputuser, inputpassword))
                {
                    CurrentUser = AuthenticationService.GetCurrentUser(inputuser);
                    this.DialogResult = DialogResult.OK;
                    submitted = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciales inválidas");
                }
            }
        }
    }
}
