namespace TeamProject_RentalSystem
{
    partial class LoginForm
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
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.txtBox_pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_membership = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(146, 170);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(291, 21);
            this.txtBox_id.TabIndex = 0;
            this.txtBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_id_KeyPress);
            // 
            // txtBox_pw
            // 
            this.txtBox_pw.Location = new System.Drawing.Point(146, 197);
            this.txtBox_pw.Name = "txtBox_pw";
            this.txtBox_pw.Size = new System.Drawing.Size(291, 21);
            this.txtBox_pw.TabIndex = 1;
            this.txtBox_pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_pw_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(106, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(97, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW :";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(454, 170);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(58, 48);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(74, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "물품대여 관리시스템에 오신것을 환영합니다";
            // 
            // btn_membership
            // 
            this.btn_membership.Location = new System.Drawing.Point(12, 12);
            this.btn_membership.Name = "btn_membership";
            this.btn_membership.Size = new System.Drawing.Size(103, 23);
            this.btn_membership.TabIndex = 6;
            this.btn_membership.Text = "회원가입";
            this.btn_membership.UseVisualStyleBackColor = true;
            this.btn_membership.Click += new System.EventHandler(this.btn_membership_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "회원탈퇴";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_membership);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_pw);
            this.Controls.Add(this.txtBox_id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "물품대여 관리시스템 - 로그인";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_id;
        private System.Windows.Forms.TextBox txtBox_pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_membership;
        private System.Windows.Forms.Button button1;
    }
}