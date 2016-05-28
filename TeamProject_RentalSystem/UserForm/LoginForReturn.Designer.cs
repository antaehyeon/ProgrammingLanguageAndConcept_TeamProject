namespace TeamProject_RentalSystem
{
    partial class LoginForReturn
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
            this.txtBox_pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_errorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_pw
            // 
            this.txtBox_pw.Location = new System.Drawing.Point(234, 127);
            this.txtBox_pw.Name = "txtBox_pw";
            this.txtBox_pw.Size = new System.Drawing.Size(190, 28);
            this.txtBox_pw.TabIndex = 0;
            this.txtBox_pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_pw_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(65, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "물품을 반납하기 위해서는 비밀번호를 입력하시고";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(230, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "엔터를 눌러주세요";
            // 
            // lbl_errorMsg
            // 
            this.lbl_errorMsg.AutoSize = true;
            this.lbl_errorMsg.Location = new System.Drawing.Point(210, 179);
            this.lbl_errorMsg.Name = "lbl_errorMsg";
            this.lbl_errorMsg.Size = new System.Drawing.Size(0, 18);
            this.lbl_errorMsg.TabIndex = 5;
            // 
            // LoginForReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 240);
            this.Controls.Add(this.lbl_errorMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_pw);
            this.Name = "LoginForReturn";
            this.Text = "물품관리 시스템 - 로그인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForReturn_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_errorMsg;
    }
}