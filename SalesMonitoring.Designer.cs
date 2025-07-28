namespace RMC2021
{
    partial class SalesMonitoring
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesMonitoring));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_exp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_salesperday = new System.Windows.Forms.TabPage();
            this.chart_numberofsales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_monthyear_total = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.tab_salesbybrand = new System.Windows.Forms.TabPage();
            this.chart_salesbybrand = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_monthyear = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tab_salesbyitem = new System.Windows.Forms.TabPage();
            this.chart_salesbyitem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cb_selectBrand = new System.Windows.Forms.ComboBox();
            this.tab_solditems = new System.Windows.Forms.TabPage();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtbox_salesmon = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.grid_salesperitem = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costtomakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalsalepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesperitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDB2DataSet = new RMC2021.POSDB2DataSet();
            this.sales_peritemTableAdapter = new RMC2021.POSDB2DataSetTableAdapters.sales_peritemTableAdapter();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_salesperday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_numberofsales)).BeginInit();
            this.tab_salesbybrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_salesbybrand)).BeginInit();
            this.tab_salesbyitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_salesbyitem)).BeginInit();
            this.tab_solditems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesperitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesperitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDB2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "TIP: Save your MASTERLIST in CSV files for backup.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "MASTERLIST : ALL DISHES SOLD";
            // 
            // cashier
            // 
            this.cashier.DataPropertyName = "cashier";
            this.cashier.HeaderText = "cashier";
            this.cashier.Name = "cashier";
            this.cashier.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(98, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALES MONITORING";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 81);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(103, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monitor sales trends of your dishes.";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.progressBar1.Location = new System.Drawing.Point(25, 667);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1249, 10);
            this.progressBar1.TabIndex = 3;
            // 
            // btn_exp
            // 
            this.btn_exp.BackColor = System.Drawing.Color.Sienna;
            this.btn_exp.FlatAppearance.BorderSize = 0;
            this.btn_exp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exp.Image = ((System.Drawing.Image)(resources.GetObject("btn_exp.Image")));
            this.btn_exp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exp.Location = new System.Drawing.Point(635, 22);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(180, 53);
            this.btn_exp.TabIndex = 2;
            this.btn_exp.Text = "   EXPORT";
            this.btn_exp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exp.UseVisualStyleBackColor = false;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_salesperday);
            this.tabControl1.Controls.Add(this.tab_salesbybrand);
            this.tabControl1.Controls.Add(this.tab_salesbyitem);
            this.tabControl1.Controls.Add(this.tab_solditems);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1309, 746);
            this.tabControl1.TabIndex = 5;
            // 
            // tab_salesperday
            // 
            this.tab_salesperday.Controls.Add(this.chart_numberofsales);
            this.tab_salesperday.Controls.Add(this.label7);
            this.tab_salesperday.Controls.Add(this.cb_monthyear_total);
            this.tab_salesperday.Controls.Add(this.label19);
            this.tab_salesperday.Controls.Add(this.label18);
            this.tab_salesperday.Location = new System.Drawing.Point(4, 33);
            this.tab_salesperday.Name = "tab_salesperday";
            this.tab_salesperday.Padding = new System.Windows.Forms.Padding(3);
            this.tab_salesperday.Size = new System.Drawing.Size(1301, 709);
            this.tab_salesperday.TabIndex = 0;
            this.tab_salesperday.Text = "SALES PER DAY";
            this.tab_salesperday.UseVisualStyleBackColor = true;
            // 
            // chart_numberofsales
            // 
            this.chart_numberofsales.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart_numberofsales.BorderSkin.BorderWidth = 20;
            chartArea1.Name = "ChartArea1";
            this.chart_numberofsales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_numberofsales.Legends.Add(legend1);
            this.chart_numberofsales.Location = new System.Drawing.Point(3, 85);
            this.chart_numberofsales.Name = "chart_numberofsales";
            this.chart_numberofsales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart_numberofsales.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "ITEMS SOLD";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart_numberofsales.Series.Add(series1);
            this.chart_numberofsales.Size = new System.Drawing.Size(1295, 616);
            this.chart_numberofsales.TabIndex = 22;
            this.chart_numberofsales.Text = "TOTAL SALES PER DAY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total number of units sold per day";
            // 
            // cb_monthyear_total
            // 
            this.cb_monthyear_total.FormattingEnabled = true;
            this.cb_monthyear_total.Location = new System.Drawing.Point(744, 21);
            this.cb_monthyear_total.Name = "cb_monthyear_total";
            this.cb_monthyear_total.Size = new System.Drawing.Size(234, 28);
            this.cb_monthyear_total.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(577, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 20);
            this.label19.TabIndex = 16;
            this.label19.Text = "SELECT MONTH:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(28, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(435, 29);
            this.label18.TabIndex = 15;
            this.label18.Text = "SALES SUMMARY AND ANALYTICS";
            // 
            // tab_salesbybrand
            // 
            this.tab_salesbybrand.Controls.Add(this.chart_salesbybrand);
            this.tab_salesbybrand.Controls.Add(this.label5);
            this.tab_salesbybrand.Controls.Add(this.cb_monthyear);
            this.tab_salesbybrand.Controls.Add(this.label20);
            this.tab_salesbybrand.Location = new System.Drawing.Point(4, 33);
            this.tab_salesbybrand.Name = "tab_salesbybrand";
            this.tab_salesbybrand.Padding = new System.Windows.Forms.Padding(3);
            this.tab_salesbybrand.Size = new System.Drawing.Size(1301, 709);
            this.tab_salesbybrand.TabIndex = 1;
            this.tab_salesbybrand.Text = "SALES BY DISH TYPE";
            this.tab_salesbybrand.UseVisualStyleBackColor = true;
            // 
            // chart_salesbybrand
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_salesbybrand.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_salesbybrand.Legends.Add(legend2);
            this.chart_salesbybrand.Location = new System.Drawing.Point(0, 82);
            this.chart_salesbybrand.Name = "chart_salesbybrand";
            this.chart_salesbybrand.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sales By Category";
            this.chart_salesbybrand.Series.Add(series2);
            this.chart_salesbybrand.Size = new System.Drawing.Size(1287, 621);
            this.chart_salesbybrand.TabIndex = 26;
            this.chart_salesbybrand.Text = "SALES BY BRAND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Determine which categories generate the most sales.";
            // 
            // cb_monthyear
            // 
            this.cb_monthyear.FormattingEnabled = true;
            this.cb_monthyear.Location = new System.Drawing.Point(173, 41);
            this.cb_monthyear.Name = "cb_monthyear";
            this.cb_monthyear.Size = new System.Drawing.Size(312, 28);
            this.cb_monthyear.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 20);
            this.label20.TabIndex = 23;
            this.label20.Text = "SELECT MONTH";
            // 
            // tab_salesbyitem
            // 
            this.tab_salesbyitem.Controls.Add(this.chart_salesbyitem);
            this.tab_salesbyitem.Controls.Add(this.label6);
            this.tab_salesbyitem.Controls.Add(this.label22);
            this.tab_salesbyitem.Controls.Add(this.cb_selectBrand);
            this.tab_salesbyitem.Location = new System.Drawing.Point(4, 33);
            this.tab_salesbyitem.Name = "tab_salesbyitem";
            this.tab_salesbyitem.Padding = new System.Windows.Forms.Padding(3);
            this.tab_salesbyitem.Size = new System.Drawing.Size(1301, 709);
            this.tab_salesbyitem.TabIndex = 2;
            this.tab_salesbyitem.Text = "SALES BY DISH";
            this.tab_salesbyitem.UseVisualStyleBackColor = true;
            // 
            // chart_salesbyitem
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_salesbyitem.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_salesbyitem.Legends.Add(legend3);
            this.chart_salesbyitem.Location = new System.Drawing.Point(6, 75);
            this.chart_salesbyitem.Name = "chart_salesbyitem";
            this.chart_salesbyitem.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart_salesbyitem.Size = new System.Drawing.Size(1292, 634);
            this.chart_salesbyitem.TabIndex = 24;
            this.chart_salesbyitem.Text = "chart2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(541, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Determine which items (under certain brands) generate the most sales.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(167, 20);
            this.label22.TabIndex = 21;
            this.label22.Text = "SELECT DISH TYPE";
            // 
            // cb_selectBrand
            // 
            this.cb_selectBrand.FormattingEnabled = true;
            this.cb_selectBrand.Location = new System.Drawing.Point(191, 42);
            this.cb_selectBrand.Name = "cb_selectBrand";
            this.cb_selectBrand.Size = new System.Drawing.Size(310, 28);
            this.cb_selectBrand.TabIndex = 20;
            // 
            // tab_solditems
            // 
            this.tab_solditems.Controls.Add(this.btn_all);
            this.tab_solditems.Controls.Add(this.txtbox_salesmon);
            this.tab_solditems.Controls.Add(this.label4);
            
            this.tab_solditems.Controls.Add(this.label2);
            this.tab_solditems.Controls.Add(this.progressBar1);
            this.tab_solditems.Controls.Add(this.btn_exp);
            this.tab_solditems.Controls.Add(this.btn_delete);
            this.tab_solditems.Controls.Add(this.btn_search);
            this.tab_solditems.Controls.Add(this.grid_salesperitem);
            this.tab_solditems.Location = new System.Drawing.Point(4, 29);
            this.tab_solditems.Name = "tab_solditems";
            this.tab_solditems.Padding = new System.Windows.Forms.Padding(3);
            this.tab_solditems.Size = new System.Drawing.Size(1137, 666);
            this.tab_solditems.TabIndex = 3;
            this.tab_solditems.Text = "ALL ITEMS SOLD";
            this.tab_solditems.UseVisualStyleBackColor = true;
            // 
            // btn_all
            // 
            this.btn_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_all.Location = new System.Drawing.Point(830, 48);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(45, 27);
            this.btn_all.TabIndex = 20;
            this.btn_all.Text = "ALL";
            this.btn_all.UseVisualStyleBackColor = true;
           this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // txtbox_salesmon
            // 
            this.txtbox_salesmon.Location = new System.Drawing.Point(961, 50);
            this.txtbox_salesmon.Name = "txtbox_salesmon";
            this.txtbox_salesmon.Size = new System.Drawing.Size(154, 23);
            this.txtbox_salesmon.TabIndex = 18;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(420, 22);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(211, 53);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "   DELETE";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search.Location = new System.Drawing.Point(874, 48);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(80, 27);
            this.btn_search.TabIndex = 19;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // grid_salesperitem
            // 
            this.grid_salesperitem.AutoGenerateColumns = false;
            
            this.grid_salesperitem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_salesperitem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_salesperitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_salesperitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.purchasedateDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.labelDataGridViewTextBoxColumn,
            this.costtomakeDataGridViewTextBoxColumn,
            this.finalsalepriceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.originalpriceDataGridViewTextBoxColumn,
            this.cashier});
            this.grid_salesperitem.DataSource = this.salesperitemBindingSource;
            this.grid_salesperitem.EnableHeadersVisualStyles = false;
            this.grid_salesperitem.GridColor = System.Drawing.Color.Silver;
            this.grid_salesperitem.Location = new System.Drawing.Point(21, 87);
            this.grid_salesperitem.Name = "grid_salesperitem";
            this.grid_salesperitem.ReadOnly = true;
            this.grid_salesperitem.RowTemplate.Height = 24;
            this.grid_salesperitem.Size = new System.Drawing.Size(1096, 532);
            this.grid_salesperitem.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // purchasedateDataGridViewTextBoxColumn
            // 
            this.purchasedateDataGridViewTextBoxColumn.DataPropertyName = "purchasedate";
            this.purchasedateDataGridViewTextBoxColumn.HeaderText = "purchasedate";
            this.purchasedateDataGridViewTextBoxColumn.Name = "purchasedateDataGridViewTextBoxColumn";
            this.purchasedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "label";
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            this.labelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costtomakeDataGridViewTextBoxColumn
            // 
            this.costtomakeDataGridViewTextBoxColumn.DataPropertyName = "costtomake";
            this.costtomakeDataGridViewTextBoxColumn.HeaderText = "costtomake";
            this.costtomakeDataGridViewTextBoxColumn.Name = "costtomakeDataGridViewTextBoxColumn";
            this.costtomakeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalsalepriceDataGridViewTextBoxColumn
            // 
            this.finalsalepriceDataGridViewTextBoxColumn.DataPropertyName = "finalsaleprice";
            this.finalsalepriceDataGridViewTextBoxColumn.HeaderText = "finalsaleprice";
            this.finalsalepriceDataGridViewTextBoxColumn.Name = "finalsalepriceDataGridViewTextBoxColumn";
            this.finalsalepriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customername";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customername";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originalpriceDataGridViewTextBoxColumn
            // 
            this.originalpriceDataGridViewTextBoxColumn.DataPropertyName = "originalprice";
            this.originalpriceDataGridViewTextBoxColumn.HeaderText = "originalprice";
            this.originalpriceDataGridViewTextBoxColumn.Name = "originalpriceDataGridViewTextBoxColumn";
            this.originalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashierDataGridViewTextBoxColumn
            // 
            this.cashierDataGridViewTextBoxColumn.DataPropertyName = "cashier";
            this.cashierDataGridViewTextBoxColumn.HeaderText = "cashier";
            this.cashierDataGridViewTextBoxColumn.Name = "cashierDataGridViewTextBoxColumn";
            this.cashierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesperitemBindingSource
            // 
            this.salesperitemBindingSource.DataMember = "sales_peritem";
            this.salesperitemBindingSource.DataSource = this.pOSDB2DataSet;
            // 
            // pOSDB2DataSet
            // 
            this.pOSDB2DataSet.DataSetName = "POSDB2DataSet";
            this.pOSDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sales_peritemTableAdapter
            // 
            this.sales_peritemTableAdapter.ClearBeforeFill = true;
           
            
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // RMSYHAJKHIAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1309, 833);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RMSYHAJKHIAY";
            this.Text = "SALES MONITORING";
            this.Load += new System.EventHandler(this.RMSYHAJKHIAY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_salesperday.ResumeLayout(false);
            this.tab_salesperday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_numberofsales)).EndInit();
            this.tab_salesbybrand.ResumeLayout(false);
            this.tab_salesbybrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_salesbybrand)).EndInit();
            this.tab_salesbyitem.ResumeLayout(false);
            this.tab_salesbyitem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_salesbyitem)).EndInit();
            this.tab_solditems.ResumeLayout(false);
            this.tab_solditems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesperitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesperitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDB2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_salesperday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_monthyear_total;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tab_salesbybrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_monthyear;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tab_salesbyitem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cb_selectBrand;
        private System.Windows.Forms.TabPage tab_solditems;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView grid_salesperitem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_numberofsales;
        private POSDB2DataSet pOSDB2DataSet;
        private System.Windows.Forms.BindingSource salesperitemBindingSource;
        private POSDB2DataSetTableAdapters.sales_peritemTableAdapter sales_peritemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costtomakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalsalepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_salesbybrand;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_salesbyitem;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtbox_salesmon;
    }
}