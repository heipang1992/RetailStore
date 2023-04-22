using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP
{
    public partial class StaticViewer : Form
    {
        bool isDaily = true;

        List<double> dailySalesData = new List<double> { 0, 0, 0, 0, 0 };
        List<double> MonthlySalesData = new List<double> { 0, 0, 0, 0, 0 };

        List<double> dailyDeliveryData = new List<double> { 0, 0, 0, 0, 0 };
        List<double> MonthlyDeliveryData = new List<double> { 0, 0, 0, 0, 0 };

        List<double> dailyInstallData = new List<double> { 0, 0, 0, 0, 0 };
        List<double> MonthlyInstallData = new List<double> { 0, 0, 0, 0, 0 };

        public StaticViewer()
        {
            InitializeComponent();
            changeChartMode.Text = "Column";
            changeMode.Text = "Daily";
        }

        private void displayData()
        {
            foreach (var series in SalesChart.Series)
            {
                series.Points.Clear();
            }

            if (isDaily)
            {
                salesOrderText.Text = dailySalesData[0].ToString();
                if (dailySalesData[1] != 0)
                {
                    double dailyDifferent = Math.Round(((dailySalesData[0] - dailySalesData[1]) / dailySalesData[1]) * 100, 2);
                    if (dailySalesData[0] < dailySalesData[1])
                    {
                        salesOrder2.Text = "⮟" + dailyDifferent + "%";
                        salesOrder2.ForeColor = Color.FromArgb(247, 92, 92);
                    }
                    else
                    {
                        salesOrder2.Text = "⮝" + dailyDifferent + "%";
                        salesOrder2.ForeColor = Color.FromArgb(156, 242, 109);
                    }
                } else
                {
                    salesOrder2.Text = "⮝ 0%";
                    salesOrder2.ForeColor = Color.FromArgb(156, 242, 109);
                }
                
                deliveryText.Text = dailyDeliveryData[0].ToString();
                if (dailyDeliveryData[1] != 0)
                {
                    double dailyDifferent = Math.Round(((dailyDeliveryData[0] - dailyDeliveryData[1]) / dailyDeliveryData[1]) * 100);
                    if (dailyDeliveryData[0] < dailyDeliveryData[1])
                    {
                        deliveryText2.Text = "⮟" + dailyDifferent + "%";
                        deliveryText2.ForeColor = Color.FromArgb(247, 92, 92);
                    }
                    else
                    {
                        deliveryText2.Text = "⮝" + dailyDifferent + "%";
                        deliveryText2.ForeColor = Color.FromArgb(156, 242, 109);
                    }
                }
                else
                {
                    deliveryText2.Text = "⮝ 0%";
                    deliveryText2.ForeColor = Color.FromArgb(156, 242, 109);
                }

                installationText.Text = dailyInstallData[0].ToString();
                if (dailyInstallData[1] != 0)
                {
                    double dailyDifferent = Math.Round(((dailyInstallData[0] - dailyInstallData[1]) / dailyInstallData[1]) * 100);
                    if (dailyInstallData[0] < dailyInstallData[1])
                    {
                        installationText2.Text = "⮟" + dailyDifferent + "%";
                        installationText2.ForeColor = Color.FromArgb(247, 92, 92);
                    }
                    else
                    {
                        installationText2.Text = "⮝" + dailyDifferent + "%";
                        installationText2.ForeColor = Color.FromArgb(156, 242, 109);
                    }
                }
                else
                {
                    installationText2.Text = "⮝ 0%";
                    installationText2.ForeColor = Color.FromArgb(156, 242, 109);
                }

                for (var i = 0; i < 4; i++)
                {
                    SalesChart.Series["Sales"].Points.AddXY(DateTime.Now.AddDays(-i).Day, dailySalesData[i]);
                    SalesChart.Series["Delivery"].Points.AddXY(DateTime.Now.AddDays(-i).Day, dailyDeliveryData[i]);
                    SalesChart.Series["Installation"].Points.AddXY(DateTime.Now.AddDays(-i).Day, dailyInstallData[i]);
                }

            } else
            {
                salesOrderText.Text = MonthlySalesData[0].ToString();
                if (MonthlySalesData[1] != 0)
                {
                    double dailyDifferent = Math.Round(((MonthlySalesData[0] - MonthlySalesData[1]) / MonthlySalesData[1]) * 100);
                    if (MonthlySalesData[0] < MonthlySalesData[1])
                    {
                        salesOrder2.Text = "⮟" + dailyDifferent + "%";
                        salesOrder2.ForeColor = Color.FromArgb(247, 92, 92);
                    }
                    else
                    {
                        salesOrder2.Text = "⮝" + dailyDifferent + "%";
                        salesOrder2.ForeColor = Color.FromArgb(156, 242, 109);
                    }
                }
                else
                {
                    salesOrder2.Text = "⮝ 0%";
                    salesOrder2.ForeColor = Color.FromArgb(156, 242, 109);
                }

                deliveryText.Text = MonthlyDeliveryData[0].ToString();
                if (MonthlyDeliveryData[1] != 0)
                {
                    double dailyDifferent = Math.Round(((MonthlyDeliveryData[0] - MonthlyDeliveryData[1]) / MonthlyDeliveryData[1]) * 100);
                    if (MonthlyDeliveryData[0] < MonthlyDeliveryData[1])
                    {
                        deliveryText2.Text = "⮟" + dailyDifferent + "%";
                        deliveryText2.ForeColor = Color.FromArgb(247, 92, 92);
                    }
                    else
                    {
                        deliveryText2.Text = "⮝" + dailyDifferent + "%";
                        deliveryText2.ForeColor = Color.FromArgb(156, 242, 109);
                    }
                }
                else
                {
                    deliveryText2.Text = "⮝ 0%";
                    deliveryText2.ForeColor = Color.FromArgb(156, 242, 109);
                }

                installationText.Text = MonthlyInstallData[0].ToString();
                if (MonthlyInstallData[1] != 0)
                {
                    double dailyDifferent = Math.Round(((MonthlyInstallData[0] - MonthlyInstallData[1]) / MonthlyInstallData[1]) * 100);
                    if (MonthlyInstallData[0] < MonthlyInstallData[1])
                    {
                        installationText2.Text = "⮟" + dailyDifferent + "%";
                        installationText2.ForeColor = Color.FromArgb(247, 92, 92);
                    }
                    else
                    {
                        installationText2.Text = "⮝" + dailyDifferent + "%";
                        installationText2.ForeColor = Color.FromArgb(156, 242, 109);
                    }
                }
                else
                {
                    installationText2.Text = "⮝ 0%";
                    installationText2.ForeColor = Color.FromArgb(156, 242, 109);
                }

                for (var i = 0; i < 4; i++)
                {
                    SalesChart.Series["Sales"].Points.AddXY(DateTime.Now.AddMonths(-i).Month, MonthlySalesData[i]);
                    SalesChart.Series["Delivery"].Points.AddXY(DateTime.Now.AddMonths(-i).Month, MonthlyDeliveryData[i]);
                    SalesChart.Series["Installation"].Points.AddXY(DateTime.Now.AddMonths(-i).Month, MonthlyInstallData[i]);
                }

            }
            
        }
        private void StaticViewer_Load(object sender, EventArgs e)
        {
            using (sdpEntities content = new sdpEntities())
            {

                foreach (var item in content.SalesOrderInfoes.ToList())
                {
                    for (var i = 0; i < 4; i ++)
                    {
                        if (item.date.Day == DateTime.Now.AddDays(-i).Day)
                        {
                            dailySalesData[i]++;
                        }

                        if (item.date.Month == DateTime.Now.AddMonths(-i).Month)
                        {
                            MonthlySalesData[i]++;
                        }
                    }

                }
                

                foreach (var item in content.DeliveryNotes.ToList())
                {
                    for (var i = 0; i < 4; i++)
                    {
                        if (item.deliveryDate2.Value.Day == DateTime.Now.AddDays(-i).Day)
                        {
                            dailyDeliveryData[i]++;
                        }

                        if (item.deliveryDate2.Value.Month == DateTime.Now.AddMonths(-i).Month)
                        {
                            MonthlyDeliveryData[i]++;
                        }
                    }
                }

                foreach (var item in content.InstallationNotes.ToList())
                {
                    for (var i = 0; i < 4; i++)
                    {
                        if (item.installDate.Value.Day == DateTime.Now.AddDays(-i).Day)
                        {
                            dailyInstallData[i]++;
                        }

                        if (item.installDate.Value.Month == DateTime.Now.AddMonths(-i).Month)
                        {
                            MonthlyInstallData[i]++;
                        }
                    }
                }
            }
            displayData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (changeMode.Text == "Daily")
            {
                isDaily = true;
            } else
            {
                isDaily = false;
            }
            displayData();

        }

        private void changeChartMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var series in SalesChart.Series)
            {
                if (changeChartMode.Text == "Column")
                {
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                } else if (changeChartMode.Text == "Bar")
                {
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                }
                else if (changeChartMode.Text == "SplineArea")
                {
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                }
                else if (changeChartMode.Text == "Spline")
                {
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                }
                else if (changeChartMode.Text == "Point")
                {
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                }


            }
        }
    }
}
