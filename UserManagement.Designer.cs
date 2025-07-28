namespace RMC2021
{
    partial class UserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_adminusers = new System.Windows.Forms.TabPage();
            this.btn_edituser = new System.Windows.Forms.Button();
            this.btn_deleteuser = new System.Windows.Forms.Button();
            this.grid_users = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admin_Users = new RMC2021.Admin_Users();
            this.tab_normalusers = new System.Windows.Forms.TabPage();
            this.btn_edituser_normal = new System.Windows.Forms.Button();
            this.btn_deleteuser_normal = new System.Windows.Forms.Button();
            this.grid_users_normal = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_admin = new System.Windows.Forms.CheckBox();
            this.tb_upass2 = new System.Windows.Forms.TextBox();
            this.tb_upass = new System.Windows.Forms.TextBox();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.tb_desc = new System.Windows.Forms.RichTextBox();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.btn_saveuser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_usersTableAdapter = new RMC2021.Admin_UsersTableAdapters.admin_usersTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tab_adminusers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_Users)).BeginInit();
            this.tab_normalusers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_users_normal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_adminusers);
            this.tabControl1.Controls.Add(this.tab_normalusers);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(25, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 505);
            this.tabControl1.TabIndex = 11;
            // 
            // tab_adminusers
            // 
            this.tab_adminusers.Controls.Add(this.btn_edituser);
            this.tab_adminusers.Controls.Add(this.btn_deleteuser);
            this.tab_adminusers.Controls.Add(this.grid_users);
            this.tab_adminusers.Location = new System.Drawing.Point(4, 29);
            this.tab_adminusers.Name = "tab_adminusers";
            this.tab_adminusers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_adminusers.Size = new System.Drawing.Size(612, 472);
            this.tab_adminusers.TabIndex = 0;
            this.tab_adminusers.Text = "ADMIN USERS";
            this.tab_adminusers.UseVisualStyleBackColor = true;
            // 
            // btn_edituser
            // 
            this.btn_edituser.BackColor = System.Drawing.Color.Silver;
            this.btn_edituser.FlatAppearance.BorderSize = 0;
            this.btn_edituser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edituser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_edituser.Location = new System.Drawing.Point(316, 411);
            this.btn_edituser.Name = "btn_edituser";
            this.btn_edituser.Size = new System.Drawing.Size(291, 50);
            this.btn_edituser.TabIndex = 8;
            this.btn_edituser.Text = "EDIT USER DETAILS";
            this.btn_edituser.UseVisualStyleBackColor = false;
            this.btn_edituser.Click += new System.EventHandler(this.btn_edituser_Click);
            // 
            // btn_deleteuser
            // 
            this.btn_deleteuser.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_deleteuser.FlatAppearance.BorderSize = 0;
            this.btn_deleteuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteuser.ForeColor = System.Drawing.Color.Black;
            this.btn_deleteuser.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteuser.Image")));
            this.btn_deleteuser.Location = new System.Drawing.Point(5, 411);
            this.btn_deleteuser.Name = "btn_deleteuser";
            this.btn_deleteuser.Size = new System.Drawing.Size(305, 50);
            this.btn_deleteuser.TabIndex = 7;
            this.btn_deleteuser.Text = "   DELETE USER";
            this.btn_deleteuser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deleteuser.UseVisualStyleBackColor = false;
            this.btn_deleteuser.Click += new System.EventHandler(this.btn_deleteuser_Click);
            // 
            // grid_users
            // 
            this.grid_users.AutoGenerateColumns = false;
            this.grid_users.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.adminDataGridViewTextBoxColumn});
            this.grid_users.DataSource = this.adminusersBindingSource;
            this.grid_users.EnableHeadersVisualStyles = false;
            this.grid_users.Location = new System.Drawing.Point(5, 6);
            this.grid_users.Name = "grid_users";
            this.grid_users.ReadOnly = true;
            this.grid_users.RowTemplate.Height = 24;
            this.grid_users.Size = new System.Drawing.Size(602, 398);
            this.grid_users.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminDataGridViewTextBoxColumn
            // 
            this.adminDataGridViewTextBoxColumn.DataPropertyName = "admin";
            this.adminDataGridViewTextBoxColumn.HeaderText = "admin";
            this.adminDataGridViewTextBoxColumn.Name = "adminDataGridViewTextBoxColumn";
            this.adminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminusersBindingSource
            // 
            this.adminusersBindingSource.DataMember = "admin_users";
            this.adminusersBindingSource.DataSource = this.admin_Users;
            // 
            // admin_Users
            // 
            this.admin_Users.DataSetName = "Admin_Users";
            this.admin_Users.Namespace = "http://tempuri.org/Admin_Users.xsd";
            this.admin_Users.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_normalusers
            // 
            this.tab_normalusers.Controls.Add(this.btn_edituser_normal);
            this.tab_normalusers.Controls.Add(this.btn_deleteuser_normal);
            this.tab_normalusers.Controls.Add(this.grid_users_normal);
            this.tab_normalusers.Location = new System.Drawing.Point(4, 29);
            this.tab_normalusers.Name = "tab_normalusers";
            this.tab_normalusers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_normalusers.Size = new System.Drawing.Size(612, 472);
            this.tab_normalusers.TabIndex = 1;
            this.tab_normalusers.Text = "NORMAL USERS";
            this.tab_normalusers.UseVisualStyleBackColor = true;
            // 
            // btn_edituser_normal
            // 
            this.btn_edituser_normal.BackColor = System.Drawing.Color.Silver;
            this.btn_edituser_normal.FlatAppearance.BorderSize = 0;
            this.btn_edituser_normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edituser_normal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_edituser_normal.Location = new System.Drawing.Point(316, 411);
            this.btn_edituser_normal.Name = "btn_edituser_normal";
            this.btn_edituser_normal.Size = new System.Drawing.Size(291, 50);
            this.btn_edituser_normal.TabIndex = 10;
            this.btn_edituser_normal.Text = "EDIT USER DETAILS";
            this.btn_edituser_normal.UseVisualStyleBackColor = false;
            this.btn_edituser_normal.Click += new System.EventHandler(this.btn_edituser_normal_Click);
            // 
            // btn_deleteuser_normal
            // 
            this.btn_deleteuser_normal.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_deleteuser_normal.FlatAppearance.BorderSize = 0;
            this.btn_deleteuser_normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteuser_normal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_deleteuser_normal.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteuser_normal.Image")));
            this.btn_deleteuser_normal.Location = new System.Drawing.Point(5, 411);
            this.btn_deleteuser_normal.Name = "btn_deleteuser_normal";
            this.btn_deleteuser_normal.Size = new System.Drawing.Size(305, 50);
            this.btn_deleteuser_normal.TabIndex = 9;
            this.btn_deleteuser_normal.Text = "   DELETE USER";
            this.btn_deleteuser_normal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteuser_normal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deleteuser_normal.UseVisualStyleBackColor = false;
            this.btn_deleteuser_normal.Click += new System.EventHandler(this.btn_deleteuser_normal_Click);
            // 
            // grid_users_normal
            // 
            this.grid_users_normal.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_users_normal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_users_normal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_users_normal.EnableHeadersVisualStyles = false;
            this.grid_users_normal.Location = new System.Drawing.Point(5, 3);
            this.grid_users_normal.Name = "grid_users_normal";
            this.grid_users_normal.ReadOnly = true;
            this.grid_users_normal.RowTemplate.Height = 24;
            this.grid_users_normal.Size = new System.Drawing.Size(602, 400);
            this.grid_users_normal.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 76);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(90, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Manage user accounts and credentials.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(86, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER MANAGEMENT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(659, 134);
            this.label9.MaximumSize = new System.Drawing.Size(350, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 60);
            this.label9.TabIndex = 13;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_id);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_admin);
            this.groupBox1.Controls.Add(this.tb_upass2);
            this.groupBox1.Controls.Add(this.tb_upass);
            this.groupBox1.Controls.Add(this.tb_uname);
            this.groupBox1.Controls.Add(this.tb_desc);
            this.groupBox1.Controls.Add(this.tb_fullname);
            this.groupBox1.Controls.Add(this.btn_saveuser);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(662, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 384);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD/ EDIT USER";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(86, 254);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(25, 15);
            this.lb_id.TabIndex = 13;
            this.lb_id.Text = "000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "USER ID:";
            // 
            // cb_admin
            // 
            this.cb_admin.AutoSize = true;
            this.cb_admin.Location = new System.Drawing.Point(291, 250);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(100, 19);
            this.cb_admin.TabIndex = 11;
            this.cb_admin.Text = "ADMIN USER?";
            this.cb_admin.UseVisualStyleBackColor = true;
            // 
            // tb_upass2
            // 
            this.tb_upass2.Location = new System.Drawing.Point(150, 200);
            this.tb_upass2.Name = "tb_upass2";
            this.tb_upass2.Size = new System.Drawing.Size(250, 23);
            this.tb_upass2.TabIndex = 10;
            // 
            // tb_upass
            // 
            this.tb_upass.Location = new System.Drawing.Point(150, 175);
            this.tb_upass.Name = "tb_upass";
            this.tb_upass.Size = new System.Drawing.Size(250, 23);
            this.tb_upass.TabIndex = 9;
            // 
            // tb_uname
            // 
            this.tb_uname.Location = new System.Drawing.Point(150, 151);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(250, 23);
            this.tb_uname.TabIndex = 8;
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(150, 54);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(250, 90);
            this.tb_desc.TabIndex = 7;
            this.tb_desc.Text = "";
            // 
            // tb_fullname
            // 
            this.tb_fullname.Location = new System.Drawing.Point(150, 29);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(250, 23);
            this.tb_fullname.TabIndex = 6;
            // 
            // btn_saveuser
            // 
            this.btn_saveuser.BackColor = System.Drawing.Color.Sienna;
            this.btn_saveuser.FlatAppearance.BorderSize = 0;
            this.btn_saveuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_saveuser.ForeColor = System.Drawing.Color.White;
            this.btn_saveuser.Image = ((System.Drawing.Image)(resources.GetObject("btn_saveuser.Image")));
            this.btn_saveuser.Location = new System.Drawing.Point(24, 293);
            this.btn_saveuser.Name = "btn_saveuser";
            this.btn_saveuser.Size = new System.Drawing.Size(374, 71);
            this.btn_saveuser.TabIndex = 5;
            this.btn_saveuser.Text = "  SAVE USER CREDENTIALS";
            this.btn_saveuser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saveuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_saveuser.UseVisualStyleBackColor = false;
            this.btn_saveuser.Click += new System.EventHandler(this.btn_saveuser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "RETYPE PASSWORD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "PASSWORD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "USERNAME: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "USER DESCRIPTION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "FULL NAME:";
            // 
            // admin_usersTableAdapter
            // 
            this.admin_usersTableAdapter.ClearBeforeFill = true;
            // 
            // HYZNAAFWES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1089, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HYZNAAFWES";
            this.Text = "USER MANAGEMENT";
            this.Load += new System.EventHandler(this.HYZNAAFWES_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_adminusers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_Users)).EndInit();
            this.tab_normalusers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_users_normal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_adminusers;
        private System.Windows.Forms.Button btn_edituser;
        private System.Windows.Forms.Button btn_deleteuser;
        private System.Windows.Forms.DataGridView grid_users;
        private System.Windows.Forms.TabPage tab_normalusers;
        private System.Windows.Forms.Button btn_edituser_normal;
        private System.Windows.Forms.Button btn_deleteuser_normal;
        private System.Windows.Forms.DataGridView grid_users_normal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_admin;
        private System.Windows.Forms.TextBox tb_upass2;
        private System.Windows.Forms.TextBox tb_upass;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.RichTextBox tb_desc;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.Button btn_saveuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Admin_Users admin_Users;
        private System.Windows.Forms.BindingSource adminusersBindingSource;
        private Admin_UsersTableAdapters.admin_usersTableAdapter admin_usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminDataGridViewTextBoxColumn;
    }
}