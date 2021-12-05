using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frmListRevenue : UserControl
    {
        public frmListRevenue()
        {
            InitializeComponent();
            LoadChart();
            LoadRevenue();
        }

        int sumRecord;
        int maxPage;
        int currentPage = 1;
        int pageSize = 3;
        int UpdateMaxPage()
        {
            string fromDate, toDate;

            switch (cbbStatiticsMode.SelectedIndex)
            {
                case 0:
                    fromDate = dtp_From.Value.ToShortDateString();
                    toDate = dtp_To.Value.ToShortDateString();
                    sumRecord = BLL_Revenue.Instance.GetNumBillList_ByDay(fromDate, toDate);
                    break;
                case 1:
                    fromDate = dtp_From.Value.Month.ToString();
                    toDate = dtp_To.Value.Month.ToString();
                    sumRecord = BLL_Revenue.Instance.GetNumBillList_ByMonth(fromDate, toDate);
                    break;
                case 2:
                    fromDate = dtp_From.Value.Year.ToString();
                    toDate = dtp_To.Value.Year.ToString();
                    sumRecord = BLL_Revenue.Instance.GetNumBillList_ByYear(fromDate, toDate);
                    break;
                default: break;
            }
            maxPage = sumRecord / pageSize;
            if (sumRecord % pageSize != 0) { maxPage++; }
            return maxPage;
        }

        public void LoadRevenue()
        {
            string fromDate, toDate;
            int selectRows = pageSize * currentPage;
            int exceptRows = (currentPage - 1) * pageSize;

            switch (cbbStatiticsMode.SelectedIndex)
            {
                case 0:
                    fromDate = dtp_From.Value.ToShortDateString();
                    toDate = dtp_To.Value.ToShortDateString();
                    dtgvRevenue.DataSource = BLL_Revenue.Instance.LoadRevenue_ByDay(fromDate, toDate, selectRows, exceptRows);
                    dtgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgvRevenue.Columns["Day"].DisplayIndex = 0;
                    dtgvRevenue.Columns["Month"].DisplayIndex = 1;
                    dtgvRevenue.Columns["Year"].DisplayIndex = 2;
                    dtgvRevenue.Columns["Total Money"].DisplayIndex = 3;
                    break;
                case 1:
                    fromDate = dtp_From.Value.Month.ToString();
                    toDate = dtp_To.Value.Month.ToString();
                    dtgvRevenue.DataSource = BLL_Revenue.Instance.LoadRevenue_ByMonth(fromDate, toDate, selectRows, exceptRows);
                    dtgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgvRevenue.Columns["Month"].DisplayIndex = 0;
                    dtgvRevenue.Columns["Year"].DisplayIndex = 1;
                    dtgvRevenue.Columns["Total Money"].DisplayIndex = 2;
                    break;
                case 2:
                    fromDate = dtp_From.Value.Year.ToString();
                    toDate = dtp_To.Value.Year.ToString();
                    dtgvRevenue.DataSource = BLL_Revenue.Instance.LoadRevenue_ByYear(fromDate, toDate, selectRows, exceptRows);
                    dtgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgvRevenue.Columns["Year"].DisplayIndex = 0;
                    dtgvRevenue.Columns["Total Money"].DisplayIndex = 1;
                    break;
                default: break;
            }
            maxPage = UpdateMaxPage();
            LoadChart();
            for (int i = 0; i < dtgvRevenue.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvRevenue.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvRevenue.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvRevenue.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvRevenue.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
        }

        public void LoadChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Revenue";
            Series S = chart1.Series.Add("Revenue over time");
            S.ChartType = SeriesChartType.Column;
            S.Color = Color.Blue;

            if (cbbStatiticsMode.SelectedIndex != 2)
            {
                string x_axis_format = "{0}/{1}";

                // and fill in all the values from the dgv to the chart:
                for (int i = 0; i < dtgvRevenue.Rows.Count; i++)
                {
                    S.Points.AddXY(string.Format(x_axis_format, dtgvRevenue[0, i].Value, dtgvRevenue[1, i].Value), dtgvRevenue[dtgvRevenue.Columns.Count - 1, i].Value);
                    S["PointWidth"] = "0.2";
                    S.IsValueShownAsLabel = true;
                }
            }
            else
            {
                string x_axis_format = "{0}";

                // and fill in all the values from the dgv to the chart:
                for (int i = 0; i < dtgvRevenue.Rows.Count; i++)
                {
                    S.Points.AddXY(string.Format(x_axis_format, dtgvRevenue[0, i].Value), dtgvRevenue[dtgvRevenue.Columns.Count - 1, i].Value);
                    S["PointWidth"] = "0.5";
                    S.IsValueShownAsLabel = true;
                }
            }
        }

        private void dtp_From_ValueChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadRevenue();
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
        }

        private void dtp_To_ValueChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadRevenue();
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
        }

        private void cbbStatiticsMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadRevenue();
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
        }

        private void ListRevenue_Load(object sender, EventArgs e)
        {
            currentPage = 1;
            maxPage = UpdateMaxPage();
            dtp_From.Value = new DateTime(2020, 1, 1);
            cbbStatiticsMode.SelectedItem = "Day";
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);

        } //can xem lai

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = maxPage;
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (currentPage > 1) currentPage--;
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
        }

        private void btnNxt_Click(object sender, EventArgs e)
        {
            maxPage = UpdateMaxPage();
            if (currentPage < maxPage) currentPage++;
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
        }

        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            string[] numPage = txtPage.Text.Split('/');
            currentPage = Int32.Parse(numPage[0]);
            LoadRevenue();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = maxPage;
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
        }
    }
}
