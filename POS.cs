using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DGVPrinterHelper;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMC2021
{

    public partial class POS : Form
    {
        DataTable cart = new DataTable();
        DateTime dateToday = DateTime.UtcNow.Date;
        POSDB2Entities db = new POSDB2Entities();
        int discount;

        public POS()
        {
            InitializeComponent();
            PopulateCart();
            var query =
              from ord in db.current_user
              where ord.id == 1
              select ord;
            foreach (current_user ord in query)
            {
                lb_cuser.Text = ord.username;
            }
            PopulateCart();

            //INITIALIZE DATATABLE
            cart.Clear();
            cart.Columns.Add("category");
            cart.Columns.Add("label");
            cart.Columns.Add("price");
            cart.Columns.Add("qty");
            cart.Columns.Add("discount");
            cart.Columns.Add("finalprice");
        }

        private void PopulateCart()
        {

            //populate CATEGORY
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

            dt.Columns.Add("category");
            dt.Columns.Add("label");
            dt.Columns.Add("description");
            dt.Columns.Add("dishcost");
            dt.Columns.Add("dishprice");
            dt.Columns.Add("available");


            var query =
           from ord in db.Menu
           where ord.category == selected && ord.available == 1
           select ord;

            foreach (Menu ord in query)
            {
                DataRow _ravi = dt.NewRow();
                _ravi["category"] = ord.category;
                _ravi["label"] = ord.label;
                _ravi["description"] = ord.description;
                _ravi["dishcost"] = ord.dishcost;
                _ravi["dishprice"] = ord.dishprice;
                _ravi["available"] = ord.available;
                dt.Rows.Add(_ravi);

            }

            cb_item.DataSource = dt;
            cb_item.ValueMember = "label";
            cb_item.DisplayMember = "label";
        }
        public void clearFields()
        {
            cb_brand.Text = "";
            cb_item.Text = "";
            tb_discount.Text = "";
            tb_qty.Text = "";

        }

        private void refreshTotal()
        {

            grid_cart.DataSource = cart;
            var result = cart.AsEnumerable()
                    .Sum(x => Convert.ToDouble(x["finalprice"]));

            lb_totalprice.Text = result.ToString();
        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            string selectedCategory = Convert.ToString(this.cb_brand.GetItemText(this.cb_brand.SelectedItem));
            string selectedDish = Convert.ToString(this.cb_item.GetItemText(this.cb_item.SelectedItem));
            if (selectedDish == "")
            {
                MessageBox.Show("Please select dish to order", "PLEASE INPUT DISH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (tb_qty.Text == "")
                {
                    MessageBox.Show("Please input quantity", "PLEASE INPUT QUANTITY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //   int discount;
                    if (tb_discount.Text == "")
                    {
                        discount = 0;
                    }
                    else
                    {
                        try
                        {
                            discount = (int)tb_discount.Value;
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show("Please input VALID INTEGER", "INVALID INTEGER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            discount = 0;
                        }
                    }
                    int quantity = Convert.ToInt32(tb_qty.Text);


                    //SWITCH
                    var query =
                    from ord in db.Menu
                    where ord.category == selectedCategory && ord.label == selectedDish
                    select ord;

                    foreach (Menu ord in query)
                    {
                        double itemprice = ord.dishprice.Value;
                        double discounted = discount * itemprice / 100;
                        double Fprice = (itemprice - discounted) * quantity;

                        //Add to Datagrid
                        DataRow _ravi = cart.NewRow();
                        _ravi["category"] = selectedCategory;
                        _ravi["label"] = selectedDish;
                        _ravi["price"] = itemprice;
                        _ravi["qty"] = quantity;
                        _ravi["discount"] = discount;
                        _ravi["finalprice"] = Fprice;
                        cart.Rows.Add(_ravi);

                    }

                    clearFields();

                }

                refreshTotal();
            }
        }

        private void btn_removecart_Click(object sender, EventArgs e)
        {
            DeleteFromCart();
            refreshTotal();
            grid_cart.DataSource = cart;
        }

        protected void DeleteFromCart()
        {
            DataGridViewRow dr = grid_cart.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (dr != null)
            {
                var rowToRemove = cart.Rows.Cast<DataRow>().FirstOrDefault(row => row[0] == dr.Cells[0].Value);
                if (rowToRemove != null)
                    cart.Rows.Remove(rowToRemove);
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            string name = tb_cname.Text;
            if (name == "")
            {
                MessageBox.Show("Please input CUSTOMER NAME or TABLE NAME.", "PLEASE INPUT NAME", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (grid_cart.Rows.Count < 2 || grid_cart.RowCount < 2) {
               /* int blank = 0;
                foreach (DataGridViewRow rw in grid_cart.Rows) {

                    for (int i = 0; i < rw.Cells.Count; i++) {
                        if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                        {
                            blank++;
                        }
                    }  
                }
                if (blank > 0) {
                   // CheckOut();
                    MessageBox.Show("Blank > 0", "EMPTY CART", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                   // CheckOut();
                    MessageBox.Show("BLANK is < 0", "EMPTY CART", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // MessageBox.Show("Your cart is EMPTY.", "EMPTY CART", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               */
               MessageBox.Show("Your cart is EMPTY.", "EMPTY CART", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                CheckOut();
            }
        }

        private void printInvoice()
        {
            var getrecord = db.bprofile.Where(a => a.id == 1).SingleOrDefault();
            string bname = getrecord.bname;
            string badd = getrecord.baddress;

            string customer_name = tb_cname.Text;
            string totaldue = lb_totalprice.Text;

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "SALES INVOICE";//HEADER
            printer.SubTitle = bname + " " + badd;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            // printer.ProportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "  SOLD TO: " + customer_name + " TOTAL AMT DUE:  " + totaldue;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(grid_cart);

        }

        private void CheckOut()
        {
            DialogResult result = MessageBox.Show("CONFIRM PURCHASE", "CONFIRM PURCHASE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
       
                foreach (DataRow row in cart.Rows)
                {
                    //ADD ROW TO SALE_PERITEM
                    string sdate = dateToday.ToString("dd-MM-yyyy");
                    string scategory = row.Field<string>("category");
                    string siname = row.Field<string>("label");
                    string cname = Convert.ToString(tb_cname.Text);
                    string loggedBy = lb_cuser.Text;

                    int qty = int.Parse(row.Field<string>("qty"));
                    double sfprice = double.Parse(row.Field<string>("finalprice"));
                    int sdisc = int.Parse(row.Field<string>("discount"));
                    double spprice = double.Parse(row.Field<string>("price"));

               


                    for (int i = 0; i < qty; i++)
                    {
                        //GET ROW FROM INVENTORY ITEM
                        var report = (from d in db.Menu
                                      where d.category == scategory && d.label == siname
                                      select d).FirstOrDefault();
                     

                        double pprice = Convert.ToDouble(report.dishcost);

                        sales_peritem sper = new sales_peritem()
                        {
                            purchasedate = sdate,
                            originalprice = spprice,
                            category = scategory,
                            label = siname,
                            costtomake = pprice,
                            finalsaleprice = sfprice,
                            discount = sdisc,
                            customername = cname,
                            cashier = loggedBy,
                        };

                        db.sales_peritem.Add(sper);


                    }

                }
                //CLEAR DATATABLE
                db.SaveChanges();

                //PRINT INVOICE?
                DialogResult print = MessageBox.Show("PRINT INVOICE?", "CHECKOUT SUCCESS!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (print == DialogResult.Yes)
                {

                    printInvoice();
                    lb_totalprice.Text = "";
                    tb_cname.Text = "";
                    cart.Clear();

                }
                else if (print == DialogResult.No)
                {

                    tb_cname.Text = "";
                    lb_totalprice.Text = "";
                    cart.Clear();
                }
            }

            else if (result == DialogResult.No)
            {
                //DO NOTHING
            }
        }
    }


}
