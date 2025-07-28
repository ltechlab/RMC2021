using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace RMC2021
{
    public partial class Profile : Form
    {

        int repeatba;
        POSDB2Entities db = new POSDB2Entities();
        public Profile()
        {
            InitializeComponent();
            UpdateSidebar();
            displayValues();
            load_Calendar();
            load_Tables();
        }

        private void load_Tables()
        {
            ClearTables();
            DynamicGenerateTable_MULTI();
            RefreshListBox();
        }

        public void RefreshListBox()
        {
            
            listBox1.DataSource = db.Reminders.ToList();
            listBox1.DisplayMember = "title";
            listBox1.ValueMember = "id";
        }

        public void DynamicGenerateTable_MULTI()
        {
    
            monthlytable.ColumnCount = 2;
            monthlytable.RowCount = 1;
            monthlytable.Controls.Add(new Label() { Text = "DATE" }, 0, 0);
            monthlytable.Controls.Add(new Label() { Text = "TASK" }, 1, 0);
            monthlytable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            monthlytable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
           

          
            var query =
                from ord in db.Reminders
                where ord.repeat == 1
                select ord;
            
           
            foreach (Reminder ord in query)
            {
             
                string message = ord.title;
                string date = ord.date;
                monthlytable.RowStyles.Add(new RowStyle(SizeType.AutoSize, 10F));
                monthlytable.RowCount = monthlytable.RowCount + 1;
                monthlytable.Controls.Add(new Label() { Text = date, Anchor = AnchorStyles.Top | AnchorStyles.Left, AutoSize = true }, 0, monthlytable.RowCount - 1);
                monthlytable.Controls.Add(new Label() { Text = message, Anchor = AnchorStyles.Top | AnchorStyles.Left, AutoSize = true }, 1, monthlytable.RowCount - 1);

            }


        }

        public void ClearTables()
        {


            monthlytable.RowStyles.Clear();
            monthlytable.Controls.Clear();


        }

        private void btn_savereminder_Click(object sender, EventArgs e)
        {
            if (tb_remind.Text != "")
            {
                SaveSchedule();
                load_Tables();
                load_Calendar();

            }
            else
            {
                MessageBox.Show("Please don't leave text field blank!", "BMC : ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_Calendar()
        {
            //MAKE A STRING OF ALL DATES IN DATABASE
            List<DateTime> scheduledDates = new List<DateTime>();
            List<DateTime> scheduledDates_repeat = new List<DateTime>();
  

            var checkDate =
            from ord in db.Reminders
            where ord.repeat == 0
            select ord;

            foreach (Reminder ord in checkDate)
            {
                DateTime exists = DateTime.ParseExact(ord.date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                bool exist = scheduledDates.Any(d => d.Month == exists.Month && d.Day == exists.Day && d.Year == exists.Year);
                if (exist)
                {

                }
                else
                {
                scheduledDates.Add(exists);
                }

            }

            var checkDate2 =
           from ord2 in db.Reminders
           where ord2.repeat == 1
           select ord2;

            foreach (Reminder ord in checkDate2)
            {
                DateTime exists = DateTime.ParseExact(ord.date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                bool exist = scheduledDates.Any(d => d.Month == exists.Month && d.Day == exists.Day && d.Year == exists.Year);
                if (exist)
                {
                 
                }
                else
                {
                    scheduledDates_repeat.Add(exists);
                }

            }

            
            calendar.BoldedDates = scheduledDates.ToArray();
            calendar.MonthlyBoldedDates = scheduledDates_repeat.ToArray();




        }

        private void SaveSchedule()
        {
            string reminderz = tb_remind.Text;
            string theDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            if (cb_repeating.Checked)
            {
                repeatba = 1;
            }
            else
            {
                repeatba = 0;
            }


            try
            {
                Reminder reminder = new Reminder()
                {
                    title = reminderz,
                    date = theDate,
                    repeat = repeatba,
                };

                db.Reminders.Add(reminder);
                db.SaveChanges();
                MessageBox.Show("SAVED SUCCESSFULLY!");
                tb_remind.Text = "";
            }

            catch (Exception ee)
            {
                Console.WriteLine(ee);
                // Provide for exceptions.
            }



        }

        private void btn_deletesched_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Schedule will be deleted PERMANENTLY. Are you sure you want to delete this? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteReminder();
                RefreshListBox();
                load_Tables();
                load_Calendar();
            }
        }

        public void DeleteReminder()
        {
            var selectedValue = listBox1.SelectedItem;
            if (selectedValue != null)
            {
                int valueint = Int32.Parse(listBox1.SelectedValue.ToString());
                try
                {

                    var report = (from d in db.Reminders
                                  where d.id == valueint
                               
                                  select d).FirstOrDefault();

                    db.Reminders.Remove(report);
                    db.SaveChanges();



                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee);
                }


            }

        }

        private void UpdateSidebar()
        {
            var getrecord = db.bprofile.Where(a => a.id == 1).SingleOrDefault();
            txt_bname.Text = getrecord.bname;
            txt_tin.Text = getrecord.tinumber;
            badd.Text = getrecord.baddress;
            bnat.Text = getrecord.bnature;
            dtic.Text = getrecord.dtinumber;
            blic.Text = getrecord.blisencenumber;
        }

        private void displayValues()
        {
            var getrecord = db.bprofile.Where(a => a.id == 1).SingleOrDefault();
            bname.Text = getrecord.bname;
            tb_tin.Text = getrecord.tinumber;
            baddress.Text = getrecord.baddress;
            bnature.Text = getrecord.bnature;
            dticert.Text = getrecord.dtinumber;
            blicense.Text = getrecord.blisencenumber;

            var query =
               from ord in db.current_user
               where ord.id == 1
               select ord;

            foreach (current_user ord in query)
            {

                if (ord.admin == 1)
                {

                    lb_cuser.Text = "ADMIN USER";
                }
                else
                {

                    lb_cuser.Text = "NORMAL USER";
                }
            }
        }


        private void btn_updateprofile_Click(object sender, EventArgs e)
        {
           if (lb_cuser.Text == "ADMIN USER")
            {
                //get entries from the text boxes and replace row
                string newName = bname.Text;
                string newTin = tb_tin.Text;
                string newBadd = baddress.Text;
                string newNature = bnature.Text;
                string newDti = dticert.Text;
                string newLicense = blicense.Text;

                //SQL QUERY
                var query =
                    from ord in db.bprofile
                    where ord.id == 1
                    select ord;
                // Execute the query, and change the column values
                // you want to change.
                foreach (bprofile ord in query)
                {
                    ord.bname = newName;
                    ord.tinumber = newTin;
                    ord.baddress = newBadd;
                    ord.bnature = newNature;
                    ord.dtinumber = newDti;
                    ord.blisencenumber = newLicense;
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
                displayValues();
                UpdateSidebar();
                MessageBox.Show("Business details successfully modified!", "MODIFICATION SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ONLY ADMIN USERS can edit business profile.", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        public void DynamicGenerateTable_TODAY(string selectedDate)
        {
            tb_today.ColumnCount = 2;
            tb_today.RowCount = 1;
            tb_today.Controls.Add(new Label() { Text = "DATE" }, 0, 0);
            tb_today.Controls.Add(new Label() { Text = "TASK" }, 1, 0);
            tb_today.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tb_today.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));

            var query =
                from ord in db.Reminders
                where ord.date == selectedDate
                select ord;
            if (query.Count() > 0)
            {

                foreach (Reminder ord in query)
                {
                    //get record on Message
                    string message = ord.title;
                    string date = ord.date;
                    tb_today.RowStyles.Add(new RowStyle(SizeType.AutoSize, 10F));
                    tb_today.RowCount = tb_today.RowCount + 1;
                    tb_today.Controls.Add(new Label() { Text = date, Anchor = AnchorStyles.Top | AnchorStyles.Left, AutoSize = true }, 0, tb_today.RowCount - 1);
                    tb_today.Controls.Add(new Label() { Text = message, Anchor = AnchorStyles.Top | AnchorStyles.Left, AutoSize = true }, 1, tb_today.RowCount - 1);
                }
            }

        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //  string selected = calendar.SelectionRange.Start.ToString();
            tb_today.RowStyles.Clear();
            tb_today.Controls.Clear();
            DateTime d = calendar.SelectionRange.Start;
            string selected = d.ToString("dd-MM-yyyy");
            lb_char.Text = selected;
            DynamicGenerateTable_TODAY(selected);
        }
    }
}
