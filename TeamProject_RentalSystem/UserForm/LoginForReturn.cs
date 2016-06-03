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
    public partial class LoginForReturn : Form
    {
        SharingData sd;
        RentAndReturnForm rarf;
        int count = 0;

        public LoginForReturn(RentAndReturnForm rarf)
        {
            InitializeComponent();
            sd = SharingData.GetInstance();

            this.rarf = rarf;

            // 패스워드를 별로 표시
            txtBox_pw.Text = "";
            txtBox_pw.PasswordChar = '*';
        }

        private void txtBox_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter가 입력될 시
            if(e.KeyChar.Equals((char)Keys.Enter))
            {
                // 해당 ID의 index를 찾는다
                int index = findIdIndex();
                int itemIndex = findItemNoIndex();
                // 해당 ID의 패스워드와 일치한다면
                if (sd.AccountList[index].UserPw == txtBox_pw.Text)
                {
                    // 해당 itemList 에 물품의 갯수를 더해주고
                    var calc = int.Parse(sd.ItemList[itemIndex].ItemNum) + int.Parse(sd.RentList[rarf.Index].RentNum);
                    sd.ItemList[itemIndex].ItemNum = calc.ToString();

                    // 대여자 목록은 삭제
                    sd.RentList.RemoveAt(rarf.Index);

                    // RentAndReturnForm 쪽의 GridView 2개를 Refresh
                    rarf.rentGridViewRefresh();
                    rarf.itemGridViewRefresh();

                    MessageBox.Show("반납이 완료되었습니다");

                    // 해당 폼 종료
                    this.OnFormClosed(null);
                }
                // 패스워드 불일치
                else
                {
                    count++;
                    MessageBox.Show("비밀번호가 일치하지 않습니다");
                    lbl_errorMsg.Text = count + "번 틀리셨습니다.\n3번 틀리시면 창이 종료됩니다";
                    txtBox_pw.Clear();
                    if (count.Equals(3))
                    {
                        this.OnFormClosed(null);
                    }
                }
            }

            // ESC 입력되면 창 종료
            if (e.KeyChar.Equals((char)Keys.Escape))
            {
                this.OnFormClosed(null);
            }
        }

        // 현재 아이디의 index를 찾는 메소드
        private int findIdIndex()
        {
            for (int index = 0; index < sd.AccountList.Count; index++)
            {
                if (sd.CurrentId.Equals(sd.AccountList[index].UserId))
                {
                    return index;
                }
            }
            return -1;
        }

        // itemList 에서 대여한 물품의번호와 같은 index를 찾는 메소드
        private int findItemNoIndex()
        {
            for (int index = 0; index < sd.ItemList.Count; index++)
            {
                if (sd.ItemList[index].ItemNo.Equals(sd.RentList[rarf.Index].RentNo))
                {
                    return index;
                }
            }
            return -1;
        }

        private void LoginForReturn_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
