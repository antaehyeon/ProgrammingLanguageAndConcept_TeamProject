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
            // 해당 폼이 로드됬을 경우는
            // 1. 프로그램이 처음 시작되었을 때
            // 2. 뒤로가기로 돌아왔을때

            // 2번의 경우에서 계속해서 텍스트파일에 데이터를 쓰게되므로
            // SharingData 의 Class 쪽 체크값을 이용해 프로그램이 구동될 동안은 한번만 쓰도록 설정
            if (!sd.LoginWriteCheck)
            {
                // Account Text File Read
                var lines = File.ReadAllLines("Account.txt", Encoding.Default);
                foreach (var cellValues in lines)
                {
                    var cellArray = cellValues.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    AccountVO accountData = new AccountVO(cellArray[0], cellArray[1], cellArray[2]);
                    sd.AccountList.Add(accountData);
                } // foreach

                // Item Text File Read
                lines = File.ReadAllLines("Item.txt", Encoding.Default);
                foreach (var cellValues in lines)
                {
                    var cellArray = cellValues.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    itemVO itemData = new itemVO(cellArray[0], cellArray[1], cellArray[2]);
                    sd.ItemList.Add(itemData);
                } // foreach

                // Rent Text File Read
                lines = File.ReadAllLines("Rent.txt", Encoding.Default);
                foreach (var cellValues in lines)
                {
                    var cellArray = cellValues.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    rentVO rentData = new rentVO(cellArray[0], cellArray[1], cellArray[2], cellArray[3]);
                    sd.RentList.Add(rentData);
                } // foreach
                sd.LoginWriteCheck = true;
            }
        } // M.LoginForm_Load

        // ID 텍스트박스에서 엔터키가 입력됬을경우
        private void txtBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
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
            if (e.KeyChar.Equals((char)Keys.Enter))
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
                if (this.txtBox_id.Text.Equals(sd.AccountList[index].UserId) && this.txtBox_pw.Text.Equals(sd.AccountList[index].UserPw))
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
                // 입력했던 정보를 지워버림
                txtBox_id.Clear();
                txtBox_pw.Clear();
                // 입력했던 것이 지워지고 나서 ID TextBox 쪽으로 커서를 옮김
                txtBox_id.Focus();
            }
            return false;
        } // M.loginPwCheck

        // UserForm Open
        public void openUserForm()
        {
            sd.CurrentId = txtBox_id.Text;
            userForm userform = new userForm();
            userform.FormClosed += new FormClosedEventHandler(LoginForm_FormClosed);
            userform.Show();
            this.Hide();
        } // M.openUserForm

        // 로그인폼이 닫혔을 경우
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Application.Exit();
        } // M.LoginForm_FormClosed
    } // Class
}
