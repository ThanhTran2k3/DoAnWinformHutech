using DoAn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FormLichSu : Form
    {
        ContextModel model = new ContextModel();
        int mapdb;
        public FormLichSu()
        {
            InitializeComponent();
        }

        private void FormLichSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormThongTin.Thoat(sender, e);
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTin.formThongTin.Show();
        }

        private void FormLichSu_Load(object sender, EventArgs e)
        {
            List<PhieuDatBan> phieuDatBans = model.PhieuDatBan.Where(p => p.KhachHang.SDT == FormThongTin.formThongTin.textSDT.Text).ToList();
            foreach (PhieuDatBan pdb in  phieuDatBans)
            {
                int newRow = dgv_BangPDB.Rows.Add();
                dgv_BangPDB.Rows[newRow].Cells[0].Value = pdb.MaPDB.ToString();
                dgv_BangPDB.Rows[newRow].Cells[1].Value = pdb.Ngay.Value.Date.ToString("dd/MM/yyyy");
                dgv_BangPDB.Rows[newRow].Cells[2].Value = pdb.TGVao.ToString(); ;
                dgv_BangPDB.Rows[newRow].Cells[3].Value = pdb.TGRa.ToString();
                dgv_BangPDB.Rows[newRow].Cells[4].Value = pdb.GhiChu;
                dgv_BangPDB.Rows[newRow].Cells[5].Value = pdb.HoaDon.TongTien.ToString();

            }
        }

        private void dgv_BangPDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                List<Ban> bans = new List<Ban>();
                mapdb = int.Parse(dgv_BangPDB.Rows[e.RowIndex].Cells[0].Value.ToString());
                List<CTPhieuDatBan> cTPhieuDatBans = model.CTPhieuDatBan.Where(p => p.MaPDB == mapdb).ToList();
                foreach (CTPhieuDatBan list in cTPhieuDatBans)
                {
                    bans.Add(list.Ban);
                }
                cmb_Ban.DataSource = bans;
                cmb_Ban.DisplayMember = "TeBan";
                cmb_Ban.ValueMember = "MaBan";
                cmb_Ban.SelectedIndex = 0;
            }
            catch
            {
                if (dgv_BangPDB.Rows.Count == 0)
                    MessageBox.Show("Bạn chưa có thông tin đặt bàn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Vui lòng chọn 1 dòng!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Ban_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_ThongTinChTiet.Rows.Clear();
            CTPhieuDatBan vt = model.CTPhieuDatBan.FirstOrDefault(p => p.MaBan == cmb_Ban.Text && p.MaPDB == mapdb);
            if (vt != null)
            {
                List<CTPhieuGoiMon> cTPhieuGoiMon = model.CTPhieuGoiMon.Where(p => p.MaPGM == vt.MaPGM).ToList();
                foreach (CTPhieuGoiMon a in cTPhieuGoiMon)
                {
                    int newrow = dgv_ThongTinChTiet.Rows.Add();
                    dgv_ThongTinChTiet.Rows[newrow].Cells[0].Value = a.MonNuoc.TenMon;
                    dgv_ThongTinChTiet.Rows[newrow].Cells[1].Value = a.SoLuong;
                    dgv_ThongTinChTiet.Rows[newrow].Cells[2].Value = a.MonNuoc.Gia;
                    decimal tien = Convert.ToDecimal(a.SoLuong * a.MonNuoc.Gia);
                    dgv_ThongTinChTiet.Rows[newrow].Cells[3].Value = tien.ToString();
                }
            }
        }
    }
}
