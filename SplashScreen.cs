using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using EntityFramework99;
using System.Text;
using System.Text.RegularExpressions;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMC2021
{
    public partial class SplashScreen : Form
    {
        POSDB2Entities db = new POSDB2Entities();
        public SplashScreen()
        {
            InitializeComponent();
        }

   
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 10;
            if (progressBar1.Value == 80)
            {
                progressBar1.Value = progressBar1.Value + 20;
                if (progressBar1.Value >= progressBar1.Maximum)
                {
                    timer1.Enabled = false;


                    //Open-source Version

                    Login frm = new Login();
                    frm.Show();
                    this.Hide();


                }
            }
        }

        private void LKMVHJSUSAERJ_Load(object sender, EventArgs e)
        {

        }
    }
}

