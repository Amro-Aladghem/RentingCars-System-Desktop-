using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace clsDataAccessLayer
{
    public partial class TestFrom : Form
    {
        public TestFrom()
        {
            InitializeComponent();
        }

        private void TestFrom_Load(object sender, EventArgs e)
        {
            DataTable rentData = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Rents.RentID, Schedules.DateOfSchedule\r\nFROM   Schedules INNER JOIN\r\nRents ON Schedules.ScheduleID = Rents.ScheduleID", conn);
                da.Fill(rentData);

                // ثم تابع كما في المثال السابق
            }


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

        }
    }
}
