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
    public partial class UserManagement : Form
    {

        int adminba;
        POSDB2Entities db = new POSDB2Entities();

        public UserManagement()
        {
            InitializeComponent();
            loadGrid();
            tb_upass.PasswordChar = '*';
            tb_upass2.PasswordChar = '*';
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {

            //SQL QUERY
            int userID = Convert.ToInt32(lb_id.Text);

            if (db.admin_users.Any(u => u.id == userID))
            {
                UpdateRow();

            }
            else
            {
                SaveNewUser();
            }

        }

        private void UpdateRow()
        {
            //get the strings
            string fullName = tb_fullname.Text;
            string Description = tb_desc.Text;
            string userName = tb_uname.Text;
            string userPass = tb_upass.Text;
            string userPass2 = tb_upass2.Text;
            int uid = Convert.ToInt32(lb_id.Text);
            if (cb_admin.Checked)
            {
                adminba = 1;
            }
            else
            {
                adminba = 0;
            }

            if (userPass == userPass2)
            {


                //SQL QUERY
                var query =
                    from ord in db.admin_users
                    where ord.id == uid
                    select ord;
                // Execute the query, and change the column values
                // you want to change.
                foreach (admin_users ord in query)
                {
                    ord.fullname = fullName;
                    ord.designation = Description;
                    ord.username = userName;
                    ord.password = userPass;
                    ord.admin = adminba;
                }

                // Submit the changes to the database.
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee);
                    // Provide for exceptions.
                }
                MessageBox.Show("DETAILS MODIFIED SUCCESSFULLY!");
                loadGrid();
                clearValues();
            }
            else
            {
                MessageBox.Show("Passwords do not match!", "BMC : ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SaveNewUser()
        {
            //get the strings
            string fullName = tb_fullname.Text;
            string Description = tb_desc.Text;
            string userName = tb_uname.Text;
            string userPass = tb_upass.Text;
            string userPass2 = tb_upass2.Text;

            //CHECK FOR BLANKS
            if (fullName != "" && Description != "" && userName != "" && userPass != "")
            {

                if (cb_admin.Checked)
                {
                    adminba = 1;
                }
                else
                {
                    adminba = 0;
                }

                if (userPass == userPass2)
                {

                    try
                    {

                        admin_users adminusers = new admin_users()
                        {
                            username = userName,
                            password = userPass,
                            fullname = fullName,
                            designation = Description,
                            admin = adminba,
                        };

                        db.admin_users.Add(adminusers);
                        db.SaveChanges();
                        MessageBox.Show("SAVED SUCCESSFULLY!");
                        loadGrid();
                        clearValues();

                    }

                    catch (Exception ee)
                    {
                        Console.WriteLine(ee);
                        // Provide for exceptions.
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match!", "BMC : ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please don't leave text field blank!", "BMC : ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteRow_admin()
        {
            if (grid_users.SelectedCells.Count > 0)
            {
                int rowIndex = grid_users.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = grid_users.Rows[rowIndex];
                int a = Convert.ToInt32(selectedRow.Cells[0].Value);

                try
                {

                    var report = (from d in db.admin_users
                                  where d.id == a
                                  //   select d).Single();
                                  select d).FirstOrDefault();
                    db.admin_users.Remove(report);
                    db.SaveChanges();
                    MessageBox.Show("USER DELETED!");
                    loadGrid();
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee);
                }
            }
        }

        private void DeleteRow_normal()
        {
            if (grid_users_normal.SelectedCells.Count > 0)
            {
                int rowIndex = grid_users_normal.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = grid_users_normal.Rows[rowIndex];
                int a = Convert.ToInt32(selectedRow.Cells[0].Value);

                try
                {
                    var report = (from d in db.admin_users
                                  where d.id == a
                                  //   select d).Single();
                                  select d).FirstOrDefault();
                    db.admin_users.Remove(report);
                    db.SaveChanges();
                    MessageBox.Show("USER DELETED!");
                    loadGrid();
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee);
                }
            }
        }

        private void clearValues()
        {
            tb_uname.Text = "";
            tb_upass.Text = "";
            tb_fullname.Text = "";
            tb_desc.Text = "";
            tb_upass2.Text = "";
            cb_admin.Checked = false;
            lb_id.Text = "000";

        }

        private void loadGrid()
        {

            var query = from c in db.admin_users
                        where c.admin == 1
                        select c;
            var users = query.ToList();
            grid_users.DataSource = users;

            var query2 = from c in db.admin_users
                         where c.admin == 0
                         select c;
            var users2 = query2.ToList();
            grid_users_normal.DataSource = users2;


        }

        private void btn_edituser_normal_Click(object sender, EventArgs e)
        {
            if (grid_users_normal.Rows.Count == 0)
            {
                MessageBox.Show("EMPTY LIST!");


            }
            else
            {
                //LOAD ROW INFO TO DB
                int rowIndex = grid_users_normal.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = grid_users_normal.Rows[rowIndex];
                int a = Convert.ToInt32(selectedRow.Cells[0].Value);

                lb_id.Text = selectedRow.Cells[0].Value.ToString();
                tb_uname.Text = selectedRow.Cells[1].Value.ToString();
                tb_upass.Text = selectedRow.Cells[2].Value.ToString();
                tb_fullname.Text = selectedRow.Cells[3].Value.ToString();
                tb_desc.Text = selectedRow.Cells[4].Value.ToString();
                int adminngaba = Convert.ToInt32(selectedRow.Cells[5].Value);
                if (adminngaba == 1)
                {
                    cb_admin.Checked = true;
                }
                else
                {
                    cb_admin.Checked = false;
                }
            }
        }

        private void btn_edituser_Click(object sender, EventArgs e)
        {

            if (grid_users.Rows.Count == 0)
            {

                MessageBox.Show("EMPTY LIST!");

            }
            else
            {
                //LOAD ROW INFO TO DB
                int rowIndex = grid_users.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = grid_users.Rows[rowIndex];
                int a = Convert.ToInt32(selectedRow.Cells[0].Value);

                lb_id.Text = selectedRow.Cells[0].Value.ToString();
                tb_uname.Text = selectedRow.Cells[1].Value.ToString();
                tb_upass.Text = selectedRow.Cells[2].Value.ToString();
                tb_fullname.Text = selectedRow.Cells[3].Value.ToString();
                tb_desc.Text = selectedRow.Cells[4].Value.ToString();
                int adminngaba = Convert.ToInt32(selectedRow.Cells[5].Value);
                if (adminngaba == 1)
                {
                    cb_admin.Checked = true;
                }
                else
                {
                    cb_admin.Checked = false;
                }
            }
        }

        private void btn_deleteuser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Selected account will be deleted PERMANENTLY. Are you sure you want to delete this user? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (grid_users.Rows.Count == 1)
                {
                    MessageBox.Show("CANNOT LEAVE USER LIST ZERO!");
                }
                else
                {
                    DeleteRow_admin();

                }
            }
        }

        private void btn_deleteuser_normal_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Selected account will be deleted PERMANENTLY. Are you sure you want to delete this user? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (grid_users_normal.Rows.Count == 0)
                {
                    MessageBox.Show("EMPTY LIST!");
                }
                else
                {
                    DeleteRow_normal();

                }
            }
        }

        private void HYZNAAFWES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admin_Users.admin_users' table. You can move, or remove it, as needed.
            this.admin_usersTableAdapter.Fill(this.admin_Users.admin_users);

        }
    }
}
