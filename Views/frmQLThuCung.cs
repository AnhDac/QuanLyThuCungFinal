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
    public partial class frmQLThuCung : Form
    {
        ThuCungEntities db = new ThuCungEntities();
        private int iduser;
        Controller ctrl = new Controller();

        public frmQLThuCung()
        {
            InitializeComponent();
        }

        public frmQLThuCung(int iduser)
        {
            InitializeComponent();
            this.iduser = iduser;

        }

        private void frmQLThuCung_Load(object sender, EventArgs e)
        {  
            PhanQuyen();
        }

        private void tabQL_Click(object sender, EventArgs e)
        {
            if (tabQL.SelectedTab == tabDanhDachThuCungDaMua)
            {
                LoadTabThuCungDaMua();
            }
            else if (tabQL.SelectedTab == tabQLLoaiThuCung)
            {
                LoadLoaiThuCung();
            } else if (tabQL.SelectedTab == tabNhaCungCap)
            {
                LoadTabNhaCungCap();
            } else if (tabQL.SelectedTab == tabBaoHanh)
            {
                LoadTabBaoHanh();
            }
        }

        void PhanQuyen()
        {
            string permiss = "";
            permiss = ctrl.getPermissUser(iduser);

            switch (permiss)
            {
                case "customer":
                    tabQL.TabPages.Remove(tabQuanLyTC);
                    tabQL.TabPages.Remove(tabQLLoaiThuCung);
                    tabQL.TabPages.Remove(tabNhaCungCap);
                    tabQL.TabPages.Remove(tabBaoHanh);
                    LoadTabThuCungDaMua();
                    break;
                case "employee":
                    tabQL.TabPages.Remove(tabDanhDachThuCungDaMua);
                    LoadThuCung();
                    break;
                case "admin":
                    tabQL.TabPages.Remove(tabDanhDachThuCungDaMua);
                    LoadThuCung();
                    break;
            }
        }


        #region TAB THU CUNG
        //======================Start THU CUNG============================
        void DataBindThuCung()
        {

            tbIDThuCung.Text = dgvThuCung.CurrentRow.Cells[0].Value.ToString();
            tbLoaiThuCung.Text = dgvThuCung.CurrentRow.Cells[1].Value.ToString();
            //cbLoaiThuCung.SelectedIndex = cbLoaiThuCung.FindStringExact("");
            cbGioitinh.SelectedItem = dgvThuCung.CurrentRow.Cells[2].Value.ToString();
            tbGiaNhapThuCung.Text = dgvThuCung.CurrentRow.Cells[3].Value.ToString();
            tbNccThuCung.Text = dgvThuCung.CurrentRow.Cells[4].Value.ToString();
            tbCanNangThuCung.Text = dgvThuCung.CurrentRow.Cells[5].Value.ToString();
            tbTuoiThuCung.Text = dgvThuCung.CurrentRow.Cells[6].Value.ToString();
        }

        void LoadThuCung()
        {
            //Chinh sua style dgv
            dgvThuCung.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvThuCung.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvThuCung.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvThuCung.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvThuCung.BackgroundColor = Color.White;

            dgvThuCung.EnableHeadersVisualStyles = false;
            dgvThuCung.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvThuCung.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvThuCung.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            var result = db.usp_GetThuCung().ToList();
            dgvThuCung.DataSource = result.ToList();
            DataBindThuCung();
            cbbTimThuCung.SelectedItem = "Loại";
            tbIDThuCung.ReadOnly = true;

        }

        private void dgvThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBindThuCung();
        }


        private void btnThemThuCung_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Thêm Thú Cưng ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Pet pet = new Pet();
                    pet.ID_Spec = Convert.ToInt32(tbLoaiThuCung.Text.ToString().Trim());
                    pet.Sex = cbGioitinh.Text.ToString().Trim();
                    pet.PriceImport = Convert.ToInt32(tbGiaNhapThuCung.Text);
                    pet.ID_Sup = Convert.ToInt32(tbNccThuCung.Text.ToString().Trim());
                    pet.Weight = Convert.ToDouble(tbCanNangThuCung.Text);
                    pet.Age = Convert.ToInt32(tbTuoiThuCung.Text);

                    db.Pets.Add(pet);
                    db.SaveChanges();

                    MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThuCung();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            }
        }

        private void btnSuaThuCung_Click(object sender, EventArgs e)
        {

            try
            {
                int idpet = Convert.ToInt32(dgvThuCung.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim());
                Pet pet = db.Pets.Find(idpet);
                pet.ID_Spec = Convert.ToInt32(tbLoaiThuCung.Text.ToString().Trim());
                pet.Sex = cbGioitinh.Text.ToString().Trim();
                pet.PriceImport = Convert.ToInt32(tbGiaNhapThuCung.Text);
                pet.ID_Sup = Convert.ToInt32(tbNccThuCung.Text.ToString().Trim());
                pet.Weight = Convert.ToDouble(tbCanNangThuCung.Text);
                pet.Age = Convert.ToInt32(tbTuoiThuCung.Text);

                db.SaveChanges();
                MessageBox.Show("Chỉnh Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThuCung();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Sửa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadThuCung();
            }
        }

        private void btnXoaThuCung_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Có Chắc Muốn Xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int valueDelete = Convert.ToInt32(tbIDThuCung.Text.ToString().Trim());
                    Pet pet = db.Pets.Where(p => p.ID_Pet == valueDelete).SingleOrDefault();
                    db.Pets.Remove(pet);
                    db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThuCung();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Xóa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadThuCung();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            String loaitimkiem = cbbTimThuCung.Text.ToString();
            Boolean flag_error = false;
            Boolean flag_check_case = false;

            string valueFind = tbTimThuCung.Text.ToString().Trim();

            var ms = db.usp_TimTCTheoGioiTinh(valueFind).ToList();

            switch (loaitimkiem)
            {
                case "Loại":
                    try
                    {
                        int loai = Convert.ToInt32(valueFind);
                        var ms1 = db.usp_TimTCTheoLoai(loai).ToList();
                        dgvThuCung.DataSource = ms1;
                        flag_check_case = true;
                        break;
                    }
                    catch (Exception)
                    {
                        flag_error = true;
                        break;
                    }
                case "Tuổi":
                    try
                    {
                        int age = Convert.ToInt32(valueFind);
                        var ms2 = db.usp_TimTCTheoTuoi(age).ToList();
                        dgvThuCung.DataSource = ms2;
                        flag_check_case = true;
                        break;
                    }
                    catch (Exception)
                    {
                        flag_error = true;
                        break;
                    }
            }
            if (flag_error)
            {
                MessageBox.Show("Lỗi! Vui lòng kiểm tra dữ liệu nhập vào.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadThuCung();
            }
            else
                if(flag_check_case==false)
                     dgvThuCung.DataSource = ms;
        }

        private void btnReloadTC_Click(object sender, EventArgs e)
        {
            LoadThuCung();
        }

        //======================End THU CUNG============================
        #endregion

        #region TAB THU CUNG DA MUA

        void LoadTabThuCungDaMua()
        {
            var result = db.usp_GetThuCungDaMua(this.iduser).ToList();
            dgvDSThuCungDaMua.DataSource = result.ToList();

        }

        #endregion

        #region TAB LOAI THU CUNG
        void DataBindLoaiThuCung()
        {
            tbIDLoaiTC.Text = dgvLoaiThuCung.CurrentRow.Cells[0].Value.ToString();
            tbTenLoaiTC.Text = dgvLoaiThuCung.CurrentRow.Cells[1].Value.ToString();
        }

        void LoadLoaiThuCung()
        { 

            var result = db.usp_GetLoaiThuCung().ToList();
            dgvLoaiThuCung.DataSource = result.ToList();
            DataBindLoaiThuCung();
            tbIDLoaiTC.ReadOnly = true;

        }

        private void dgvLoaiThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDLoaiTC.Show();
            lbIDLoaiTC.Show();
            DataBindLoaiThuCung();
        }
        private void btnThemLoaiTC_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Thêm Loại Thú Cưng ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Species spec = new Species();
                    spec.Name = tbTenLoaiTC.Text.ToString().Trim();

                    db.Species.Add(spec);
                    db.SaveChanges();

                    MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoaiThuCung();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            }
        }

        private void btnSuaLoaiTC_Click(object sender, EventArgs e)
        {

            try
            {
                int idspet = Convert.ToInt32(dgvLoaiThuCung.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim());
                Species spec = db.Species.Find(idspet);
                spec.Name = tbTenLoaiTC.Text.ToString().Trim();
              
                db.SaveChanges();
                MessageBox.Show("Chỉnh Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiThuCung();
                tbIDLoaiTC.Show();
                lbIDLoaiTC.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Chỉnh Sửa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadLoaiThuCung();
            }
        }

        private void btnXoaLoaiTC_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Có Chắc Muốn Xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int valueDelete = Convert.ToInt32(tbIDLoaiTC.Text.ToString().Trim());
                    Species spec = db.Species.Where(p => p.ID_Spec == valueDelete).SingleOrDefault();
                    db.Species.Remove(spec);
                    db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoaiThuCung();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Xóa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadLoaiThuCung();
            }
        }

        private void tbTenLoaiTC_Click(object sender, EventArgs e)
        {
            tbIDLoaiTC.Hide();
            lbIDLoaiTC.Hide();
        }
        #endregion

        #region TAB NHA CUNG CAP
        void DataBindNhaCungCap()
        {
            tbIDNCCTC.Text = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
            tbTenNCCTC.Text = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            tbSDTNCCTC.Text = dgvNhaCungCap.CurrentRow.Cells[2].Value.ToString();
            tbDiaChiNCC.Text = dgvNhaCungCap.CurrentRow.Cells[3].Value.ToString();

        }

        void LoadTabNhaCungCap()
        {

            var result = db.usp_GetDataNhaCungCap().ToList();
            dgvNhaCungCap.DataSource = result.ToList();
            DataBindNhaCungCap();
            tbIDNCCTC.ReadOnly = true;

        }
        private void dgvNhaCungCap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            tbIDNCCTC.Show();
            lbIDNCCTC.Show();
            DataBindNhaCungCap();
        }

        private void btThemNCC_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Thêm Nhà Cung Cấp Thú Cưng ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Supplier sup = new Supplier();
                    sup.ID_Sup = Convert.ToInt32(tbIDNCCTC.Text.ToString().Trim());
                    sup.Name = tbTenNCCTC.Text.ToString().Trim();
                    sup.Phone = tbSDTNCCTC.Text.ToString().Trim();
                    sup.Address = tbDiaChiNCC.Text.ToString().Trim();

                    db.Suppliers.Add(sup);
                    db.SaveChanges();

                    MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTabNhaCungCap();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            }
        }

        private void btSuaNCC_Click(object sender, EventArgs e)
        {

            try
            {
                int idspet = Convert.ToInt32(dgvNhaCungCap.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim());
                Supplier sup = db.Suppliers.Find(idspet);
                sup.Name = tbTenNCCTC.Text.ToString().Trim();
                sup.Phone = tbSDTNCCTC.Text.ToString().Trim();
                sup.Address = tbDiaChiNCC.Text.ToString().Trim();

                db.SaveChanges();
                MessageBox.Show("Chỉnh Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTabNhaCungCap();
                tbIDNCCTC.Show();
                lbIDNCCTC.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Chỉnh Sửa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadTabNhaCungCap();
            }
        }

        private void btXoaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Có Chắc Muốn Xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int valueDelete = Convert.ToInt32(tbIDNCCTC.Text.ToString().Trim());
                    Supplier sup = db.Suppliers.Where(p => p.ID_Sup == valueDelete).SingleOrDefault();
                    db.Suppliers.Remove(sup);
                    db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTabNhaCungCap();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Xóa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadTabNhaCungCap();
            }
        }

        private void tbTenNCCTC_Click(object sender, EventArgs e)
        {
            tbIDNCCTC.Hide();
            lbIDNCCTC.Hide();
        }


        #endregion

        #region TAB BAO HANH
        void LoadTabBaoHanh()
        {
            var result = db.usp_GetDataBaoHanh();
            dgvBaoHanh.DataSource = result.ToList();
            DataBindBaoHanhThuCung();
            tbIDBaoHanh.ReadOnly = true;
        }
        void DataBindBaoHanhThuCung()
        {
            tbIDBaoHanh.Text = dgvBaoHanh.CurrentRow.Cells[0].Value.ToString();
            tbTenBaoHanh.Text = dgvBaoHanh.CurrentRow.Cells[1].Value.ToString();
            tbThangBaoHanh.Text = dgvBaoHanh.CurrentRow.Cells[2].Value.ToString();
        }
        private void dgvBaoHanh_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbIDBaoHanh.Show();
            lbIDBaoHanh.Show();
            DataBindBaoHanhThuCung();
        }
        private void btThemBH_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Thêm Bảo Hành Thú Cưng ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    WarrantyType war = new WarrantyType();
                    war.Name = tbTenBaoHanh.Text.ToString().Trim();
                    war.Months = tbThangBaoHanh.Text.ToString().Trim();

                    db.WarrantyTypes.Add(war);
                    db.SaveChanges();

                    MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTabBaoHanh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            }
        }
        private void btSuaBH_Click_1(object sender, EventArgs e)
        {

            try
            {
                int idspet = Convert.ToInt32(dgvBaoHanh.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim());
                WarrantyType war = db.WarrantyTypes.Find(idspet);
                war.Name = tbTenBaoHanh.Text.ToString().Trim();
                war.Months = tbThangBaoHanh.Text.ToString().Trim();

                db.SaveChanges();
                MessageBox.Show("Chỉnh Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTabBaoHanh();
                tbIDBaoHanh.Show();
                lbIDBaoHanh.Show();


            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Chỉnh Sửa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadTabBaoHanh();
            }
        }
        private void btXoaBH_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Có Chắc Muốn Xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int valueDelete = Convert.ToInt32(tbIDBaoHanh.Text.ToString().Trim());
                    WarrantyType war = db.WarrantyTypes.Where(p => p.ID_Warr == valueDelete).SingleOrDefault();
                    db.WarrantyTypes.Remove(war);
                    db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTabBaoHanh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Xóa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadTabBaoHanh();

            }
        }








        #endregion

        
    }
}
