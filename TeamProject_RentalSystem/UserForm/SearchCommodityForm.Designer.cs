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
            this.txtbox_commodity = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_search_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_commodity
            // 
            this.txtbox_commodity.Location = new System.Drawing.Point(123, 123);
            this.txtbox_commodity.Name = "txtbox_commodity";
            this.txtbox_commodity.Size = new System.Drawing.Size(280, 21);
            this.txtbox_commodity.TabIndex = 0;
            this.txtbox_commodity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(420, 123);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 21);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_search_back
            // 
            this.btn_search_back.Location = new System.Drawing.Point(12, 12);
            this.btn_search_back.Name = "btn_search_back";
            this.btn_search_back.Size = new System.Drawing.Size(75, 23);
            this.btn_search_back.TabIndex = 5;
            this.btn_search_back.Text = "뒤로가기";
            this.btn_search_back.UseVisualStyleBackColor = true;
            this.btn_search_back.Click += new System.EventHandler(this.btn_search_back_Click);
            // 
            // SearchCommodityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 296);
            this.Controls.Add(this.btn_search_back);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtbox_commodity);
            this.Name = "SearchCommodityForm";
            this.Text = "물품대여시스템 - 물품검색";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchCommodityForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_commodity;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_search_back;
    }
}