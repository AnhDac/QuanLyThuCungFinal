using QuanLyThuCung.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuCung.Views
{
    public partial class frmMuaDichVu : Form
    {
        public int idnhanvien;
        public int idcus;
        public int idser;
        public int price;
        public string loaidichvu;
        public DateTime ngaymua;
        Form currentChildForm;
        ThuCungEntities db = new ThuCungEntities();

        public frmMuaDichVu()
        {
            InitializeComponent();
            this.idnhanvien = 1;//default
            currentChildForm = new Form();
            this.ngaymua = DateTime.Now;
        }

        private void frmMuaDichVu_Load(object sender, EventArgs e)
        {
            LoadMuaDichVu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadMuaDichVu()
        {
            tbIDCus.Text = this.idcus+"";
            tbLoaiDichVu.Text = this.loaidichvu;
            tbGia.Text = this.price+"";
            tbNgayMua.Text =this.ngaymua.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Đồng Ý Thanh Toán ?", "Mua Thú Cưng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contract_Ser contract_ser = new Contract_Ser();

                    contract_ser.ID_Emp = this.idnhanvien;
                    contract_ser.ID_Cus = this.idcus;
                    contract_ser.ID_Ser = this.idser;


                    contract_ser.DateBuy = DateTime.Now;
                    db.Contract_Ser.Add(contract_ser);

                    db.SaveChanges();

                    MessageBox.Show("Mua Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmHoaDonMuaDichVu frm = new frmHoaDonMuaDichVu();
                    frm.idcus = this.idcus;
                    frm.price = this.price;
                    frm.ngaymua = this.ngaymua.ToString();
                    frm.tendichvu = this.loaidichvu;
                    frm.frmparent = this;
                    OpenChildForm(frm);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mua Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();

            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainMuaDichVu.Controls.Add(childForm);
            // panelMainQLDichVu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }


}
