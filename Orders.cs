using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DGVPrinterHelper;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMC2021
{ 

    public partial class Orders : Form
    {

        DataTable orders = new DataTable();
        DateTime dateToday = DateTime.UtcNow.Date;
        POSDB2Entities db = new POSDB2Entities();
        int qty;
        double ttprice;
        int discount;

        public Orders()
        {
            InitializeComponent();
            LoadComboBoxes();
     
            var query =
              from ord in db.current_user
              where ord.id == 1
              select ord;
            foreach (current_user ord in query)
            {
                lb_cuser.Text = ord.username;
            }


            //INITIALIZE DATATABLE ORDERS
            orders.Clear();
            orders.Columns.Add("category");
            orders.Columns.Add("label");
            orders.Columns.Add("qty");
            orders.Columns.Add("discount");
            orders.Columns.Add("price");
            orders.Columns.Add("totalprice");

           setOrderSummary();
        }

        private void btn_addtolist_Click(object sender, EventArgs e)
        {
            string brand = cb_brand.Text;
            string item = cb_item.Text;
            double pricez = Convert.ToDouble(lb_price.Text);


            if (brand == "")
            {
                MessageBox.Show("Please input item BRAND", "PLEASE INPUT BRAND", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (item == "")
            {
                MessageBox.Show("Please input item NAME", "PLEASE INPUT ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pricez == 0)

            {
                MessageBox.Show("PRICE CAN'T BE ZERO.", "PLEASE INPUT PRICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_qty.Text == "")
            {
                MessageBox.Show("Please input QUANTITY.", "PLEASE INPUT QUANTITY", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (tb_diskawnt.Text == "")
            {
                MessageBox.Show("Please input DISCOUNT.", "PLEASE INPUT DISCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                qty = Convert.ToInt32(tb_qty.Text);

                discount = (int)tb_diskawnt.Value;
                double discounted = discount * pricez / 100;
                ttprice = (pricez - discounted) * qty;

                //SAVE TO DATATABLE
                DataRow _ravi = orders.NewRow();
                _ravi["category"] = brand;
                _ravi["label"] = item;
                _ravi["qty"] = qty;
                _ravi["discount"] = discount;
                _ravi["price"] = pricez;
                _ravi["totalprice"] = ttprice;
                orders.Rows.Add(_ravi);

                compute_subtotal();
            }
        }

        private void LoadComboBoxes()
        {


            //populate BRAND
            var meronba = db.Menu.Select(c => c.category).Distinct().ToList();
            cb_brand.DataSource = meronba;

            //populate ITEMNAME (INITIALIZE)
            cb_brand.SelectedIndexChanged += new EventHandler(cb_brand_selectedIndexChanged);


        }

        protected void cb_brand_selectedIndexChanged(object sender, EventArgs e)
        {

            string selected = this.cb_brand.GetItemText(this.cb_brand.SelectedItem);

            DataTable dt = new DataTable();

            dt.Clear();
            dt.Columns.Add("id");
            dt.Columns.Add("category");
            dt.Columns.Add("label");
            dt.Columns.Add("dishcost");
            dt.Columns.Add("dishprice");

            var query =
           from ord in db.Menu
           where ord.category == selected
           select ord;

            foreach (Menu ord in query)
            {
                DataRow _ravi = dt.NewRow();
                _ravi["category"] = ord.category;
                _ravi["label"] = ord.label;   
                _ravi["dishcost"] = ord.dishcost;
                _ravi["dishprice"] = ord.dishprice;
                dt.Rows.Add(_ravi);

            }

            cb_item.DataSource = dt;
            cb_item.ValueMember = "label";
            cb_item.DisplayMember = "label";
            cb_item.SelectedIndexChanged += new EventHandler(cb_item_selectedIndexChanged);
        }

        protected void cb_item_selectedIndexChanged(object sender, EventArgs e)
        {

            string selected = this.cb_item.GetItemText(this.cb_item.SelectedItem);
            string selectedBrand = this.cb_brand.GetItemText(this.cb_brand.SelectedItem);


            var query =
            from ord in db.Menu
            where ord.category == selectedBrand && ord.label == selected
            select ord;

            foreach (Menu ord in query)
            {
                lb_price.Text = Convert.ToString(ord.dishprice);
            }


        }


        private void compute_subtotal()
        {
            grid_orderlist.DataSource = orders;
            var result = orders.AsEnumerable()
                    .Sum(x => Convert.ToDouble(x["totalprice"]));

            lb_subtotal.Text = result.ToString();


        }

        private void btn_addtolist_new_Click(object sender, EventArgs e)
        {
            //GET ITEM DETAILS
            string brands = tb_brand.Text;
            string items = tb_item.Text;

            if (brands == "")
            {
                MessageBox.Show("Please input item BRAND", "PLEASE INPUT BRAND", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (items == "")
            {
                MessageBox.Show("Please input item NAME", "PLEASE INPUT ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_disc.Text == "")
            {
                MessageBox.Show("Please input DISCOUNT.", "PLEASE INPUT DISCOUNT", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (tb_price.Text == "")
            {
                MessageBox.Show("PRICE CAN'T BE ZERO.", "PLEASE INPUT PRICE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_qty2.Text == "")
            {
                MessageBox.Show("Please input QUANTITY.", "PLEASE INPUT QUANTITY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                discount = (int)tb_disc.Value;

                qty = Convert.ToInt32(tb_qty2.Text);
                double prices = (double)tb_price.Value;
                double discounted = discount * prices / 100;
                ttprice = (prices - discounted) * qty;


                //SAVE TO DATATABLE
                DataRow _ravi = orders.NewRow();
                _ravi["category"] = brands;
                _ravi["label"] = items;
                _ravi["qty"] = qty;
                _ravi["discount"] = discount;
                _ravi["price"] = prices;
                _ravi["totalprice"] = ttprice;
                orders.Rows.Add(_ravi);

                compute_subtotal();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = grid_orderlist.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (dr != null)
            {
                var rowToRemove = orders.Rows.Cast<DataRow>().FirstOrDefault(row => row[0] == dr.Cells[0].Value);
                if (rowToRemove != null)
                    orders.Rows.Remove(rowToRemove);
            }

            compute_subtotal();
        }


        private bool CheckBeforeOut()
        {
            string cname = tb_cname.Text;
            string cadd = tb_address.Text;
            string ccontact = tb_contact.Text;

            if (cname != "" && cadd != "" && ccontact != "")
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        private void clearFields()
        {

            tb_cname.Text = "";
            tb_address.Text = "";
            tb_contact.Text = "";
            cb_brand.Text = "";
            cb_item.Text = "";
            tb_diskawnt.Text = "";
            tb_qty.Text = "";
            tb_brand.Text = "";
            tb_item.Text = "";
            tb_price.Text = "";
            tb_qty2.Text = "";
            tb_disc.Text = "";
            lb_subtotal.Text = "0";
            tb_notes.Text = "";

            orders.Clear();

        }

        private void btn_placeorder_Click(object sender, EventArgs e)
        {

            if (CheckBeforeOut() == true)
            {

                DialogResult result = MessageBox.Show("CONFIRM ORDER?", "CONFIRM ORDER?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    foreach (DataRow row in orders.Rows)
                    {

                        string customer = tb_cname.Text;
                        string address = tb_address.Text;
                        string contacts = tb_contact.Text;
                        string notez = tb_notes.Text;

                        if (db.sales_customers.Any(o => o.customername == customer))
                        {
                        }
                        else
                        {
                            sales_customers spera = new sales_customers()
                            {
                                customername = customer,
                                customeraddress = address,
                                customercontact = contacts,

                            };

                            db.sales_customers.Add(spera);
                        }

                        string deliverydatez = delivery_picker.Value.ToString("dd-MM-yyyy");
                        double subtotal = Convert.ToDouble(lb_subtotal.Text);

                        string obrand = row.Field<string>("category");
                        string oiname = row.Field<string>("label");
                        int oqty = int.Parse(row.Field<string>("qty"));
                        int odisc = int.Parse(row.Field<string>("discount"));
                        double oprice = double.Parse(row.Field<string>("price"));
                        string odate = dateToday.ToString("dd-MM-yyyy");
                        double tpriz = double.Parse(row.Field<string>("totalprice"));
                        string loggedBy = lb_cuser.Text;


                        sales_pending_orders sper = new sales_pending_orders()
                        {
                            category = obrand,
                            label = oiname,
                            qty = oqty,
                            dateorderplaced = odate,
                            customername = customer,
                            discount = odisc,
                            price = oprice,
                            deliverydate = deliverydatez,
                            tprice = tpriz,
                            loggedby = loggedBy,
                            notes = notez,
                        };
                        db.sales_pending_orders.Add(sper);
                    }

                    db.SaveChanges();
                    MessageBox.Show("Order successfully saved to database!", "ORDER SAVED TO DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    setOrderSummary();
                }
                else if (result == DialogResult.No)
                {
                }
            }
            else
            {
                MessageBox.Show("Please complete customer information before checkout", "PLEASE COMPLETE CUSTOMER INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setOrderSummary()
        {

            DataTable order_summary = new DataTable();

            //INITIALIZE DATATABLE SUMMARY
            order_summary.Clear();
            order_summary.Columns.Add("customername");
            order_summary.Columns.Add("address");
            order_summary.Columns.Add("contact");

            var query =
           from ord in db.sales_pending_orders
           select ord;

            foreach (sales_pending_orders ord in query)
            {
                string customernamez = ord.customername;
                bool anyFieldContainsName = order_summary.AsEnumerable().Any(row => customernamez == row.Field<String>("customername"));
                if (anyFieldContainsName)
                {
                    //skip
                }
                else
                {

                    var query2 =
                        from orda in db.sales_customers
                        where orda.customername == customernamez
                        select orda;

                    foreach (sales_customers orda in query2)
                    {
                        string caddress = orda.customeraddress;
                        string ccontact = orda.customercontact;

                        bool anyFieldContainsName2 = order_summary.AsEnumerable().Any(row => customernamez == row.Field<String>("customername"));
                        if (anyFieldContainsName2)
                        {
                            //skip
                        }
                        else
                        {

                            //add row
                            DataRow _ravi = order_summary.NewRow();
                            _ravi["customername"] = customernamez;
                            _ravi["address"] = caddress;
                            _ravi["contact"] = ccontact;
                            order_summary.Rows.Add(_ravi);
                        }
                    }
                }
            }
            grid_customerlist.DataSource = order_summary;


        }
        private void grid_customerlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selectedrowindex = grid_customerlist.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grid_customerlist.Rows[selectedrowindex];
            string selectedCustomer = Convert.ToString(selectedRow.Cells["customername"].Value);

            var query =
                from ord in db.sales_pending_orders
                where ord.customername == selectedCustomer
                select ord;

            var countme = query.Count();

            if (countme > 0)
            {
                var selectedorders = query.ToList();
                grid_orders.DataSource = selectedorders;

            }
            else
            {

            }


        }

        private void RefreshGrid_customerlist()
        {
            if (grid_customerlist.Rows.Count == 0)
            { //do nothing
            }
            else
            {
                try
                {
                    int selectedrowindex = grid_customerlist.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = grid_customerlist.Rows[selectedrowindex];
                    string selectedCustomer = Convert.ToString(selectedRow.Cells["customername"].Value);

                    var query =
                        from ord in db.sales_pending_orders
                        where ord.customername == selectedCustomer
                        select ord;

                    var countme = query.Count();

                    if (countme > 0)
                    {
                        var selectedorders = query.ToList();
                        grid_orders.DataSource = selectedorders;
                    }
                    else
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("The list is empty.", "EMPTY LIST!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grid_orders.DataSource = null;

                }
            }
        }

        private void btn_removeorder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Item will be deleted PERMANENTLY. Are you sure you want to delete this? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteRow_orders();
                setOrderSummary();
                RefreshGrid_customerlist();
                DeleteRow_customer();
            }
        }


        protected void DeleteRow_orders()
        {
            if (grid_orders.SelectedCells.Count > 0)
            {

                int rowIndex = grid_orders.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = grid_orders.Rows[rowIndex];
                int a = Convert.ToInt32(selectedRow.Cells[0].Value);

                try
                {
                    var report = (from d in db.sales_pending_orders
                                  where d.id == a
                                  //   select d).Single();
                                  select d).FirstOrDefault();
                    db.sales_pending_orders.Remove(report);
                    db.SaveChanges();

                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee);
                }
            }

        }

        protected void DeleteRow_customer()
        {

            var query =
                from ord in db.sales_customers
                select ord;

            foreach (sales_customers ord in query)
            {

                var query2 =
                from orda in db.sales_pending_orders
                where orda.customername == ord.customername
                select orda;

                var countme = query2.Count();

                if (countme > 0)
                {

                }
                else
                {

                    var report = (from d in db.sales_customers
                                  where d.customername == ord.customername
                                  //   select d).Single();
                                  select d).FirstOrDefault();
                    db.sales_customers.Remove(report);
                    db.SaveChanges();
                }
            }

        }

        private void btn_printreceipt_Click(object sender, EventArgs e)
        {
            printDeliveryReceipt();
        }
        private void printDeliveryReceipt()
        {

            try
            {
                int selectedrowindex = grid_customerlist.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_customerlist.Rows[selectedrowindex];
                string selectedCustomer = Convert.ToString(selectedRow.Cells["customername"].Value);

                var getrecord = db.bprofile.Where(a => a.id == 1).SingleOrDefault();
                string bname = getrecord.bname;
                string badd = getrecord.baddress;



                DGVPrinter printer = new DGVPrinter();
                printer.Title = "DELIVERY RECEIPT";//HEADER
                printer.SubTitle = "DELIVERED TO: " + selectedCustomer + "   DATE: " + DateTime.Today.ToString("dd/MM/yyyy");
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                //printer.ProportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = bname + "  " + badd;
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(grid_orders);

            }
            catch
            {
                MessageBox.Show("The list is empty.", "EMPTY LIST!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grid_orders.DataSource = null;
            }
        }
    }
}
