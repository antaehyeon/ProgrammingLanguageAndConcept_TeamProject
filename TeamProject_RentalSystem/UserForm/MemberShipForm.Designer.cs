namespace TeamProject_RentalSystem
{
    partial class MemberShipForm
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
            this.txtBox_repw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_first = new System.Windows.Forms.TextBox();
            this.txtBox_mid = new System.Windows.Forms.TextBox();
            this.txtBox_last = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_guide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(97, 51);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(193, 21);
            this.txtBox_id.TabIndex = 0;
            this.txtBox_id.TextChanged += new System.EventHandler(this.txtBox_id_TextChanged);
            this.txtBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_id_KeyPress);
            this.txtBox_id.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBox_id_MouseDown);
            // 
            // txtBox_pw
            // 
            this.txtBox_pw.Location = new System.Drawing.Point(97, 84);
            this.txtBox_pw.Name = "txtBox_pw";
            this.txtBox_pw.Size = new System.Drawing.Size(193, 21);
            this.txtBox_pw.TabIndex = 1;
            this.txtBox_pw.TextChanged += new System.EventHandler(this.txtBox_pw_TextChanged);
            this.txtBox_pw.Enter += new System.EventHandler(this.txtBox_pw_Enter);
            // 
            // txtBox_repw
            // 
            this.txtBox_repw.Location = new System.Drawing.Point(97, 117);
            this.txtBox_repw.Name = "txtBox_repw";
            this.txtBox_repw.Size = new System.Drawing.Size(193, 21);
            this.txtBox_repw.TabIndex = 2;
            this.txtBox_repw.TextChanged += new System.EventHandler(this.txtBox_repw_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID (학번) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "패스워드 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "재 입력 :";
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_register.Location = new System.Drawing.Point(97, 186);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(193, 33);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "가입하기";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "핸드폰번호 :";
            // 
            // txtBox_first
            // 
            this.txtBox_first.Location = new System.Drawing.Point(98, 147);
            this.txtBox_first.Name = "txtBox_first";
            this.txtBox_first.Size = new System.Drawing.Size(51, 21);
            this.txtBox_first.TabIndex = 9;
            this.txtBox_first.TextChanged += new System.EventHandler(this.txtBox_first_TextChanged);
            this.txtBox_first.Enter += new System.EventHandler(this.txtBox_first_Enter);
            // 
            // txtBox_mid
            // 
            this.txtBox_mid.Location = new System.Drawing.Point(170, 147);
            this.txtBox_mid.Name = "txtBox_mid";
            this.txtBox_mid.Size = new System.Drawing.Size(51, 21);
            this.txtBox_mid.TabIndex = 10;
            this.txtBox_mid.TextChanged += new System.EventHandler(this.txtBox_mid_TextChanged);
            // 
            // txtBox_last
            // 
            this.txtBox_last.Location = new System.Drawing.Point(239, 147);
            this.txtBox_last.Name = "txtBox_last";
            this.txtBox_last.Size = new System.Drawing.Size(51, 21);
            this.txtBox_last.TabIndex = 11;
            this.txtBox_last.TextChanged += new System.EventHandler(this.txtBox_last_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            // 
            // lbl_guide
            // 
            this.lbl_guide.AutoSize = true;
            this.lbl_guide.Location = new System.Drawing.Point(12, 18);
            this.lbl_guide.Name = "lbl_guide";
            this.lbl_guide.Size = new System.Drawing.Size(261, 12);
            this.lbl_guide.TabIndex = 14;
            this.lbl_guide.Text = "             회원가입에 필요한 정보를 입력하세요";
            // 
            // MemberShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 247);
            this.Controls.Add(this.lbl_guide);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_last);
            this.Controls.Add(this.txtBox_mid);
            this.Controls.Add(this.txtBox_first);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_repw);
            this.Controls.Add(this.txtBox_pw);
            this.Controls.Add(this.txtBox_id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberShipForm";
            this.Text = "물품대여 관리시스템 - 회원가입";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberShipForm_FormClosed);
            this.Load += new System.EventHandler(this.MemberShipForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_id;
        private System.Windows.Forms.TextBox txtBox_pw;
        private System.Windows.Forms.TextBox txtBox_repw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_first;
        private System.Windows.Forms.TextBox txtBox_mid;
        private System.Windows.Forms.TextBox txtBox_last;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_guide;
    }
}