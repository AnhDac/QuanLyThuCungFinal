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
    public partial class frmAddAdmin : Form
    {
        ThuCungEntities db = new ThuCungEntities();

        public frmAddAdmin()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLưu_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();

                //user.ID = Convert.ToInt32(tbIDUser.Text.ToString().Trim());
                user.Name = tbTenUser.Text.ToString().Trim();
                user.Username = tbUsernameUser.Text.ToString().Trim();
                user.PassWord = tbPasswordUser.Text.ToString().Trim();
                user.Permission = "admin";

                db.Users.Add(user);

                db.SaveChanges();

                MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            }
        }
    }
}
