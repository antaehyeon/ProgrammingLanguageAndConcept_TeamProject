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
    public partial class MemberShipForm : Form
    {
        SharingData sd;
        LoginForm loginform;
        private string phoneNum;

        public MemberShipForm(LoginForm loginform)
        {
            InitializeComponent();
            sd = SharingData.GetInstance();
            this.loginform = loginform;
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
        
        private void txtBox_id_TextChanged(object sender, EventArgs e)
        {
            txtBox_id.MaxLength = 10;

            for(int i = 0; i < sd.AccountList.Count; i++)
            {
                if (txtBox_id.Text == sd.AccountList[i].UserId)
                {
                    lbl_guide.Text = "                      이미 등록된 학번입니다";
                    lbl_guide.ForeColor = Color.Red;
                    txtBox_id.Clear();
                    return;
                }
            }
            
            if(txtBox_id.Text.Length.Equals(10))
            {
                txtBox_pw.Focus();
            }
        }

        private void txtBox_pw_TextChanged(object sender, EventArgs e)
        {
            txtBox_pw.PasswordChar = '*';
        }

        private void txtBox_first_TextChanged(object sender, EventArgs e)
        {
            txtBox_first.MaxLength = 3;

            // TAB 효과
            if(txtBox_first.Text.Length.Equals(3))
            {
                txtBox_mid.Focus();
            }
        }

        private void txtBox_mid_TextChanged(object sender, EventArgs e)
        {
            txtBox_mid.MaxLength = 4;

            // TAB 효과
            if (txtBox_mid.Text.Length.Equals(4))
            {
                txtBox_last.Focus();
            }
        }
        private void txtBox_last_TextChanged(object sender, EventArgs e)
        {
            txtBox_last.MaxLength = 4;
        }

        // 상황에 따라서 위의 텍스트박스에 도움말을 표시
        private void txtBox_id_MouseDown(object sender, MouseEventArgs e)
        {
            lbl_guide.Text = "ID는 숫자만 입력가능하며, 10자리 까지 입력 가능합니다";
        }
        private void txtBox_pw_Enter(object sender, EventArgs e)
        {
            lbl_guide.Text = "          패스워드는 자유롭게 입력 가능합니다";
            lbl_guide.ForeColor = Color.Black;
        }
        private void txtBox_repw_TextChanged(object sender, EventArgs e)
        {
            txtBox_repw.PasswordChar = '*';
            if (txtBox_pw.Text == txtBox_repw.Text)
            {
                lbl_guide.Text = "                      비밀번호가 일치합니다";
                lbl_guide.ForeColor = Color.MediumSpringGreen;
            }
            else
            {
                lbl_guide.Text = "                  비밀번호가 일치하지 않습니다";
                lbl_guide.ForeColor = Color.DarkRed;
            }
            if (txtBox_pw.Text.Equals(txtBox_repw.Text))
            {
                txtBox_first.Focus();   
            }
        }

        // 가입하기 버튼
        private void btn_register_Click(object sender, EventArgs e)
        {
            phoneNum = txtBox_first.Text + "-" + txtBox_mid.Text + "-" + txtBox_last.Text;
            for (int i = 0; i < sd.AccountList.Count; i++)
            {
                if(phoneNum.Equals(sd.AccountList[i].PhoneNum))
                {
                    lbl_guide.Text = "                      핸드폰 번호는 중복될 수 없습니다";
                    lbl_guide.ForeColor = Color.Red;
                    txtBox_first.Text = "";
                    txtBox_mid.Text = "";
                    txtBox_last.Text = "";
                    txtBox_first.Focus();
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtBox_id.Text) || string.IsNullOrWhiteSpace(txtBox_first.Text) || string.IsNullOrWhiteSpace(txtBox_last.Text) ||
                string.IsNullOrWhiteSpace(txtBox_mid.Text) || string.IsNullOrWhiteSpace(txtBox_repw.Text) || string.IsNullOrWhiteSpace(txtBox_pw.Text))
            {
                lbl_guide.Text = "데이터가 제대로 입력되지 않았습니다";
                lbl_guide.ForeColor = Color.Red;
                return;
            }
            else if (txtBox_first.Text.Length.Equals(3) && (txtBox_mid.Text.Length.Equals(4) || txtBox_mid.Text.Equals(3)) && txtBox_last.Text.Length.Equals(4))
            {
                AccountVO account = new AccountVO(txtBox_id.Text, txtBox_pw.Text, "0", phoneNum);

                sd.AccountList.Add(account);
            }
            else
            {
                lbl_guide.Text = "데이터가 제대로 입력되지 않았습니다";
                lbl_guide.ForeColor = Color.Red;
                return;
            }

            StreamWriter writer = new StreamWriter("Account.txt", false, System.Text.Encoding.Default);
            for (int i = 0; i < sd.AccountList.Count; i++)
            {
                writer.WriteLine("{0} {1} {2} {3}", sd.AccountList[i].UserId, sd.AccountList[i].UserPw, sd.AccountList[i].AccessLevel, sd.AccountList[i].PhoneNum);
            }
            writer.Close();

            MessageBox.Show("회원가입에 성공하였습니다");

            this.OnFormClosed(null);
        }

        // 핸드폰번호 마지막 칸에서 Enter 가 눌렸을 경우
        // 가입하기 버튼이 눌린것과 똑같은 이벤트 발생
        private void txtBox_last_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자만 입력할 수 있도록
            int keyCode = (int)e.KeyChar;
            if ((keyCode < 48 || keyCode > 57) && keyCode != 8 && !keyCode.Equals(46))
            {
                e.Handled = true;
            }
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                btn_register_Click(null, null);
            }
        }

        // 핸드폰 박스에 번호만 들어갈 수 있도록 예외처리
        private void txtBox_first_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyCode = (int)e.KeyChar;
            if ((keyCode < 48 || keyCode > 57) && keyCode != 8 && !keyCode.Equals(46))
            {
                e.Handled = true;
            }
        }
        private void txtBox_mid_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyCode = (int)e.KeyChar;
            if ((keyCode < 48 || keyCode > 57) && keyCode != 8 && !keyCode.Equals(46))
            {
                e.Handled = true;
            }
        }

        // 폼이 종료될 시 이벤트처리
        private void MemberShipForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginform.Show();
            this.Close();
        }
    }
}
