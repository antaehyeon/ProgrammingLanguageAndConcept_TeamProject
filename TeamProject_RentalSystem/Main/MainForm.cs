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

        private void btn_userMode_Click(object sender, EventArgs e)
        {
            // 창 전환하는 부분 (유저모드)
            userForm userform = new userForm();
            userform.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            userform.Show();
            this.Hide();

        }

        private void btn_adminMode_Click(object sender, EventArgs e)
        {
            // 창 전환하는 부분 (관리자모드)
            adminForm adminform = new adminForm();
            adminform.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            adminform.Show();
            this.Hide();
        }

        // 폼에서 닫기버튼을 클릭했을 경우
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
