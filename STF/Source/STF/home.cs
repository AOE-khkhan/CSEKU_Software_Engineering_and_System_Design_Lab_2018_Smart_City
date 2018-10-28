﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            request Req = new request();
            this.Hide();
            Req.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search Search = new search();
            this.Hide();
            Search.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tuitons Tuition = new tuitons();
            this.Hide();
            Tuition.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            signup SignUp = new signup();
            this.Hide();
            SignUp.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            help Help = new help();
            this.Hide();
            Help.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            login Login = new login();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }
    }
}
