namespace project_BDS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dtgExcel = new System.Windows.Forms.DataGridView();
            this.txtDinhDangTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboDinhDangsdt = new System.Windows.Forms.ComboBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.cboKieusdt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(531, 189);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(136, 32);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import file excel";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1175, 728);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(136, 32);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export file txt";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dtgExcel
            // 
            this.dtgExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExcel.Location = new System.Drawing.Point(673, 12);
            this.dtgExcel.Name = "dtgExcel";
            this.dtgExcel.RowHeadersWidth = 51;
            this.dtgExcel.RowTemplate.Height = 24;
            this.dtgExcel.Size = new System.Drawing.Size(629, 348);
            this.dtgExcel.TabIndex = 2;
            // 
            // txtDinhDangTP
            // 
            this.txtDinhDangTP.Location = new System.Drawing.Point(843, 622);
            this.txtDinhDangTP.Multiline = true;
            this.txtDinhDangTP.Name = "txtDinhDangTP";
            this.txtDinhDangTP.Size = new System.Drawing.Size(151, 29);
            this.txtDinhDangTP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(840, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập định dạng ở Tp HCM để lọc dữ liệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(840, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "(VD: Hồ Chí Minh, Ho Chi Minh, HCM,...)";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(112, 119);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(41, 22);
            this.txtHoten.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(331, 119);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(41, 22);
            this.txtSDT.TabIndex = 7;
            // 
            // txtTP
            // 
            this.txtTP.Location = new System.Drawing.Point(491, 119);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(41, 22);
            this.txtTP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1004, 704);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Chọn kiểu sdt để xuất:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhập các ô dữ liệu tương ứng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 578);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Chọn định dạng sdt để tách chuỗi:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(792, 508);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 185);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cboDinhDangsdt
            // 
            this.cboDinhDangsdt.FormattingEnabled = true;
            this.cboDinhDangsdt.Location = new System.Drawing.Point(541, 610);
            this.cboDinhDangsdt.Name = "cboDinhDangsdt";
            this.cboDinhDangsdt.Size = new System.Drawing.Size(168, 24);
            this.cboDinhDangsdt.TabIndex = 13;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(670, 380);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(103, 17);
            this.lblTong.TabIndex = 14;
            this.lblTong.Text = "Tổng cộng có: ";
            // 
            // cboKieusdt
            // 
            this.cboKieusdt.FormattingEnabled = true;
            this.cboKieusdt.Location = new System.Drawing.Point(1007, 728);
            this.cboKieusdt.Name = "cboKieusdt";
            this.cboKieusdt.Size = new System.Drawing.Size(121, 24);
            this.cboKieusdt.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 783);
            this.Controls.Add(this.cboKieusdt);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.cboDinhDangsdt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTP);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDinhDangTP);
            this.Controls.Add(this.dtgExcel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BDS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dtgExcel;
        private System.Windows.Forms.TextBox txtDinhDangTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboDinhDangsdt;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.ComboBox cboKieusdt;
    }
}

