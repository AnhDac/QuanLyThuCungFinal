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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace QuanLyThuCung.Views
{
    public partial class BaoCao : Form
    {
        ThuCungEntities db = new ThuCungEntities();
        Controller ctrl = new Controller();

        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            LoadDataComboboxContractSell();
            LoadDataComboboxContractSer();
            LoadDataComboboxChartBaoCao();
            ShowDataContractSer();
            LoadChartBCDoanhThu(2021);

        }

        void LoadChartBCDoanhThu(int year)
        {
            chartBCDoanhThu.Series["DoanhThu"].Points.Clear();

            if (radioBaoCaoChartTheoQuy.Checked == false)
            {
                for (int i = 1; i < 13; i++)
                {
                    int valueY = 0;
                    string strvalueY = ctrl.getProfiContractSellTheoThangVaNam(i, year);
                    string confitContracSer = ctrl.getTotalMoneyTransactionContractSerTheoThangVaNam(i, year);
                    if (strvalueY != null && strvalueY != "")
                    {
                        valueY = Convert.ToInt32(strvalueY);
                    }
                    if(confitContracSer != null && confitContracSer != "")
                    {
                        int tam = Convert.ToInt32(confitContracSer);
                        tam = (int)(tam * 0.3);
                        valueY += tam;
                    }
                    chartBCDoanhThu.Series["DoanhThu"].Points.AddXY("Tháng" + i, valueY);
                }
            }
            else
            {
                for(int i = 0; i < 4; i++)
                {
                    int sum = 0;
                    for(int j = 1; j < 4; j++)
                    {
                        int valueY = 0;
                        string strvalueY = ctrl.getProfiContractSellTheoThangVaNam(i*3+j, year);
                        string confitContracSer = ctrl.getTotalMoneyTransactionContractSerTheoThangVaNam(i*3+j, year);
                        if (strvalueY != null && strvalueY != "")
                        {
                            valueY = Convert.ToInt32(strvalueY);
                        }
                        if (confitContracSer != null && confitContracSer != "")
                        {
                            int tam = Convert.ToInt32(confitContracSer);
                            tam = (int)(tam * 0.3);
                            valueY += tam;
                        }
                        sum += valueY;
                    }
                    chartBCDoanhThu.Series["DoanhThu"].Points.AddXY("Quý " + (i+1), sum);
                }
            }
        }

        private void tabBanThuCung_Click(object sender, EventArgs e)
        {
            ShowDataContractSell();
        }

        /*============================================
        ===============REPORT CONTRACT SELLL =========
       ==============================================*/

        void LoadDataComboboxChartBaoCao()
        {
            //============Load Combobox Năm=============
            for (int i = 2019; i <= DateTime.Now.Year; i++)
            {
                cbBCChart.Items.Add(i);
            }
            cbBCChart.Text=DateTime.Now.Year.ToString();
        }

        void LoadDataComboboxContractSell()
        {
            //============Load Combobox Thang=================
            for (int i = 1; i < 13; i++)
            {
                cbThangBCContractSell.Items.Add(i);
            }
            cbThangBCContractSell.Text = DateTime.Now.Month.ToString();

            //============Load Combobox Năm=============
            for (int i = 2019; i <= DateTime.Now.Year; i++)
            {
                cbNamBCContractSell.Items.Add(i);
            }
            cbNamBCContractSell.Text = DateTime.Now.Year.ToString();
        }

        void ShowDataContractSell()
        {
            int year = Convert.ToInt32(cbNamBCContractSell.Text.ToString());
            int month = Convert.ToInt32(cbThangBCContractSell.Text.ToString());

            var c = db.usp_GetContractSellTheoThangVaNam(month, year).ToList();

            
            dgvBCSell.DataSource = c;

            //Get Number Transaction
            tbSoGiaoDichContractSell.Text = "" + c.Count();

            //Get profit          
            string total = ctrl.getProfiContractSellTheoThangVaNam(month, year);
            tbProfitContractSell.Text = total;

            //Get Total Money Transaction
            total = ctrl.getTotalMoneyTransactionContractSellTheoThangVaNam(month, year);

            tbTotalMoneyTransContractSell.Text = total;

        }

        void ShowDataContractSer()
        {
            int year = Convert.ToInt32(cbNamContractSer.Text.ToString());
            int month = Convert.ToInt32(cbThangContractSer.Text.ToString());
            var c = db.usp_GetContractSerTheoThangVaNam(month, year).ToList();
            dgvBCDV.DataSource = c;

            //Get Number Transaction
            tbSoGiaoDichContractSer.Text = "" + c.Count();

            //Get Total Money Transaction
            string total = ctrl.getTotalMoneyTransactionContractSerTheoThangVaNam(month, year);
            int money = 0;
            if (total != null && total != "")
            {
                money += Convert.ToInt32(total);
            }
            tbTotalMoneyContractSer.Text = money+"";

            //Get profit 
            int profit = (int)(money * 0.3);
            tbProfitContracSer.Text = profit + "";
        }
        void LoadDataComboboxContractSer()
        {
            //============Load Combobox Thang=================
            for (int i = 1; i < 13; i++)
            {
                cbThangContractSer.Items.Add(i);
            }
            cbThangContractSer.Text = DateTime.Now.Month.ToString();

            //============Load Combobox Năm=============
            for (int i = 2019; i <= DateTime.Now.Year; i++)
            {
                cbNamContractSer.Items.Add(i);
            }
            cbNamContractSer.Text = DateTime.Now.Year.ToString();
        }

        private void btnShowContractSell_Click(object sender, EventArgs e)
        {
            ShowDataContractSell();
        }

        private void btnShowContractSer_Click(object sender, EventArgs e)
        {
            ShowDataContractSer();
        }

        private void btnExportBTC_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 3;
            Range myRange1 = (Range)sheet1.Cells[2, 1];
            myRange1.Value2 = "Số GD: " + tbSoGiaoDichContractSell.Text;
            Range myRange2 = (Range)sheet1.Cells[2, 2];
            myRange2.Value2 = "Tổng Giá Trị GD : " + tbTotalMoneyTransContractSell.Text;
            Range myRange3 = (Range)sheet1.Cells[1, 1];
            myRange3.Value2 = "Báo Cáo Mua Bán Thú Cưng Tháng " + cbThangBCContractSell.Text + " Năm " + cbNamBCContractSell.Text;
            for (int j = 0; j < dgvBCSell.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgvBCSell.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgvBCSell.Rows.Count; i++)
            {
                for (int j = 0; j < dgvBCSell.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dgvBCSell[j, i].Value.ToString() == null ? "" : dgvBCSell[j, i].Value.ToString();
                    myRange.Select();
                }
            }
        }

        private void btnExportDV_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 3;
            Range myRange1 = (Range)sheet1.Cells[2, 1];
            myRange1.Value2 = "Số GD: " + tbSoGiaoDichContractSer.Text;
            Range myRange2 = (Range)sheet1.Cells[2, 2];
            myRange2.Value2 = "Tổng Giá Trị GD : " + tbTotalMoneyContractSer.Text;
            Range myRange3 = (Range)sheet1.Cells[1, 1];
            myRange3.Value2 = "Báo Cáo Mua Bán Dịch Vụ Tháng " + cbThangContractSer.Text + " Năm " +  cbNamContractSer.Text;
            for (int j = 0; j < dgvBCDV.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgvBCDV.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgvBCDV.Rows.Count; i++)
            {
                for (int j = 0; j < dgvBCDV.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dgvBCDV[j, i].Value.ToString() == null ? "" : dgvBCDV[j, i].Value.ToString();
                    myRange.Select();
                }
            }
        }

        private void btnHienChart_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(cbBCChart.Text.ToString().Trim()); 
            LoadChartBCDoanhThu(year);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
