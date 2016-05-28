namespace TeamProject_RentalSystem
{
    partial class userForm
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_rent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_userForm_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(36, 171);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(120, 50);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "물품검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_rent
            // 
            this.btn_rent.Location = new System.Drawing.Point(227, 171);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(120, 50);
            this.btn_rent.TabIndex = 1;
            this.btn_rent.Text = "물품예약";
            this.btn_rent.UseVisualStyleBackColor = true;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(421, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "물품반납";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(135, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "수행할 항목을 클릭하세요";
            // 
            // btn_userForm_back
            // 
            this.btn_userForm_back.Location = new System.Drawing.Point(12, 12);
            this.btn_userForm_back.Name = "btn_userForm_back";
            this.btn_userForm_back.Size = new System.Drawing.Size(75, 23);
            this.btn_userForm_back.TabIndex = 4;
            this.btn_userForm_back.Text = "뒤로가기";
            this.btn_userForm_back.UseVisualStyleBackColor = true;
            this.btn_userForm_back.Click += new System.EventHandler(this.btn_userForm_back_Click);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 296);
            this.Controls.Add(this.btn_userForm_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_rent);
            this.Controls.Add(this.btn_search);
            this.Name = "userForm";
            this.Text = "물품대여 시스템";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_rent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_userForm_back;
    }
}