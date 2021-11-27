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
    public partial class frmHoaDonMuaDichVu : Form
    {
        public int idcus;
        public int price;
        public string ngaymua;
        public string tendichvu;
        public Form frmparent;

        ThuCungEntities db = new ThuCungEntities();

        public frmHoaDonMuaDichVu()
        {
            InitializeComponent();
            frmparent =new Form();
        }

        private void frmHoaDonMuaDichVu_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        void LoadHoaDon()
        {

            tbIDCus.Text = this.idcus + "";
            tbTenKhachHang.Text = db.Customers.Find(this.idcus).Name.ToString() ;
            tbLoaiDichVu.Text = this.tendichvu;
            tbGia.Text = this.price + "";
            tbNgayMua.Text = this.ngaymua;
            tbNgayXuatHoaDon.Text = DateTime.Now.ToString();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.frmparent.Close();
        }
    }
}
