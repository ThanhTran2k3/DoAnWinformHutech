using DoAn.Image;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn
{
    public partial class FormThongTin : Form
    {
        public static FormThongTin formThongTin;

        public FormThongTin()
        {
            InitializeComponent();
            formThongTin = this;
            rtb_Nam.Checked = true;
        }

        private void btn_ChonBan_Click(object sender, EventArgs e)
        {
            if (KTDL())
            {
                this.Hide();
                FormDatBan datBan = new FormDatBan();
                datBan.Show();
            }
        }

        private bool KTDL()
        {
            if (textHoTen.Text == "" || textSDT.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;

            }
            else
            {
                string hoTen = textHoTen.Text;
                bool coChuaSo = hoTen.Any(char.IsDigit);
                if (coChuaSo)
                {
                    MessageBox.Show("Họ tên không được chứa số!");
                    return false;
                }
                if (hoTen.Length < 3 || hoTen.Length > 100)
                {
                    MessageBox.Show("Họ tên phải từ 3 đến 100 ký tự");
                    return false;
                }

             
                string soDienThoai = textSDT.Text;

                Regex regex = new Regex(@"^0\d{9}$");

                if (!regex.IsMatch(soDienThoai))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Số điện thoại phải bắt đầu bằng số 0 và có 10 chữ số.");
                    return false;
                }

                if(dateTimeNgaySinh.Value.Date > DateTime.Today.AddYears(-10))
                {
                    MessageBox.Show("Ngày sinh phải hợp lệ và phải lớn hơn 10 tuổi!");
                    return false;
                }
            }
            
            return true;
        }

        internal static void Thoat(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void FormThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thoat(sender, e);
        }

        private void btn_LichSu_Click(object sender, EventArgs e)
        {
            if (textSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SDT!");
            }
            else
            {
                Regex regex = new Regex(@"^0\d{9}$");
                if (!regex.IsMatch(textSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Số điện thoại phải bắt đầu bằng số 0 và có 10 chữ số.");
                }
                else
                {
                    this.Hide();
                    FormLichSu formLichSu = new FormLichSu();
                    formLichSu.Show();
                }
            }
        }

       
    }
}
