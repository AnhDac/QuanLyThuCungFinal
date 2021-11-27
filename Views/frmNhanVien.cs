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
    public partial class frmNhanVien : Form
    {

        ThuCungEntities db = new ThuCungEntities();
        Controller ctrl = new Controller();
        private Form currentChildForm;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //Chinh sua style dgv
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvNhanVien.BackgroundColor = Color.White;

            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            LoadNhanVien();
            cbbTimNhanVien.SelectedItem = "Tên";
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddNhanVien());
        }


        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int idemp = Convert.ToInt32(dgvNhanVien.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim());
                Employee emp = db.Employees.Find(idemp);
                emp.Name = tbTenNhanVien.Text.ToString().Trim();
                emp.Phone = tbSDTNhanVien.Text.ToString().Trim();
                emp.Age = Convert.ToInt32(tbTuoiNhanVien.Text.ToString().Trim());
                emp.Address = tbDiaChiNhanVien.Text.ToString().Trim();
                emp.Salary = Convert.ToInt32(tbLuongNhanVien.Text.ToString().Trim());
                emp.DateStart = DateTime.Parse(dtpNgayVaoLam.Text.ToString());

                db.SaveChanges();
                MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Sửa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadNhanVien();
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(tbIDNhanVien.Text.ToString());
                    User user = db.Users.Where(p => p.ID == id).SingleOrDefault();
                    db.Users.Remove(user);
                    db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Xóa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadNhanVien();
            }
        }

        private void btnReloadNV_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnTimNhanVien_Click(object sender, EventArgs e)
        {
            String loaitimkiem = cbbTimNhanVien.Text.ToString();
            Boolean flag_error = false;
            Boolean flag_CheckCase = false;

            var ms = db.usp_TimNVTheoTen(tbTimNhanVien.Text.ToString().Trim()).ToList();
            switch (loaitimkiem)
            {
                case "SĐT":
                    try
                    {
                        int flag = Convert.ToInt32(tbTimNhanVien.Text.ToString().Trim());
                        var ms1 = db.usp_TimNVTheoSDT(tbTimNhanVien.Text.ToString().Trim()).ToList();
                        dgvNhanVien.DataSource = ms1;
                        flag_CheckCase = true;
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
                        int age = Convert.ToInt32(tbTimNhanVien.Text.ToString());
                        var ms2 = db.usp_TimNVTheoTuoi(age).ToList();
                        dgvNhanVien.DataSource = ms2;
                        flag_CheckCase = true;
                        break;
                    }
                    catch (Exception)
                    {
                        flag_error = true;
                        break;
                    }
                case "Lương":
                    try
                    {
                        int salary = Convert.ToInt32(tbTimNhanVien.Text.ToString());
                        var ms3 = db.usp_TimNVTheoLuong(salary).ToList();
                        dgvNhanVien.DataSource = ms3;
                        flag_CheckCase = true;
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
                LoadNhanVien();
            }
            else
                if(flag_CheckCase==false)
                    dgvNhanVien.DataSource = ms;
        }

        //============= Hàm =================

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
            panelMainNV.Controls.Add(childForm);
            panelMainNV.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
       

        void DataBindNhanVien()
        {
            tbIDNhanVien.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            tbTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            tbSDTNhanVien.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            tbTuoiNhanVien.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            tbDiaChiNhanVien.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            tbLuongNhanVien.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            dtpNgayVaoLam.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            dgvNhanVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void LoadNhanVien()
        {
            var result = db.usp_GetDataNV().ToList();
            dgvNhanVien.DataSource = result.ToList();
            DataBindNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBindNhanVien();
        }
    }
}
