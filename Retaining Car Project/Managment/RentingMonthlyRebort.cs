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
    public partial class RentingMonthlyRebort : Form
    {
        public RentingMonthlyRebort()
        {
            InitializeComponent();
        }

        DataTable rentData = new DataTable();

        private void _LoadDataToChart()
        {
            var rentCountPerDay = rentData.AsEnumerable()
         .GroupBy(row => row.Field<DateTime>("DateOfSchedule"))
         .Select(g => new { Date = g.Key, Count = g.Count() })
         .ToList();

          

            // إعداد المخطط
            chart1.Series.Clear();
            Series series = new Series("Rents Per Day");
            series.ChartType = SeriesChartType.Column; // يمكنك تغيير النوع إلى Line أو Bar حسب الحاجة

            foreach (var item in rentCountPerDay)
            {
                series.Points.AddXY(item.Date.ToShortDateString(), item.Count);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Date";
            chart1.ChartAreas[0].AxisY.Title = "Number of Rents";

            // ضبط إعدادات المحور الأفقي (AxisX)
            chart1.ChartAreas[0].AxisX.Interval = 1; // عرض كل يوم على المحور
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // لتدوير النص وعرضه بشكل أفضل

            // تقليل عرض الأعمدة
            series["PointWidth"] = "0.5"; // بين 0.0 و 1.0 لتقليل عرض الأعمدة (0.5 مثال)

            // ضبط حجم الـ Chart (اختياري)
           

            // ضبط خصائص أخرى حسب الحاجة
            chart1.ChartAreas[0].RecalculateAxesScale(); // لإعادة حساب المحاور بناءً على التغييرات

        }

        private void _LoadDataToChartWithSpecificMonth()
        {

            int selectedMonth = dateTimePicker1.Value.Month;
            int selectedYear = dateTimePicker1.Value.Year;

            var filteredData = rentData.AsEnumerable()
    .Where(row => row.Field<DateTime>("DateOfSchedule").Month == selectedMonth &&
                  row.Field<DateTime>("DateOfSchedule").Year == selectedYear)
    .GroupBy(row => row.Field<DateTime>("DateOfSchedule"))
    .Select(g => new { Date = g.Key, Count = g.Count() })
    .ToList();

            // إعداد المخطط
            chart1.Series.Clear();
            Series series = new Series("Rents Per Day");
            series.ChartType = SeriesChartType.Column;

            foreach (var item in filteredData)
            {
                series.Points.AddXY(item.Date.ToShortDateString(), item.Count);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Date";
            chart1.ChartAreas[0].AxisY.Title = "Number of Rents";
        }



        private void RentingDailyRebort_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                rentData = clsRenting.GetAllRentingWithHisDate();


                this.Invoke((Action)(() =>
                {
                   
                    _LoadDataToChart();
                }));
            });
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
          


                this.Invoke((Action)(() =>
                {
                    _LoadDataToChartWithSpecificMonth();
                }));
            });

        }
    }
}
