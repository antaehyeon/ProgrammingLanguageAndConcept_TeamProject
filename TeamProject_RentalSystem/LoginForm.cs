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
    public partial class LoginForm : Form
    {
        SharingData sd;

        public LoginForm()
        {
            InitializeComponent();
            sd = SharingData.GetInstance();

            // 비밀번호 입력란 * 표시
            txtBox_pw.Text = "";
            txtBox_pw.PasswordChar = '*';
        } // Constructor

        // Login 폼이 로드되었을 경우
        private void LoginForm_Load(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("account.txt", Encoding.Default);
            if (lines.Count() > 0)
            {
                foreach (var cellValues in lines)
                {
                    var cellArray = cellValues.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    AccountVO accountData = new AccountVO(cellArray[0], cellArray[1], cellArray[2]);
                    sd.AccountList.Add(accountData);
                } // foreach
            } // if
        } // M.LoginForm_Load

        // ID 텍스트박스에서 엔터키가 입력됬을경우
        private void txtBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (loginPwCheck())
                {
                    openUserForm();
                }
            }
        }

        // PW 텍스트박스에서 엔터키가 입력됬을경우
        private void txtBox_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(loginPwCheck())
                {
                    openUserForm();
                }
            }
        }

        // LOGIN 버튼을 눌렀을 경우
        private void btn_login_Click(object sender, EventArgs e)
        {
            // 로그인 성공시
            if (loginPwCheck())
            {
                openUserForm();
            }
        }

        public bool loginPwCheck()
        {
            int index = 0;
            bool loginCheck = false;

            for (index = 0; index < sd.AccountList.Count; index++)
            {
                // ID가 존재하는지 확인
                // 그 ID에 대한 PW도 맞는지 확인
                if (this.txtBox_id.Text == sd.AccountList[index].UserId && this.txtBox_pw.Text == sd.AccountList[index].UserPw)
                {
                    // 로그인 성공
                    loginCheck = true;
                    MessageBox.Show("로그인에 성공하셨습니다 - 유저모드");
                    return true;
                } // if
            } // for

            // 로그인 실패 (index가 count값과 같을경우)
            if (!loginCheck)
            {
                MessageBox.Show("아이디 비밀번호를 확인하세요");
            }
            return false;
        } // M.loginPwCheck

        // UserForm Open
        public void openUserForm()
        {
            userForm userform = new userForm();
            userform.FormClosed += new FormClosedEventHandler(LoginForm_FormClosed);
            userform.Show();
            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    } // Class
}
