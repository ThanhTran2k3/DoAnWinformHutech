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

namespace DoAn.Image
{
    public partial class FormDatBan : Form
    {
        public static FormDatBan formDatBan;
        ContextModel model = new ContextModel();

        internal static List<String> list = new List<String>();
        public FormDatBan()
        {
            InitializeComponent();
            formDatBan = this;
            dateTimeGioVao.ShowUpDown = true;
            dateTimeGioVao.Format = DateTimePickerFormat.Custom;
            dateTimeGioVao.CustomFormat = "HH:mm";
            dateTimeGioRa.ShowUpDown = true;
            dateTimeGioRa.Format = DateTimePickerFormat.Custom;
            dateTimeGioRa.CustomFormat = "HH:mm";
        }



        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTin.formThongTin.Show();
        }

        private void FormDatBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormThongTin.Thoat(sender, e);
        }


        private void btn_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            if (button.BackColor == Color.LightBlue)
            {
                button.BackColor = Color.White;
            }
            else
            {
                button.BackColor = Color.LightBlue;
            }

        }

        private bool KTDL()
        {
            list.Clear();
            DateTime selectedDate = dateTimeNgay.Value.Date;
            DateTime currentDate = DateTime.Now;
            TimeSpan tgvao = dateTimeGioVao.Value.TimeOfDay;
            TimeSpan tgra = dateTimeGioRa.Value.TimeOfDay;
            if (selectedDate.Date < currentDate.Date)
            {
                MessageBox.Show("Ngày chọn không hợp lệ!");
                return false;
            }
            else if(selectedDate.Date == currentDate.Date)
            {
                TimeSpan hientai = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
                if (tgvao < hientai)
                {
                    MessageBox.Show("Thời gian chọn không hợp lệ!");
                    return false;
                }
               
            }
            if (tgvao > tgra)
            {
                MessageBox.Show("Thời gian chọn không hợp lệ!");
                return false;
            }


            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    if (control.BackColor == Color.LightBlue)
                    {
                        String i = list.FirstOrDefault(p => p == control.Text);
                        if (i == null)
                        {
                            list.Add(control.Text);
                        }
                    }

                }
            }
            if (list.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn bàn!");
                return false;
            }
            return true;
        }

        private void LoadBan(DateTime selectedDate, DateTime selectedTime)
        {
            DateTime combinedDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, selectedTime.Hour, selectedTime.Minute, 00);
            List<PhieuDatBan> phieuDatBan = model.PhieuDatBan.ToList();
            if (phieuDatBan != null)
            {
                foreach (PhieuDatBan phieuDat in phieuDatBan)
                {
                    TimeSpan tgvao = dateTimeGioVao.Value.TimeOfDay;
                    TimeSpan tgra = dateTimeGioRa.Value.TimeOfDay;
                    if (combinedDateTime.Date == phieuDat.Ngay.Value.Date)
                    {
                        if ((tgvao >= phieuDat.TGVao && tgvao <= phieuDat.TGRa) ||
                            (tgra >= phieuDat.TGRa && tgra <= phieuDat.TGVao) ||
                            (tgvao <= phieuDat.TGVao && phieuDat.TGVao <= tgra))
                        {
                            foreach (CTPhieuDatBan ban in phieuDat.CTPhieuDatBan)
                            {
                                foreach (Control control in panel1.Controls)
                                {
                                    if (control is Button)
                                    {
                                        if (control.Text.Trim() == ban.Ban.TenBan.Trim())
                                        {
                                            control.Enabled = false;
                                            control.BackColor = Color.Red;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        ResetButton();
                    }
                }
            }
        }

        private void ResetButton()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    if (control.Text != "")
                    {
                        control.Enabled = true;
                        control.BackColor = Color.White;
                    }
                }
            }
        }
        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            ResetButton();
            LoadBan(dateTimeNgay.Value.Date, dateTimeGioVao.Value);
        }
        private void btn_TiepTuc_Click(object sender, EventArgs e)
        {
            if (KTDL())
            {
                this.Hide();
                FormChiTiet formChiTiet = new FormChiTiet();
                formChiTiet.Show();
            }
        }

        private void FormDatBan_Load(object sender, EventArgs e)
        {
            LoadBan(DateTime.Now.Date,DateTime.Now);
        }

       
    }
}
