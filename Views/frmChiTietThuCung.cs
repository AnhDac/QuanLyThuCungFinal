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
    public partial class frmChiTietThuCung : Form
    {
        public int iduser;
        public Panel pnlTimKiemThuCung;
        private Form currentChildForm;
        private Pet pet;
        

        ThuCungEntities db = new ThuCungEntities();
        Controller ctrl = new Controller();

        public frmChiTietThuCung()
        {
            InitializeComponent();
        }
        public frmChiTietThuCung(Pet pet)
        {
            InitializeComponent();
            this.pet = pet;
        }

        private void frmChiTietThuCung_Load(object sender, EventArgs e)
        {
            txtIDChiTietThuCung.Text = pet.ID_Pet.ToString();
            txtLoaiChiTietThuCung.Text = db.Species.Find(pet.ID_Spec).Name;
            txtNCCChiTietThuCung.Text = db.Suppliers.Find(pet.ID_Sup).Name;
            txtCanNangChiTietThuCung.Text = pet.Weight+"";
            txtTuoiChiTietThuCung.Text = pet.Age + "";
            txtGenderChiTietThuCung.Text = pet.Sex;
            PhanQuyen();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            pnlTimKiemThuCung.Show();
            this.Close();
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            frmMuaThuCung frm = new frmMuaThuCung();
            frm.btnMua = this.btnMua;
            frm.idpet = pet.ID_Pet;
            frm.iduser = this.iduser;
            frm.pricepet =(int) pet.PriceImport;
            frm.loaithucung = db.Species.Find(pet.ID_Spec).Name;
            OpenChildForm(frm);
        }

        void PhanQuyen()
        {
            string permiss = "";
            permiss = ctrl.getPermissUser(this.iduser);
            if(permiss != "customer")
            {
                btnMua.Hide();
            }
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
            panelMainChiTietThuCung.Controls.Add(childForm);
            pnlChiTietThuCung.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
