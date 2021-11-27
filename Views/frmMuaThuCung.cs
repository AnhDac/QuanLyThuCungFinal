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
    public partial class frmMuaThuCung : Form
    {
        public int idpet;
        public int iduser;
        public int pricepet=0;
        public string loaithucung = "";
        public Button btnMua;

        private Form currentChildForm;

        ThuCungEntities db = new ThuCungEntities();

        public frmMuaThuCung()
        {
            InitializeComponent();
            btnMua = new Button();
        }
  
        private void frmMuaThuCung_Load(object sender, EventArgs e)
        {
            txtSell_IDPet.Text = idpet.ToString();
            txtSell_IDCus.Text = iduser.ToString();
            tbLoaiThuCung.Text = this.loaithucung;
            LoadComboboxBaoHanh();
            cbLoaiBaoHanh.SelectedIndex = 1;

            int numbermonth = Convert.ToInt32(cbLoaiBaoHanh.Text.ToString().Trim());
            txtSell_Price.Text = tinhGiaThuCung(numbermonth) +"";
            txtSell_Price.ReadOnly = true;
            txtSell_IDCus.ReadOnly = true;
            txtSell_IDPet.ReadOnly = true;
            txtSell_Price.ReadOnly = true;
            tbLoaiThuCung.ReadOnly = true;

        }

        int tinhGiaThuCung(int loaibaohanh)
        {
            int price = (int)(pricepet * 0.2 + 200*loaibaohanh);
            return price;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void LoadComboboxBaoHanh()
        {
            List <WarrantyType> warr = db.WarrantyTypes.ToList();
            cbLoaiBaoHanh.DataSource = warr;
            cbLoaiBaoHanh.ValueMember = "ID_Warr";
            cbLoaiBaoHanh.DisplayMember = "Months"; 
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Đồng Ý Thanh Toán ?", "Mua Thú Cưng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contract_Sell contract_sell = new Contract_Sell();

                    contract_sell.ID_Emp = 1;//Default
                    contract_sell.ID_Cus = Convert.ToInt32(txtSell_IDCus.Text.ToString().Trim());
                    contract_sell.ID_Pet = Convert.ToInt32(txtSell_IDPet.Text.ToString().Trim());

                    int month = Convert.ToInt32(cbLoaiBaoHanh.Text.ToString().Trim());
                    contract_sell.CateInsurance =Convert.ToInt32( cbLoaiBaoHanh.SelectedValue.ToString().Trim());

                    contract_sell.DateSell = DateTime.Now;
                    contract_sell.Price = Convert.ToInt32(txtSell_Price.Text.Trim());
                    db.Contract_Sell.Add(contract_sell);

                    db.SaveChanges();

                    MessageBox.Show("Mua Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnMua.Hide();

                    frmHoaDonMuaThuCung frm = new frmHoaDonMuaThuCung();
                    frm.idpet = this.idpet;
                    frm.iduser = this.iduser;
                    frm.loaithucung = this.loaithucung;
                    int numbermonth = Convert.ToInt32(cbLoaiBaoHanh.Text.ToString().Trim());
                    frm.sothangBaoHanh = numbermonth;
                    frm.price = tinhGiaThuCung(numbermonth);
                    frm.frm = this;
                    OpenChildForm(frm);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mua Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();

            }
         }

        private void cbLoaiBaoHanh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int numbermonth = Convert.ToInt32(cbLoaiBaoHanh.Text.ToString().Trim());
            txtSell_Price.Text = tinhGiaThuCung(numbermonth) +"";

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
            panelMainMuaThuCung.Controls.Add(childForm);
            pnlChiTietThuCung.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
