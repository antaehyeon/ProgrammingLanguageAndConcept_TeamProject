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

        // 간단히 시각적인 효과를 주기위해서 비밀번호 텍스트박스를 숨겨놈
        private void MemberLeave_Load(object sender, EventArgs e)
        {
            txtBox_pw.Visible = false;
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
                    // 관리자 계정이 영어라서 아래의 예외처리에는 절대 걸릴 수 없지만 (아이디 텍스트박스에는 숫자만 들어가게 설정해놓음)
                    // 혹시나 하는 마음에 처리해놨습니다
                    if(sd.AccountList[index].AccessLevel.Equals("1"))
                    {
                        MessageBox.Show("관리자 계정은 삭제할 수 없습니다");
                        return;
                    }

                    // 대여한 물품이 존재한 계정이 탈퇴를 시도할시 예외처리
                    for (int i = 0; i < sd.RentList.Count; i++)
                    {
                        if (sd.AccountList[index].UserId.Equals(sd.RentList[i].RentId))
                        {
                            MessageBox.Show("대여한 물품이 있는 계정은 탈퇴가 불가능합니다");
                            this.OnFormClosed(null);
                            return;
                        }
                    }
                    
                    // 해당 List에서 계정정보를 지우고
                    sd.AccountList.RemoveAt(index);
                    
                    // Account 정보로 텍스트파일을 다시 Write
                    StreamWriter writer = new StreamWriter("Account.txt", false, System.Text.Encoding.Default);
                    for (int i = 0; i < sd.AccountList.Count; i++)
                    {
                        writer.WriteLine("{0} {1} {2} {3}", sd.AccountList[i].UserId, sd.AccountList[i].UserPw, sd.AccountList[i].AccessLevel, sd.AccountList[i].PhoneNum);
                    }
                    writer.Close();

                    // 정상처리문
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
            this.Dispose();
        }
    }
}
