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
    public partial class Form3 : Form
    {
        POSDB2Entities db = new POSDB2Entities();
        DataTable dtNew = new DataTable();

        public Form3()
        {
            InitializeComponent();

        }


        private void btn_load_Click(object sender, EventArgs e)
        {


            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";

                if (dialog.FileName != "")
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {

                        dtNew.Clear();
                        dtNew = GetDataTabletFromCSVFile(dialog.FileName);

                        if (Convert.ToString(dtNew.Columns[0]).ToLower() != "id")
                        {
                            MessageBox.Show("Please follow the proper column order in your CSV file.");
                            btn_save.Enabled = false;
                            return;
                        }

                        txtFile.Text = dialog.SafeFileName;
                        SourceURl = dialog.FileName;
                        if (dtNew.Rows != null && dtNew.Rows.ToString() != String.Empty)
                        {
                            dgItems.DataSource = dtNew;
                        }
                        foreach (DataGridViewRow row in dgItems.Rows)
                        {
                            if (Convert.ToString(row.Cells["purchasedate"].Value) == "" || row.Cells["purchasedate"].Value == null
                                || Convert.ToString(row.Cells["category"].Value) == "" || row.Cells["category"].Value == null
                                || Convert.ToString(row.Cells["label"].Value) == "" || row.Cells["label"].Value == null
                                || Convert.ToString(row.Cells["costtomake"].Value) == "" || row.Cells["costtomake"].Value == null
                       
                                || Convert.ToString(row.Cells["finalsaleprice"].Value) == "" || row.Cells["finalsaleprice"].Value == null
                                || Convert.ToString(row.Cells["discount"].Value) == "" || row.Cells["discount"].Value == null
                                || Convert.ToString(row.Cells["customername"].Value) == "" || row.Cells["customername"].Value == null
                                || Convert.ToString(row.Cells["originalprice"].Value) == "" || row.Cells["originalprice"].Value == null
                                 || Convert.ToString(row.Cells["cashier"].Value) == "" || row.Cells["cashier"].Value == null)


                            {
                                // row.DefaultCellStyle.BackColor = Color.Red;
                                inValidItem += 1;
                            }
                            else
                            {
                                ImportedRecord += 1;
                            }
                        }
                        if (dgItems.Rows.Count == 0)
                        {
                            btn_save.Enabled = false;
                            MessageBox.Show("No data in file selected.", "RMC MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid CSV file. ", "RMC MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Please follow the correct file and format when importing data.", "RMC MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // MessageBox.Show(ex.ToString(), "RMC MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {

                if (csv_file_path.EndsWith(".csv"))
                {
                    using (Microsoft.VisualBasic.FileIO.TextFieldParser csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csv_file_path))
                    {

                        //   csvReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        csvReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                        csvReader.SetDelimiters(new string[] { ",", "\t" });


                        //read column
                        string[] colFields = csvReader.ReadFields();

                        foreach (string column in colFields)
                        {

                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {

                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            csvData.Rows.Add(fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Exce " + ex);
                MessageBox.Show("Error getting table from CSV. Make sure you don't have invalid elements in your file.");
            }
            return csvData;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Insert rows to database?", "CONFIRM INSERT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (dgItems.Rows.Count == 0)
                {
                    MessageBox.Show("Please loead a valid CSV file first!");

                }
                else
                {

                    SaveItem();
                    dtNew.Clear();
                }





            }



        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void SaveItem()
        {


            try
            {
                DataTable dtItem = (DataTable)(dgItems.DataSource);
                string purchasedate1, label1, discount1, itembrand1, itemname1, category1, customer1, cashier1;
                Double costtomake1, salesprice2, finalsaleprice1;

                foreach (DataRow dr in dtItem.Rows)
                {

                    if (dr["purchasedate"] != null && dr["category"] != null && dr["costtomake"] != null && dr["costtomake"] != null && dr["finalsaleprice"] != null && dr["customername"] != null && dr["originalprice"] != null && dr["cashier"] != null)
                    {

                        try
                        {
                            String purchasedat = Convert.ToString(dr["purchasedate"]);
                            category1 = Convert.ToString(dr["category"]);
                            label1 = Convert.ToString(dr["label"]);
                           
                            costtomake1 = Convert.ToDouble(dr["costtomake"]);
                            finalsaleprice1 = Convert.ToDouble(dr["finalsaleprice"]);
                            discount1 = Convert.ToString(dr["discount"]);
                            customer1 = Convert.ToString(dr["customername"]);
                            salesprice2 = Convert.ToDouble(dr["originalprice"]);
                            cashier1 = Convert.ToString(dr["cashier"]);

                            var cultureInfo = new CultureInfo("en-US");
                            var formats = new[] { "d-M-yyyy", "dd-MM-yyyy", "d-MM-yyyy", "dd-M-yyyy", "d.M.yyyy", "dd.MM.yyyy", "d.MM.yyyy", "dd.M.yyyy", "dd/MM/yyyy", "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy" }
                             .Union(cultureInfo.DateTimeFormat.GetAllDateTimePatterns()).ToArray();

                            // DateTime purchasedatee = DateTime.ParseExact(purchasedat, formats, CultureInfo.InvariantCulture);
                            DateTime purchasedatee = DateTime.ParseExact(purchasedat, formats, cultureInfo, DateTimeStyles.AssumeLocal);


                            purchasedate1 = purchasedatee.ToString("dd-MM-yyyy");

                            int discount2 = int.Parse(discount1);
                         

                            sales_peritem sper = new sales_peritem()
                            {
                                purchasedate = purchasedate1,
                                category = category1,
                                label = label1,
                                costtomake = costtomake1,
                                discount = discount2,
                               
                                finalsaleprice = finalsaleprice1,
                             
                                customername = customer1,
                                originalprice = salesprice2,
                                cashier = cashier1,
                            };

                            db.sales_peritem.Add(sper);


                        }
                        catch (Exception ee)
                        {
                            // MessageBox.Show("Please make sure you don't have missing or invalid values in your CSV file.", "INVALID ENTRIES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Provide for exceptions.
                        }

                        db.SaveChanges();


                    }


                    else
                    {
                        //skip row
                        MessageBox.Show("Please make sure you don't have missing or invalid values in your CSV file.", "INVALID ENTRIES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }

                txtFile.Text = "Saved to Database! Check your Sales Monitoring list!";
                MessageBox.Show("Item(s) saved successfully to database!", "DATABASE UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                txtFile.Text = "INVALID OR EMPTY FILE!";
                MessageBox.Show("Please do NOT import a blank or invalid CSV file!");

            }
        }
    }
}


