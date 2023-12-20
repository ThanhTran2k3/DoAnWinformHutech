namespace DoAn
{
    partial class FormLichSu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_BangPDB = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ThongTinChTiet = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Ban = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BangPDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinChTiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(581, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các phiếu đặt bàn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.dgv_BangPDB);
            this.panel1.Controls.Add(this.dgv_ThongTinChTiet);
            this.panel1.Controls.Add(this.btn_TroVe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 701);
            this.panel1.TabIndex = 1;
            // 
            // dgv_BangPDB
            // 
            this.dgv_BangPDB.AllowUserToAddRows = false;
            this.dgv_BangPDB.AllowUserToDeleteRows = false;
            this.dgv_BangPDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_BangPDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BangPDB.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_BangPDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BangPDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ngay,
            this.TGVao,
            this.TGRa,
            this.GhiChu,
            this.TongTien});
            this.dgv_BangPDB.Location = new System.Drawing.Point(13, 36);
            this.dgv_BangPDB.Name = "dgv_BangPDB";
            this.dgv_BangPDB.ReadOnly = true;
            this.dgv_BangPDB.RowHeadersWidth = 51;
            this.dgv_BangPDB.RowTemplate.Height = 24;
            this.dgv_BangPDB.Size = new System.Drawing.Size(1258, 165);
            this.dgv_BangPDB.TabIndex = 8;
            this.dgv_BangPDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BangPDB_CellClick);
            // 
            // Ma
            // 
            this.Ma.HeaderText = "Mã PDB";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // TGVao
            // 
            this.TGVao.HeaderText = "Thời gian vào";
            this.TGVao.MinimumWidth = 6;
            this.TGVao.Name = "TGVao";
            this.TGVao.ReadOnly = true;
            // 
            // TGRa
            // 
            this.TGRa.HeaderText = "Thời gian ra";
            this.TGRa.MinimumWidth = 6;
            this.TGRa.Name = "TGRa";
            this.TGRa.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // dgv_ThongTinChTiet
            // 
            this.dgv_ThongTinChTiet.AllowUserToAddRows = false;
            this.dgv_ThongTinChTiet.AllowUserToDeleteRows = false;
            this.dgv_ThongTinChTiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_ThongTinChTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongTinChTiet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ThongTinChTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTinChTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgv_ThongTinChTiet.Location = new System.Drawing.Point(486, 264);
            this.dgv_ThongTinChTiet.Name = "dgv_ThongTinChTiet";
            this.dgv_ThongTinChTiet.ReadOnly = true;
            this.dgv_ThongTinChTiet.RowHeadersWidth = 51;
            this.dgv_ThongTinChTiet.RowTemplate.Height = 24;
            this.dgv_ThongTinChTiet.Size = new System.Drawing.Size(785, 334);
            this.dgv_ThongTinChTiet.TabIndex = 7;
            // 
            // TenMon
            // 
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
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
            // btn_TroVe
            // 
            this.btn_TroVe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TroVe.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn_TroVe.Location = new System.Drawing.Point(545, 621);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(133, 47);
            this.btn_TroVe.TabIndex = 5;
            this.btn_TroVe.Text = "Trở về";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(793, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin chi tiết trong bàn";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmb_Ban);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 375);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin trong phiếu đặt bàn";
            // 
            // cmb_Ban
            // 
            this.cmb_Ban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ban.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Ban.FormattingEnabled = true;
            this.cmb_Ban.Location = new System.Drawing.Point(127, 167);
            this.cmb_Ban.Name = "cmb_Ban";
            this.cmb_Ban.Size = new System.Drawing.Size(247, 27);
            this.cmb_Ban.TabIndex = 1;
            this.cmb_Ban.SelectedIndexChanged += new System.EventHandler(this.cmb_Ban_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bàn";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // FormLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 701);
            this.Controls.Add(this.panel1);
            this.Name = "FormLichSu";
            this.Text = "Lịch sử";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLichSu_FormClosing);
            this.Load += new System.EventHandler(this.FormLichSu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BangPDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinChTiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.ComboBox cmb_Ban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_ThongTinChTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridView dgv_BangPDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}