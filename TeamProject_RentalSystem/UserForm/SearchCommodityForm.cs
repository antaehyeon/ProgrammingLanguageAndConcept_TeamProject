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
    public partial class SearchCommodityForm : Form
    {
        SharingData sd;

        public SearchCommodityForm()
        {
            InitializeComponent();
            sd = SharingData.GetInstance();
        }

        private void SearchCommodityForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sd.ItemList.Count; i++)
            {
                dataGridView_itemList.Rows.Add(sd.ItemList[i].ItemName);
            }
        }

        private void btn_search_back_Click(object sender, EventArgs e)
        {
            userForm userform = new userForm();
            userform.FormClosed += new FormClosedEventHandler(SearchCommodityForm_FormClosed);
            userform.Show();
            this.Hide();
        }

        private void dataGridView_itemList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string contentText = "";
            string itemNo = "";
            string itemNum = "";

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_itemList.Rows[e.RowIndex];
                contentText = row.Cells["itemName"].Value.ToString();
            }

            for (int i = 0; i < sd.ItemList.Count; i++)
            {
                if (contentText.Equals(sd.ItemList[i].ItemName))
                {
                    itemNo = sd.ItemList[i].ItemNo;
                    itemNum = sd.ItemList[i].ItemNum;
                    // 해당 물품의 갯수에 따라서 메세지를 다르게 출력
                    if (sd.ItemList[i].ItemNum.Equals("0"))
                    {
                        lbl_rentState.Text = "대여 가능여부 : 불가능";
                        lbl_rentState.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_rentState.Text = "대여 가능여부 : 가능";
                        lbl_rentState.ForeColor = Color.Blue;
                    }
                    break;
                }
            }
     
            label1.Text = "현재 선택하신 " + contentText + " 에 대한 정보입니다";
            label2.Text = "물품 번호 : " + itemNo;
            label3.Text = "재고 상태 : " + itemNum;
        }

        private void SearchCommodityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
