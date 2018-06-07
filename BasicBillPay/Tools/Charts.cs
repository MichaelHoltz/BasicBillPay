using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicBillPay.Tools
{
    /// <summary>
    /// Helper for MS Chart to keep code in one place.
    /// </summary>
    internal static class Charts
    {
        internal static void InitializeChart(Chart c, String chartName)
        {
            c.Series.Clear();
            c.Series.Add(chartName);
            c.Series[0].ChartType = SeriesChartType.Pie;
        }

        internal static void AddChartPoint(Chart c, String name, float Amount)
        {
            DataPoint dp = new DataPoint(0, Amount);
            dp.IsValueShownAsLabel = true;
            dp.LabelFormat = "C0";
            dp.Name = name;
            dp.LegendText = name;
            dp.LabelToolTip = name; // Amount.ToString("C0");
            dp.LegendToolTip = Amount.ToString("C0");
            DataPoint odp = c.Series[0].Points.FirstOrDefault(o => o.LegendText == name);
            if (odp == null)
            {
                c.Series[0].Points.Add(dp);
            }
            else
            {
                odp = dp;
            }

        }
    }
}
