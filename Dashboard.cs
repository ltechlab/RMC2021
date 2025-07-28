using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RMC2021
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            DisplayCurrentUser();
        }

        private void DisplayCurrentUser()
        {
            POSDB2Entities db = new POSDB2Entities();
            var query =
                from ord in db.current_user
                where ord.id == 1
                select ord;

            foreach (current_user ord in query)
            {
                lb_current_fullname.Text = ord.fullname;
                lb_designation.Text = ord.description;

                if (ord.admin == 1)
                {

                    lb_admin.Text = "ADMIN USER";
                }
                else
                {

                    lb_admin.Text = "NORMAL USER";
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            MenuMaker frm = new MenuMaker();
            frm.Show();
        
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
           Profile frm = new Profile();
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            POS frm = new POS();
            frm.Show(); 
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            if (lb_admin.Text == "ADMIN USER")
            {
                SalesMonitoring frm = new SalesMonitoring();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ONLY ADMIN USERS can edit business profile.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

         
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (lb_admin.Text == "ADMIN USER")
            {

                FinanceMonitoring frm = new FinanceMonitoring();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ONLY ADMIN USERS can edit business profile.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {

         

             
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassChange frm = new PassChange();
            frm.Show(); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Orders frm = new Orders();
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void contactDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us at http://www.layertechlab.com/ or send an email with your REGISTERED EMAIL-ADDRESS to support@layertechlab.com", "CONTACT LAYERTECH", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "file://C:\\Layertech Software Labs\\Layertech RMC Manual.chm");
            Help.ShowHelp(this, Application.StartupPath + @"\" + "RMC21.chm");
        }

        private void adminControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_admin.Text == "ADMIN USER")
            {

                UserManagement frm = new UserManagement();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ONLY ADMIN USERS can edit business profile.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void importSalesDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_admin.Text == "ADMIN USER")
            {

                Form3 frm = new Form3();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ONLY ADMIN USERS can edit business profile.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void importMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_admin.Text == "ADMIN USER")
            {

                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ONLY ADMIN USERS can edit business profile.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
