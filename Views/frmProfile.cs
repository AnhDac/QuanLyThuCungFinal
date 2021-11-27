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
    public partial class frmProfile : Form
    {
        ThuCungEntities db = new ThuCungEntities();

        Controller ctrl = new Controller();

        private int iduser;

        public frmProfile()
        {
            InitializeComponent();
            iduser = 0;
        }

        public frmProfile(int iduser)
        {
            InitializeComponent();
            this.iduser = iduser;
        }


        private void frmProfile_Load(object sender, EventArgs e)
        {
            getProfileUser();
            panelLuuHuyProfile.Hide();
            tbIDUser.ReadOnly = true;
            tbTenUser.ReadOnly = true;
            tbUsername.ReadOnly = true;
            tbPasswordUser.ReadOnly = true;
            tbDiaChiNhanVien.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTuoi.ReadOnly = true;
            tbLuongNhanVien.ReadOnly = true;

        }

        private void btnSuaProfile_Click(object sender, EventArgs e)
        {
            btnSuaProfile.Enabled = false;
            panelLuuHuyProfile.Show();
            tbTenUser.ReadOnly = false;
            tbUsername.ReadOnly = false;
            tbPasswordUser.ReadOnly = false;
            tbDiaChiNhanVien.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTuoi.ReadOnly = false;

        }

        private void btnLuuProfile_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.iduser;

                User user = db.Users.Find(id);
                user.Name = tbTenUser.Text.ToString().Trim();
                user.PassWord = tbPasswordUser.Text.ToString().Trim();
                user.Username  =tbUsername.Text.ToString().Trim();

                string permiss = user.Permission.ToString();
                if (permiss == "customer")
                {
                    Customer customer = db.Customers.Find(id);
                    customer.Name = tbTenUser.Text.ToString().Trim();
                    customer.Phone = txtSDT.Text.ToString().Trim();
                    customer.Age = Convert.ToInt32(txtTuoi.Text);
                }
                else if (permiss == "employee")
                {
                    Employee employee = db.Employees.Find(id);

                    employee.Name = tbTenUser.Text.ToString().Trim();
                    employee.Phone = txtSDT.Text.ToString().Trim();
                    employee.Age = Convert.ToInt32(txtTuoi.Text);
                    employee.Address = tbDiaChiNhanVien.Text.ToString().Trim();
                }

                db.SaveChanges();
                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HandleBtnHuyProfile();
                getProfileUser();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Sửa Được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                HandleBtnHuyProfile();
            }
        }

        private void btnHuyProfile_Click(object sender, EventArgs e)
        {
            HandleBtnHuyProfile();
        }

        void getProfileUser()
        {
           var user = db.Users.Find(iduser);
            tbIDUser.Text = user.ID.ToString();
            tbTenUser.Text = user.Name.ToString();
            tbUsername.Text = user.Username.ToString();
            tbPasswordUser.Text = user.PassWord.ToString();

            string permiss = user.Permission.ToString().Trim();
            if (permiss == "customer")
            {
                panelNV.Hide();
               
                var customer = db.Customers.Find(iduser);
                txtSDT.Text = customer.Phone.ToString();
                txtTuoi.Text = customer.Age.ToString();

            }
            else if(permiss == "employee")
            {
                var employee =db.Employees.Find(iduser);
                txtSDT.Text = employee.Phone.ToString();
                txtTuoi.Text = employee.Age.ToString();
                tbLuongNhanVien.Text = employee.Salary.ToString();
                tbDiaChiNhanVien.Text = employee.Address.ToString();
                dtpNgayVaoLam.Text = employee.DateStart.ToString();
            }
            else
            {
                txtSDT.Hide();
                txtTuoi.Hide();
                lbSDT.Hide();
                lbTuoi.Hide();
                panelNV.Hide();
            }

        }

        void HandleBtnHuyProfile()
        {
            panelLuuHuyProfile.Hide();
            btnSuaProfile.Enabled = true;
            tbTenUser.ReadOnly = true;
            tbUsername.ReadOnly = true;
            tbPasswordUser.ReadOnly = true;
            tbDiaChiNhanVien.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTuoi.ReadOnly = true;
        }

        
    }
}
