using FontAwesome.Sharp;
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
    public partial class frmHome : Form
    {
        public int iduser;
        public string loaitimkiem;
        public string giatritimkiem;
        public Panel pnlTimkiemThuCung;

        ThuCungEntities db = new ThuCungEntities();
        private Form currentChildForm;
        Controller ctrl = new Controller();

        public frmHome()
        {
            InitializeComponent();
            loaitimkiem = "";
            pnlTimkiemThuCung = new Panel();
        }


        private void frmHome_Load(object sender, EventArgs e)
        {
            List<Pet> Pets = new List<Pet>();
            Pets = ctrl.LayDanhSachThuCungTheoTimKiem(this.loaitimkiem, this.giatritimkiem);
            LoadDanhSachThuCung(Pets);   
        }
        private void LoadDanhSachThuCung(List<Pet> Pets)
        {
            int count = 0;

            foreach (Pet pet in Pets)
            {
                count++;
                #region Create button
                IconButton btn = new IconButton();
                //btn.Text = "Thú Cưng " + count;
                btn.Text = count + " " + db.Species.Find(pet.ID_Spec).Name;

                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                btn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.Color.Navy;
                List<Bitmap> bm = new List<Bitmap>();
                bm.Add(Properties.Resources.ThuCungResixe);

                btn.Image = bm[0];
                btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btn.Location = new System.Drawing.Point(147, 5);
                btn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
                btn.Size = new System.Drawing.Size(155, 159);
                btn.TabIndex = 4;
                btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btn.UseVisualStyleBackColor = true;
                btn.BackColor = System.Drawing.Color.AntiqueWhite;


                btn.Click += (sender, args) =>
                {
                    frmChiTietThuCung frm = new frmChiTietThuCung(pet);
                    frm.iduser = this.iduser;
                    frm.pnlTimKiemThuCung = pnlTimkiemThuCung;
                    OpenChildForm(frm);
                    pnlTimkiemThuCung.Hide();
                };
                #endregion

                panelFormHome.Controls.Add(btn);

            }
            Panel pnlfooter = new Panel();
            pnlfooter.Size = new System.Drawing.Size(2, 190);
            panelFormHome.Controls.Add(pnlfooter);

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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}
