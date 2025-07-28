using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMC2021
{
    public partial class PassChange : Form
    {

        POSDB2Entities db = new POSDB2Entities();
        public PassChange()
        {
            InitializeComponent();
            tb_oldpass.PasswordChar = '*';
            tb_newpass.PasswordChar = '*';
            tb_newpass2.PasswordChar = '*';
            var query =
           from ord in db.current_user
           where ord.id == 1
           select ord;
            foreach (current_user ord in query)
            {
                lb_cuser.Text = ord.username;
                lb_desc.Text = ord.description;
            }
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            string cuser = lb_cuser.Text;
            string oldpass = tb_oldpass.Text;
            string newpass = tb_newpass.Text;
            string newpass2 = tb_newpass2.Text;

            var query =
           from ord in db.admin_users
           where ord.username == cuser
           select ord;
            foreach (admin_users ord in query)
            {

                if (ord.password == oldpass)
                {
                    //check if the same ang new passes
                    if (newpass == newpass2)
                    {
                        //save

                        ord.password = newpass;
                        db.SaveChanges();
                        lb_notice.Text = "PASSWORD SUCCESSFULLY CHANGED!";
                        tb_oldpass.Text = "";
                        tb_newpass.Text = "";
                        tb_newpass2.Text = "";
                    }
                    else
                    {
                        lb_notice.Text = "YOUR NEW PASSWORDS DO NOT MATCH.";
                    }

                }
                else
                {
                    lb_notice.Text = "YOUR 'OLD PASSWORD' IS WRONG.";

                }

            }
        }

        private void lb_notice_Click(object sender, EventArgs e)
        {

        }
    }
}
