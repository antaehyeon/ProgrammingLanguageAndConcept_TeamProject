﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject_RentalSystem
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchCommodityForm searchForm = new SearchCommodityForm();
            searchForm.FormClosed += new FormClosedEventHandler(userForm_FormClosed);
            searchForm.Show();
            this.Hide();
        }

        private void btn_userForm_back_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.FormClosed += new FormClosedEventHandler(userForm_FormClosed);
            loginform.Show();
            this.Hide();
        }

        private void btn_rentRentForm_Click(object sender, EventArgs e)
        {
            RentAndReturnForm rentform = new RentAndReturnForm();
            rentform.FormClosed += new FormClosedEventHandler(userForm_FormClosed);
            rentform.Show();
            this.Hide();
        }

        private void userForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
