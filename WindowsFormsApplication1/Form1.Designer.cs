using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        static private SqlConnection connection;
        string item;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDbConnect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblConnection = new System.Windows.Forms.Label();
            this.rtbList = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDbConnect
            // 
            this.btnDbConnect.Location = new System.Drawing.Point(639, 12);
            this.btnDbConnect.Name = "btnDbConnect";
            this.btnDbConnect.Size = new System.Drawing.Size(115, 34);
            this.btnDbConnect.TabIndex = 0;
            this.btnDbConnect.Text = "DB Connect";
            this.btnDbConnect.UseVisualStyleBackColor = true;
            this.btnDbConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "SELECT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(637, 49);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(117, 12);
            this.lblConnection.TabIndex = 2;
            this.lblConnection.Text = "연결되지 않았습니다";
            // 
            // rtbList
            // 
            this.rtbList.Location = new System.Drawing.Point(13, 164);
            this.rtbList.Name = "rtbList";
            this.rtbList.Size = new System.Drawing.Size(741, 287);
            this.rtbList.TabIndex = 3;
            this.rtbList.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(131, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "JOIN";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(493, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "UPDATE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(250, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 34);
            this.button6.TabIndex = 7;
            this.button6.Text = "INSERT";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "BROADCASTING_STATION",
            "CAST",
            "DEPENDENT",
            "EMPLOYEE",
            "ENTERTAINMENT",
            "TVPROGRAM"});
            this.checkedListBox1.Location = new System.Drawing.Point(13, 58);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(216, 100);
            this.checkedListBox1.TabIndex = 8;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(741, 287);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rtbList);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDbConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDbConnect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.RichTextBox rtbList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

