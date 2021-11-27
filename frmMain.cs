using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLyThuCung.Model;
using QuanLyThuCung.Views;
using QuanLyThuCung.Database;


namespace QuanLyThuCung
{
    public partial class frmMain : Form
    {
        ThuCungEntities db = new ThuCungEntities();

        Controller ctrl = new Controller();

        private int iduser = 0;
        private IconButton currentBtn;
        private Panel leftBoderBtn;
        private Form currentChildForm;
        public frmMain()
        {
            InitializeComponent();

            leftBoderBtn = new Panel();
            leftBoderBtn.Size = new Size(7, 60);
        }

        
        private void Home_Load(object sender, EventArgs e)
        {
            PhanQuyenUser(this.iduser);
            panelTimKiemThuCungMain.Hide();
            cbbTimThuCungMain.SelectedItem = "Loại";
            tbUsername.Text = "Kh2";
            tbPassword.Text = "12345678";

        }


        public void PhanQuyenUser (int iduser)
        {
            string permiss = "";
            permiss = ctrl.getPermissUser(iduser);

            //Show All
            btnProfile.Show();
            btnThuCung.Show();
            btnKhachHang.Show();
            btnNhanVien.Show();
            btnNguoiDung.Show();
            btnBaoCao.Show();
            btnDichVu.Show();

            switch (permiss)
            {
                case ""://guest
                    btnProfile.Hide();
                    btnThuCung.Hide();
                    btnKhachHang.Hide();
                    btnNhanVien.Hide();
                    btnNguoiDung.Hide();
                    btnBaoCao.Hide();

                    break;
                case "customer":
                    btnProfile.Show();
                    btnKhachHang.Hide();
                    btnNhanVien.Hide();
                    btnNguoiDung.Hide();
                    btnBaoCao.Hide();
                    break;
                case "employee":
                    btnProfile.Show();
                    btnThuCung.Show();
                    btnKhachHang.Show();
                    btnNhanVien.Hide();
                    btnNguoiDung.Hide();
                    btnBaoCao.Hide();
                    break;
            }
            
        }



        //Structss
        private struct RBGColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);


        }


        //method
        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            //Button
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 26, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left boder button
                leftBoderBtn.BackColor = color;
                leftBoderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBoderBtn.Visible = true;
                leftBoderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(222, 184, 135);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            panelTimKiemThuCungMain.Hide();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color1);
            frmHome frm = new frmHome();
            frm.iduser = this.iduser;
            frm.pnlTimkiemThuCung = this.panelTimKiemThuCungMain;
            OpenChildForm(frm);
            panelTimKiemThuCungMain.Show();
        }

        private void btnThuCung_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new frmQLThuCung(this.iduser));
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new frmKhachHang());

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color3);
            OpenChildForm(new frmNhanVien());          
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color4);
            OpenChildForm(new frmQLUser());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new frmProfile(this.iduser));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color2);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                this.iduser = 0;
                PhanQuyenUser(this.iduser);
            }
            panelTimKiemThuCungMain.Hide();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color6);
            OpenChildForm(new BaoCao());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String PassWord = tbPassword.Text.ToString().Trim();
            String Username = tbUsername.Text.ToString().Trim();
          
            var result = ctrl.getUserCheckLogin(Username, PassWord);
            if (result != null)
            {
                this.iduser = result.IDUser;          
                tbPassword.Text = "12345678";
                tbUsername.Text = "";
                PhanQuyenUser(this.iduser);
                frmHome frm = new frmHome();
                frm.pnlTimkiemThuCung = this.panelTimKiemThuCungMain;
                frm.iduser = this.iduser;
                OpenChildForm(frm);
                panelTimKiemThuCungMain.Show();
                DisableButton();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            frmAddKhachHang frm = new frmAddKhachHang();
            DisableButton();
            OpenChildForm(frm);
        }

        private void btnLater_Click(object sender, EventArgs e)
        {
            DisableButton();
            frmHome frm = new frmHome();
            frm.pnlTimkiemThuCung = this.panelTimKiemThuCungMain;
            OpenChildForm(frm);
            panelTimKiemThuCungMain.Show();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color5);
            OpenChildForm(new frmQLDichVuMuaBan(this.iduser));
        }

        private void btnTimThuCungMain_Click(object sender, EventArgs e)
        {
            String loaitimkiem = cbbTimThuCungMain.Text.ToString();
            Boolean flag_error = false;

            string gtritimkiem = tbTimThuCungMain.Text.ToString().Trim();

            switch (loaitimkiem)
            {
                case "Loại":
                    frmHome frm = new frmHome();
                    frm.iduser = this.iduser;
                    frm.loaitimkiem = "Loại";
                    frm.giatritimkiem = gtritimkiem;
                    frm.pnlTimkiemThuCung = this.panelTimKiemThuCungMain;
                    OpenChildForm(frm);
                    break;

                case "Giới Tính":
                    frmHome frm1 = new frmHome();
                    frm1.iduser = this.iduser;
                    frm1.loaitimkiem = "Giới Tính";
                    frm1.giatritimkiem = gtritimkiem;
                    frm1.pnlTimkiemThuCung = this.panelTimKiemThuCungMain;
                    OpenChildForm(frm1);
                    break;
                case "Tuổi":
                    try
                    {
                        int age = Convert.ToInt32(gtritimkiem);
                        frmHome frm2 = new frmHome();
                        frm2.iduser = this.iduser;
                        frm2.loaitimkiem = "Tuổi";
                        frm2.giatritimkiem = gtritimkiem;
                        frm2.pnlTimkiemThuCung = this.panelTimKiemThuCungMain;
                        OpenChildForm(frm2);
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
                MessageBox.Show("Vui lòng kiểm tra dữ liệu nhập vào.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            panelTimKiemThuCungMain.Show();
        }


       
    }
}
