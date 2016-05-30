namespace TeamProject_RentalSystem
{
    partial class MemberLeave
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
            this.lbl_guide = new System.Windows.Forms.Label();
            this.txtBox_pw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(69, 96);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(183, 21);
            this.txtBox_id.TabIndex = 0;
            this.txtBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_id_KeyPress);
            // 
            // lbl_guide
            // 
            this.lbl_guide.AutoSize = true;
            this.lbl_guide.Location = new System.Drawing.Point(25, 61);
            this.lbl_guide.Name = "lbl_guide";
            this.lbl_guide.Size = new System.Drawing.Size(282, 12);
            this.lbl_guide.TabIndex = 4;
            this.lbl_guide.Text = "탈퇴하실 ID(학번)을 입력하시고 엔터를 눌러주세요";
            // 
            // txtBox_pw
            // 
            this.txtBox_pw.Location = new System.Drawing.Point(69, 123);
            this.txtBox_pw.Name = "txtBox_pw";
            this.txtBox_pw.Size = new System.Drawing.Size(183, 21);
            this.txtBox_pw.TabIndex = 5;
            this.txtBox_pw.TextChanged += new System.EventHandler(this.txtBox_pw_TextChanged);
            this.txtBox_pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_pw_KeyPress);
            // 
            // MemberLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 247);
            this.Controls.Add(this.txtBox_pw);
            this.Controls.Add(this.lbl_guide);
            this.Controls.Add(this.txtBox_id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberLeave";
            this.Text = "물품대여 관리시스템 - 회원탈퇴";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberLeave_FormClosed);
            this.Load += new System.EventHandler(this.MemberLeave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_id;
        private System.Windows.Forms.Label lbl_guide;
        private System.Windows.Forms.TextBox txtBox_pw;
    }
}