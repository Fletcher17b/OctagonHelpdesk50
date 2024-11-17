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

namespace OctagonHelpdesk
{
    public partial class Frame : Form
    {
        bool sidebarexpand;
        bool ticketcollapsed;
        //UserModel user { get; set; }
        UserModel user = new UserModel();
        public Frame()
        {
            InitializeComponent();
            user.Roles.AdminPerms = false;
            if (!(user.Roles.AdminPerms))
            {
                containerhome.MaximumSize = new System.Drawing.Size(containerhome.MaximumSize.Width, 110);
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                panelouter.Width -= 10;
                if (panelouter.Width == panelouter.MinimumSize.Width)
                {
                    sidebarexpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                panelouter.Width += 10;
                if (panelouter.Width == panelouter.MaximumSize.Width)
                {
                    sidebarexpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void containerstimer_Tick(object sender, EventArgs e)
        {
            if (ticketcollapsed)
            {
                containerhome.Height -= 10;
                if (containerhome.Height == containerhome.MinimumSize.Height)
                {
                    ticketcollapsed = false;
                    containerstimer.Stop();
                }
            }
            else
            {
                containerhome.Height += 10;
                if (containerhome.Height == containerhome.MaximumSize.Height)
                {
                    ticketcollapsed = true;
                    containerstimer.Stop();
                }
            }
        }



        private void homebtn_Click(object sender, EventArgs e)
        {
            containerstimer.Start();
        }
 
        

        private void btnagregarticket_Click_1(object sender, EventArgs e)
        {

        }

        private void addticketpicbx_Click(object sender, EventArgs e)
        {
            btnagregarticket_Click_1(sender, e);
        }

        private void btnverticket_Click(object sender, EventArgs e)
        {

        }

        private void btneditartickets_Click(object sender, EventArgs e)
        {

        }

        private void verpicturebox_Click(object sender, EventArgs e)
        {
            btnverticket_Click(sender, e);
        }

        private void editpicturebox_Click(object sender, EventArgs e)
        {
            btneditartickets_Click(sender, e);
        }

        private void panelouter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelcontent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
