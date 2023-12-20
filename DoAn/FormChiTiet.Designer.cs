namespace DoAn
{
    partial class FormChiTiet
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textTongTien = new System.Windows.Forms.TextBox();
            this.btn_DatBan = new System.Windows.Forms.Button();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.dgv_Bang = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_ThongTinMon = new System.Windows.Forms.GroupBox();
            this.btn_Sửa = new System.Windows.Forms.Button();
            this.numericUpSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cmb_Mon = new System.Windows.Forms.ComboBox();
            this.cmb_TheLoai = new System.Windows.Forms.ComboBox();
            this.cmb_Ban = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bang)).BeginInit();
            this.gb_ThongTinMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textTongTien);
            this.panel1.Controls.Add(this.btn_DatBan);
            this.panel1.Controls.Add(this.btn_TroVe);
            this.panel1.Controls.Add(this.dgv_Bang);
            this.panel1.Controls.Add(this.gb_ThongTinMon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 676);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(1026, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng tiền";
            // 
            // textTongTien
            // 
            this.textTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textTongTien.Enabled = false;
            this.textTongTien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTongTien.Location = new System.Drawing.Point(1127, 535);
            this.textTongTien.Name = "textTongTien";
            this.textTongTien.Size = new System.Drawing.Size(200, 27);
            this.textTongTien.TabIndex = 9;
            // 
            // btn_DatBan
            // 
            this.btn_DatBan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_DatBan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatBan.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn_DatBan.Location = new System.Drawing.Point(640, 566);
            this.btn_DatBan.Name = "btn_DatBan";
            this.btn_DatBan.Size = new System.Drawing.Size(133, 47);
            this.btn_DatBan.TabIndex = 8;
            this.btn_DatBan.Text = "Đặt bàn";
            this.btn_DatBan.UseVisualStyleBackColor = true;
            this.btn_DatBan.Click += new System.EventHandler(this.btn_DatBan_Click);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_TroVe.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn_TroVe.Location = new System.Drawing.Point(459, 566);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(133, 47);
            this.btn_TroVe.TabIndex = 7;
            this.btn_TroVe.Text = "Trở về";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // dgv_Bang
            // 
            this.dgv_Bang.AllowUserToAddRows = false;
            this.dgv_Bang.AllowUserToDeleteRows = false;
            this.dgv_Bang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Bang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Bang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgv_Bang.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Bang.Location = new System.Drawing.Point(666, 13);
            this.dgv_Bang.Name = "dgv_Bang";
            this.dgv_Bang.ReadOnly = true;
            this.dgv_Bang.RowHeadersWidth = 51;
            this.dgv_Bang.RowTemplate.Height = 24;
            this.dgv_Bang.Size = new System.Drawing.Size(661, 507);
            this.dgv_Bang.TabIndex = 1;
            this.dgv_Bang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Bang_CellClick);
            // 
            // TenMon
            // 
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đon giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // gb_ThongTinMon
            // 
            this.gb_ThongTinMon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_ThongTinMon.BackColor = System.Drawing.Color.White;
            this.gb_ThongTinMon.Controls.Add(this.btn_Sửa);
            this.gb_ThongTinMon.Controls.Add(this.numericUpSoLuong);
            this.gb_ThongTinMon.Controls.Add(this.label4);
            this.gb_ThongTinMon.Controls.Add(this.btn_Xoa);
            this.gb_ThongTinMon.Controls.Add(this.btn_Them);
            this.gb_ThongTinMon.Controls.Add(this.cmb_Mon);
            this.gb_ThongTinMon.Controls.Add(this.cmb_TheLoai);
            this.gb_ThongTinMon.Controls.Add(this.cmb_Ban);
            this.gb_ThongTinMon.Controls.Add(this.label3);
            this.gb_ThongTinMon.Controls.Add(this.label2);
            this.gb_ThongTinMon.Controls.Add(this.label1);
            this.gb_ThongTinMon.Location = new System.Drawing.Point(13, 13);
            this.gb_ThongTinMon.Name = "gb_ThongTinMon";
            this.gb_ThongTinMon.Size = new System.Drawing.Size(646, 507);
            this.gb_ThongTinMon.TabIndex = 0;
            this.gb_ThongTinMon.TabStop = false;
            this.gb_ThongTinMon.Text = "Thông tin chọn món";
            // 
            // btn_Sửa
            // 
            this.btn_Sửa.Location = new System.Drawing.Point(168, 414);
            this.btn_Sửa.Name = "btn_Sửa";
            this.btn_Sửa.Size = new System.Drawing.Size(133, 47);
            this.btn_Sửa.TabIndex = 10;
            this.btn_Sửa.Text = "Sửa";
            this.btn_Sửa.UseVisualStyleBackColor = true;
            this.btn_Sửa.Click += new System.EventHandler(this.btn_Sửa_Click);
            // 
            // numericUpSoLuong
            // 
            this.numericUpSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpSoLuong.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpSoLuong.Location = new System.Drawing.Point(196, 284);
            this.numericUpSoLuong.Name = "numericUpSoLuong";
            this.numericUpSoLuong.Size = new System.Drawing.Size(315, 27);
            this.numericUpSoLuong.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(483, 414);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(133, 47);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(325, 414);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(133, 47);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cmb_Mon
            // 
            this.cmb_Mon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_Mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mon.FormattingEnabled = true;
            this.cmb_Mon.Location = new System.Drawing.Point(196, 230);
            this.cmb_Mon.Name = "cmb_Mon";
            this.cmb_Mon.Size = new System.Drawing.Size(315, 27);
            this.cmb_Mon.TabIndex = 5;
            // 
            // cmb_TheLoai
            // 
            this.cmb_TheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_TheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TheLoai.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TheLoai.FormattingEnabled = true;
            this.cmb_TheLoai.Location = new System.Drawing.Point(196, 168);
            this.cmb_TheLoai.Name = "cmb_TheLoai";
            this.cmb_TheLoai.Size = new System.Drawing.Size(315, 27);
            this.cmb_TheLoai.TabIndex = 4;
            this.cmb_TheLoai.SelectedIndexChanged += new System.EventHandler(this.cmb_TheLoai_SelectedIndexChanged);
            // 
            // cmb_Ban
            // 
            this.cmb_Ban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_Ban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ban.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Ban.FormattingEnabled = true;
            this.cmb_Ban.Location = new System.Drawing.Point(196, 108);
            this.cmb_Ban.Name = "cmb_Ban";
            this.cmb_Ban.Size = new System.Drawing.Size(315, 27);
            this.cmb_Ban.TabIndex = 3;
            this.cmb_Ban.SelectedIndexChanged += new System.EventHandler(this.cmb_Ban_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Món";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại món";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bàn";
            // 
            // FormChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1339, 676);
            this.Controls.Add(this.panel1);
            this.Name = "FormChiTiet";
            this.Text = "Chi tiết đặt bàn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChiTiet_FormClosing);
            this.Load += new System.EventHandler(this.FormChiTiet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bang)).EndInit();
            this.gb_ThongTinMon.ResumeLayout(false);
            this.gb_ThongTinMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Bang;
        private System.Windows.Forms.GroupBox gb_ThongTinMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cmb_Mon;
        private System.Windows.Forms.ComboBox cmb_TheLoai;
        private System.Windows.Forms.ComboBox cmb_Ban;
        private System.Windows.Forms.Button btn_DatBan;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_Sửa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}