using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMC2021
{
    public partial class FinanceMonitoring : Form
    {


        POSDB2Entities db = new POSDB2Entities();

        public FinanceMonitoring()
        {
            InitializeComponent();
            InitializeStuff();
            LoadGraph_annual();
            LoadGraph_monthly();
        }


        public void InitializeStuff()
        {
            // Set the Format type and the CustomFormat string.
            dtp_monthyear.Format = DateTimePickerFormat.Custom;
            dtp_monthyear.CustomFormat = "MMMM -  yyyy";

            dtp_selectYear.Format = DateTimePickerFormat.Custom;
            dtp_selectYear.CustomFormat = "yyyy";
        }


        public void LoadGraph_monthly()
        {

            string selectedMonth = dtp_monthyear.Value.ToString("MM-yyyy");

            //LOAD THE CHART
            DataTable monthly_visualization = new DataTable();
            //INITIALIZE DATATABLE SUMMARY
            monthly_visualization.Clear();
            monthly_visualization.Columns.Add("values");
            monthly_visualization.Columns.Add("amount");
            double gastos = 0;
            double kaperahan = 0;
            double stockValue = 0;

           

            var query =
             from ord in db.sales_peritem
             where ord.purchasedate.Contains(selectedMonth)
             select ord;

            foreach (sales_peritem ord in query)
            {
                double purchaseprize = ord.costtomake.Value;
                double originalprize = ord.originalprice.Value;
                double discountz = ord.discount.Value;

                double saleprize = originalprize - (originalprize * (discountz / 100));

                gastos = gastos + purchaseprize;
                kaperahan = kaperahan + saleprize;

            }
            double kinita = kaperahan - gastos;

            DataRow row = monthly_visualization.NewRow();
            row["values"] = "COST OF DISHES";
            row["amount"] = gastos;
            monthly_visualization.Rows.Add(row);

            DataRow pera = monthly_visualization.NewRow();
            pera["values"] = "SALES REVENUE";
            pera["amount"] = kaperahan;
            monthly_visualization.Rows.Add(pera);

            DataRow kita = monthly_visualization.NewRow();
            kita["values"] = "SALES PROFIT";
            kita["amount"] = kinita;
            monthly_visualization.Rows.Add(kita);

    

            chart_visual_month.Series["AMOUNT in PHP"].XValueMember = "values";
            chart_visual_month.Series["AMOUNT in PHP"].YValueMembers = "amount";
            chart_visual_month.DataSource = monthly_visualization;
            chart_visual_month.DataBind();

            lb_selectedmonthyear.Text = dtp_monthyear.Value.ToString("MMMM-yyyy");
            lb_cost.Text = gastos.ToString();
            lb_revenue.Text = kaperahan.ToString();
            lb_profit.Text = kinita.ToString();
           


        }

        public void LoadGraph_annual()
        {
            string selectedYear = dtp_selectYear.Value.ToString("yyyy");
            lb_year.Text = selectedYear;

            //LOAD THE CHART
            DataTable annual_visualization = new DataTable();
            //INITIALIZE DATATABLE SUMMARY
            annual_visualization.Clear();
            annual_visualization.Columns.Add("months");
            annual_visualization.Columns.Add("amount");
            annual_visualization.Columns.Add("revenue");
            annual_visualization.Columns.Add("profit");

            var query =
                   from ord in db.sales_peritem
                   where ord.purchasedate.Contains(selectedYear)
                   select ord;

            foreach (sales_peritem ord in query)
            {

                //  DateTime dtRaw = DateTime.Parse(ord.purchasedate);
                DateTime dtRaw = DateTime.ParseExact(ord.purchasedate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                string purchaseMonth = dtRaw.ToString("MM-yyyy");

                DataColumn[] columns = annual_visualization.Columns.Cast<DataColumn>().ToArray();
                bool anyFieldContainsName = annual_visualization.AsEnumerable()
                     .Any(row => columns.Any(col => row[col].ToString() == purchaseMonth));
                if (anyFieldContainsName)
                {
                    //skip
                }
                else
                {
                    var query2 =
                      from orda in db.sales_peritem
                      where orda.purchasedate.Contains(purchaseMonth)
                      select orda;
                    double sum = 0;
                    double rev = 0;
                    foreach (sales_peritem orda in query2)
                    {
                        double purchaseprize = orda.costtomake.Value;
                        double revenue = orda.finalsaleprice.Value;
                        sum = sum + purchaseprize;
                        rev = rev + revenue;

                    }
                    double profit = rev - sum;
                    string sumMe = Convert.ToString(sum);

                    DataRow _ravi = annual_visualization.NewRow();
                    _ravi["months"] = purchaseMonth;
                    _ravi["amount"] = sumMe;
                    _ravi["revenue"] = rev;
                    _ravi["profit"] = profit;
                    annual_visualization.Rows.Add(_ravi);
                }


            }

            chart_annual.Series["COST OF ITEMS"].XValueMember = "months";
            chart_annual.Series["COST OF ITEMS"].YValueMembers = "amount";
            chart_annual.Series["SALES REVENUE"].XValueMember = "months";
            chart_annual.Series["SALES REVENUE"].YValueMembers = "revenue";
            chart_annual.Series["SALES PROFIT"].XValueMember = "months";
            chart_annual.Series["SALES PROFIT"].YValueMembers = "profit";
            chart_annual.DataSource = annual_visualization;
            chart_annual.DataBind();

        }

        private void btn_loadmonth_Click(object sender, EventArgs e)
        {
            LoadGraph_monthly();
        }

        private void btn_LoadAnnual_Click(object sender, EventArgs e)
        {
            LoadGraph_annual();
        }

        private void btn_LoadAnnual_Click_1(object sender, EventArgs e)
        {
            LoadGraph_annual();
        }
    }
}
