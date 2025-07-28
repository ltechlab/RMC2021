using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RMC2021
{
    public partial class SalesMonitoring : Form
    {

        POSDB2Entities db = new POSDB2Entities();
        public SalesMonitoring()
        {
            InitializeComponent();
            LoadGraphs_SalesByCategory();
            LoadGraphs_totalSales();
            LoadGraphs_SalesByItem();
            LoadComboBox_Brand();
        }

        private void LoadGraphs_totalSales()
        {

            //POPULATE COMBOBOX
            var tanong =
            from ord in db.sales_peritem
            select ord;
            List<string> dates = new List<string>()
                {
                    "ALL TIME",
                };


            foreach (sales_peritem ord in tanong)
            {
                DateTime dtRaw = DateTime.ParseExact(ord.purchasedate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                //  DateTime dtRaw = DateTime.Parse(ord.purchasedate);
                string dtFormatted = dtRaw.ToString("MM-yyyy");
                if (dates.Contains(dtFormatted))
                {
                    //SKIP
                }
                else
                {
                    dates.Add(dtFormatted);
                }

            }
            cb_monthyear_total.DataSource = dates;
            cb_monthyear_total.SelectedIndexChanged += new EventHandler(cb_monthyeartotal_selectedIndexChanged);
            string selectedDate = cb_monthyear_total.Text;


            //LOAD THE CHART
            DataTable sales_total_graph = new DataTable();
            //INITIALIZE DATATABLE SUMMARY
            sales_total_graph.Clear();
            sales_total_graph.Columns.Add("date");
            sales_total_graph.Columns.Add("count");

            var query =
            from ord in db.sales_peritem
            select ord;

            foreach (sales_peritem ord in query)
            {
                string purchaseDate = ord.purchasedate;
                DataColumn[] columns = sales_total_graph.Columns.Cast<DataColumn>().ToArray();
                bool anyFieldContainsName = sales_total_graph.AsEnumerable()
                     .Any(row => columns.Any(col => row[col].ToString() == purchaseDate));
                if (anyFieldContainsName)
                {
                    //skip
                }
                else
                {
                    var countme = db.sales_peritem.Where(me => me.purchasedate == purchaseDate).Count();
                    DataRow _ravi = sales_total_graph.NewRow();
                    _ravi["date"] = purchaseDate;
                    _ravi["count"] = countme;
                    sales_total_graph.Rows.Add(_ravi);
                }

                chart_numberofsales.Series["ITEMS SOLD"].XValueMember = "date";
                chart_numberofsales.Series["ITEMS SOLD"].YValueMembers = "count";
                chart_numberofsales.DataSource = sales_total_graph;
                chart_numberofsales.Series["ITEMS SOLD"].BorderWidth = 5;
                chart_numberofsales.DataBind();
            }



        }

        protected void cb_monthyeartotal_selectedIndexChanged(object sender, EventArgs e)
        {

            string selected = this.cb_monthyear.GetItemText(this.cb_monthyear_total.SelectedItem);
            //   MessageBox.Show(selected);


            //MAKE THE DATATATBLE
            DataTable sales_total_graph = new DataTable();
            //INITIALIZE DATATABLE SUMMARY
            sales_total_graph.Clear();
            sales_total_graph.Columns.Add("date");
            sales_total_graph.Columns.Add("count");

            if (selected == "ALL TIME")
            {

                var query =
                 from ord in db.sales_peritem
                 select ord;

                foreach (sales_peritem ord in query)
                {
                    string purchaseDate = ord.purchasedate;
                    DataColumn[] columns = sales_total_graph.Columns.Cast<DataColumn>().ToArray();
                    bool anyFieldContainsName = sales_total_graph.AsEnumerable()
                         .Any(row => columns.Any(col => row[col].ToString() == purchaseDate));
                    if (anyFieldContainsName)
                    {
                        //skip
                    }
                    else
                    {


                        var countme = db.sales_peritem.Where(me => me.purchasedate == purchaseDate).Count();
                        DataRow _ravi = sales_total_graph.NewRow();
                        //convert string to date then, graph
                        //DateTime parsedDate = DateTime.Parse(purchaseDate, "dd-MM-yyyy");
                        try
                        {
                            DateTime parsedDate = DateTime.ParseExact(purchaseDate, "dd-MM-yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
                            //  String newDate = parsedDate.ToString("dd-MM-yyyy");
                            _ravi["date"] = parsedDate.ToShortDateString();
                            //_ravi["date"] = purchaseDate;
                            _ravi["count"] = countme;
                            sales_total_graph.Rows.Add(_ravi);
                        }
                        catch
                        {
                            MessageBox.Show("You have an INVALID Date in your sales monitoring! Make sure you did not import sales records with wrong date formats (not dd-MM-yyyy).", "BMC MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            _ravi["date"] = purchaseDate;
                            _ravi["count"] = countme;
                            sales_total_graph.Rows.Add(_ravi);
                        }

                        /*
                        var countme = db.sales_peritem.Where(me => me.purchasedate == purchaseDate).Count();
                        DataRow _ravi = sales_total_graph.NewRow();
                        _ravi["date"] = purchaseDate;
                        _ravi["count"] = countme;
                        sales_total_graph.Rows.Add(_ravi); */
                    }

                    chart_numberofsales.Series["ITEMS SOLD"].XValueMember = "date";
                    chart_numberofsales.Series["ITEMS SOLD"].YValueMembers = "count";
                    chart_numberofsales.DataSource = sales_total_graph;
                    chart_numberofsales.DataBind();
                }

            }
            else
            {

                var query =
                  from ord in db.sales_peritem
                  where ord.purchasedate.Contains(selected)

                  select ord;

                foreach (sales_peritem ord in query)
                {
                    string purchaseDate = ord.purchasedate;
                    DataColumn[] columns = sales_total_graph.Columns.Cast<DataColumn>().ToArray();
                    bool anyFieldContainsName = sales_total_graph.AsEnumerable()
                         .Any(row => columns.Any(col => row[col].ToString() == purchaseDate));
                    if (anyFieldContainsName)
                    {
                        //skip
                    }
                    else
                    {
                        var countme = db.sales_peritem.Where(me => me.purchasedate == purchaseDate).Count();
                        DataRow _ravi = sales_total_graph.NewRow();
                        _ravi["date"] = purchaseDate;
                        _ravi["count"] = countme;
                        sales_total_graph.Rows.Add(_ravi);
                    }


                    chart_numberofsales.Series["ITEMS SOLD"].XValueMember = "date";
                    chart_numberofsales.Series["ITEMS SOLD"].YValueMembers = "count";
                    chart_numberofsales.DataSource = sales_total_graph;
                    chart_numberofsales.DataBind();
                }

            }

        }

        private void RMSYHAJKHIAY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDB2DataSet.sales_peritem' table. You can move, or remove it, as needed.
            this.sales_peritemTableAdapter.Fill(this.pOSDB2DataSet.sales_peritem);
            salesperitemBindingSource.DataSource = db.sales_peritem.ToList();

        }

        private void LoadGraphs_SalesByCategory()
        {

            //LOAD GRAPH FOR SALES BY BRAND
            using (POSDB2Entities db = new POSDB2Entities())
            {
                //POPULATE COMBOBOX

                var tanong =
                 from ord in db.sales_peritem
                 select ord;
                List<string> dates = new List<string>()
                {
                    "ALL TIME",
                };

                foreach (sales_peritem ord in tanong)
                {
                    DateTime dtRaw = DateTime.ParseExact(ord.purchasedate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    //DateTime dtRaw = DateTime.Parse(ord.purchasedate);
                    string dtFormatted = dtRaw.ToString("MM-yyyy");
                    if (dates.Contains(dtFormatted))
                    { //SKIP
                    }
                    else
                    {
                        dates.Add(dtFormatted);
                    }

                }
                cb_monthyear.DataSource = dates;
                cb_monthyear.SelectedIndexChanged += new EventHandler(cb_monthyear_selectedIndexChanged);

                string selectedDate = cb_monthyear.Text;

                DataTable sales_brand_graph = new DataTable();

                //INITIALIZE DATATABLE SUMMARY
                sales_brand_graph.Clear();
                sales_brand_graph.Columns.Add("category");
                sales_brand_graph.Columns.Add("count");

                //start test
                if (selectedDate == "ALL TIME")
                {

                    var query =
                   from ord in db.sales_peritem
                   select ord;

                    foreach (sales_peritem ord in query)
                    {
                        string sbrand = ord.category;
                        DataColumn[] columns = sales_brand_graph.Columns.Cast<DataColumn>().ToArray();
                        bool anyFieldContainsName = sales_brand_graph.AsEnumerable()
                             .Any(row => columns.Any(col => row[col].ToString() == sbrand));
                        if (anyFieldContainsName)
                        {
                            //skip
                        }
                        else
                        {
                            var countme = db.sales_peritem.Where(me => me.category == sbrand).Count();
                            DataRow _ravi = sales_brand_graph.NewRow();
                            _ravi["category"] = sbrand;
                            _ravi["count"] = countme;
                            sales_brand_graph.Rows.Add(_ravi);
                        }
                    }


                }

                //end test
                else
                {

                    var query =
                    from ord in db.sales_peritem
                    where ord.purchasedate.Contains(selectedDate)

                    select ord;

                    foreach (sales_peritem ord in query)
                    {
                        string sbrand = ord.category;
                        DataColumn[] columns = sales_brand_graph.Columns.Cast<DataColumn>().ToArray();
                        bool anyFieldContainsName = sales_brand_graph.AsEnumerable()
                             .Any(row => columns.Any(col => row[col].ToString() == sbrand));
                        if (anyFieldContainsName)
                        {
                            //skip
                        }
                        else
                        {
                            var countme = db.sales_peritem.Where(me => me.category == sbrand).Count();
                            DataRow _ravi = sales_brand_graph.NewRow();
                            _ravi["category"] = sbrand;
                            _ravi["count"] = countme;
                            sales_brand_graph.Rows.Add(_ravi);
                        }
                    }

                }
                chart_salesbybrand.Series["Sales By Category"].XValueMember = "category";
                chart_salesbybrand.Series["Sales By Category"].YValueMembers = "count";
                chart_salesbybrand.DataSource = sales_brand_graph;
                chart_salesbybrand.DataBind();
              

            
     
            }
        }

        private void LoadComboBox_Brand()
        {

                //POPULATE COMBOBOX
                var brands = db.sales_peritem.Select(o => o.category).Distinct();
                cb_selectBrand.DataSource = brands.ToList();
                //ON COMBOBOX VALUE CHANGED:
                cb_selectBrand.SelectedIndexChanged += new EventHandler(cb_brand_selectedIndexChanged);
            

        }

        protected void cb_brand_selectedIndexChanged(object sender, EventArgs e)
        {

            string selected = this.cb_selectBrand.GetItemText(this.cb_selectBrand.SelectedItem);
   
            //MAKE THE DATATATBLE
            DataTable sales_item_graph = new DataTable();
            //INITIALIZE DATATABLE SUMMARY
            sales_item_graph.Clear();
            sales_item_graph.Columns.Add("label");
            sales_item_graph.Columns.Add("count");

            var query =
           from ord in db.sales_peritem
           where ord.category == selected
           select ord;

            foreach (sales_peritem ord in query)
            {
                string sitem = ord.label;
                DataColumn[] columns = sales_item_graph.Columns.Cast<DataColumn>().ToArray();
                bool anyFieldContainsName = sales_item_graph.AsEnumerable()
                    .Any(row => columns.Any(col => row[col].ToString() == sitem));
                if (anyFieldContainsName)
                {
                    //skip
                }
                else
                {
                    var countme = db.sales_peritem.Where(me => me.label == sitem).Count();
                    DataRow _ravi = sales_item_graph.NewRow();
                    _ravi["label"] = sitem;
                    _ravi["count"] = countme;
                    sales_item_graph.Rows.Add(_ravi);
                }

            }

            chart_salesbyitem.DataSource = sales_item_graph;
            chart_salesbyitem.Series["Sales By Item"].XValueMember = "label";
            chart_salesbyitem.Series["Sales By Item"].YValueMembers = "count";
            chart_salesbyitem.DataSource = sales_item_graph;
            chart_salesbyitem.DataBind();
        }



        protected void cb_monthyear_selectedIndexChanged(object sender, EventArgs e)
        {

            string selected = this.cb_monthyear.GetItemText(this.cb_monthyear.SelectedItem);

       
            //MAKE THE DATATATBLE
            DataTable sales_brand_graph = new DataTable();
            //INITIALIZE DATATABLE SUMMARY
            sales_brand_graph.Clear();
            sales_brand_graph.Columns.Add("category");
            sales_brand_graph.Columns.Add("count");

            var query =
           from ord in db.sales_peritem
           where ord.purchasedate.Contains(selected)
           select ord;

            foreach (sales_peritem ord in query)
            {
                string sbrand = ord.category;
                DataColumn[] columns = sales_brand_graph.Columns.Cast<DataColumn>().ToArray();
                bool anyFieldContainsName = sales_brand_graph.AsEnumerable()
                    .Any(row => columns.Any(col => row[col].ToString() == sbrand));
                if (anyFieldContainsName)
                {
                    //skip
                }
                else
                {
                    var countme = db.sales_peritem.Where(me => me.category == sbrand).Count();
                    DataRow _ravi = sales_brand_graph.NewRow();
                    _ravi["category"] = sbrand;
                    _ravi["count"] = countme;
                    sales_brand_graph.Rows.Add(_ravi);
                }

            }

            chart_salesbybrand.DataSource = sales_brand_graph;
            chart_salesbybrand.Series["Sales By Category"].XValueMember = "category";
            chart_salesbybrand.Series["Sales By Category"].YValueMembers = "count";
            chart_salesbybrand.DataSource = sales_brand_graph;
            chart_salesbybrand.DataBind();

        }

        private void LoadGraphs_SalesByItem()
        {
            using (POSDB2Entities db = new POSDB2Entities())
            {

                //MAKE THE DATATATBLE
                DataTable sales_item_graph = new DataTable();
                //INITIALIZE DATATABLE SUMMARY
                sales_item_graph.Clear();
                sales_item_graph.Columns.Add("item");
                sales_item_graph.Columns.Add("count");

                string selectedBrand = cb_selectBrand.Text;

                var query =
                from ord in db.sales_peritem
                where ord.category == selectedBrand
                select ord;

                foreach (sales_peritem ord in query)
                {
                    string sitem = ord.label;
                    DataColumn[] columns = sales_item_graph.Columns.Cast<DataColumn>().ToArray();
                    bool anyFieldContainsName = sales_item_graph.AsEnumerable()
                        .Any(row => columns.Any(col => row[col].ToString() == sitem));
                    if (anyFieldContainsName)
                    {
                        //skip
                    }
                    else
                    {
                        var countme = db.sales_peritem.Where(me => me.label == sitem).Count();
                        DataRow _ravi = sales_item_graph.NewRow();
                        _ravi["item"] = sitem;
                        _ravi["count"] = countme;
                        sales_item_graph.Rows.Add(_ravi);
                    }
                }

                chart_salesbyitem.Series.Add("Sales By Item");
                chart_salesbyitem.Series["Sales By Item"].XValueMember = "label";
                chart_salesbyitem.Series["Sales By Item"].YValueMembers = "count";
                chart_salesbyitem.DataSource = sales_item_graph;
                chart_salesbyitem.DataBind();

            }
      

        }

        private void loadGrid_Peritem()
        {
            var query = from c in db.sales_peritem
                        select c;
            var users = query.ToList();
            grid_salesperitem.DataSource = users;

            salesperitemBindingSource.DataSource = db.sales_peritem.ToList();
        }

        protected void DeleteRow()
        {

            if (grid_salesperitem.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in grid_salesperitem.SelectedRows)
                {
                    POSDB2Entities db = new POSDB2Entities();
                   // int rowIndex = grid_salesperitem.CurrentCell.RowIndex;
                    //  DataGridViewRow selectedRow = grid_salesperitem.Rows[rowIndex];
                    // int a = Convert.ToInt32(selectedRow.Cells[0].Value);
                    int a = Convert.ToInt32(row.Cells[0].Value);

                    try
                    {

                        var report = (from d in db.sales_peritem
                                      where d.id == a
                                      select d).FirstOrDefault();
                        db.sales_peritem.Remove(report);
                        db.SaveChanges();

                    }
                    catch (Exception ee)
                    {
                        Console.WriteLine(ee);
                    }
                }
                MessageBox.Show("DELETED SUCCESSFULLY!");
                loadGrid_Peritem();
            }
            else
            {
                MessageBox.Show("PLEASE SELECT/HIGHLIGHT THE ENTIRE ROW TO DELETE. You can do this by clicking the leftmost cell of the rows you wish to delete. You can also hold the 'shift button' to select multiple rows.");
            }

            /* if (grid_salesperitem.SelectedCells.Count > 0)
             {

                 int rowIndex = grid_salesperitem.CurrentCell.RowIndex;
                 DataGridViewRow selectedRow = grid_salesperitem.Rows[rowIndex];
                 int a = Convert.ToInt32(selectedRow.Cells[1].Value);

                 try
                 {
                     var report = (from d in db.sales_peritem
                                   where d.id == a
                                   //   select d).Single();
                                   select d).FirstOrDefault();
                     db.sales_peritem.Remove(report);
                     db.SaveChanges();
                 }
                 catch (Exception ee)
                 {
                     Console.WriteLine(ee);
                 }
             }
            */

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DELETE THIS ROW PERMANENTLY?", "CONFIRM DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (grid_salesperitem.Rows.Count == 0)
                {
                    MessageBox.Show("EMPTY LIST!");
                }
                else
                {

                    DeleteRow();
                   // MessageBox.Show("DELETED SUCCESSFULLY!");
                    //loadGrid_Peritem();
                }
            }
            else
            {

            }
        }

        struct DataParameter
        {
            public List<sales_peritem> sales_peritem;
            public string FileName { get; set; }
        }

        DataParameter _inputParameter;

      

        private void btn_exp_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv*", DefaultExt = ".csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _inputParameter.sales_peritem = salesperitemBindingSource.DataSource as List<sales_peritem>;
                    _inputParameter.FileName = sfd.FileName;
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 0;
                    backgroundWorker.RunWorkerAsync(_inputParameter);
                }
            }
        }
     

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<sales_peritem> list = ((DataParameter)e.Argument).sales_peritem;
            string filename = ((DataParameter)e.Argument).FileName;
            int index = 1;

            int process = list.Count;
            using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("id,purchasedate,category,label,costtomake,finalsaleprice,discount,customername,originalprice,cashier");
                foreach (sales_peritem p in list)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process);
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", p.id, "\"" + p.purchasedate +"\"", "\"" + p.category + "\"", "\"" + p.label + "\"", "\"" + p.costtomake +"\"", "\"" + p.finalsaleprice + "\"", "\"" + p.discount + "\"", "\"" + p.customername + "\"", "\"" + p.originalprice + "\"", "\"" + p.cashier + "\""));

                    }
                }
                sw.Write(sb.ToString());
            }
        }


   

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(100);
            MessageBox.Show("Successfully Exported to File!");
            progressBar1.Value = 0;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (txtbox_salesmon.Text == "")
            {
                MessageBox.Show("Please type a KEYWORD in the search box.");

            }
            else
            {
                POSDB2Entities db = new POSDB2Entities();
                var query = from c in db.sales_peritem
                            where
                            c.label.ToLower().Contains(txtbox_salesmon.Text.ToLower()) ||
                            c.category.ToLower().Contains(txtbox_salesmon.Text.ToLower())
                            select c;

                var searchresults = query.ToList();
                grid_salesperitem.DataSource = searchresults;
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            loadGrid_Peritem();
            txtbox_salesmon.Text = "";
        }



    }
}
