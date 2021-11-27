
namespace QuanLyThuCung.Views
{
    partial class frmKhachHang
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
            this.panelMainKH = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReloadKH = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTimKhachHang = new FontAwesome.Sharp.IconButton();
            this.tbTimKhachHang = new System.Windows.Forms.TextBox();
            this.cbbTimKhachHang = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSuaKhachHang = new System.Windows.Forms.Button();
            this.btnXoaKhachHang = new System.Windows.Forms.Button();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.pnlDataBindKH = new System.Windows.Forms.Panel();
            this.tbTuoiKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSDTKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenKhachHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIDKhachHang = new System.Windows.Forms.TextBox();
            this.labMaDoUong = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panelMainKH.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlDataBindKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainKH
            // 
            this.panelMainKH.Controls.Add(this.panel1);
            this.panelMainKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainKH.Location = new System.Drawing.Point(0, 0);
            this.panelMainKH.Name = "panelMainKH";
            this.panelMainKH.Size = new System.Drawing.Size(1219, 625);
            this.panelMainKH.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnReloadKH);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 625);
            this.panel1.TabIndex = 27;
            // 
            // btnReloadKH
            // 
            this.btnReloadKH.FlatAppearance.BorderSize = 0;
            this.btnReloadKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadKH.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadKH.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReloadKH.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnReloadKH.IconColor = System.Drawing.Color.Olive;
            this.btnReloadKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReloadKH.IconSize = 42;
            this.btnReloadKH.Location = new System.Drawing.Point(32, 17);
            this.btnReloadKH.Name = "btnReloadKH";
            this.btnReloadKH.Size = new System.Drawing.Size(126, 48);
            this.btnReloadKH.TabIndex = 8;
            this.btnReloadKH.Text = "Tải Lại";
            this.btnReloadKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReloadKH.UseVisualStyleBackColor = true;
            this.btnReloadKH.Click += new System.EventHandler(this.btnReloadKH_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnlDataBindKH);
            this.panel2.Location = new System.Drawing.Point(702, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 513);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.btnTimKhachHang);
            this.panel4.Controls.Add(this.tbTimKhachHang);
            this.panel4.Controls.Add(this.cbbTimKhachHang);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 66);
            this.panel4.TabIndex = 25;
            // 
            // btnTimKhachHang
            // 
            this.btnTimKhachHang.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTimKhachHang.FlatAppearance.BorderSize = 0;
            this.btnTimKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKhachHang.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTimKhachHang.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKhachHang.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKhachHang.IconSize = 42;
            this.btnTimKhachHang.Location = new System.Drawing.Point(381, 11);
            this.btnTimKhachHang.Name = "btnTimKhachHang";
            this.btnTimKhachHang.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnTimKhachHang.Size = new System.Drawing.Size(53, 43);
            this.btnTimKhachHang.TabIndex = 27;
            this.btnTimKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKhachHang.UseVisualStyleBackColor = false;
            this.btnTimKhachHang.Click += new System.EventHandler(this.btnTimKhachHang_Click);
            // 
            // tbTimKhachHang
            // 
            this.tbTimKhachHang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTimKhachHang.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKhachHang.Location = new System.Drawing.Point(191, 19);
            this.tbTimKhachHang.Name = "tbTimKhachHang";
            this.tbTimKhachHang.Size = new System.Drawing.Size(161, 30);
            this.tbTimKhachHang.TabIndex = 26;
            // 
            // cbbTimKhachHang
            // 
            this.cbbTimKhachHang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbbTimKhachHang.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimKhachHang.FormattingEnabled = true;
            this.cbbTimKhachHang.Items.AddRange(new object[] {
            "Tên",
            "Tuổi",
            "SĐT"});
            this.cbbTimKhachHang.Location = new System.Drawing.Point(43, 19);
            this.cbbTimKhachHang.Name = "cbbTimKhachHang";
            this.cbbTimKhachHang.Size = new System.Drawing.Size(102, 31);
            this.cbbTimKhachHang.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSuaKhachHang);
            this.panel3.Controls.Add(this.btnXoaKhachHang);
            this.panel3.Controls.Add(this.btnThemKhachHang);
            this.panel3.Location = new System.Drawing.Point(69, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 78);
            this.panel3.TabIndex = 15;
            // 
            // btnSuaKhachHang
            // 
            this.btnSuaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKhachHang.Location = new System.Drawing.Point(120, 15);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.Size = new System.Drawing.Size(85, 45);
            this.btnSuaKhachHang.TabIndex = 21;
            this.btnSuaKhachHang.Text = "Sửa";
            this.btnSuaKhachHang.UseVisualStyleBackColor = true;
            this.btnSuaKhachHang.Click += new System.EventHandler(this.btnSuaKhachHang_Click);
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhachHang.Location = new System.Drawing.Point(220, 15);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.Size = new System.Drawing.Size(85, 45);
            this.btnXoaKhachHang.TabIndex = 18;
            this.btnXoaKhachHang.Text = "Xóa";
            this.btnXoaKhachHang.UseVisualStyleBackColor = true;
            this.btnXoaKhachHang.Click += new System.EventHandler(this.btnXoaKhachHang_Click);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.Location = new System.Drawing.Point(20, 15);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(85, 45);
            this.btnThemKhachHang.TabIndex = 16;
            this.btnThemKhachHang.Text = "Thêm";
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // pnlDataBindKH
            // 
            this.pnlDataBindKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.pnlDataBindKH.Controls.Add(this.tbTuoiKhachHang);
            this.pnlDataBindKH.Controls.Add(this.label4);
            this.pnlDataBindKH.Controls.Add(this.tbSDTKhachHang);
            this.pnlDataBindKH.Controls.Add(this.label2);
            this.pnlDataBindKH.Controls.Add(this.tbTenKhachHang);
            this.pnlDataBindKH.Controls.Add(this.label7);
            this.pnlDataBindKH.Controls.Add(this.tbIDKhachHang);
            this.pnlDataBindKH.Controls.Add(this.labMaDoUong);
            this.pnlDataBindKH.Location = new System.Drawing.Point(0, 122);
            this.pnlDataBindKH.Name = "pnlDataBindKH";
            this.pnlDataBindKH.Size = new System.Drawing.Size(464, 308);
            this.pnlDataBindKH.TabIndex = 9;
            // 
            // tbTuoiKhachHang
            // 
            this.tbTuoiKhachHang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTuoiKhachHang.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTuoiKhachHang.Location = new System.Drawing.Point(218, 186);
            this.tbTuoiKhachHang.Name = "tbTuoiKhachHang";
            this.tbTuoiKhachHang.Size = new System.Drawing.Size(205, 30);
            this.tbTuoiKhachHang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(30, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tuổi:";
            // 
            // tbSDTKhachHang
            // 
            this.tbSDTKhachHang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSDTKhachHang.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDTKhachHang.Location = new System.Drawing.Point(217, 130);
            this.tbSDTKhachHang.Name = "tbSDTKhachHang";
            this.tbSDTKhachHang.Size = new System.Drawing.Size(205, 30);
            this.tbSDTKhachHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "SĐT:";
            // 
            // tbTenKhachHang
            // 
            this.tbTenKhachHang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTenKhachHang.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKhachHang.Location = new System.Drawing.Point(218, 67);
            this.tbTenKhachHang.Name = "tbTenKhachHang";
            this.tbTenKhachHang.Size = new System.Drawing.Size(205, 30);
            this.tbTenKhachHang.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên Khách Hàng:";
            // 
            // tbIDKhachHang
            // 
            this.tbIDKhachHang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbIDKhachHang.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDKhachHang.Location = new System.Drawing.Point(217, 14);
            this.tbIDKhachHang.Name = "tbIDKhachHang";
            this.tbIDKhachHang.Size = new System.Drawing.Size(206, 30);
            this.tbIDKhachHang.TabIndex = 1;
            // 
            // labMaDoUong
            // 
            this.labMaDoUong.AutoSize = true;
            this.labMaDoUong.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaDoUong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labMaDoUong.Location = new System.Drawing.Point(30, 17);
            this.labMaDoUong.Name = "labMaDoUong";
            this.labMaDoUong.Size = new System.Drawing.Size(33, 23);
            this.labMaDoUong.TabIndex = 0;
            this.labMaDoUong.Text = "ID:";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 83);
            this.dgvKhachHang.Name = "dgvKhachHang";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.dgvKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKhachHang.RowTemplate.Height = 30;
            this.dgvKhachHang.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.Size = new System.Drawing.Size(645, 459);
            this.dgvKhachHang.TabIndex = 3;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 625);
            this.Controls.Add(this.panelMainKH);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.panelMainKH.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlDataBindKH.ResumeLayout(false);
            this.pnlDataBindKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMainKH;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnReloadKH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnTimKhachHang;
        private System.Windows.Forms.TextBox tbTimKhachHang;
        private System.Windows.Forms.ComboBox cbbTimKhachHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSuaKhachHang;
        private System.Windows.Forms.Button btnXoaKhachHang;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Panel pnlDataBindKH;
        private System.Windows.Forms.TextBox tbTuoiKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSDTKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIDKhachHang;
        private System.Windows.Forms.Label labMaDoUong;
        private System.Windows.Forms.DataGridView dgvKhachHang;
    }
}