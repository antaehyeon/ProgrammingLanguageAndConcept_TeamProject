namespace TeamProject_RentalSystem
{
    partial class SearchCommodityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_search_back = new System.Windows.Forms.Button();
            this.dataGridView_itemList = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_itemList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search_back
            // 
            this.btn_search_back.Location = new System.Drawing.Point(17, 18);
            this.btn_search_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search_back.Name = "btn_search_back";
            this.btn_search_back.Size = new System.Drawing.Size(107, 34);
            this.btn_search_back.TabIndex = 5;
            this.btn_search_back.Text = "뒤로가기";
            this.btn_search_back.UseVisualStyleBackColor = true;
            this.btn_search_back.Click += new System.EventHandler(this.btn_search_back_Click);
            // 
            // dataGridView_itemList
            // 
            this.dataGridView_itemList.AllowUserToAddRows = false;
            this.dataGridView_itemList.AllowUserToDeleteRows = false;
            this.dataGridView_itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_itemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName});
            this.dataGridView_itemList.Location = new System.Drawing.Point(17, 59);
            this.dataGridView_itemList.Name = "dataGridView_itemList";
            this.dataGridView_itemList.ReadOnly = true;
            this.dataGridView_itemList.RowTemplate.Height = 30;
            this.dataGridView_itemList.Size = new System.Drawing.Size(242, 373);
            this.dataGridView_itemList.TabIndex = 6;
            this.dataGridView_itemList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_itemList_CellMouseClick);
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "물품 이름";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(302, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "왼쪽 박스에서 조회하고 싶은 물품을 선택하세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "물품 번호 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "재고 상태 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "대여 가능여부 : ";
            // 
            // SearchCommodityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_itemList);
            this.Controls.Add(this.btn_search_back);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchCommodityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "물품대여시스템 - 물품검색";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchCommodityForm_FormClosed);
            this.Load += new System.EventHandler(this.SearchCommodityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_itemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_search_back;
        private System.Windows.Forms.DataGridView dataGridView_itemList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
    }
}