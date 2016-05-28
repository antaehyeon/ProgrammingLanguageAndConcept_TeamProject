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
    public partial class InputNumForm : Form
    {
        SharingData sd;
        RentAndReturnForm rarf;

        public InputNumForm(RentAndReturnForm rarf)
        {
            InitializeComponent();
            sd = SharingData.GetInstance();
            this.rarf = rarf;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자만 입력할 수 있도록
            int keyCode = (int)e.KeyChar;
            if ((keyCode < 48 || keyCode > 57) && keyCode != 8 && !keyCode.Equals(46))
            {
                e.Handled = true;
            }

            // 엔터키가 입력되면
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                sd.InputNumData = txtBox_inputNum.Text;

                // 해당 물품 갯수 차감
                var calc = int.Parse(sd.ItemList[rarf.Index].ItemNum) - int.Parse(sd.InputNumData);
                sd.ItemList[rarf.Index].ItemNum = calc.ToString();

                // 대여자 쪽 정보 추가
                rentVO rentData = new rentVO(sd.ItemList[rarf.Index].ItemNo, DateTime.Now.ToShortDateString(), sd.CurrentId, sd.InputNumData);
                sd.RentList.Add(rentData);

                // RentAndReturnForm 쪽의 GridView 2개를 Refresh
                rarf.rentGridViewRefresh();
                rarf.itemGridViewRefresh();

                // Closed Event 발생
                this.OnFormClosed(null);
            }

            // ESC 입력되면 창 종료
            if (e.KeyChar.Equals((char)Keys.Escape))
            {
                this.OnFormClosed(null);
            }
        }

        private void InputNumForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
