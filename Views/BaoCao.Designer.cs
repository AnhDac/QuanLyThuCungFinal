
namespace QuanLyThuCung.Views
{
    partial class BaoCao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabBanThuCung = new System.Windows.Forms.TabControl();
            this.tabBaoCaoDV = new System.Windows.Forms.TabPage();
            this.btnExportDV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSoGiaoDichContractSer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotalMoneyContractSer = new System.Windows.Forms.TextBox();
            this.btnShowContractSer = new System.Windows.Forms.Button();
            this.cbNamContractSer = new System.Windows.Forms.ComboBox();
            this.cbThangContractSer = new System.Windows.Forms.ComboBox();
            this.dgvBCDV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExportBTC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoGiaoDichContractSell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProfitContractSell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotalMoneyTransContractSell = new System.Windows.Forms.TextBox();
            this.btnShowContractSell = new System.Windows.Forms.Button();
            this.cbNamBCContractSell = new System.Windows.Forms.ComboBox();
            this.cbThangBCContractSell = new System.Windows.Forms.ComboBox();
            this.dgvBCSell = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.chartBCDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHienChart = new System.Windows.Forms.Button();
            this.cbBCChart = new System.Windows.Forms.ComboBox();
            this.radioBaoCaoChartTheoQuy = new System.Windows.Forms.RadioButton();
            this.radioBaoCaoChartTheoThang = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.tbProfitContracSer = new System.Windows.Forms.TextBox();
            this.tabBanThuCung.SuspendLayout();
            this.tabBaoCaoDV.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCDV)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCSell)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBCDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBanThuCung
            // 
            this.tabBanThuCung.Controls.Add(this.tabBaoCaoDV);
            this.tabBanThuCung.Controls.Add(this.tabPage2);
            this.tabBanThuCung.Controls.Add(this.tabPage1);
            this.tabBanThuCung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBanThuCung.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBanThuCung.Location = new System.Drawing.Point(0, 0);
            this.tabBanThuCung.Name = "tabBanThuCung";
            this.tabBanThuCung.Padding = new System.Drawing.Point(60, 5);
            this.tabBanThuCung.SelectedIndex = 0;
            this.tabBanThuCung.Size = new System.Drawing.Size(1101, 617);
            this.tabBanThuCung.TabIndex = 0;
            this.tabBanThuCung.Click += new System.EventHandler(this.tabBanThuCung_Click);
            // 
            // tabBaoCaoDV
            // 
            this.tabBaoCaoDV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabBaoCaoDV.Controls.Add(this.btnExportDV);
            this.tabBaoCaoDV.Controls.Add(this.panel2);
            this.tabBaoCaoDV.Controls.Add(this.dgvBCDV);
            this.tabBaoCaoDV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabBaoCaoDV.Location = new System.Drawing.Point(4, 34);
            this.tabBaoCaoDV.Name = "tabBaoCaoDV";
            this.tabBaoCaoDV.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaoCaoDV.Size = new System.Drawing.Size(1093, 579);
            this.tabBaoCaoDV.TabIndex = 0;
            this.tabBaoCaoDV.Text = "Dịch Vụ";
            // 
            // btnExportDV
            // 
            this.btnExportDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportDV.Location = new System.Drawing.Point(907, 15);
            this.btnExportDV.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportDV.Name = "btnExportDV";
            this.btnExportDV.Size = new System.Drawing.Size(169, 48);
            this.btnExportDV.TabIndex = 9;
            this.btnExportDV.Text = "Xuất Ra Excel";
            this.btnExportDV.UseVisualStyleBackColor = true;
            this.btnExportDV.Click += new System.EventHandler(this.btnExportDV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbProfitContracSer);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbSoGiaoDichContractSer);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbTotalMoneyContractSer);
            this.panel2.Controls.Add(this.btnShowContractSer);
            this.panel2.Controls.Add(this.cbNamContractSer);
            this.panel2.Controls.Add(this.cbThangContractSer);
            this.panel2.Location = new System.Drawing.Point(751, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 402);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Chọn Tháng:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Số Giao Dịch:";
            // 
            // tbSoGiaoDichContractSer
            // 
            this.tbSoGiaoDichContractSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoGiaoDichContractSer.Location = new System.Drawing.Point(173, 141);
            this.tbSoGiaoDichContractSer.Name = "tbSoGiaoDichContractSer";
            this.tbSoGiaoDichContractSer.Size = new System.Drawing.Size(100, 26);
            this.tbSoGiaoDichContractSer.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tổng Giá Trị Giao Dịch:";
            // 
            // tbTotalMoneyContractSer
            // 
            this.tbTotalMoneyContractSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalMoneyContractSer.Location = new System.Drawing.Point(173, 242);
            this.tbTotalMoneyContractSer.Name = "tbTotalMoneyContractSer";
            this.tbTotalMoneyContractSer.Size = new System.Drawing.Size(100, 26);
            this.tbTotalMoneyContractSer.TabIndex = 28;
            // 
            // btnShowContractSer
            // 
            this.btnShowContractSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowContractSer.Location = new System.Drawing.Point(107, 355);
            this.btnShowContractSer.Name = "btnShowContractSer";
            this.btnShowContractSer.Size = new System.Drawing.Size(95, 35);
            this.btnShowContractSer.TabIndex = 27;
            this.btnShowContractSer.Text = "Lọc";
            this.btnShowContractSer.UseVisualStyleBackColor = true;
            this.btnShowContractSer.Click += new System.EventHandler(this.btnShowContractSer_Click);
            // 
            // cbNamContractSer
            // 
            this.cbNamContractSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamContractSer.FormattingEnabled = true;
            this.cbNamContractSer.Location = new System.Drawing.Point(199, 56);
            this.cbNamContractSer.Name = "cbNamContractSer";
            this.cbNamContractSer.Size = new System.Drawing.Size(89, 28);
            this.cbNamContractSer.TabIndex = 26;
            // 
            // cbThangContractSer
            // 
            this.cbThangContractSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThangContractSer.FormattingEnabled = true;
            this.cbThangContractSer.Location = new System.Drawing.Point(107, 56);
            this.cbThangContractSer.Name = "cbThangContractSer";
            this.cbThangContractSer.Size = new System.Drawing.Size(68, 28);
            this.cbThangContractSer.TabIndex = 25;
            // 
            // dgvBCDV
            // 
            this.dgvBCDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBCDV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvBCDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBCDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvBCDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBCDV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBCDV.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBCDV.Location = new System.Drawing.Point(19, 83);
            this.dgvBCDV.Name = "dgvBCDV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBCDV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBCDV.RowHeadersVisible = false;
            this.dgvBCDV.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.dgvBCDV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBCDV.RowTemplate.Height = 30;
            this.dgvBCDV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBCDV.Size = new System.Drawing.Size(693, 468);
            this.dgvBCDV.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.btnExportBTC);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dgvBCSell);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1093, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bán Thú Cưng";
            // 
            // btnExportBTC
            // 
            this.btnExportBTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportBTC.Location = new System.Drawing.Point(940, 20);
            this.btnExportBTC.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportBTC.Name = "btnExportBTC";
            this.btnExportBTC.Size = new System.Drawing.Size(143, 48);
            this.btnExportBTC.TabIndex = 10;
            this.btnExportBTC.Text = "Xuất Ra Excel";
            this.btnExportBTC.UseVisualStyleBackColor = true;
            this.btnExportBTC.Click += new System.EventHandler(this.btnExportBTC_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbSoGiaoDichContractSell);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbProfitContractSell);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbTotalMoneyTransContractSell);
            this.panel1.Controls.Add(this.btnShowContractSell);
            this.panel1.Controls.Add(this.cbNamBCContractSell);
            this.panel1.Controls.Add(this.cbThangBCContractSell);
            this.panel1.Location = new System.Drawing.Point(773, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 418);
            this.panel1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Chọn Tháng:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Số Giao Dịch:";
            // 
            // tbSoGiaoDichContractSell
            // 
            this.tbSoGiaoDichContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoGiaoDichContractSell.Location = new System.Drawing.Point(137, 143);
            this.tbSoGiaoDichContractSell.Name = "tbSoGiaoDichContractSell";
            this.tbSoGiaoDichContractSell.Size = new System.Drawing.Size(100, 26);
            this.tbSoGiaoDichContractSell.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Lợi Nhuận:";
            // 
            // tbProfitContractSell
            // 
            this.tbProfitContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfitContractSell.Location = new System.Drawing.Point(137, 298);
            this.tbProfitContractSell.Name = "tbProfitContractSell";
            this.tbProfitContractSell.Size = new System.Drawing.Size(100, 26);
            this.tbProfitContractSell.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tổng Giá Trị Giao Dịch:";
            // 
            // tbTotalMoneyTransContractSell
            // 
            this.tbTotalMoneyTransContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalMoneyTransContractSell.Location = new System.Drawing.Point(137, 235);
            this.tbTotalMoneyTransContractSell.Name = "tbTotalMoneyTransContractSell";
            this.tbTotalMoneyTransContractSell.Size = new System.Drawing.Size(100, 26);
            this.tbTotalMoneyTransContractSell.TabIndex = 18;
            // 
            // btnShowContractSell
            // 
            this.btnShowContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowContractSell.Location = new System.Drawing.Point(100, 352);
            this.btnShowContractSell.Name = "btnShowContractSell";
            this.btnShowContractSell.Size = new System.Drawing.Size(114, 43);
            this.btnShowContractSell.TabIndex = 17;
            this.btnShowContractSell.Text = "Lọc";
            this.btnShowContractSell.UseVisualStyleBackColor = true;
            this.btnShowContractSell.Click += new System.EventHandler(this.btnShowContractSell_Click);
            // 
            // cbNamBCContractSell
            // 
            this.cbNamBCContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamBCContractSell.FormattingEnabled = true;
            this.cbNamBCContractSell.Location = new System.Drawing.Point(167, 67);
            this.cbNamBCContractSell.Name = "cbNamBCContractSell";
            this.cbNamBCContractSell.Size = new System.Drawing.Size(89, 28);
            this.cbNamBCContractSell.TabIndex = 16;
            // 
            // cbThangBCContractSell
            // 
            this.cbThangBCContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThangBCContractSell.FormattingEnabled = true;
            this.cbThangBCContractSell.Location = new System.Drawing.Point(75, 67);
            this.cbThangBCContractSell.Name = "cbThangBCContractSell";
            this.cbThangBCContractSell.Size = new System.Drawing.Size(68, 28);
            this.cbThangBCContractSell.TabIndex = 15;
            // 
            // dgvBCSell
            // 
            this.dgvBCSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBCSell.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvBCSell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBCSell.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvBCSell.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBCSell.ColumnHeadersHeight = 40;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBCSell.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBCSell.Location = new System.Drawing.Point(3, 83);
            this.dgvBCSell.Name = "dgvBCSell";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBCSell.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBCSell.RowHeadersVisible = false;
            this.dgvBCSell.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.dgvBCSell.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBCSell.RowTemplate.Height = 30;
            this.dgvBCSell.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBCSell.Size = new System.Drawing.Size(764, 418);
            this.dgvBCSell.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioBaoCaoChartTheoThang);
            this.tabPage1.Controls.Add(this.radioBaoCaoChartTheoQuy);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.chartBCDoanhThu);
            this.tabPage1.Controls.Add(this.btnHienChart);
            this.tabPage1.Controls.Add(this.cbBCChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 579);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Thống Kê";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 35);
            this.label8.TabIndex = 33;
            this.label8.Text = "Báo Cáo Doanh Thu";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // chartBCDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBCDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBCDoanhThu.Legends.Add(legend1);
            this.chartBCDoanhThu.Location = new System.Drawing.Point(26, 77);
            this.chartBCDoanhThu.Name = "chartBCDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.chartBCDoanhThu.Series.Add(series1);
            this.chartBCDoanhThu.Size = new System.Drawing.Size(847, 484);
            this.chartBCDoanhThu.TabIndex = 19;
            this.chartBCDoanhThu.Text = "chart1";
            this.chartBCDoanhThu.UseWaitCursor = true;
            // 
            // btnHienChart
            // 
            this.btnHienChart.Location = new System.Drawing.Point(942, 101);
            this.btnHienChart.Name = "btnHienChart";
            this.btnHienChart.Size = new System.Drawing.Size(108, 39);
            this.btnHienChart.TabIndex = 18;
            this.btnHienChart.Text = "Hiện";
            this.btnHienChart.UseVisualStyleBackColor = true;
            this.btnHienChart.Click += new System.EventHandler(this.btnHienChart_Click);
            // 
            // cbBCChart
            // 
            this.cbBCChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBCChart.FormattingEnabled = true;
            this.cbBCChart.Location = new System.Drawing.Point(951, 34);
            this.cbBCChart.Name = "cbBCChart";
            this.cbBCChart.Size = new System.Drawing.Size(89, 28);
            this.cbBCChart.TabIndex = 17;
            // 
            // radioBaoCaoChartTheoQuy
            // 
            this.radioBaoCaoChartTheoQuy.AutoSize = true;
            this.radioBaoCaoChartTheoQuy.Location = new System.Drawing.Point(755, 37);
            this.radioBaoCaoChartTheoQuy.Name = "radioBaoCaoChartTheoQuy";
            this.radioBaoCaoChartTheoQuy.Size = new System.Drawing.Size(60, 25);
            this.radioBaoCaoChartTheoQuy.TabIndex = 34;
            this.radioBaoCaoChartTheoQuy.Text = "Quý";
            this.radioBaoCaoChartTheoQuy.UseVisualStyleBackColor = true;
            // 
            // radioBaoCaoChartTheoThang
            // 
            this.radioBaoCaoChartTheoThang.AutoSize = true;
            this.radioBaoCaoChartTheoThang.Checked = true;
            this.radioBaoCaoChartTheoThang.Location = new System.Drawing.Point(831, 37);
            this.radioBaoCaoChartTheoThang.Name = "radioBaoCaoChartTheoThang";
            this.radioBaoCaoChartTheoThang.Size = new System.Drawing.Size(78, 25);
            this.radioBaoCaoChartTheoThang.TabIndex = 35;
            this.radioBaoCaoChartTheoThang.TabStop = true;
            this.radioBaoCaoChartTheoThang.Text = "Tháng";
            this.radioBaoCaoChartTheoThang.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Lợi Nhuận:";
            // 
            // tbProfitContracSer
            // 
            this.tbProfitContracSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfitContracSer.Location = new System.Drawing.Point(170, 307);
            this.tbProfitContracSer.Name = "tbProfitContracSer";
            this.tbProfitContracSer.Size = new System.Drawing.Size(100, 26);
            this.tbProfitContracSer.TabIndex = 33;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 617);
            this.Controls.Add(this.tabBanThuCung);
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            this.tabBanThuCung.ResumeLayout(false);
            this.tabBaoCaoDV.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCDV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCSell)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBCDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBanThuCung;
        private System.Windows.Forms.TabPage tabBaoCaoDV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoGiaoDichContractSell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProfitContractSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotalMoneyTransContractSell;
        private System.Windows.Forms.Button btnShowContractSell;
        private System.Windows.Forms.ComboBox cbNamBCContractSell;
        private System.Windows.Forms.ComboBox cbThangBCContractSell;
        private System.Windows.Forms.DataGridView dgvBCSell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSoGiaoDichContractSer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotalMoneyContractSer;
        private System.Windows.Forms.Button btnShowContractSer;
        private System.Windows.Forms.ComboBox cbNamContractSer;
        private System.Windows.Forms.ComboBox cbThangContractSer;
        private System.Windows.Forms.DataGridView dgvBCDV;
        private System.Windows.Forms.Button btnExportDV;
        private System.Windows.Forms.Button btnExportBTC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnHienChart;
        private System.Windows.Forms.ComboBox cbBCChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBCDoanhThu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioBaoCaoChartTheoThang;
        private System.Windows.Forms.RadioButton radioBaoCaoChartTheoQuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbProfitContracSer;
    }
}