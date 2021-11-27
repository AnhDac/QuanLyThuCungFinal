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
    public partial class frmQLUser : Form
    {
        ThuCungEntities db = new ThuCungEntities();
        private Form currentChildForm;

        public frmQLUser()
        {
            InitializeComponent();
        }


        private void frmQLUser_Load(object sender, EventArgs e)
        {
            //Chinh sua style dgv
            dgvUser.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUser.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvUser.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvUser.BackgroundColor = Color.White;

            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUser.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvUser.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            LoadUser();
            cbbTimUser.SelectedItem = "Tên";
        }

        private void btnReloadUser_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void btnTimUser_Click(object sender, EventArgs e)
        {
            String loaitimkiem = cbbTimUser.Text.ToString();

            var ms = db.usp_TimUserTheoTen(tbTimUser.Text.ToString().Trim()).ToList();
            Boolean flag_check_case = false;

            switch (loaitimkiem)
            {
                case "Tên Tài Khoản":
                    var ms1 = db.usp_TimUserTheoUsername(tbTimUser.Text.ToString().Trim()).ToList();
                    dgvUser.DataSource = ms1;
                    flag_check_case = true;
                    break;
            }
            if(flag_check_case==false)
                dgvUser.DataSource = ms;
        }

        private void btnSuaUser_Click(object sender, EventArgs e)
        {
            try
            {
                int iduser = Convert.ToInt32( dgvUser.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim());
                User user = db.Users.Find(iduser);
                user.Name = tbTenUser.Text.ToString().Trim();
                user.Username = tbUsernameUser.Text.ToString().Trim();
                user.PassWord = tbPasswordUser.Text.ToString().Trim();

                db.SaveChanges();
                MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUser();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Sửa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadUser();
            }
        }

        private void btnXoaUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32( tbIDUser.Text.ToString());
                    User user = db.Users.Where(p => p.ID ==id).SingleOrDefault();
                    db.Users.Remove(user);
                    db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUser();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Xóa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadUser();
            }
        }

        private void btnThemUserKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddKhachHang());
        }

        private void btnThemUserNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddNhanVien());
        }

        private void ThemUserAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddAdmin());
        }
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBindUser();
        }


        //===================Function=================
        void DataBindUser()
        {
            tbIDUser.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            tbTenUser.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            tbUsernameUser.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            tbPasswordUser.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            tbPermissionUser.Text = dgvUser.CurrentRow.Cells[4].Value.ToString().Trim();
        }

        void LoadUser()
        {
            var result =db.usp_GetDataUser().ToList();
            dgvUser.DataSource = result.ToList();
            DataBindUser();
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
            panelMainQLUser.Controls.Add(childForm);
            panelMainQLUser.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

    }
}
