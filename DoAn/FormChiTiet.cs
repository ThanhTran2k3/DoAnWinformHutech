using DoAn.Image;
using DoAn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FormChiTiet : Form
    {
        ContextModel models = new ContextModel();
        public Dictionary<string, List<OrderItem>> OrderItemsByBan = new Dictionary<string, List<OrderItem>>();
        public class OrderItem
        {
            public string FoodName { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
        }

        public FormChiTiet()
        {
            InitializeComponent();
        }

        private void FormChiTiet_Load(object sender, EventArgs e)
        {
            cmb_Ban.DataSource = FormDatBan.list;
            cmb_Ban.SelectedIndex =0;

            
            List<TheLoai> theLoaiNuocs = models.TheLoai.ToList();
            LoadTheLoai(theLoaiNuocs);
            cmb_TheLoai.SelectedIndex = 0;

            TheLoai selectedTheLoai = (TheLoai)cmb_TheLoai.SelectedItem;
            List<MonNuoc> nuocs = models.MonNuoc.Where(p => p.MaTL == selectedTheLoai.MaTL).ToList();
            LoadMonNuoc(nuocs);
            cmb_Mon.SelectedIndex = 0;

        }

        private void LoadTheLoai(List<TheLoai> theLoaiNuocs)
        {
            cmb_TheLoai.DataSource = theLoaiNuocs;
            cmb_TheLoai.DisplayMember = "TenTL";
            cmb_TheLoai.ValueMember = "MaTL";
        }

        private void LoadMonNuoc(List<MonNuoc> nuocs)
        {
            cmb_Mon.DataSource = nuocs;
            cmb_Mon.DisplayMember = "TenMon";
            cmb_Mon.ValueMember = "MaMon";
        }
        private void FormChiTiet_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormThongTin.Thoat(sender,e);
        }

        private void cmb_Ban_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenban = cmb_Ban.Text;
            dgv_Bang.Rows.Clear();
            if (OrderItemsByBan.ContainsKey(tenban))
            {
                List<OrderItem> orderItems = OrderItemsByBan[tenban];
                foreach(OrderItem orderItem in orderItems)
                {
                    MonNuoc monNuoc = models.MonNuoc.FirstOrDefault(p => p.TenMon == orderItem.FoodName);
                    int newRow = dgv_Bang.Rows.Add();
                    dgv_Bang.Rows[newRow].Cells[0].Value = orderItem.FoodName.ToString();
                    dgv_Bang.Rows[newRow].Cells[1].Value = orderItem.Quantity.ToString();
                    dgv_Bang.Rows[newRow].Cells[2].Value = monNuoc.Gia.ToString();
                    dgv_Bang.Rows[newRow].Cells[3].Value = orderItem.Price.ToString();
                }
            }
        }

        private void cmb_TheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            TheLoai selectedTheLoai = (TheLoai)cmb_TheLoai.SelectedItem;
            List<MonNuoc> nuocs = models.MonNuoc.Where(p => p.MaTL == selectedTheLoai.MaTL).ToList();
            LoadMonNuoc(nuocs);
        }

        private int TimKiem(String a)
        {
            if (dgv_Bang.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < dgv_Bang.Rows.Count; i++)
                {
                    if (dgv_Bang.Rows[i].Cells[0].Value.Equals(a))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (numericUpSoLuong.Value > 0)
            {
                var k = (MonNuoc)cmb_Mon.SelectedItem;
                if (TimKiem(k.TenMon) == -1)
                {
                    int newRow = dgv_Bang.Rows.Add();
                    dgv_Bang.Rows[newRow].Cells[0].Value = k.TenMon.ToString();
                    dgv_Bang.Rows[newRow].Cells[1].Value = numericUpSoLuong.Value.ToString();
                    dgv_Bang.Rows[newRow].Cells[2].Value = k.Gia.ToString();
                    int sl = int.Parse(numericUpSoLuong.Value.ToString());
                    decimal tongtien = sl * Convert.ToDecimal(k.Gia);
                    dgv_Bang.Rows[newRow].Cells[3].Value = tongtien.ToString();
                }
                else
                {
                    int soluongHienCo = int.Parse(dgv_Bang.Rows[TimKiem(k.TenMon)].Cells[1].Value.ToString());
                    int tongsoluong = int.Parse(numericUpSoLuong.Text) + soluongHienCo;
                    dgv_Bang.Rows[TimKiem(k.TenMon)].Cells[1].Value = tongsoluong.ToString();

                    decimal thanhtienHienCo = Convert.ToDecimal(dgv_Bang.Rows[TimKiem(k.TenMon)].Cells[3].Value.ToString());
                    int sl = int.Parse(numericUpSoLuong.Value.ToString());
                    decimal tongThanhTien = (Convert.ToDecimal(k.Gia) * sl) + thanhtienHienCo;
                    dgv_Bang.Rows[TimKiem(k.TenMon)].Cells[3].Value = tongThanhTien.ToString();
                }
                CapNhatDuLieu();
            }
            else
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
            }

        }

        private void CapNhatDuLieu()
        {
            string tenBan = cmb_Ban.Text;
            if (!OrderItemsByBan.ContainsKey(tenBan))
            {
                OrderItemsByBan.Add(tenBan, new List<OrderItem>());
            }
            else
            {
                OrderItemsByBan[tenBan].Clear();
            }
            foreach (DataGridViewRow row in dgv_Bang.Rows)
            {
                string foodName = row.Cells[0].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells[1].Value);
                decimal price = Convert.ToDecimal(row.Cells[3].Value);
                OrderItem orderItem = new OrderItem { FoodName = foodName, Quantity = quantity, Price = price };
                OrderItemsByBan[tenBan].Add(orderItem);
            }

            decimal thanhTien = 0;
            foreach (String i in OrderItemsByBan.Keys.ToList())
            {
                foreach (OrderItem item in OrderItemsByBan[i])
                {
                    thanhTien += item.Price;
                }
            }
            textTongTien.Text = thanhTien.ToString();
        }
        private void btn_TroVe_Click(object sender, EventArgs e)
        { 
            this.Hide();
            FormDatBan.formDatBan.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var k = (MonNuoc)cmb_Mon.SelectedItem;
            if (TimKiem(k.TenMon) == -1)
            {
                MessageBox.Show("Không có món trong danh sách");
            }
            else
            {
                int dong = TimKiem(k.TenMon);
                dgv_Bang.Rows.RemoveAt(dong);
                MessageBox.Show("Xoá thành công!");
            }
            CapNhatDuLieu();
        }

        private void dgv_Bang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string tenMon = dgv_Bang.Rows[e.RowIndex].Cells[0].Value.ToString();
                MonNuoc k = models.MonNuoc.FirstOrDefault(p => p.TenMon == tenMon);
                cmb_Mon.SelectedValue = k.MaMon;
                cmb_TheLoai.SelectedValue = k.MaTL;
                numericUpSoLuong.Value = decimal.Parse(dgv_Bang.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch
            {
                if(dgv_Bang.Rows.Count ==0)
                    MessageBox.Show("Bàn chưa có thông tin chọn món!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Vui lòng chọn 1 dòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            var k = (MonNuoc)cmb_Mon.SelectedItem;
            if (TimKiem(k.TenMon) == -1)
            {
                MessageBox.Show("Không có món trong danh sách");
            }
            else
            {
                if (numericUpSoLuong.Value > 0)
                {
                    int dong = TimKiem(k.TenMon);
                    int sl = int.Parse(numericUpSoLuong.Value.ToString());
                    dgv_Bang.Rows[dong].Cells[1].Value = sl;
                    decimal tien = sl * Convert.ToDecimal(k.Gia);
                    dgv_Bang.Rows[dong].Cells[3].Value = tien;
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!");
                }
                CapNhatDuLieu();
            }
        }

        private void btn_DatBan_Click(object sender, EventArgs e)
        {
            using(var transaction = models.Database.BeginTransaction())
            {
                try
                {
                    if (textTongTien.Text != "")
                    {
                        int id;
                        KhachHang newKhach = models.KhachHang.FirstOrDefault(p => p.SDT == FormThongTin.formThongTin.textSDT.Text);
                        if (newKhach == null)
                        {
                            KhachHang khachHang = new KhachHang();
                            khachHang.TenKH = FormThongTin.formThongTin.textHoTen.Text;
                            khachHang.SDT = FormThongTin.formThongTin.textSDT.Text;
                            khachHang.GioiTinh = FormThongTin.formThongTin.rtb_Nam.Checked ? "Nam" : "Nữ";
                            DateTime ngaySinh = FormThongTin.formThongTin.dateTimeNgaySinh.Value;
                            khachHang.NgaySinh = ngaySinh;
                            models.KhachHang.Add(khachHang);
                            id = khachHang.MaKH;
                        }
                        else
                        {
                            id = newKhach.MaKH;
                            newKhach.TenKH = FormThongTin.formThongTin.textHoTen.Text;
                            newKhach.GioiTinh = FormThongTin.formThongTin.rtb_Nam.Checked ? "Nam" : "Nữ";
                            DateTime ngaySinh = FormThongTin.formThongTin.dateTimeNgaySinh.Value;
                            newKhach.NgaySinh = ngaySinh;
                        }
                        HoaDon hoaDon = new HoaDon();
                        hoaDon.NgayLap = DateTime.Now;
                        hoaDon.TongTien = Convert.ToDecimal(textTongTien.Text);
                        models.HoaDon.Add(hoaDon);

                        PhieuDatBan phieuDatBan = new PhieuDatBan();
                        phieuDatBan.Ngay = FormDatBan.formDatBan.dateTimeNgay.Value.Date;
                        TimeSpan giovao = FormDatBan.formDatBan.dateTimeGioVao.Value.TimeOfDay;
                        giovao = new TimeSpan(giovao.Hours, giovao.Minutes, 0);
                        TimeSpan giora = FormDatBan.formDatBan.dateTimeGioRa.Value.TimeOfDay;
                        giora = new TimeSpan(giora.Hours, giora.Minutes, 0);
                        phieuDatBan.TGVao = giovao;
                        phieuDatBan.TGRa = giora;
                        phieuDatBan.GhiChu = FormThongTin.formThongTin.textGhiChu.Text == null ? null : FormThongTin.formThongTin.textGhiChu.Text;
                        phieuDatBan.MaHD = hoaDon.MaHD;
                        phieuDatBan.MaKH = id;
                        models.PhieuDatBan.Add(phieuDatBan);

                        foreach (String i in OrderItemsByBan.Keys.ToList())
                        {
                            Ban ban = models.Ban.FirstOrDefault(p => p.TenBan == i);
                            CTPhieuDatBan cTPhieuDatBan = new CTPhieuDatBan();
                            cTPhieuDatBan.Ban = ban;
                            cTPhieuDatBan.PhieuDatBan = phieuDatBan;
                            PhieuGoiMon phieuGoiMon = new PhieuGoiMon();
                            decimal tien = 0;
                            foreach (OrderItem item in OrderItemsByBan[i])
                            {
                                MonNuoc monNuoc = models.MonNuoc.FirstOrDefault(p => p.TenMon == item.FoodName);
                                CTPhieuGoiMon cTPhieuGoiMon = new CTPhieuGoiMon();
                                cTPhieuGoiMon.MonNuoc = monNuoc;
                                cTPhieuGoiMon.PhieuGoiMon = phieuGoiMon;
                                cTPhieuGoiMon.SoLuong = item.Quantity;
                                tien += item.Price;
                                models.CTPhieuGoiMon.Add(cTPhieuGoiMon);

                            }
                            phieuGoiMon.ThanhTien = tien;
                            cTPhieuDatBan.PhieuGoiMon = phieuGoiMon;
                            models.CTPhieuDatBan.Add(cTPhieuDatBan);
                        }
                        models.SaveChanges();
                        transaction.Commit();

                        DialogResult result = MessageBox.Show("Thông tin đặt bàn đã được lưu trữ!", "Xác nhận", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            this.Hide();
                            FormThongTin newform = new FormThongTin();
                            newform.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền thông tin các bàn!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }
    }
}
