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
    public partial class frmKhachHang : Form
    {
        ThuCungEntities db = new ThuCungEntities();
        private Form currentChildForm;


        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddKhachHang());
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
            panelMainKH.Controls.Add(childForm);
            panelMainKH.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            //Chinh sua style dgv
            dgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvKhachHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKhachHang.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvKhachHang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvKhachHang.BackgroundColor = Color.White;

            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            LoadKhachHang();
            cbbTimKhachHang.SelectedItem = "Tên";
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                int idkh = Convert.ToInt32(dgvKhachHang.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim());
                Customer cus = db.Customers.Find(idkh);
                cus.Name = tbTenKhachHang.Text.ToString().Trim();
                cus.Phone = tbSDTKhachHang.Text.ToString().Trim();
                cus.Age = Convert.ToInt32(tbTuoiKhachHang.Text);

                db.SaveChanges();
                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Sửa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadKhachHang();
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tbIDKhachHang.Text.ToString());
                    User user = db.Users.Where(p => p.ID == id).SingleOrDefault();
                    db.Users.Remove(user);
                    db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Xóa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadKhachHang();
            }
        }
       
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBindKhachHang();
        }

        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            String loaitimkiem = cbbTimKhachHang.Text.ToString();
            Boolean flag_error = false;//Check Loi
            Boolean flag_checkCase = false;

            var ms = db.usp_TimKHTheoTen(tbTimKhachHang.Text.ToString().Trim()).ToList();
            switch (loaitimkiem)
            {
                case "SĐT":
                    try
                    {
                        int flag = Convert.ToInt32(tbTimKhachHang.Text.ToString());
                        var ms1 = db.usp_TimKHTheoSDT(tbTimKhachHang.Text.ToString().Trim()).ToList();
                        dgvKhachHang.DataSource = ms1;
                        flag_checkCase = true;
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
                        int age = Convert.ToInt32(tbTimKhachHang.Text.ToString());
                        var ms2 = db.usp_TimKHTheoTuoi(age).ToList();
                        dgvKhachHang.DataSource = ms2;
                        flag_checkCase = true;
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
                LoadKhachHang();
            }
            else
                if(flag_checkCase ==false)
                    dgvKhachHang.DataSource = ms;
        }

        private void btnReloadKH_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }


        void DataBindKhachHang()
        {
            tbIDKhachHang.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            tbTenKhachHang.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            tbSDTKhachHang.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            tbTuoiKhachHang.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
        }
        void LoadKhachHang()
        {
            var result = db.usp_GetDataCustomer().ToList();
            dgvKhachHang.DataSource = result.ToList();
            DataBindKhachHang();
        }




    }
}
