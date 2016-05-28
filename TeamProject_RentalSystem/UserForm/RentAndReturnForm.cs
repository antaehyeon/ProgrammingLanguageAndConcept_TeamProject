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
    public partial class RentAndReturnForm : Form
    {
        SharingData sd;

        public RentAndReturnForm()
        {
            InitializeComponent();
            sd = SharingData.GetInstance();
        }

        private void btn_rentReturn_back_Click(object sender, EventArgs e)
        {
            userForm userform = new userForm();
            userform.FormClosed += new FormClosedEventHandler(RentAndReturnForm_FormClosed);
            userform.Show();
            this.Hide();
        }

        private void RentAndReturnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RentAndReturnForm_Load(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("ITEM.txt", Encoding.Default);
            if (lines.Count() > 0)
            {
                // 텍스트파일의 Line에서 데이터를 전부 가져온 후에
                // Split 로 \t 공백을 구분하여 데이터를 배열로 나누고
                // itemVO객체를 하나 선언하여 데이터를 넣어주고
                // SharingData의 List에 추가한다
                // 그리고 DataGridView 에 추가한다
                foreach (var cellValues in lines)
                {
                    var cellArray = cellValues
                        .Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    itemVO itemData = new itemVO(cellArray[0], cellArray[1]);
                    sd.ItemList.Add(itemData);

                    if (cellArray.Length == itemGridView.Columns.Count)
                        itemGridView.Rows.Add(cellArray);
                }
            }
        }
    }
}
