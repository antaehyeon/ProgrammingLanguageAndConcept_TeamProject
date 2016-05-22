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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_userMode_Click(object sender, EventArgs e)
        {
            // 창 전환하는 부분 (유저모드)
            var userForm = new userForm();
            userForm.Location = this.Location;
            userForm.StartPosition = FormStartPosition.Manual;
            userForm.FormClosing += delegate { this.Show(); };
            userForm.Show();
            this.Hide();
        }

        private void btn_adminMode_Click(object sender, EventArgs e)
        {
            // 창 전환하는 부분 (관리자모드)
            var adminForm = new adminForm();
            adminForm.Location = this.Location;
            adminForm.StartPosition = FormStartPosition.Manual;
            adminForm.FormClosing += delegate { this.Show(); };
            adminForm.Show();
            this.Hide();
        }
    }
}
