using QuanLyThuCung.Database;
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
    public partial class frmQLDichVuMuaBan : Form
    {
        ThuCungEntities db = new ThuCungEntities();
        Controller ctrl = new Controller();
        Form currentChildForm =new Form();
        private int iduser;
        public frmQLDichVuMuaBan()
        {
            this.iduser = 0;
            InitializeComponent();
        }
        public frmQLDichVuMuaBan(int id)
        {
            InitializeComponent();
            this.iduser = id;
        }

        private void frmQLDichVuMuaBan_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            LoadTabShowDichVuChamSoc();
            
        }

        private void tabQL_Click(object sender, EventArgs e)
        {
            if (tabQL.SelectedTab == tabHDDV)
            {
                LoadHopDongDV();
            }else if (tabQL.SelectedTab == tabContracSell)
            {
                LoadHopDongThuCung();
            } else if (tabQL.SelectedTab == tabDV)//Tab QL DV
            {
                LoadDVChamSoc();
            } else if (tabQL.SelectedTab == tabDichVuDaMua)//Tab QL DV
            {
                LoadDichVuDaMua();
            }
        }

        void PhanQuyen()
        {
            string permiss = "";
            permiss = ctrl.getPermissUser(iduser);

            switch (permiss)
            {
                case ""://guest
                    tabQL.TabPages.Remove(tabHDDV);
                    tabQL.TabPages.Remove(tabDV);
                    tabQL.TabPages.Remove(tabContracSell);

                    break;
                case "customer":
                    tabQL.TabPages.Remove(tabHDDV);
                    tabQL.TabPages.Remove(tabDV);
                    tabQL.TabPages.Remove(tabContracSell);
                    break;
                case "employee":
                    btnMuaDichVu.Hide();
                    tabQL.TabPages.Remove(tabDichVuDaMua);
                    break;
                case "admin":
                    tabQL.TabPages.Remove(tabDichVuDaMua);
                    btnMuaDichVu.Hide();
                    break;

            }

        }

        /*=====================================
         =============TAB DICH VU===============
        =====================================*/
        #region TAB DICH VỤ

        void LoadTabShowDichVuChamSoc()
        {
            var result = db.usp_GetDataDichVu().ToList();
            dgvShowDVChamSoc.DataSource = result.ToList();
        }
        private void btnMuaDichVu_Click(object sender, EventArgs e)
        {
            int idservic = Convert.ToInt32(dgvShowDVChamSoc.CurrentRow.Cells[0].Value.ToString().Trim());
            int price = Convert.ToInt32(dgvShowDVChamSoc.CurrentRow.Cells[2].Value.ToString().Trim());
            string loaidichvu = dgvShowDVChamSoc.CurrentRow.Cells[1].Value.ToString();
            frmMuaDichVu frm = new frmMuaDichVu();
            frm.idcus = this.iduser;
            frm.idser = idservic;
            frm.price = price;
            frm.loaidichvu = loaidichvu;
            OpenChildForm(frm);
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
            panelMainQLDichVu.Controls.Add(childForm);
           // panelMainQLDichVu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        /*=====================================
        =============TAB DICH VU DA MUA===============
       =====================================*/
        #region TAB DICH VU DA MUA
        void LoadDichVuDaMua()
        {
            var result = db.usp_GetDanhSachDichVuDaMua(this.iduser);
            dgvDichVuDaMua.DataSource = result.ToList();
        }

        #endregion
        /*=====================================
         =============TAB QUAN LY DICH VU===============
        =====================================*/
        #region TAB QUAN LY DICH VU

        private void btnReloadDV_Click(object sender, EventArgs e)
        {
            LoadDVChamSoc();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Servic servic = new Servic();

                    servic.Name = txtDV_name.Text.ToString().Trim();
                    servic.Price = int.Parse(txtDV_price.Text.ToString());



                    db.Servics.Add(servic);
                    db.SaveChanges();

                    MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDVChamSoc();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dvgDV.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim());
                    Servic servic = db.Servics.Find(id);
                    servic.Name = txtDV_name.Text.ToString().Trim();
                    servic.Price = Convert.ToInt32(txtDV_price.Text.ToString().Trim());
                    db.SaveChanges();

                    MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDVChamSoc();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không sửa được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadDVChamSoc();
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chăc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtDV_IDSer.Text.ToString().Trim());
                    Servic servic = db.Servics.Where(p => p.ID_Ser ==id ).SingleOrDefault();
                    db.Servics.Remove(servic);
                    db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDVChamSoc();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Xóa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadDVChamSoc();
            }
        }

        private void btnTimDV_Click(object sender, EventArgs e)
        {
            string valueFind = tbTimDV.Text.ToString();
            var result = db.usp_TimDVTheoTen(tbTimDV.Text.ToString().Trim()).ToList();
            dvgDV.DataSource = result;
        }


        private void dvgDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binDVChamSoc();
        }

        //=========Hàm======

        void LoadDVChamSoc()
        {
            var result = db.usp_GetDataDichVu().ToList();
            dvgDV.DataSource = result.ToList();
            binDVChamSoc();

        }
        void binDVChamSoc()
        {
            try
            {
                txtDV_IDSer.Text = dvgDV.CurrentRow.Cells[0].Value.ToString().Trim();
                txtDV_name.Text = dvgDV.CurrentRow.Cells[1].Value.ToString().Trim();
                txtDV_price.Text = dvgDV.CurrentRow.Cells[2].Value.ToString().Trim();
            }
            catch
            {

            }
           
        }


        #endregion


        /*=====================================
         ========TAB HĐ BÁN DỊCH VỤ===========
        =====================================*/
        #region TAB HĐ BÁN DỊCH VỤ

        private void btnThemHDDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contract_Ser contract = new Contract_Ser();

                    contract.ID_Emp = Convert.ToInt32(txtHD_IDEmp.Text.ToString().Trim());
                    contract.ID_Cus = Convert.ToInt32(txtHD_IDCus.Text.ToString().Trim());
                    contract.DateBuy = Convert.ToDateTime(dtpNgayMuaHDDV.Text);
                    contract.ID_Ser = Convert.ToInt32(txt_HDSer_MaDichVu.Text.ToString().Trim());
                    db.Contract_Ser.Add(contract);
                    db.SaveChanges();

                    MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongDV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            }
        }

        private void btnSuaHDDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvHDDV.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim());
                    Contract_Ser contract = db.Contract_Ser.Find(id);
                    contract.ID_Emp = Convert.ToInt32(txtHD_IDEmp.Text.ToString().Trim());
                    contract.ID_Cus = Convert.ToInt32(txtHD_IDCus.Text.ToString().Trim());
                    contract.DateBuy = Convert.ToDateTime(dtpNgayMuaHDDV.Text);

                    db.SaveChanges();

                    MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongDV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không sửa được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadHopDongDV();
            }
        }

        private void btnXoaHDDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtHD_IDConser.Text.ToString().Trim());
                    Contract_Ser Contrac = db.Contract_Ser.Where(p => p.ID_ConSer == id).SingleOrDefault();
                    db.Contract_Ser.Remove(Contrac);
                    db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongDV();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Xóa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadHopDongDV();
            }
        }

        private void btnReloadHDDV_Click(object sender, EventArgs e)
        {
            LoadHopDongDV();
        }

        private void btnTimHDDV_Click(object sender, EventArgs e)
        {
            int day = dtpTimKiemHDDV.Value.Day;
            int month = dtpTimKiemHDDV.Value.Month;
            int year = dtpTimKiemHDDV.Value.Year;
            var kq = db.timKiemHDDV( day, month,year);
            dgvHDDV.DataSource = kq.ToList();
        }

        private void dgvHDDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binHopDongDV();
        }



        //=========Hàm======
        void LoadHopDongDV()
        {
            var result = db.usp_GetDataHDBanDV().ToList();
            dgvHDDV.DataSource = result.ToList();
            binHopDongDV();

        }
        void binHopDongDV()
        {
            txtHD_IDConser.Text = dgvHDDV.CurrentRow.Cells[0].Value.ToString().Trim();
            txtHD_IDEmp.Text = dgvHDDV.CurrentRow.Cells[1].Value.ToString().Trim();
            txtHD_IDCus.Text = dgvHDDV.CurrentRow.Cells[2].Value.ToString().Trim();
            dtpNgayMuaHDDV.Text = dgvHDDV.CurrentRow.Cells[3].Value.ToString().Trim();
            txt_HDSer_MaDichVu.Text = dgvHDDV.CurrentRow.Cells[4].Value.ToString().Trim();
            txtTenDichVuHDSer.Text = dgvHDDV.CurrentRow.Cells[5].Value.ToString().Trim();
            txtHDSer_Price.Text = dgvHDDV.CurrentRow.Cells[6].Value.ToString().Trim();

        }









        #endregion


        /*=====================================
        =============TAB HĐ BÁN THÚ CƯNG========
       =====================================*/
        #region TAB HĐ BÁN THÚ CƯNG
        private void dgvContractSell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binHopDongThuCung();
        }

        private void btnTimContractSell_Click(object sender, EventArgs e)
        {
            int day = dtpTimKiemHDThuCung.Value.Day;
            int month = dtpTimKiemHDThuCung.Value.Month;
            int year = dtpTimKiemHDThuCung.Value.Year;
            var kq = db.timKiemHDBanThuCung(day, month, year);
            dgvContractSell.DataSource = kq.ToList();
        }

        private void btnReloadHDThuCung_Click(object sender, EventArgs e)
        {
            LoadHopDongThuCung();
        }

        private void btnSell_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Có Chắc Muốn Thêm?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contract_Sell contract_sell = new Contract_Sell();

                    //contract_sell.ID_ConSell = txtSell_IDCon.Text.ToString().Trim();
                    contract_sell.ID_Emp = Convert.ToInt32(txtSell_IDEmp.Text.ToString().Trim());
                    contract_sell.ID_Cus = Convert.ToInt32(txtSell_IDCus.Text.ToString().Trim());
                    contract_sell.ID_Pet = Convert.ToInt32(txtSell_IDPet.Text.ToString().Trim());
                    contract_sell.CateInsurance = Convert.ToInt32(txtSell_Caltel.Text.ToString().Trim());
                    contract_sell.DateSell = Convert.ToDateTime(dateSell_DateSell.Text);
                    contract_sell.Price = Convert.ToInt32(txtSell_Price.Text);
                    db.Contract_Sell.Add(contract_sell);

                    db.SaveChanges();

                    MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongThuCung();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            
            }
        }

        private void btnSell_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvContractSell.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim());
                    Contract_Sell contract_Sell1 = db.Contract_Sell.Find(id);

                    contract_Sell1.ID_Emp = Convert.ToInt32(txtSell_IDEmp.Text.ToString().Trim());
                    contract_Sell1.ID_Cus = Convert.ToInt32(txtSell_IDCus.Text.ToString().Trim());
                    contract_Sell1.ID_Pet = Convert.ToInt32(txtSell_IDPet.Text.ToString().Trim());
                    contract_Sell1.CateInsurance = Convert.ToInt32(txtSell_Caltel.Text.ToString().Trim());
                    contract_Sell1.DateSell = Convert.ToDateTime(dateSell_DateSell.Text);
                    contract_Sell1.Price = Convert.ToInt32(txtSell_Price.Text);
                    db.SaveChanges();

                    MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongThuCung();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không sửa được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadHopDongThuCung();
            }
        }

        private void btnSell_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtSell_IDCon.Text.ToString().Trim());
                    Contract_Sell contract = db.Contract_Sell.Where(p => p.ID_ConSell == id).SingleOrDefault();
                    db.Contract_Sell.Remove(contract);
                    db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongThuCung();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Xóa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            }
        }


        //=========Hàm======
        void binHopDongThuCung()
        {
            txtSell_IDCon.Text = dgvContractSell.CurrentRow.Cells[0].Value.ToString().Trim();
            txtSell_IDEmp.Text = dgvContractSell.CurrentRow.Cells[1].Value.ToString().Trim();
            txtSell_IDCus.Text = dgvContractSell.CurrentRow.Cells[2].Value.ToString().Trim();
            txtSell_IDPet.Text = dgvContractSell.CurrentRow.Cells[3].Value.ToString().Trim();
            txtSell_Caltel.Text = dgvContractSell.CurrentRow.Cells[4].Value.ToString().Trim();
            dateSell_DateSell.Text = dgvContractSell.CurrentRow.Cells[5].Value.ToString().Trim();
            txtSell_Price.Text = dgvContractSell.CurrentRow.Cells[6].Value.ToString().Trim();
        }
        void LoadHopDongThuCung()
        {
            var result = db.usp_GetDataHDBanThuCung().ToList();
            dgvContractSell.DataSource = result.ToList();
            binHopDongThuCung();

        }






        #endregion

     
    }
}
