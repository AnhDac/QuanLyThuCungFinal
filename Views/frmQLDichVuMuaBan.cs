using QuanLyThuCung.Database;
using QuanLyThuCung.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
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
        
        private int ser_IDNV;
        private int ser_IDCus;
        private int ser_IDServic;

        string tam = "bin";


        private int Sell_id_emp;
        private int Sell_id_cus;
        private int Sell_id_BaoHanh;
        string tam2 = "bin";

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



                    Contract_Ser contract_Ser = new Contract_Ser();

                    //contract_sell.ID_ConSell = txtSell_IDCon.Text.ToString().Trim();
                    contract_Ser.ID_Emp = ser_IDNV;
                    contract_Ser.ID_Cus = ser_IDCus;
                    contract_Ser.DateBuy = Convert.ToDateTime(dtpNgayMuaHDDV.Text.ToString().Trim());
                    contract_Ser.ID_Ser = ser_IDServic;
                    db.Contract_Ser.Add(contract_Ser);
                    db.SaveChanges();


                    // string Emp = txtHD_IDEmp.Text.ToString().Trim();
                    // string cus = txtHD_IDCus.Text.ToString().Trim();
                   // DateTime date = Convert.ToDateTime(dtpNgayMuaHDDV.Text.ToString());
                   // string tenDV = txtTenDichVuHDSer.Text.ToString().Trim();
                   // db.insert_contractSer(Emp,cus, date, tenDV);

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


                    int id = Convert.ToInt32(txtHD_IDConser.Text.ToString().Trim());
                    Contract_Ser contract_Ser = db.Contract_Ser.Find(id);
                    contract_Ser.ID_Emp = ser_IDNV;
                    contract_Ser.ID_Cus = ser_IDCus;
                    contract_Ser.DateBuy = Convert.ToDateTime(dtpNgayMuaHDDV.Text.ToString().Trim());
                    contract_Ser.ID_Ser = ser_IDServic;
                    db.SaveChanges();


                    // int id = Convert.ToInt32(txtHD_IDConser.Text.ToString().Trim());
                    //string Emp= txtHD_IDEmp.Text.ToString().Trim();
                   // string cus = txtHD_IDCus.Text.ToString().Trim();
                   // DateTime date = Convert.ToDateTime(dtpNgayMuaHDDV.Text.ToString());
                   // string tenDV=txtTenDichVuHDSer.Text.ToString().Trim();
                    //db.update_contractSer(id, Emp, cus, date, tenDV);

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
                    db.delete_contractSer(id);
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
            var result = db.GetData_contractSer().ToList();
            dgvHDDV.DataSource = result.ToList();
            binHopDongDV();
            btnSer_chon.Visible = false;

        }
        void binHopDongDV()
        {
            if (tam == "bin")
            {
                txtHD_IDConser.Text = dgvHDDV.CurrentRow.Cells[0].Value.ToString().Trim();
                txtHD_IDEmp.Text = dgvHDDV.CurrentRow.Cells[1].Value.ToString().Trim();
                txtHD_IDCus.Text = dgvHDDV.CurrentRow.Cells[2].Value.ToString().Trim();
                dtpNgayMuaHDDV.Text = dgvHDDV.CurrentRow.Cells[3].Value.ToString().Trim();
                txtTenDichVuHDSer.Text = dgvHDDV.CurrentRow.Cells[4].Value.ToString().Trim();
                txtHDSer_Price.Text = dgvHDDV.CurrentRow.Cells[5].Value.ToString().Trim();
            }

        }
        private void printBanDichVu_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fontTieuDe = new Font("Arial", 3, FontStyle.Bold);
            Font fontNoiDung = new Font("Arial", 3, FontStyle.Regular);

            printBanDichVu.DefaultPageSettings.PaperSize = new PaperSize("HÓA ĐƠN DỊCH VỤ", 148, 150);

            Contract_Ser c = db.Contract_Ser.Find(int.Parse(txtHD_IDConser.Text));
            int pos = 0;
            int theLastPos = 0;
            int leftMargin = 22;
            int topMargin = 40;
            int halfWidthPage = printBanDichVu.DefaultPageSettings.PaperSize.Width / 2;
            e.Graphics.DrawString("HÓA ĐƠN DỊCH VỤ", new Font("Arial", 5, FontStyle.Bold), Brushes.Black, new Point(halfWidthPage - 30, 10));
            e.Graphics.DrawString("Người mua hàng : " + txtHD_IDCus.Text, new Font("Arial", 3, FontStyle.Bold), Brushes.Black, new Point(leftMargin, 23));
            e.Graphics.DrawString("Ngày xuất hóa đơn: " + DateTime.Now.ToString("dd-MM-yyyy"), new Font("Arial", 3, FontStyle.Bold), Brushes.Black, new Point(leftMargin, 30));
           
            //In phần tiêu đề hóa đơn
            e.Graphics.DrawString("Mã dịch vụ", fontTieuDe, Brushes.Black, new Point(leftMargin, topMargin));
            e.Graphics.DrawString("Tên dịch vụ", fontTieuDe, Brushes.Black, new Point(leftMargin + 25, topMargin));
            e.Graphics.DrawString("Giá tiên", fontTieuDe, Brushes.Black, new Point(leftMargin + 50, topMargin));


            e.Graphics.DrawString(c.ID_ConSer + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 1, topMargin + 10 + pos));
            e.Graphics.DrawString(db.Contract_Ser.Find(c.ID_ConSer).Servic.Name + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 25, topMargin + 10 + pos));
            e.Graphics.DrawString(db.Contract_Ser.Find(c.ID_ConSer).Servic.Price + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 56, topMargin + 10 + pos));

            theLastPos = topMargin + 10 + pos;
            pos += 10;

            e.Graphics.DrawString("==========================================", fontNoiDung,
                Brushes.Black, new Point(leftMargin, theLastPos + 10));
            e.Graphics.DrawString("Thành tiền : " + txtHDSer_Price.Text + " VNĐ", fontTieuDe,
                Brushes.Black, new Point(leftMargin, theLastPos + 20));
            e.Graphics.DrawString("Người bán : " + txtHD_IDEmp.Text, fontTieuDe,
                Brushes.Black, new Point(leftMargin, theLastPos + 30));
            e.Graphics.DrawString("Ngày mua : " + dtpNgayMuaHDDV.Text, fontTieuDe,
                Brushes.Black, new Point(leftMargin, theLastPos + 40));
            e.Graphics.DrawString("- HẸN GẶP LẠI QUÝ KHÁCH - ", fontTieuDe, Brushes.Black,
                new Point(leftMargin + 21, theLastPos + 60));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printBanDichVu.DefaultPageSettings.PaperSize = new PaperSize("HÓA ĐƠN DỊCH VỤ", 148, 150);
            printPreviewDialogBanDichVu.ShowDialog();
        }
        private void btnSer_IDNV_Click(object sender, EventArgs e)
        {

            btnSuaHDDV.Visible = false;
            btnXoaHDDV.Visible = false;
            btnThemHDDV.Visible = false;
            btnInHoaDonDV.Visible = false;
            tam = "NV";
            btnSer_chon.Visible = true;
            dgvHDDV.DataSource = db.usp_GetDataNV();

        }

        private void btnSer_IDKH_Click(object sender, EventArgs e)
        {
            dgvHDDV.DataSource = db.usp_GetDataCustomer();
            btnSuaHDDV.Visible = false;
            btnXoaHDDV.Visible = false;
            btnThemHDDV.Visible = false;
            btnInHoaDonDV.Visible = false;
            tam = "KH";
            btnSer_chon.Visible = true;

        }

        private void btnSer_IDDV_Click(object sender, EventArgs e)
        {
            dgvHDDV.DataSource = db.usp_GetDataDichVu();
            btnSuaHDDV.Visible = false;
            btnXoaHDDV.Visible = false;
            btnThemHDDV.Visible = false;
            btnInHoaDonDV.Visible = false;
            tam = "NameDV";
            btnSer_chon.Visible = true;

        }

        private void btnSer_chon_Click(object sender, EventArgs e)
        {
            if (tam == "NameDV")
            {
                ser_IDServic = Convert.ToInt32(dgvHDDV.CurrentRow.Cells[0].Value.ToString().Trim());
                txtTenDichVuHDSer.Text = dgvHDDV.CurrentRow.Cells[1].Value.ToString().Trim();
            }
            if (tam == "KH")
            {
                ser_IDCus = Convert.ToInt32(dgvHDDV.CurrentRow.Cells[0].Value.ToString().Trim());
                txtHD_IDCus.Text = dgvHDDV.CurrentRow.Cells[1].Value.ToString().Trim();
            }
            if (tam == "NV")
            {
                ser_IDNV = Convert.ToInt32(dgvHDDV.CurrentRow.Cells[0].Value.ToString().Trim());
                txtHD_IDEmp.Text = dgvHDDV.CurrentRow.Cells[1].Value.ToString().Trim();
            }
            tam = "bin";
            btnSuaHDDV.Visible = true;
            btnXoaHDDV.Visible = true;
            btnThemHDDV.Visible = true;
            btnInHoaDonDV.Visible = true;
            btnSer_chon.Visible = false;
            dgvHDDV.DataSource = db.GetData_contractSer().ToList();
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

                    contract_sell.ID_Emp = Sell_id_emp;
                    contract_sell.ID_Cus = Sell_id_cus;
                    contract_sell.ID_Pet = Convert.ToInt32(txtSell_IDPet.Text.ToString().Trim());
                    contract_sell.CateInsurance = Sell_id_BaoHanh;
                    contract_sell.DateSell = Convert.ToDateTime(dateSell_DateSell.Text);
                    contract_sell.Price = Convert.ToInt32(txtSell_Price.Text);
                    db.Contract_Sell.Add(contract_sell);

                    db.SaveChanges();





                    //int id = Convert.ToInt32(txtSell_IDCon.Text.ToString());
                    //string NV = txtHD_IDEmp.Text.ToString().Trim();
                   // string cus = txtSell_IDCus.Text.ToString().Trim();
                    //int pet1 = Convert.ToInt32(txtSell_IDPet.Text.ToString());


                   // DateTime date = Convert.ToDateTime(dateSell_DateSell.Text.ToString());
                   // string warr = txtSell_Caltel.Text.ToString().Trim();
                   // int price = Convert.ToInt32(txtSell_Price.Text.ToString().Trim());
                   // db.insert_contractSell( NV, cus, pet1, warr, date, price);

                    //db.SaveChanges();

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


                    int id = Convert.ToInt32(txtSell_IDCon.Text.ToString().Trim());
                    Contract_Sell contract_Sell1 = db.Contract_Sell.Find(id);

                    contract_Sell1.ID_Emp = Sell_id_emp;
                    contract_Sell1.ID_Cus = Sell_id_cus;
                    contract_Sell1.ID_Pet = Convert.ToInt32(txtSell_IDPet.Text.ToString().Trim());
                    contract_Sell1.CateInsurance = Sell_id_BaoHanh;
                    contract_Sell1.DateSell = Convert.ToDateTime(dateSell_DateSell.Text);
                    contract_Sell1.Price = Convert.ToInt32(txtSell_Price.Text);
                    db.SaveChanges();



                    //int id = Convert.ToInt32( txtSell_IDCon.Text.ToString());
                    //string NV = txtHD_IDEmp.Text.ToString().Trim();
                    //string cus = txtSell_IDCus.Text.ToString().Trim();
                    //int pet1 =Convert.ToInt32( txtSell_IDPet.Text.ToString());
          
                    
                    //DateTime date = Convert.ToDateTime( dateSell_DateSell.Text.ToString());
                    //string warr = txtSell_Caltel.Text.ToString().Trim();
                   // int price = Convert.ToInt32(txtSell_Price.Text.ToString().Trim());
                    //db.update_contractSell(id, NV, cus, pet1,  warr,date, price);
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                LoadHopDongThuCung();
            }
        }


        //=========Hàm======
        void binHopDongThuCung()
        {
            if (tam2 == "bin")
            {
                txtSell_IDCon.Text = dgvContractSell.CurrentRow.Cells[0].Value.ToString().Trim();
                txtSell_IDEmp.Text = dgvContractSell.CurrentRow.Cells[1].Value.ToString().Trim();
                txtSell_IDCus.Text = dgvContractSell.CurrentRow.Cells[2].Value.ToString().Trim();
                txtSell_IDPet.Text = dgvContractSell.CurrentRow.Cells[3].Value.ToString().Trim();
                txtSell_Caltel.Text = dgvContractSell.CurrentRow.Cells[4].Value.ToString().Trim();
                dateSell_DateSell.Text = dgvContractSell.CurrentRow.Cells[5].Value.ToString().Trim();
                txtSell_Price.Text = dgvContractSell.CurrentRow.Cells[6].Value.ToString().Trim();
            }
        }
        void LoadHopDongThuCung()
        {
            var result = db.GetData_contractSell().ToList();
            dgvContractSell.DataSource = result.ToList();
            binHopDongThuCung();
            btnSell_chon.Visible = false;

        }
        #endregion

        private void btnExport_Click(object sender, EventArgs e)
        {
            printBill.DefaultPageSettings.PaperSize = new PaperSize("HÓA ĐƠN", 148, 150);
            printPreviewDialogBill.ShowDialog();
        }

        private void printBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontTieuDe = new Font("Arial", 3, FontStyle.Bold);
            Font fontNoiDung = new Font("Arial", 3, FontStyle.Regular);

            printBill.DefaultPageSettings.PaperSize = new PaperSize("HÓA ĐƠN", 148, 150);

            Contract_Sell c = db.Contract_Sell.Find(int.Parse(txtSell_IDCon.Text));
            int pos = 0;
            int theLastPos = 0;
            int leftMargin = 22;
            int topMargin = 40;
            int halfWidthPage = printBill.DefaultPageSettings.PaperSize.Width / 2;
            e.Graphics.DrawString("HÓA ĐƠN BÁN LẺ", new Font("Arial", 5, FontStyle.Bold), Brushes.Black, new Point(halfWidthPage - 30, 10));
            e.Graphics.DrawString("Người mua hàng: " + txtSell_IDCus.Text, new Font("Arial", 3, FontStyle.Bold), Brushes.Black, new Point(leftMargin, 23));
            e.Graphics.DrawString("Ngày xuất hóa đơn: " + DateTime.Now.ToString("dd-MM-yyyy"), new Font("Arial", 3, FontStyle.Bold), Brushes.Black, new Point(leftMargin, 30));

            //In phần tiêu đề hóa đơn
            e.Graphics.DrawString("Mã TC", fontTieuDe, Brushes.Black, new Point(leftMargin, topMargin));
            e.Graphics.DrawString("Loài", fontTieuDe, Brushes.Black, new Point(leftMargin + 25, topMargin));
            e.Graphics.DrawString("Cân nặng", fontTieuDe, Brushes.Black, new Point(leftMargin + 50, topMargin));
            e.Graphics.DrawString("Giá tiền", fontTieuDe, Brushes.Black, new Point(leftMargin + 85, topMargin));


            e.Graphics.DrawString(c.ID_ConSell + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 1, topMargin + 10 + pos));
            e.Graphics.DrawString(db.Pets.Find(c.ID_Pet).Species.Name + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 25, topMargin + 10 + pos));
            e.Graphics.DrawString(db.Pets.Find(c.ID_Pet).Weight + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 56, topMargin + 10 + pos));
            e.Graphics.DrawString(db.Contract_Sell.Find(c.ID_ConSell).Price + " VNĐ", fontNoiDung, Brushes.Black, new Point(leftMargin + 85, topMargin + 10 + pos));

            theLastPos = topMargin + 10 + pos;
            pos += 10;

            e.Graphics.DrawString("==========================================", fontNoiDung,
                Brushes.Black, new Point(leftMargin, theLastPos + 20));
            e.Graphics.DrawString("Loại bảo hành : " + txtSell_Caltel.Text, fontTieuDe,
                Brushes.Black, new Point(leftMargin, theLastPos + 30));
            e.Graphics.DrawString("Thành tiền : " + txtSell_Price.Text + " VNĐ", fontTieuDe,
                Brushes.Black, new Point(leftMargin, theLastPos + 40));
            e.Graphics.DrawString("Người bán : " + txtSell_IDEmp.Text, fontTieuDe,
                Brushes.Black, new Point(leftMargin, theLastPos + 50));
            e.Graphics.DrawString("Ngày mua : " + dateSell_DateSell.Text, fontTieuDe,
                Brushes.Black, new Point(leftMargin, theLastPos + 60));
            e.Graphics.DrawString("- HẸN GẶP LẠI QUÝ KHÁCH - ", fontTieuDe, Brushes.Black,
                new Point(leftMargin + 21, theLastPos + 70));
        }

        private void btnSell_NV_Click(object sender, EventArgs e)
        {
            dgvContractSell.DataSource = db.usp_GetDataNV();
            btnSell_chon.Visible = true;
            btnSell_Sua.Visible = false;
            btnSell_Them.Visible = false;
            btnSell_Xoa.Visible = false;
            btnInHoaDonTC.Visible = false;
            tam2 = "NV";
        }

        private void btnSell_KH_Click(object sender, EventArgs e)
        {
            dgvContractSell.DataSource = db.usp_GetDataCustomer();
            btnSell_chon.Visible = true;
            btnSell_Sua.Visible = false;
            btnSell_Them.Visible = false;
            btnSell_Xoa.Visible = false;
            btnInHoaDonTC.Visible = false;
            tam2 = "KH";
        }

        private void btnSell_baoHanh_Click(object sender, EventArgs e)
        {
            dgvContractSell.DataSource = db.usp_GetDataBaoHanh();
            btnSell_chon.Visible = true;
            btnSell_Sua.Visible = false;
            btnSell_Them.Visible = false;
            btnSell_Xoa.Visible = false;
            btnInHoaDonTC.Visible = false;
            tam2 = "BaoHanh";
        }

        private void btnSell_chon_Click(object sender, EventArgs e)
        {
            if (tam2 == "NV")
            {
                Sell_id_emp = Convert.ToInt32(dgvContractSell.CurrentRow.Cells[0].Value.ToString().Trim());
                txtSell_IDEmp.Text = dgvContractSell.CurrentRow.Cells[1].Value.ToString().Trim();
            }
            if (tam2 == "BaoHanh")
            {
                Sell_id_BaoHanh = Convert.ToInt32(dgvContractSell.CurrentRow.Cells[0].Value.ToString().Trim());
                txtSell_Caltel.Text = dgvContractSell.CurrentRow.Cells[1].Value.ToString().Trim();
            }
            if (tam2 == "KH")
            {
                Sell_id_cus = Convert.ToInt32(dgvContractSell.CurrentRow.Cells[0].Value.ToString().Trim());
                txtSell_IDCus.Text = dgvContractSell.CurrentRow.Cells[1].Value.ToString().Trim();
            }
            tam2 = "bin";
            btnSell_chon.Visible = false;
            btnSell_Sua.Visible = true;
            btnSell_Them.Visible = true;
            btnSell_Xoa.Visible = true;
            btnInHoaDonTC.Visible = true;
            tam2 = "bin";
            dgvContractSell.DataSource = db.GetData_contractSell();
        }
    }
}
