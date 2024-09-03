using clsBuesnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Retaining_Car_Project.Managment
{
    public partial class RentingYearlyReport : Form
    {
        public RentingYearlyReport()
        {
            InitializeComponent();
        }

        DataTable paymentData;




        private void _LoadDataToChart()
        {


            var filteredData = paymentData.AsEnumerable()
                .GroupBy(row => row.Field<DateTime>("DateOfPaid").Month)
                .Select(g => new { Month = g.Key, Count = g.Count() })
                .ToList();

            // إعداد المخطط
            chart1.Series.Clear();
            Series series = new Series("Payments Per Month");
            series.ChartType = SeriesChartType.Column;

            foreach (var item in filteredData)
            {
                // تحويل الشهر إلى اسم الشهر (يناير، فبراير، إلخ)
                string monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(item.Month);
                series.Points.AddXY(monthName, item.Count);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Month";
            chart1.ChartAreas[0].AxisY.Title = "Number of Payments";



            // ضبط إعدادات المحور الأفقي (AxisX)
            chart1.ChartAreas[0].AxisX.Interval = 1; // عرض كل يوم على المحور
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // لتدوير النص وعرضه بشكل أفضل

            // تقليل عرض الأعمدة
            series["PointWidth"] = "0.5"; // بين 0.0 و 1.0 لتقليل عرض الأعمدة (0.5 مثال)

            // ضبط حجم الـ Chart (اختياري)


            // ضبط خصائص أخرى حسب الحاجة
            chart1.ChartAreas[0].RecalculateAxesScale(); // لإعادة حساب المحاور بناءً على التغييرات

        }

        private void _LoadDataToChartWithSpecificyear()
        {
            int selectedYear = dateTimePicker1.Value.Year;

            var filteredData = paymentData.AsEnumerable()
                .Where(row => row.Field<DateTime>("DateOfPaid").Year == selectedYear)
                .GroupBy(row => row.Field<DateTime>("DateOfPaid").Month)
                .Select(g => new { Month = g.Key, Count = g.Count() })
                .ToList();

            // إعداد المخطط
            chart1.Series.Clear();
            Series series = new Series("Payments Per Month");
            series.ChartType = SeriesChartType.Column;

            if(filteredData.Count<=0)
            {
                MessageBox.Show("No DataForThis Year!");
                return;
            }

            foreach (var item in filteredData)
            {
                // تحويل الشهر إلى اسم الشهر (يناير، فبراير، إلخ)
                string monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(item.Month);
                series.Points.AddXY(monthName, item.Count);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Month";
            chart1.ChartAreas[0].AxisY.Title = "Number of Payments";


        }


        private void RentingYearlyReport_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                paymentData =clsRenting.GetPaymentDataGroupedByMonth();


                this.Invoke((Action)(() =>
                {

                    _LoadDataToChart();
                }));
            });
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _LoadDataToChartWithSpecificyear();
        }
    }
}
