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
    public partial class Form2 : Form
    {
       
        POSDB2Entities db = new POSDB2Entities();
        DataTable dtNew = new DataTable();

        public Form2()
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
                            if (Convert.ToString(row.Cells["category"].Value) == "" || row.Cells["category"].Value == null
                                || Convert.ToString(row.Cells["label"].Value) == "" || row.Cells["label"].Value == null
                                || Convert.ToString(row.Cells["description"].Value) == "" || row.Cells["description"].Value == null
                                || Convert.ToString(row.Cells["dishcost"].Value) == "" || row.Cells["dishcost"].Value == null
                                || Convert.ToString(row.Cells["dishprice"].Value) == "" || row.Cells["dishprice"].Value == null
                                || Convert.ToString(row.Cells["available"].Value) == "" || row.Cells["available"].Value == null
                          
                                 || Convert.ToString(row.Cells["loggedby"].Value) == "" || row.Cells["loggedby"].Value == null)



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
                // MessageBox.Show("Exception " + ex);
                MessageBox.Show("Please follow the correct file and format when importing data.", "RMC MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void SaveItem()
        {
            try
            {
                DataTable dtItem = (DataTable)(dgItems.DataSource);
                string category1, label1, description1, available1, loggedby1;
                Double dishcost1, dishprice1;

                foreach (DataRow dr in dtItem.Rows)
                {
                    if (dr["category"] != null && dr["label"] != null && dr["description"] != null && dr["dishcost"] != null && dr["dishprice"] != null && dr["available"] != null && dr["loggedby"] != null)
                    {
                        category1 = Convert.ToString(dr["category"]);
                        label1 = Convert.ToString(dr["label"]);
                        description1 = Convert.ToString(dr["description"]);
                        dishcost1 = Convert.ToDouble(dr["dishcost"]);
                        dishprice1 = Convert.ToDouble(dr["dishprice"]);
                        available1 = Convert.ToString(dr["available"]);
                        loggedby1 = Convert.ToString(dr["loggedby"]);


                        int available2 = int.Parse(available1);



                        try
                        {

                            Menu peritem = new Menu()
                            {
                                category = category1,
                                label = label1,
                                description = description1,
                                dishcost = dishcost1,
                                dishprice = dishprice1,
                                available = available2,
                                loggedby = loggedby1,
                            };

                            db.Menu.Add(peritem);

                        }

                        catch (Exception ee)
                        {
                            Console.WriteLine(ee);
                            // Provide for exceptions.
                        }
                        //  count++;
                        //  }
                    }
                    else
                    {
                        //skip row
                    }

                    db.SaveChanges();


                }

                txtFile.Text = "Saved to Database! Check your Menu!";
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

