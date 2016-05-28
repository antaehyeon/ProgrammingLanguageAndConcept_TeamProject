using System;
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
            mainForm mainform = new mainForm();
            mainform.FormClosed += new FormClosedEventHandler(userForm_FormClosed);
            mainform.Show();
            this.Hide();
        }

        private void userForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            RentAndReturnForm rentreturnform = new RentAndReturnForm();
            rentreturnform.FormClosed += new FormClosedEventHandler(userForm_FormClosed);
            rentreturnform.Show();
            this.Hide();
        }
    }
}
