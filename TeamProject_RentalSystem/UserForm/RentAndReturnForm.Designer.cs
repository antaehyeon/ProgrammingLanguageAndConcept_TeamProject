namespace TeamProject_RentalSystem
{
    partial class RentAndReturnForm
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
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.itemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentGridView = new System.Windows.Forms.DataGridView();
            this.rentItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_rent = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rentReturn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGridView
            // 
            this.itemGridView.AllowUserToAddRows = false;
            this.itemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNo,
            this.itemName,
            this.itemNum});
            this.itemGridView.Location = new System.Drawing.Point(13, 84);
            this.itemGridView.Margin = new System.Windows.Forms.Padding(4);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowTemplate.Height = 23;
            this.itemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGridView.Size = new System.Drawing.Size(406, 379);
            this.itemGridView.TabIndex = 0;
            this.itemGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.itemGridView_CellMouseClick);
            // 
            // itemNo
            // 
            this.itemNo.HeaderText = "물품번호";
            this.itemNo.Name = "itemNo";
            this.itemNo.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "물품이름";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // itemNum
            // 
            this.itemNum.HeaderText = "수량";
            this.itemNum.Name = "itemNum";
            this.itemNum.ReadOnly = true;
            // 
            // rentGridView
            // 
            this.rentGridView.AllowUserToAddRows = false;
            this.rentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentItemNo,
            this.rentTime,
            this.rentId,
            this.rentNum});
            this.rentGridView.Location = new System.Drawing.Point(427, 84);
            this.rentGridView.Margin = new System.Windows.Forms.Padding(4);
            this.rentGridView.Name = "rentGridView";
            this.rentGridView.RowTemplate.Height = 23;
            this.rentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentGridView.Size = new System.Drawing.Size(501, 262);
            this.rentGridView.TabIndex = 1;
            this.rentGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rentGridView_CellMouseClick);
            // 
            // rentItemNo
            // 
            this.rentItemNo.HeaderText = "물품번호";
            this.rentItemNo.Name = "rentItemNo";
            this.rentItemNo.ReadOnly = true;
            // 
            // rentTime
            // 
            this.rentTime.HeaderText = "대여날짜";
            this.rentTime.Name = "rentTime";
            this.rentTime.ReadOnly = true;
            // 
            // rentId
            // 
            this.rentId.HeaderText = "대여자";
            this.rentId.Name = "rentId";
            this.rentId.ReadOnly = true;
            // 
            // rentNum
            // 
            this.rentNum.HeaderText = "대여갯수";
            this.rentNum.Name = "rentNum";
            this.rentNum.ReadOnly = true;
            // 
            // btn_rent
            // 
            this.btn_rent.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_rent.Location = new System.Drawing.Point(427, 354);
            this.btn_rent.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(251, 109);
            this.btn_rent.TabIndex = 2;
            this.btn_rent.Text = "대여";
            this.btn_rent.UseVisualStyleBackColor = true;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_return.Location = new System.Drawing.Point(686, 354);
            this.btn_return.Margin = new System.Windows.Forms.Padding(4);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(242, 109);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "반납";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(631, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "대여자 목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(158, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "물품 목록";
            // 
            // btn_rentReturn_back
            // 
            this.btn_rentReturn_back.Location = new System.Drawing.Point(13, 13);
            this.btn_rentReturn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rentReturn_back.Name = "btn_rentReturn_back";
            this.btn_rentReturn_back.Size = new System.Drawing.Size(107, 34);
            this.btn_rentReturn_back.TabIndex = 6;
            this.btn_rentReturn_back.Text = "뒤로가기";
            this.btn_rentReturn_back.UseVisualStyleBackColor = true;
            this.btn_rentReturn_back.Click += new System.EventHandler(this.btn_rentReturn_back_Click);
            // 
            // RentAndReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 476);
            this.Controls.Add(this.btn_rentReturn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_rent);
            this.Controls.Add(this.rentGridView);
            this.Controls.Add(this.itemGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentAndReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "물품 예약 및 반납";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentAndReturnForm_FormClosed);
            this.Load += new System.EventHandler(this.RentAndReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.DataGridView rentGridView;
        private System.Windows.Forms.Button btn_rent;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_rentReturn_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentNum;
    }
}