
namespace QuanLyThuCung.Views
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMainNV = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReloadNV = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTimNhanVien = new FontAwesome.Sharp.IconButton();
            this.tbTimNhanVien = new System.Windows.Forms.TextBox();
            this.cbbTimNhanVien = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.pnlDataBindNV = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.tbLuongNhanVien = new System.Windows.Forms.TextBox();
            this.tbDiaChiNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTuoiNhanVien = new System.Windows.Forms.TextBox();
            this.tbSDTNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIDNhanVien = new System.Windows.Forms.TextBox();
            this.labMaDoUong = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panelMainNV.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlDataBindNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainNV
            // 
            this.panelMainNV.Controls.Add(this.panel1);
            this.panelMainNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainNV.Location = new System.Drawing.Point(0, 0);
            this.panelMainNV.Name = "panelMainNV";
            this.panelMainNV.Size = new System.Drawing.Size(1245, 663);
            this.panelMainNV.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnReloadNV);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 663);
            this.panel1.TabIndex = 27;
            // 
            // btnReloadNV
            // 
            this.btnReloadNV.FlatAppearance.BorderSize = 0;
            this.btnReloadNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadNV.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadNV.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReloadNV.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnReloadNV.IconColor = System.Drawing.Color.Olive;
            this.btnReloadNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReloadNV.IconSize = 42;
            this.btnReloadNV.Location = new System.Drawing.Point(32, 17);
            this.btnReloadNV.Name = "btnReloadNV";
            this.btnReloadNV.Size = new System.Drawing.Size(126, 48);
            this.btnReloadNV.TabIndex = 8;
            this.btnReloadNV.Text = "Tải Lại";
            this.btnReloadNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReloadNV.UseVisualStyleBackColor = true;
            this.btnReloadNV.Click += new System.EventHandler(this.btnReloadNV_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnlDataBindNV);
            this.panel2.Location = new System.Drawing.Point(702, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 513);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.btnTimNhanVien);
            this.panel4.Controls.Add(this.tbTimNhanVien);
            this.panel4.Controls.Add(this.cbbTimNhanVien);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 66);
            this.panel4.TabIndex = 25;
            // 
            // btnTimNhanVien
            // 
            this.btnTimNhanVien.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTimNhanVien.FlatAppearance.BorderSize = 0;
            this.btnTimNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNhanVien.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTimNhanVien.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimNhanVien.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimNhanVien.IconSize = 42;
            this.btnTimNhanVien.Location = new System.Drawing.Point(344, 14);
            this.btnTimNhanVien.Name = "btnTimNhanVien";
            this.btnTimNhanVien.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnTimNhanVien.Size = new System.Drawing.Size(53, 43);
            this.btnTimNhanVien.TabIndex = 27;
            this.btnTimNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimNhanVien.UseVisualStyleBackColor = false;
            this.btnTimNhanVien.Click += new System.EventHandler(this.btnTimNhanVien_Click);
            // 
            // tbTimNhanVien
            // 
            this.tbTimNhanVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTimNhanVien.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimNhanVien.Location = new System.Drawing.Point(164, 20);
            this.tbTimNhanVien.Name = "tbTimNhanVien";
            this.tbTimNhanVien.Size = new System.Drawing.Size(161, 30);
            this.tbTimNhanVien.TabIndex = 26;
            // 
            // cbbTimNhanVien
            // 
            this.cbbTimNhanVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbbTimNhanVien.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimNhanVien.FormattingEnabled = true;
            this.cbbTimNhanVien.Items.AddRange(new object[] {
            "Tên",
            "SĐT",
            "Tuổi",
            "Lương"});
            this.cbbTimNhanVien.Location = new System.Drawing.Point(34, 19);
            this.cbbTimNhanVien.Name = "cbbTimNhanVien";
            this.cbbTimNhanVien.Size = new System.Drawing.Size(102, 31);
            this.cbbTimNhanVien.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSuaNhanVien);
            this.panel3.Controls.Add(this.btnXoaNhanVien);
            this.panel3.Controls.Add(this.btnThemNhanVien);
            this.panel3.Location = new System.Drawing.Point(52, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 78);
            this.panel3.TabIndex = 15;
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhanVien.Location = new System.Drawing.Point(120, 15);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(85, 45);
            this.btnSuaNhanVien.TabIndex = 21;
            this.btnSuaNhanVien.Text = "Sửa";
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            this.btnSuaNhanVien.Click += new System.EventHandler(this.btnSuaNhanVien_Click);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhanVien.Location = new System.Drawing.Point(220, 15);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(85, 45);
            this.btnXoaNhanVien.TabIndex = 18;
            this.btnXoaNhanVien.Text = "Xóa";
            this.btnXoaNhanVien.UseVisualStyleBackColor = true;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btnXoaNhanVien_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.Location = new System.Drawing.Point(20, 15);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(85, 45);
            this.btnThemNhanVien.TabIndex = 16;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // pnlDataBindNV
            // 
            this.pnlDataBindNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.pnlDataBindNV.Controls.Add(this.label5);
            this.pnlDataBindNV.Controls.Add(this.label4);
            this.pnlDataBindNV.Controls.Add(this.label1);
            this.pnlDataBindNV.Controls.Add(this.dtpNgayVaoLam);
            this.pnlDataBindNV.Controls.Add(this.tbLuongNhanVien);
            this.pnlDataBindNV.Controls.Add(this.tbDiaChiNhanVien);
            this.pnlDataBindNV.Controls.Add(this.label3);
            this.pnlDataBindNV.Controls.Add(this.tbTuoiNhanVien);
            this.pnlDataBindNV.Controls.Add(this.tbSDTNhanVien);
            this.pnlDataBindNV.Controls.Add(this.label2);
            this.pnlDataBindNV.Controls.Add(this.tbTenNhanVien);
            this.pnlDataBindNV.Controls.Add(this.label7);
            this.pnlDataBindNV.Controls.Add(this.tbIDNhanVien);
            this.pnlDataBindNV.Controls.Add(this.labMaDoUong);
            this.pnlDataBindNV.Location = new System.Drawing.Point(0, 61);
            this.pnlDataBindNV.Name = "pnlDataBindNV";
            this.pnlDataBindNV.Size = new System.Drawing.Size(441, 369);
            this.pnlDataBindNV.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(30, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày Vào Làm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(30, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tiền Lương:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tuổi:";
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(191, 327);
            this.dtpNgayVaoLam.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(205, 20);
            this.dtpNgayVaoLam.TabIndex = 8;
            // 
            // tbLuongNhanVien
            // 
            this.tbLuongNhanVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbLuongNhanVien.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLuongNhanVien.Location = new System.Drawing.Point(191, 275);
            this.tbLuongNhanVien.Name = "tbLuongNhanVien";
            this.tbLuongNhanVien.Size = new System.Drawing.Size(205, 30);
            this.tbLuongNhanVien.TabIndex = 6;
            // 
            // tbDiaChiNhanVien
            // 
            this.tbDiaChiNhanVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDiaChiNhanVien.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChiNhanVien.Location = new System.Drawing.Point(191, 223);
            this.tbDiaChiNhanVien.Name = "tbDiaChiNhanVien";
            this.tbDiaChiNhanVien.Size = new System.Drawing.Size(205, 30);
            this.tbDiaChiNhanVien.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(30, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa Chỉ:";
            // 
            // tbTuoiNhanVien
            // 
            this.tbTuoiNhanVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTuoiNhanVien.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTuoiNhanVien.Location = new System.Drawing.Point(191, 171);
            this.tbTuoiNhanVien.Name = "tbTuoiNhanVien";
            this.tbTuoiNhanVien.Size = new System.Drawing.Size(205, 30);
            this.tbTuoiNhanVien.TabIndex = 1;
            // 
            // tbSDTNhanVien
            // 
            this.tbSDTNhanVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSDTNhanVien.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDTNhanVien.Location = new System.Drawing.Point(191, 119);
            this.tbSDTNhanVien.Name = "tbSDTNhanVien";
            this.tbSDTNhanVien.Size = new System.Drawing.Size(205, 30);
            this.tbSDTNhanVien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "SĐT:";
            // 
            // tbTenNhanVien
            // 
            this.tbTenNhanVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTenNhanVien.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNhanVien.Location = new System.Drawing.Point(191, 67);
            this.tbTenNhanVien.Name = "tbTenNhanVien";
            this.tbTenNhanVien.Size = new System.Drawing.Size(205, 30);
            this.tbTenNhanVien.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên Nhân VIên:";
            // 
            // tbIDNhanVien
            // 
            this.tbIDNhanVien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbIDNhanVien.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDNhanVien.Location = new System.Drawing.Point(191, 15);
            this.tbIDNhanVien.Name = "tbIDNhanVien";
            this.tbIDNhanVien.Size = new System.Drawing.Size(206, 30);
            this.tbIDNhanVien.TabIndex = 1;
            // 
            // labMaDoUong
            // 
            this.labMaDoUong.AutoSize = true;
            this.labMaDoUong.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaDoUong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labMaDoUong.Location = new System.Drawing.Point(30, 20);
            this.labMaDoUong.Name = "labMaDoUong";
            this.labMaDoUong.Size = new System.Drawing.Size(33, 23);
            this.labMaDoUong.TabIndex = 0;
            this.labMaDoUong.Text = "ID:";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 83);
            this.dgvNhanVien.Name = "dgvNhanVien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVien.RowTemplate.Height = 30;
            this.dgvNhanVien.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.Size = new System.Drawing.Size(676, 495);
            this.dgvNhanVien.TabIndex = 3;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 663);
            this.Controls.Add(this.panelMainNV);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.panelMainNV.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlDataBindNV.ResumeLayout(false);
            this.pnlDataBindNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainNV;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnReloadNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnTimNhanVien;
        private System.Windows.Forms.TextBox tbTimNhanVien;
        private System.Windows.Forms.ComboBox cbbTimNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Panel pnlDataBindNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.TextBox tbLuongNhanVien;
        private System.Windows.Forms.TextBox tbDiaChiNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTuoiNhanVien;
        private System.Windows.Forms.TextBox tbSDTNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIDNhanVien;
        private System.Windows.Forms.Label labMaDoUong;
        private System.Windows.Forms.DataGridView dgvNhanVien;
    }
}