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
    public partial class frmHoaDonMuaThuCung : Form
    {

        public int idpet;
        public int iduser;
        public string loaithucung = "";
        public int price = 0;
        public int sothangBaoHanh = 0;
        public DateTime ngaymua;
        public Form frm;

        ThuCungEntities db = new ThuCungEntities();

        public frmHoaDonMuaThuCung()
        {
            InitializeComponent();
            frm = new Form();
            ngaymua = DateTime.Now;//default
        }

        private void frmHoaDonMuaThuCung_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            tbLoaiThuCung.Text = this.loaithucung;
            txtIDCus.Text = this.iduser+"";
            txtIDPet.Text = this.idpet + "";
            txtPrice.Text = this.price + "";
            tbSoThanhBaoHanh.Text = this.sothangBaoHanh + "";
            tbNgayMua.Text = this.ngaymua.ToString();
            tbNgayXuatHoaDon.Text  = DateTime.Now.ToString();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frm.Close();
        }
    }
}
