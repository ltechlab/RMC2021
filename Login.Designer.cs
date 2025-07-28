namespace RMC2021
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lb_note = new System.Windows.Forms.Label();
            this.tb_passinput = new System.Windows.Forms.TextBox();
            this.tb_userinput = new System.Windows.Forms.TextBox();
            this.BLOG = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_note
            // 
            this.lb_note.AutoSize = true;
            this.lb_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_note.Location = new System.Drawing.Point(178, 162);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(264, 15);
            this.lb_note.TabIndex = 12;
            this.lb_note.Text = "Please log-in with your user credentials.";
            // 
            // tb_passinput
            // 
            this.tb_passinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_passinput.Location = new System.Drawing.Point(196, 240);
            this.tb_passinput.Name = "tb_passinput";
            this.tb_passinput.Size = new System.Drawing.Size(310, 23);
            this.tb_passinput.TabIndex = 11;
            // 
            // tb_userinput
            // 
            this.tb_userinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_userinput.Location = new System.Drawing.Point(196, 202);
            this.tb_userinput.Name = "tb_userinput";
            this.tb_userinput.Size = new System.Drawing.Size(310, 23);
            this.tb_userinput.TabIndex = 10;
            // 
            // BLOG
            // 
            this.BLOG.BackColor = System.Drawing.Color.Sienna;
            this.BLOG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BLOG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLOG.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BLOG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BLOG.Location = new System.Drawing.Point(65, 286);
            this.BLOG.Name = "BLOG";
            this.BLOG.Size = new System.Drawing.Size(219, 67);
            this.BLOG.TabIndex = 9;
            this.BLOG.Text = "LOGIN";
            this.BLOG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLOG.UseVisualStyleBackColor = false;
            this.BLOG.Click += new System.EventHandler(this.BLOG_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(82, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "USERNAME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RMC2021.Properties.Resources.ltechrmc;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(290, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 67);
            this.button1.TabIndex = 14;
            this.button1.Text = "EXIT";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(587, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CDEFGKHFKSYTWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(587, 415);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_note);
            this.Controls.Add(this.tb_passinput);
            this.Controls.Add(this.tb_userinput);
            this.Controls.Add(this.BLOG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CDEFGKHFKSYTWS";
            this.Text = "LOG-IN TO RMC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_note;
        private System.Windows.Forms.TextBox tb_passinput;
        private System.Windows.Forms.TextBox tb_userinput;
        private System.Windows.Forms.Button BLOG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}