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
using System.Threading;

namespace TeamProject_RentalSystem
{
    public partial class RentAndReturnForm : Form
    {
        SharingData sd;

        // 대여 및 반납시 사용
        itemVO itemData;
        rentVO rentData;
        private int index;

        public RentAndReturnForm()
        {
            InitializeComponent();
            sd = SharingData.GetInstance();

            itemData = new itemVO();
            rentData = new rentVO();
        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        // 처음 창이 Load 될 때
        private void RentAndReturnForm_Load(object sender, EventArgs e)
        {
            // item , rent GridView 출력
            itemGridViewRefresh();
            rentGridViewRefresh();

            // 버튼 (비)활성화
            btn_rent.Enabled = true;
            btn_return.Enabled = false;
        }

        // 뒤로가기 버튼을 눌렀을 때
        private void btn_rentReturn_back_Click(object sender, EventArgs e)
        {
            userForm userform = new userForm();
            userform.FormClosed += new FormClosedEventHandler(RentAndReturnForm_FormClosed);
            userform.Show();
            this.Hide();
        }

        // 대여 버튼
        private void btn_rent_Click(object sender, EventArgs e)
        {
            InputNumForm inputForm = new InputNumForm(this);
            inputForm.Show();
        }

        // Item GridView Refresh
        // 메모장에도 데이터를 새로 씀
        public void itemGridViewRefresh()
        {
            fileWriteToItem();
            this.itemGridView.Rows.Clear();
            this.itemGridView.Refresh();
            for (int i = 0; i < sd.ItemList.Count; i++)
            {
                itemGridView.Rows.Add(sd.ItemList[i].ItemNo, sd.ItemList[i].ItemName, sd.ItemList[i].ItemNum);
            }
        }

        // Item 파일에 현재 프로그램의 ItemList 데이터 Write
        public void fileWriteToItem()
        {
            StreamWriter writer = new StreamWriter("Item.txt", false, System.Text.Encoding.Default);

            for (int i = 0; i < sd.ItemList.Count; i++)
            {
                writer.WriteLine("{0} {1} {2}", sd.ItemList[i].ItemNo, sd.ItemList[i].ItemName, sd.ItemList[i].ItemNum);
            }
            writer.Close();
        }

        // 반납 버튼
        private void btn_return_Click(object sender, EventArgs e)
        {
            // 현재 로그인 아이디와 물품 대여자가 동일할 때
            if (sd.CurrentId.Equals(sd.RentList[index].RentId))
            {
                LoginForReturn loginForm = new LoginForReturn(this);
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("현재 로그인한 대여자의 물품이 아닙니다!!");
            }
        }

        // Rent GridView Refresh
        // 메모장에도 데이터를 새로 씀
        public void rentGridViewRefresh()
        {
            fileWriteToRent();
            this.rentGridView.Rows.Clear();
            this.rentGridView.Refresh();
            for (int i = 0; i < sd.RentList.Count; i++)
            {
                rentGridView.Rows.Add(sd.RentList[i].RentNo, sd.RentList[i].RentTime, sd.RentList[i].RentId, sd.RentList[i].RentNum);
            }
        }

        // Rent 파일에 현재 프로그램의 RentList 데이터 Write
        // 마지막 열에 NULL 이 있으면 처음 데이터를 불러올 때 Error가 나서 따로 처리
        public void fileWriteToRent()
        {
            StreamWriter writer = new StreamWriter("Rent.txt", false, System.Text.Encoding.Default);

            for (int i = 0; i < sd.RentList.Count; i++)
            {
                writer.WriteLine("{0} {1} {2} {3}", sd.RentList[i].RentNo, sd.RentList[i].RentTime, sd.RentList[i].RentId, sd.RentList[i].RentNum);
            }
            writer.Close();
        }

        // itemGridView 쪽 클릭시
        private void itemGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_return.Enabled = false;
            btn_rent.Enabled = true;

            // 클릭한 열의 물품번호의 데이터를 긁어옴
            DataGridViewRow row = this.itemGridView.Rows[e.RowIndex];
            itemData.ItemNo = row.Cells["itemNo"].Value.ToString();

            for (index = 0; index < sd.ItemList.Count; index++)
            {
                if (sd.ItemList[index].ItemNo == itemData.ItemNo)
                {
                    return;
                }
            }
        }

        // rentGridView 쪽 클릭시
        private void rentGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_rent.Enabled = false;
            btn_return.Enabled = true;

            // 클릭한 열의 물품번호의 데이터를 긁어옴
            DataGridViewRow row = this.rentGridView.Rows[e.RowIndex];
            rentData.RentNo = row.Cells["rentItemNo"].Value.ToString();
            rentData.RentId = row.Cells["rentId"].Value.ToString();
            rentData.RentNum = row.Cells["rentNum"].Value.ToString();
            rentData.RentTime = row.Cells["rentTime"].Value.ToString();

            for (index = 0; index < sd.RentList.Count; index++)
            {
                if (sd.RentList[index].RentNo.Equals(rentData.RentNo) &&
                    sd.RentList[index].RentId.Equals(rentData.RentId) &&
                    sd.RentList[index].RentNum.Equals(rentData.RentNum) &&
                    sd.RentList[index].RentTime.Equals(rentData.RentTime))
                {
                    return;
                }
            }
        }

        // Form 을 닫을시
        private void RentAndReturnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
