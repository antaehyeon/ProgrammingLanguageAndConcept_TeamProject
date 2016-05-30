using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TeamProject_RentalSystem
{
    public partial class MemberLeave : Form
    {
        SharingData sd;
        LoginForm loginform;

        int index;
        string id;
        string pw;        

        public MemberLeave(LoginForm loginform)
        {
            InitializeComponent();
            this.loginform = loginform;
            sd = SharingData.GetInstance();
        }

        private void txtBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 엔터가 입력될 경우
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                for (index = 0; index < sd.AccountList.Count; index++)
                {
                    // 현재 Accout List 에 텍스트박스에서 입력된 ID가 존재한다면
                    if (sd.AccountList[index].UserId.Equals(txtBox_id.Text))
                    {
                        id = txtBox_id.Text;
                        txtBox_id.Visible = false;
                        txtBox_pw.Visible = true;
                        lbl_guide.Text = "                  비밀번호를 입력하세요";
                        txtBox_pw.Focus();
                        return;
                    }
                }
                // 만약 아이디가 존재하지 않는다면
                if (index.Equals(sd.AccountList.Count))
                {
                    lbl_guide.Text = "               아이디가 존재하지 않습니다";
                    lbl_guide.ForeColor = Color.Red;
                    return;
                }
            }
            // 숫자만 입력할 수 있도록
            int keyCode = (int)e.KeyChar;
            if ((keyCode < 48 || keyCode > 57) && keyCode != 8 && !keyCode.Equals(46))
            {
                e.Handled = true;
            }
        }

        private void MemberLeave_Load(object sender, EventArgs e)
        {
            txtBox_pw.Visible = false;
        }

        private void txtBox_pw_TextChanged(object sender, EventArgs e)
        {
            txtBox_pw.PasswordChar = '*';
        }

        private void txtBox_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)Keys.Enter))
            {
                if (sd.AccountList[index].UserPw.Equals(txtBox_pw.Text))
                {
                    if(sd.AccountList[index].AccessLevel.Equals("1"))
                    {
                        MessageBox.Show("관리자 계정은 삭제할 수 없습니다");
                        return;
                    }

                    sd.AccountList.RemoveAt(index);

                    StreamWriter writer = new StreamWriter("Account.txt", false, System.Text.Encoding.Default);
                    for (int i = 0; i < sd.AccountList.Count; i++)
                    {
                        writer.WriteLine("{0} {1} {2} {3}", sd.AccountList[i].UserId, sd.AccountList[i].UserPw, sd.AccountList[i].AccessLevel, sd.AccountList[i].PhoneNum);
                    }
                    writer.Close();

                    MessageBox.Show("회원탈퇴가 정상적으로 처리되었습니다");
                    this.OnFormClosed(null);
                }
                else
                {
                    lbl_guide.Text = "비밀번호가 맞지 않습니다";
                    lbl_guide.ForeColor = Color.Red;
                }
            }
        }

        private void MemberLeave_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginform.Show();
            this.Close();
        }
    }
}
