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
    public partial class SearchCommodityForm : Form
    {
        public SearchCommodityForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_back_Click(object sender, EventArgs e)
        {
            userForm userform = new userForm();
            userform.FormClosed += new FormClosedEventHandler(SearchCommodityForm_FormClosed);
            userform.Show();
            this.Hide();
        }

        private void SearchCommodityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
