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
    public partial class frmAddNhanVien : Form
    {
        ThuCungEntities db = new ThuCungEntities();
        public frmAddNhanVien()
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
                user.Permission = "employee";

                string phone = txtSDTNhanVien.Text.ToString().Trim();
                int age = Convert.ToInt32(txtTuoiNhanVien.Text);
                int salary = Convert.ToInt32(tbLuongNhanVien.Text);
                string address = tbDiaChiNhanVien.Text.ToString().Trim();
                DateTime dt = DateTime.Parse(dtpNgayVaoLam.Text);
                

                db.Users.Add(user);
                db.SaveChanges();
                Employee employee = db.Employees.Find(user.ID);  
                try
                {
                    employee.ID_Emp = user.ID;
                    employee.Name = user.Name;
                    employee.Phone = phone;
                    employee.Address = address;
                    employee.Age = age;
                    employee.Salary = salary;
                    employee.DateStart = dt;

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
                MessageBox.Show("Lỗi Không Thêm Được 1!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            }
        }
    }
}
