using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OctagonHelpdesk.Models;
using OctagonHelpdesk.Services;

namespace OctagonHelpdesk.Formularios
{
    public partial class LoginFrm : Form
    {
        public bool submitted = false;
        public UserModel CurrentUser { get; set; }
        public LoginFrm()
        {
            InitializeComponent();
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            UsuarioService usuarioService = new UsuarioService();

            string inputuser = txbuser.Text;
            string inputpassword = txbpassword.Text;
            inputuser = inputuser.Trim();


            if (string.IsNullOrEmpty(txbuser.Text) || string.IsNullOrEmpty(txbpassword.Text))
            {
                MessageBox.Show("Credenciales vacias");
            }

            bool temp = inputuser.Equals("User") && inputpassword.Equals("123");
            //&& usuarioService.CheckUser(inputuser, inputpassword)
            if ((!string.IsNullOrEmpty(txbuser.Text) && !string.IsNullOrEmpty(txbpassword.Text)) && inputuser.Equals("User") && inputpassword.Equals("123"))
            {
                CurrentUser = new UserModel { 
                    Name = txbuser.Text              
                };
                this.DialogResult = DialogResult.OK;
                submitted = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("Credenciales invalidas");
            }

           

        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
