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
    public partial class frmAddKhachHang : Form
    {
        ThuCungEntities db = new ThuCungEntities();
        public frmAddKhachHang()
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
                db = new ThuCungEntities();

                User user = new User();

                user.Name = tbTenUser.Text.ToString().Trim();
                user.Username = tbUsernameUser.Text.ToString().Trim();
                user.PassWord = tbPasswordUser.Text.ToString().Trim();
                user.Permission = "customer";

                string phone=txtSDTKhachHang.Text.ToString().Trim();
                int age = Convert.ToInt32(txtTuoiKhachHang.Text);

                db.Users.Add(user);
                db.SaveChanges();

                Customer customer = db.Customers.Find(user.ID);
                try
                {
                    customer.ID_Cus = user.ID;
                    customer.Name = user.Name;
                    customer.Phone = phone;
                    customer.Age = age;

                    db.SaveChanges();

                    MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    db = new ThuCungEntities();
                    User userdl = db.Users.Find(user.ID);
                    db.Users.Remove(userdl);
                    db.SaveChanges();
                    MessageBox.Show("Lỗi Không Thêm Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db = new ThuCungEntities();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            }
        }

        private void pnlDataBind_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSDTKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTuoiKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbTenUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbUsernameUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbPasswordUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbIDUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void labMaDoUong_Click(object sender, EventArgs e)
        {

        }

        private void frmAddKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
