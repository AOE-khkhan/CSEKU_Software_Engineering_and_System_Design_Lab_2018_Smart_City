﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCBT
{
    public partial class AdminProfile : MetroFramework.Forms.MetroForm
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void view_budget_Click(object sender, EventArgs e)
        {
            BudgetInfo BI = new BudgetInfo();
            BI.Show();
            this.Hide();
        }

        private void faq_Click(object sender, EventArgs e)
        {
            FAQ fq = new FAQ();
            fq.Show();
            this.Hide();
        }

        private void admin_login_Click(object sender, EventArgs e)
        {
            adminLogin ad = new adminLogin();
            ad.Show();
        }
    }
}
