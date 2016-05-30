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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        // 메인 창이 로드 될 때
        // 데이터그리드뷰를 TXT를 로드해 셋팅하려고함
        private void adminForm_Load(object sender, EventArgs e)     
        {
            dataGridView1.Columns.Add("Column1", "물품번호");
            dataGridView1.Columns.Add("Column2", "이름");
            dataGridView1.Columns.Add("Column3", "수량");

            var lines = File.ReadAllLines("text.txt", Encoding.Default);    
            if (lines.Count() > 0)
            {
                foreach (var cellValues in lines)
                {
                    var cellArray = cellValues
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                          dataGridView1.Rows.Add(cellArray);
                }
            }
        }

        // 저장 버튼
        private void button1_Click(object sender, EventArgs e) 
        {
           Stream fs = File.OpenWrite("text.txt");
           StreamWriter sw= new StreamWriter(fs, Encoding.Default);

            for (int i = 0; i <(dataGridView1.RowCount -1) ; i++)
                {
                for (int j = 0; j< 3; j++)
                {
                    if (dataGridView1[j, i].Value ==null)  break;

                    sw.Write(dataGridView1[j, i].Value.ToString()); sw.Write(' ');
                }
                 sw.WriteLine("");
            }
            sw.Close();
            MessageBox.Show("저장 완료", "완료");
        }

        // 새로고침 버튼
        private void button2_Click(object sender, EventArgs e)        
        {
           dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var lines = File.ReadAllLines("text.txt", Encoding.Default);

            if (lines.Count() > 0)
            {
                foreach (var cellValues in lines)      
                {
                    var cellArray = cellValues
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    dataGridView1.Rows.Add(cellArray);      
                }
            }
            MessageBox.Show("새로고침 완료", "완료");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.FormClosed += new FormClosedEventHandler(adminForm_FormClosed);
            loginform.Show();
            this.Hide();
        }

        private void adminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}



