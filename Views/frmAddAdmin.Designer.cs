
namespace QuanLyThuCung.Views
{
    partial class frmAddAdmin
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnLưu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tbTenUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsernameUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswordUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDataBind = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlDataBind.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label3.Location = new System.Drawing.Point(161, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Thêm Quản Trị";
            // 
            // btnLưu
            // 
            this.btnLưu.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLưu.Location = new System.Drawing.Point(423, 386);
            this.btnLưu.Name = "btnLưu";
            this.btnLưu.Size = new System.Drawing.Size(92, 43);
            this.btnLưu.TabIndex = 16;
            this.btnLưu.Text = "Lưu";
            this.btnLưu.UseVisualStyleBackColor = true;
            this.btnLưu.Click += new System.EventHandler(this.btnLưu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(306, 386);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 43);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tbTenUser
            // 
            this.tbTenUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTenUser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenUser.Location = new System.Drawing.Point(247, 157);
            this.tbTenUser.Name = "tbTenUser";
            this.tbTenUser.Size = new System.Drawing.Size(134, 30);
            this.tbTenUser.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(151, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên:";
            // 
            // tbUsernameUser
            // 
            this.tbUsernameUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbUsernameUser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameUser.Location = new System.Drawing.Point(247, 213);
            this.tbUsernameUser.Name = "tbUsernameUser";
            this.tbUsernameUser.Size = new System.Drawing.Size(134, 30);
            this.tbUsernameUser.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(96, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            // 
            // tbPasswordUser
            // 
            this.tbPasswordUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPasswordUser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordUser.Location = new System.Drawing.Point(247, 272);
            this.tbPasswordUser.Name = "tbPasswordUser";
            this.tbPasswordUser.Size = new System.Drawing.Size(134, 30);
            this.tbPasswordUser.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(89, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlDataBind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 586);
            this.panel1.TabIndex = 1;
            // 
            // pnlDataBind
            // 
            this.pnlDataBind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.pnlDataBind.Controls.Add(this.label3);
            this.pnlDataBind.Controls.Add(this.btnLưu);
            this.pnlDataBind.Controls.Add(this.btnHuy);
            this.pnlDataBind.Controls.Add(this.tbTenUser);
            this.pnlDataBind.Controls.Add(this.label2);
            this.pnlDataBind.Controls.Add(this.tbUsernameUser);
            this.pnlDataBind.Controls.Add(this.label1);
            this.pnlDataBind.Controls.Add(this.tbPasswordUser);
            this.pnlDataBind.Controls.Add(this.label6);
            this.pnlDataBind.Location = new System.Drawing.Point(271, 34);
            this.pnlDataBind.Name = "pnlDataBind";
            this.pnlDataBind.Size = new System.Drawing.Size(579, 475);
            this.pnlDataBind.TabIndex = 11;
            // 
            // frmAddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 586);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddAdmin";
            this.Text = "frmAddAdmin";
            this.panel1.ResumeLayout(false);
            this.pnlDataBind.ResumeLayout(false);
            this.pnlDataBind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLưu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox tbTenUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsernameUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswordUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDataBind;
    }
}