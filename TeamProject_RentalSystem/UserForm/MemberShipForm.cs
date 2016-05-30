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
    public partial class MemberShipForm : Form
    {
        public MemberShipForm()
        {
            InitializeComponent();
        }

        private void MemberShipForm_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자만 입력할 수 있도록
            int keyCode = (int)e.KeyChar;
            if ((keyCode < 48 || keyCode > 57) && keyCode != 8 && !keyCode.Equals(46))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // 숫자만 입력할 수 있도록
            int keyCode = (int)e.KeyChar;
            if ((keyCode < 48 || keyCode > 57) && keyCode != 8 && !keyCode.Equals(46))
            {
                e.Handled = true;
            }
        }

        private void MemberShipForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void txtBox_id_TextChanged(object sender, EventArgs e)
        {
            txtBox_id.MaxLength = 10;

            if(txtBox_id.Text.Length.Equals(6))
            {
                txtBox_pw.Focus();
            }
        }

        private void txtBox_id_MouseDown(object sender, MouseEventArgs e)
        {
            lbl_guide.Text = "ID는 숫자만 입력가능하며, 10자리 까지 입력 가능합니다";
        }

        private void txtBox_pw_TextChanged(object sender, EventArgs e)
        {
            txtBox_pw.PasswordChar = '*';
        }

        private void txtBox_first_TextChanged(object sender, EventArgs e)
        {
            txtBox_first.MaxLength = 3;

            if(txtBox_first.Text.Length.Equals(3))
            {
                txtBox_mid.Focus();
            }
        }

        private void txtBox_mid_TextChanged(object sender, EventArgs e)
        {
            txtBox_mid.MaxLength = 4;

            if (txtBox_mid.Text.Length.Equals(4))
            {
                txtBox_last.Focus();
            }
        }

        private void txtBox_last_TextChanged(object sender, EventArgs e)
        {
            txtBox_last.MaxLength = 4;
        }

        private void txtBox_repw_TextChanged(object sender, EventArgs e)
        {
            txtBox_pw.PasswordChar = '*';
            if (txtBox_pw.Text.Length.Equals(txtBox_repw.Text.Length))
            {
                txtBox_first.Focus();
            }
        }

        private void txtBox_pw_Enter(object sender, EventArgs e)
        {
            lbl_guide.Text = "\t\t패스워드는 자유롭게 입력 가능합니다";
        }

        private void txtBox_first_Enter(object sender, EventArgs e)
        {
            lbl_guide.Text = "\t핸드폰번호는 회원탈퇴시 확인목적으로 사용됩니다";
        }
    }
}
