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
            this.rentGridView = new System.Windows.Forms.DataGridView();
            this.rentItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rentReturn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGridView
            // 
            this.itemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNo,
            this.itemName});
            this.itemGridView.Location = new System.Drawing.Point(12, 56);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowTemplate.Height = 23;
            this.itemGridView.Size = new System.Drawing.Size(287, 228);
            this.itemGridView.TabIndex = 0;
            this.itemGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemNo
            // 
            this.itemNo.HeaderText = "물품번호";
            this.itemNo.Name = "itemNo";
            // 
            // itemName
            // 
            this.itemName.HeaderText = "물품이름";
            this.itemName.Name = "itemName";
            // 
            // rentGridView
            // 
            this.rentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentItemNo,
            this.rentTime,
            this.rentId});
            this.rentGridView.Location = new System.Drawing.Point(306, 56);
            this.rentGridView.Name = "rentGridView";
            this.rentGridView.RowTemplate.Height = 23;
            this.rentGridView.Size = new System.Drawing.Size(294, 156);
            this.rentGridView.TabIndex = 1;
            // 
            // rentItemNo
            // 
            this.rentItemNo.HeaderText = "물품번호";
            this.rentItemNo.Name = "rentItemNo";
            // 
            // rentTime
            // 
            this.rentTime.HeaderText = "대여날짜";
            this.rentTime.Name = "rentTime";
            // 
            // rentId
            // 
            this.rentId.HeaderText = "대여자";
            this.rentId.Name = "rentId";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "대여";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "반납";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(398, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "대여자 목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(100, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "물품 목록";
            // 
            // btn_rentReturn_back
            // 
            this.btn_rentReturn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_rentReturn_back.Name = "btn_rentReturn_back";
            this.btn_rentReturn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_rentReturn_back.TabIndex = 6;
            this.btn_rentReturn_back.Text = "뒤로가기";
            this.btn_rentReturn_back.UseVisualStyleBackColor = true;
            this.btn_rentReturn_back.Click += new System.EventHandler(this.btn_rentReturn_back_Click);
            // 
            // RentAndReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 296);
            this.Controls.Add(this.btn_rentReturn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rentGridView);
            this.Controls.Add(this.itemGridView);
            this.Name = "RentAndReturnForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentId;
        private System.Windows.Forms.Button btn_rentReturn_back;
    }
}