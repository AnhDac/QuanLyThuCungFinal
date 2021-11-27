
namespace QuanLyThuCung.Views
{
    partial class frmQLUser
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
            this.panelMainQLUser = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ThemUserAdmin = new System.Windows.Forms.Button();
            this.btnThemUserNV = new System.Windows.Forms.Button();
            this.btnThemUserKH = new System.Windows.Forms.Button();
            this.btnReloadUser = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTimUser = new FontAwesome.Sharp.IconButton();
            this.tbTimUser = new System.Windows.Forms.TextBox();
            this.cbbTimUser = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSuaUser = new System.Windows.Forms.Button();
            this.btnXoaUser = new System.Windows.Forms.Button();
            this.pnlDataBindUser = new System.Windows.Forms.Panel();
            this.tbPermissionUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswordUser = new System.Windows.Forms.TextBox();
            this.tbUsernameUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIDUser = new System.Windows.Forms.TextBox();
            this.labMaDoUong = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.panelMainQLUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlDataBindUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainQLUser
            // 
            this.panelMainQLUser.Controls.Add(this.panel1);
            this.panelMainQLUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainQLUser.Location = new System.Drawing.Point(0, 0);
            this.panelMainQLUser.Name = "panelMainQLUser";
            this.panelMainQLUser.Size = new System.Drawing.Size(1158, 625);
            this.panelMainQLUser.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.ThemUserAdmin);
            this.panel1.Controls.Add(this.btnThemUserNV);
            this.panel1.Controls.Add(this.btnThemUserKH);
            this.panel1.Controls.Add(this.btnReloadUser);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 625);
            this.panel1.TabIndex = 6;
            // 
            // ThemUserAdmin
            // 
            this.ThemUserAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemUserAdmin.Location = new System.Drawing.Point(990, 554);
            this.ThemUserAdmin.Name = "ThemUserAdmin";
            this.ThemUserAdmin.Size = new System.Drawing.Size(165, 48);
            this.ThemUserAdmin.TabIndex = 19;
            this.ThemUserAdmin.Text = "Thêm Quản Trị";
            this.ThemUserAdmin.UseVisualStyleBackColor = true;
            this.ThemUserAdmin.Click += new System.EventHandler(this.ThemUserAdmin_Click);
            // 
            // btnThemUserNV
            // 
            this.btnThemUserNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemUserNV.Location = new System.Drawing.Point(809, 554);
            this.btnThemUserNV.Name = "btnThemUserNV";
            this.btnThemUserNV.Size = new System.Drawing.Size(175, 48);
            this.btnThemUserNV.TabIndex = 18;
            this.btnThemUserNV.Text = "Thêm Nhân Viên";
            this.btnThemUserNV.UseVisualStyleBackColor = true;
            this.btnThemUserNV.Click += new System.EventHandler(this.btnThemUserNV_Click);
            // 
            // btnThemUserKH
            // 
            this.btnThemUserKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemUserKH.Location = new System.Drawing.Point(622, 554);
            this.btnThemUserKH.Name = "btnThemUserKH";
            this.btnThemUserKH.Size = new System.Drawing.Size(184, 48);
            this.btnThemUserKH.TabIndex = 17;
            this.btnThemUserKH.Text = "Thêm Khách Hàng";
            this.btnThemUserKH.UseVisualStyleBackColor = true;
            this.btnThemUserKH.Click += new System.EventHandler(this.btnThemUserKH_Click);
            // 
            // btnReloadUser
            // 
            this.btnReloadUser.FlatAppearance.BorderSize = 0;
            this.btnReloadUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadUser.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReloadUser.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnReloadUser.IconColor = System.Drawing.Color.Olive;
            this.btnReloadUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReloadUser.IconSize = 42;
            this.btnReloadUser.Location = new System.Drawing.Point(32, 17);
            this.btnReloadUser.Name = "btnReloadUser";
            this.btnReloadUser.Size = new System.Drawing.Size(126, 48);
            this.btnReloadUser.TabIndex = 8;
            this.btnReloadUser.Text = "Tải Lại";
            this.btnReloadUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReloadUser.UseVisualStyleBackColor = true;
            this.btnReloadUser.Click += new System.EventHandler(this.btnReloadUser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnlDataBindUser);
            this.panel2.Location = new System.Drawing.Point(637, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 513);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.btnTimUser);
            this.panel4.Controls.Add(this.tbTimUser);
            this.panel4.Controls.Add(this.cbbTimUser);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 66);
            this.panel4.TabIndex = 25;
            // 
            // btnTimUser
            // 
            this.btnTimUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTimUser.FlatAppearance.BorderSize = 0;
            this.btnTimUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTimUser.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimUser.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimUser.IconSize = 42;
            this.btnTimUser.Location = new System.Drawing.Point(381, 11);
            this.btnTimUser.Name = "btnTimUser";
            this.btnTimUser.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnTimUser.Size = new System.Drawing.Size(53, 43);
            this.btnTimUser.TabIndex = 27;
            this.btnTimUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimUser.UseVisualStyleBackColor = false;
            this.btnTimUser.Click += new System.EventHandler(this.btnTimUser_Click);
            // 
            // tbTimUser
            // 
            this.tbTimUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTimUser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimUser.Location = new System.Drawing.Point(191, 19);
            this.tbTimUser.Name = "tbTimUser";
            this.tbTimUser.Size = new System.Drawing.Size(161, 30);
            this.tbTimUser.TabIndex = 26;
            // 
            // cbbTimUser
            // 
            this.cbbTimUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbbTimUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimUser.FormattingEnabled = true;
            this.cbbTimUser.Items.AddRange(new object[] {
            "Tên",
            "Tên Tài Khoản"});
            this.cbbTimUser.Location = new System.Drawing.Point(15, 19);
            this.cbbTimUser.Name = "cbbTimUser";
            this.cbbTimUser.Size = new System.Drawing.Size(142, 31);
            this.cbbTimUser.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSuaUser);
            this.panel3.Controls.Add(this.btnXoaUser);
            this.panel3.Location = new System.Drawing.Point(134, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 75);
            this.panel3.TabIndex = 15;
            // 
            // btnSuaUser
            // 
            this.btnSuaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaUser.Location = new System.Drawing.Point(19, 15);
            this.btnSuaUser.Name = "btnSuaUser";
            this.btnSuaUser.Size = new System.Drawing.Size(85, 45);
            this.btnSuaUser.TabIndex = 21;
            this.btnSuaUser.Text = "Sửa";
            this.btnSuaUser.UseVisualStyleBackColor = true;
            this.btnSuaUser.Click += new System.EventHandler(this.btnSuaUser_Click);
            // 
            // btnXoaUser
            // 
            this.btnXoaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaUser.Location = new System.Drawing.Point(119, 15);
            this.btnXoaUser.Name = "btnXoaUser";
            this.btnXoaUser.Size = new System.Drawing.Size(85, 45);
            this.btnXoaUser.TabIndex = 18;
            this.btnXoaUser.Text = "Xóa";
            this.btnXoaUser.UseVisualStyleBackColor = true;
            this.btnXoaUser.Click += new System.EventHandler(this.btnXoaUser_Click);
            // 
            // pnlDataBindUser
            // 
            this.pnlDataBindUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.pnlDataBindUser.Controls.Add(this.tbPermissionUser);
            this.pnlDataBindUser.Controls.Add(this.label3);
            this.pnlDataBindUser.Controls.Add(this.label1);
            this.pnlDataBindUser.Controls.Add(this.tbPasswordUser);
            this.pnlDataBindUser.Controls.Add(this.tbUsernameUser);
            this.pnlDataBindUser.Controls.Add(this.label2);
            this.pnlDataBindUser.Controls.Add(this.tbTenUser);
            this.pnlDataBindUser.Controls.Add(this.label7);
            this.pnlDataBindUser.Controls.Add(this.tbIDUser);
            this.pnlDataBindUser.Controls.Add(this.labMaDoUong);
            this.pnlDataBindUser.Location = new System.Drawing.Point(0, 122);
            this.pnlDataBindUser.Name = "pnlDataBindUser";
            this.pnlDataBindUser.Size = new System.Drawing.Size(492, 308);
            this.pnlDataBindUser.TabIndex = 9;
            // 
            // tbPermissionUser
            // 
            this.tbPermissionUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPermissionUser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPermissionUser.Location = new System.Drawing.Point(192, 241);
            this.tbPermissionUser.Name = "tbPermissionUser";
            this.tbPermissionUser.Size = new System.Drawing.Size(205, 30);
            this.tbPermissionUser.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(11, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại Người Dùng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật Khẩu:";
            // 
            // tbPasswordUser
            // 
            this.tbPasswordUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPasswordUser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordUser.Location = new System.Drawing.Point(191, 186);
            this.tbPasswordUser.Name = "tbPasswordUser";
            this.tbPasswordUser.Size = new System.Drawing.Size(205, 30);
            this.tbPasswordUser.TabIndex = 1;
            // 
            // tbUsernameUser
            // 
            this.tbUsernameUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbUsernameUser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameUser.Location = new System.Drawing.Point(191, 128);
            this.tbUsernameUser.Name = "tbUsernameUser";
            this.tbUsernameUser.Size = new System.Drawing.Size(205, 30);
            this.tbUsernameUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Tài Khoản:";
            // 
            // tbTenUser
            // 
            this.tbTenUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTenUser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenUser.Location = new System.Drawing.Point(191, 72);
            this.tbTenUser.Name = "tbTenUser";
            this.tbTenUser.Size = new System.Drawing.Size(205, 30);
            this.tbTenUser.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(30, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên:";
            // 
            // tbIDUser
            // 
            this.tbIDUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbIDUser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDUser.Location = new System.Drawing.Point(191, 15);
            this.tbIDUser.Name = "tbIDUser";
            this.tbIDUser.Size = new System.Drawing.Size(206, 30);
            this.tbIDUser.TabIndex = 1;
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
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.Location = new System.Drawing.Point(32, 83);
            this.dgvUser.Name = "dgvUser";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUser.RowTemplate.Height = 30;
            this.dgvUser.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.Size = new System.Drawing.Size(574, 519);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // frmQLUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 625);
            this.Controls.Add(this.panelMainQLUser);
            this.Name = "frmQLUser";
            this.Text = "frmQLUser";
            this.Load += new System.EventHandler(this.frmQLUser_Load);
            this.panelMainQLUser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlDataBindUser.ResumeLayout(false);
            this.pnlDataBindUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainQLUser;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnReloadUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnTimUser;
        private System.Windows.Forms.TextBox tbTimUser;
        private System.Windows.Forms.ComboBox cbbTimUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSuaUser;
        private System.Windows.Forms.Button btnXoaUser;
        private System.Windows.Forms.Panel pnlDataBindUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswordUser;
        private System.Windows.Forms.TextBox tbUsernameUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIDUser;
        private System.Windows.Forms.Label labMaDoUong;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button ThemUserAdmin;
        private System.Windows.Forms.Button btnThemUserNV;
        private System.Windows.Forms.Button btnThemUserKH;
        private System.Windows.Forms.TextBox tbPermissionUser;
    }
}