namespace TeamProject_RentalSystem
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.titleLabel = new System.Windows.Forms.Label();
            this.btn_userMode = new System.Windows.Forms.Button();
            this.btn_adminMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(129, 42);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(352, 55);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "물품대여 시스템";
            // 
            // btn_userMode
            // 
            this.btn_userMode.Location = new System.Drawing.Point(21, 156);
            this.btn_userMode.Name = "btn_userMode";
            this.btn_userMode.Size = new System.Drawing.Size(260, 74);
            this.btn_userMode.TabIndex = 1;
            this.btn_userMode.Text = "유저 모드";
            this.btn_userMode.UseVisualStyleBackColor = true;
            this.btn_userMode.Click += new System.EventHandler(this.btn_userMode_Click);
            // 
            // btn_adminMode
            // 
            this.btn_adminMode.Location = new System.Drawing.Point(320, 156);
            this.btn_adminMode.Name = "btn_adminMode";
            this.btn_adminMode.Size = new System.Drawing.Size(248, 74);
            this.btn_adminMode.TabIndex = 2;
            this.btn_adminMode.Text = "관리자 모드";
            this.btn_adminMode.UseVisualStyleBackColor = true;
            this.btn_adminMode.Click += new System.EventHandler(this.btn_adminMode_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 296);
            this.Controls.Add(this.btn_adminMode);
            this.Controls.Add(this.btn_userMode);
            this.Controls.Add(this.titleLabel);
            this.Name = "mainForm";
            this.Text = "물품대여 시스템";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button btn_userMode;
        private System.Windows.Forms.Button btn_adminMode;
    }
}

