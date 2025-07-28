namespace RMC2021
{
    partial class PassChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassChange));
            this.lb_notice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_desc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_cuser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.tb_newpass2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_newpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_oldpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_notice
            // 
            this.lb_notice.AutoSize = true;
            this.lb_notice.Location = new System.Drawing.Point(161, 351);
            this.lb_notice.Name = "lb_notice";
            this.lb_notice.Size = new System.Drawing.Size(249, 15);
            this.lb_notice.TabIndex = 33;
            this.lb_notice.Text = "Please change your password every 3 months.";
            this.lb_notice.Click += new System.EventHandler(this.lb_notice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "TIP: Set a password with AT LEAST six (6) characters, with at least one uppercase" +
    " letter.";
            // 
            // lb_desc
            // 
            this.lb_desc.AutoSize = true;
            this.lb_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_desc.Location = new System.Drawing.Point(189, 74);
            this.lb_desc.Name = "lb_desc";
            this.lb_desc.Size = new System.Drawing.Size(46, 17);
            this.lb_desc.TabIndex = 31;
            this.lb_desc.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(49, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "DESIGNATION:";
            // 
            // lb_cuser
            // 
            this.lb_cuser.AutoSize = true;
            this.lb_cuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_cuser.Location = new System.Drawing.Point(189, 48);
            this.lb_cuser.Name = "lb_cuser";
            this.lb_cuser.Size = new System.Drawing.Size(46, 17);
            this.lb_cuser.TabIndex = 29;
            this.lb_cuser.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "CURRENT USER:";
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.BackColor = System.Drawing.Color.Sienna;
            this.btn_changePassword.FlatAppearance.BorderSize = 0;
            this.btn_changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_changePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_changePassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_changePassword.Image")));
            this.btn_changePassword.Location = new System.Drawing.Point(105, 264);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(349, 61);
            this.btn_changePassword.TabIndex = 27;
            this.btn_changePassword.Text = "   SAVE NEW PASSWORD";
            this.btn_changePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_changePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_changePassword.UseVisualStyleBackColor = false;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // tb_newpass2
            // 
            this.tb_newpass2.Location = new System.Drawing.Point(255, 220);
            this.tb_newpass2.Name = "tb_newpass2";
            this.tb_newpass2.Size = new System.Drawing.Size(275, 23);
            this.tb_newpass2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "RETYPE NEW PASSWORD: ";
            // 
            // tb_newpass
            // 
            this.tb_newpass.Location = new System.Drawing.Point(255, 193);
            this.tb_newpass.Name = "tb_newpass";
            this.tb_newpass.Size = new System.Drawing.Size(275, 23);
            this.tb_newpass.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "NEW PASSWORD: ";
            // 
            // tb_oldpass
            // 
            this.tb_oldpass.Location = new System.Drawing.Point(255, 167);
            this.tb_oldpass.Name = "tb_oldpass";
            this.tb_oldpass.Size = new System.Drawing.Size(275, 23);
            this.tb_oldpass.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "OLD PASSWORD: ";
            // 
            // YSKMAWTEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(560, 414);
            this.Controls.Add(this.lb_notice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_desc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_cuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_changePassword);
            this.Controls.Add(this.tb_newpass2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_newpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_oldpass);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YSKMAWTEX";
            this.Text = "CHANGE PASSWORD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_notice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_cuser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.TextBox tb_newpass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_newpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_oldpass;
        private System.Windows.Forms.Label label2;
    }
}