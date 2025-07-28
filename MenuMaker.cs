using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMC2021
{
    public partial class MenuMaker : Form
    {
        POSDB2Entities db = new POSDB2Entities();
        DataGridView dg;
        int availability;
        string categ;

        public MenuMaker()
        {
            InitializeComponent();
            loadGrid();
            var query =
             from ord in db.current_user
             where ord.id == 1
             select ord;
            foreach (current_user ord in query)
            {
                lb_cuser.Text = ord.username;
            }
        }

    private void loadGrid()
        {
            var query = from c in db.Menu
                        where c.category == "APPETIZER"
                        select c;
           var users = query.Select(o => new
           { AVAILABLE = o.available, NAME = o.label, DESCRIPTION = o.description, PRICE = o.dishprice, COSTtoMAKE = o.dishcost, DishCode = o.id }).ToList();
            dataGridView1.DataSource = users;

            var query2 = from c in db.Menu
                        where c.category == "MAIN COURSE"
                        select c;
            var users2 = query2.Select(o => new
            { AVAILABLE = o.available, NAME = o.label, DESCRIPTION = o.description, PRICE = o.dishprice, COSTtoMAKE = o.dishcost, DishCode = o.id }).ToList();
            dataGridView2.DataSource = users2;


            var query3 = from c in db.Menu
                         where c.category == "DESSERT"
                         select c;
            var users3 = query3.Select(o => new
            { AVAILABLE = o.available, NAME = o.label, DESCRIPTION = o.description, PRICE = o.dishprice, COSTtoMAKE = o.dishcost, DishCode = o.id }).ToList();
            dataGridView3.DataSource = users3;


            var query4 = from c in db.Menu
                         where c.category == "DRINKS"
                         select c;
            var users4 = query4.Select(o => new
            { AVAILABLE = o.available, NAME = o.label, DESCRIPTION = o.description, PRICE = o.dishprice, COSTtoMAKE = o.dishcost, DishCode = o.id }).ToList();
            dataGridView4.DataSource = users4;

            var query5 = from c in db.Menu
                         where c.category == "SNACKS"
                         select c;
            var users5 = query5.Select(o => new
            { AVAILABLE = o.available, NAME = o.label, DESCRIPTION = o.description, PRICE = o.dishprice, COSTtoMAKE = o.dishcost, DishCode = o.id }).ToList();
            dataGridView5.DataSource = users5;

            var query6 = from c in db.Menu
                         where c.category == "OTHERS"
                         select c;
            var users6 = query6.Select(o => new
            { AVAILABLE = o.available, NAME = o.label, DESCRIPTION = o.description, PRICE = o.dishprice, COSTtoMAKE = o.dishcost, DishCode = o.id }).ToList();
            dataGridView6.DataSource = users6;

            var query7 = from c in db.Menu
                         where c.category == "SPECIAL"
                         select c;
            var users7 = query7.Select(o => new
            { AVAILABLE = o.available, NAME = o.label, DESCRIPTION = o.description, PRICE = o.dishprice, COSTtoMAKE = o.dishcost, DishCode = o.id }).ToList();
            dataGridView7.DataSource = users7;



        }


        private void SaveDish()
        {

            string dname = textBox1.Text;
            string ddesc = richTextBox1.Text;
            double dcost = (double)numericUpDown1.Value;
            string logger = lb_cuser.Text;
        
            double dprice = (double)numericUpDown2.Value;
            if (checkBox1.Checked)
            {
                availability = 1;
            }
            else
            {
                availability = 0;
            }

            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                                .FirstOrDefault(r => r.Checked);
            string category = checkedButton.Text;
   
            try
                {

                    Menu peritem = new Menu()
                    {
                        category = category,
                        label = dname,
                        description = ddesc,
                        dishcost = dcost,
                        dishprice = dprice,
                        available = availability,
                        loggedby = logger
                    };

                    db.Menu.Add(peritem);
                    
                }

                catch (Exception ee)
                {
                    Console.WriteLine(ee);
                
                }
            
            db.SaveChanges();
            MessageBox.Show("Dish saved successfully to database!", "DATABASE UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            
        }

        public void ClearFields()
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
            numericUpDown1.Value = 0;
            label10.Text = "000";
            numericUpDown2.Value = 0;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Please give your DISH a NAME.");
            }else if (richTextBox1.Text == "")
            {
                MessageBox.Show("Please DESCRIBE your DISH.");
            }
            else
            {

                //SQL QUERY
                int dishID = Convert.ToInt32(label10.Text);

                if (db.Menu.Any(u => u.id == dishID))
                {
                    UpdateRow();
                    ClearFields();
                    loadGrid();

                }
                else
                {
                    SaveDish();
                    ClearFields();
                    loadGrid();
                }
                
            }
         
        }


        private void UpdateRow()
        {
            string dname = textBox1.Text;
            string ddesc = richTextBox1.Text;
            double dcost = (double)numericUpDown1.Value;
            string logger = lb_cuser.Text;
            int idd = int.Parse(label10.Text);

            double dprice = (double)numericUpDown2.Value;
            if (checkBox1.Checked)
            {
                availability = 1;
            }
            else
            {
                availability = 0;
            }

            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                                .FirstOrDefault(r => r.Checked);
            string category = checkedButton.Text;
            var query =
                   from ord in db.Menu
                   where ord.id == idd
                   select ord;

            foreach (Menu ord in query)
            {
                ord.category = category;
                ord.label = dname;
                ord.description = ddesc;
                ord.dishcost = dcost;
                ord.dishprice = dprice;
                ord.available = availability;
                ord.loggedby = logger;
            }
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("SAVED CHANGES!");
            }
                catch (Exception ee)
                {
                    Console.WriteLine(ee);
                }
           
            
        }


        protected void DeleteRow()
        {

            if (dg.SelectedCells.Count > 0)
            {

                int rowIndex = dg.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dg.Rows[rowIndex];
                int a = Convert.ToInt32(selectedRow.Cells[5].Value);

                try
                {
                    var report = (from d in db.Menu
                                  where d.id == a
                                  select d).FirstOrDefault();
                    db.Menu.Remove(report);
                    db.SaveChanges();
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee);
                }

            }
        }

        private void cpat()
        {
            if (tabControl1.SelectedTab == APPETIZER)
            {
                categ = "APPETIZER";
                radioButton1.Checked = true;
                dg = dataGridView1;


            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                categ = "MAIN COURSE";
                dg = dataGridView2;
                radioButton2.Checked = true;
            }
            else if (tabControl1.SelectedTab == tabPage1)
            {
                categ = "DESSERT";
                dg = dataGridView3;
                radioButton3.Checked = true;
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                categ = "DRINKS";
                dg = dataGridView4;
                radioButton4.Checked = true;
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                categ = "SNACKS";
                dg = dataGridView5;
                radioButton5.Checked = true;
            }
            else if (tabControl1.SelectedTab == tabPage5)
            {
                categ = "OTHERS";
                dg = dataGridView6;
                radioButton6.Checked = true;
            }
            else if (tabControl1.SelectedTab == tabPage6)
            {
                categ = "SPECIAL";
                dg = dataGridView7;
                radioButton7.Checked = true;
            }
            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            cpat();
            if (MessageBox.Show("Item will be deleted PERMANENTLY. Are you sure you want to delete this? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              {
                  if (dg.Rows.Count == 0)
                  {
                      MessageBox.Show("EMPTY LIST!");
                  }
                  else
                  {
                      
                      DeleteRow();
                      MessageBox.Show("DELETED SUCCESSFULLY!");
                      loadGrid();
                  }
              } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpat();
            if (dg.Rows.Count == 0)
            {

                MessageBox.Show("EMPTY LIST!");

            }
            else
            {
                //LOAD ROW INFO TO DB
                int rowIndex = dg.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dg.Rows[rowIndex];
                int a = Convert.ToInt32(selectedRow.Cells[0].Value);
                
                textBox1.Text = selectedRow.Cells[1].Value.ToString();
                richTextBox1.Text = selectedRow.Cells[2].Value.ToString();
                numericUpDown2.Text = selectedRow.Cells[3].Value.ToString();
                numericUpDown1.Text = selectedRow.Cells[4].Value.ToString();
                label10.Text = selectedRow.Cells[5].Value.ToString();

                int availableba = Convert.ToInt32(selectedRow.Cells[0].Value);
                if (availableba == 1)
                {
                    checkBox1.Checked = true;
                  
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_exp_Click(object sender, EventArgs e)

           
        {
          

            bindingSource1.DataSource = db.Menu.ToList();
            if (backgroundWorker1.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv*", DefaultExt = ".csv", ValidateNames = true })
            {
                sfd.OverwritePrompt = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    _inputParameter.Menu = bindingSource1.DataSource as List<Menu>;
                    _inputParameter.FileName = sfd.FileName;
                    progressBar1.ForeColor = System.Drawing.Color.Teal;
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync(_inputParameter);

                }
            }
        }
        struct DataParameter
        {
            public List<Menu> Menu;
       
            public string FileName { get; set; }
        }

        DataParameter _inputParameter;
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<Menu> list = ((DataParameter)e.Argument).Menu;
            string filename = ((DataParameter)e.Argument).FileName;
            int index = 1;
            int process = list.Count;
            using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("id,category,label,description,dishcost,dishprice,available,loggedby");
                foreach (Menu p in list)
                {
                    if (!backgroundWorker1.CancellationPending)
                    {
                        backgroundWorker1.ReportProgress(index++ * 100 / process);
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", p.id, "\"" + p.category + "\"", "\"" + p.label + "\"", "\"" + p.description + "\"", "\"" + p.dishcost + "\"", "\"" + p.dishprice + "\"", "\"" + p.available + "\"", "\"" + p.loggedby + "\""));

                    }
                }
                sw.Write(sb.ToString());
            }

         
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(100);
            MessageBox.Show("Successfully Exported to File!");
            progressBar1.Value = 0;
        }
    }
}
