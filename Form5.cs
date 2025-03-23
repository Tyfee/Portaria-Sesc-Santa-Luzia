using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Definitions.Series;
using LiveCharts.Configurations;
using ScottPlot;
using System.Data.SQLite;
using ScottPlot.Palettes;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Syncfusion.Windows.Forms.Chart;
using System.Security.Cryptography.X509Certificates;
using Syncfusion.Collections;

namespace Portaria
{
    public partial class Form5 : Form
    {



        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";
        SQLiteCommand cmd;
        SQLiteConnection con;
        SQLiteDataReader dr;
        private int segunda;
        private int terca;
        private int quarta;
        private int quinta;
        private int sexta;
        private int sabado;
        private int domingo;


        public Form5()
        {
            DateTime year = DateTime.Today;
            var currentYear = year.ToString("yyyy");
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            Icon myIcon = new Icon("Resources/yass.ico");
            this.Icon = myIcon;
            showAverage();
            showAverage2();
            showAverage3();
            showAverage4();
            showAverage5();
            showAverage6();
            showAverage7();
            showTotalAverage();










            var con2 = new SQLiteConnection(cs);
            con2.Open();
            var cmd2 = new SQLiteCommand(con2);
            var cmd3 = new SQLiteCommand(con2);
            var cmd4 = new SQLiteCommand(con2);
            var cmd5 = new SQLiteCommand(con2);
            var cmd6 = new SQLiteCommand(con2);

            var cmd7 = new SQLiteCommand(con2);
            var cmd8 = new SQLiteCommand(con2);
            var cmd9 = new SQLiteCommand(con2);
            var cmd10 = new SQLiteCommand(con2);
            var cmd11 = new SQLiteCommand(con2);
            var cmd12 = new SQLiteCommand(con2);
            var cmd13 = new SQLiteCommand(con2);


            //Get january data

            cmd2.CommandText = "select count(name2) from daily where date LIKE '%/01/" + currentYear + "%'";
            cmd2.CommandType = CommandType.Text;
            int RowCount2 = 0;

            RowCount2 = Convert.ToInt32(cmd2.ExecuteScalar());

            cmd2.CommandText = "select count(name2) from daily where date LIKE '%/01/" + currentYear + "%'";
            SQLiteDataReader reader2 = cmd2.ExecuteReader();
            reader2.Close();


            //Get february data

            cmd3.CommandText = "select count(name2) from daily where date LIKE '%/02/" + currentYear + "%'";
            cmd3.CommandType = CommandType.Text;
            int RowCount3 = 0;

            RowCount3 = Convert.ToInt32(cmd3.ExecuteScalar());

            cmd3.CommandText = "select count(name2) from daily where date LIKE '%/02/" + currentYear + "%'";
            SQLiteDataReader reader3 = cmd3.ExecuteReader();
            reader3.Close();


            //Get march data

            cmd4.CommandText = "select count(name2) from daily where date LIKE '%/03/" + currentYear + "%'";
            cmd4.CommandType = CommandType.Text;
            int RowCount4 = 0;

            RowCount4 = Convert.ToInt32(cmd4.ExecuteScalar());

            cmd4.CommandText = "select count(name2) from daily where date LIKE '%/03/" + currentYear + "%'";
            SQLiteDataReader reader4 = cmd4.ExecuteReader();
            reader4.Close();

            //Get april data

            cmd5.CommandText = "select count(name2) from daily where date LIKE '%/04/" + currentYear + "%'";
            cmd5.CommandType = CommandType.Text;
            int RowCount5 = 0;

            RowCount5 = Convert.ToInt32(cmd5.ExecuteScalar());

            cmd5.CommandText = "select count(name2) from daily where date LIKE '%/04/" + currentYear + "%'";
            SQLiteDataReader reader5 = cmd4.ExecuteReader();
            reader5.Close();

            //Get may data

            cmd6.CommandText = "select count(name2) from daily where date LIKE '%/05/" + currentYear + "%'";
            cmd6.CommandType = CommandType.Text;
            int RowCount6 = 0;

            RowCount6 = Convert.ToInt32(cmd5.ExecuteScalar());

            cmd6.CommandText = "select count(name2) from daily where date LIKE '%/05/" + currentYear + "%'";
            SQLiteDataReader reader6 = cmd6.ExecuteReader();
            reader6.Close();


            //Get june data

            cmd7.CommandText = "select count(name2) from daily where date LIKE '%/06/" + currentYear + "%'";
            cmd7.CommandType = CommandType.Text;
            int RowCount7 = 0;

            RowCount7 = Convert.ToInt32(cmd5.ExecuteScalar());

            cmd7.CommandText = "select count(name2) from daily where date LIKE '%/06/" + currentYear + "%'";
            SQLiteDataReader reader7 = cmd7.ExecuteReader();
            reader7.Close();


            //Get july data

            cmd8.CommandText = "select count(name2) from daily where date LIKE '%/07/" + currentYear + "%'";
            cmd8.CommandType = CommandType.Text;
            int RowCount8 = 0;

            RowCount8 = Convert.ToInt32(cmd5.ExecuteScalar());

            cmd8.CommandText = "select count(name2) from daily where date LIKE '%/07/" + currentYear + "%'";
            SQLiteDataReader reader8 = cmd8.ExecuteReader();
            reader8.Close();

            //Get august data

            cmd9.CommandText = "select count(name2) from daily where date LIKE '%/08/" + currentYear + "%'";
            cmd9.CommandType = CommandType.Text;
            int RowCount9 = 0;

            RowCount9 = Convert.ToInt32(cmd5.ExecuteScalar());

            cmd9.CommandText = "select count(name2) from daily where date LIKE '%/08/" + currentYear + "%'";
            SQLiteDataReader reader9 = cmd9.ExecuteReader();
            reader9.Close();

            //Get september data

            cmd10.CommandText = "select count(name2) from daily where date LIKE '%/09/" + currentYear + "%'";
            cmd10.CommandType = CommandType.Text;
            int RowCount10 = 0;

            RowCount10 = Convert.ToInt32(cmd5.ExecuteScalar());

            cmd10.CommandText = "select count(name2) from daily where date LIKE '%/09/" + currentYear + "%'";
            SQLiteDataReader reader10 = cmd10.ExecuteReader();
            reader10.Close();

            //Get october data

            cmd11.CommandText = "select count(name2) from daily where date LIKE '%/10/" + currentYear + "%'";
            cmd11.CommandType = CommandType.Text;
            int RowCount11 = 0;

            RowCount11 = Convert.ToInt32(cmd11.ExecuteScalar());

            cmd11.CommandText = "select count(name2) from daily where date LIKE '%/10/" + currentYear + "%'";
            SQLiteDataReader reader11 = cmd11.ExecuteReader();
            reader11.Close();


            //Get november data

            cmd12.CommandText = "select count(name2) from daily where date LIKE '%/11/" + currentYear + "%'";
            cmd12.CommandType = CommandType.Text;
            int RowCount12 = 0;

            RowCount12 = Convert.ToInt32(cmd12.ExecuteScalar());

            cmd12.CommandText = "select count(name2) from daily where date LIKE '%/11/" + currentYear + "%'";
            SQLiteDataReader reader12 = cmd12.ExecuteReader();
            reader12.Close();


            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd2.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            //Get november data

            cmd13.CommandText = "select count(name2) from daily where date LIKE '%/12/" + currentYear + "%'";
            cmd13.CommandType = CommandType.Text;
            int RowCount13 = 0;

            RowCount13 = Convert.ToInt32(cmd13.ExecuteScalar());

            cmd13.CommandText = "select count(name2) from daily where date LIKE '%/12/" + currentYear + "%'";
            SQLiteDataReader reader13 = cmd13.ExecuteReader();
            reader13.Close();

            con2.Close();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd2.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();











            int jan = RowCount2;
            int fev = RowCount3;
            int mar = RowCount4;
            int abr = RowCount5;
            int mai = RowCount6;
            int jun = RowCount7;
            int jul = RowCount8;
            int ago = RowCount9;
            int set = RowCount10;
            int outu = RowCount11;
            int nov = RowCount12;
            int dez = RowCount13;





            var plt = new ScottPlot.Plot(600, 400);

            // create sample data
            double[] values = { jan, fev, mar, abr, mai, jun, jul, ago, set, outu, nov, dez };
            string[] labels = { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
            // add a bar graph to the plot

            formsPlot1.plt.AddBar(values);

            // adjust axis limits so there is no padding below the bar graph
            formsPlot1.plt.SetAxisLimits(yMin: 0);
            formsPlot1.plt.XTicks(labels);
            formsPlot1.plt.Title("Visitas por mês (" + currentYear + ")");
            formsPlot1.Refresh();














            DateTime today = DateTime.Today;
            var toDay = today.ToString("dd/MM/yyyy");

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);





            cmd.CommandText = "select count(name2) from daily where date = " + "'" + toDay + "'";
            cmd.CommandType = CommandType.Text;
            int RowCount = 0;

            RowCount = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.CommandText = "select count(name2) from daily where date = " + "'" + toDay + "'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            label3.Text = RowCount.ToString();




        }




        private void showAverage()
        {


            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);





            cmd.CommandText = "select count(name2) from daily where date LIKE '02/01/2023' OR date LIKE '09/01/2023' OR date LIKE '16/01/2023' OR date LIKE '23/01/2023' OR date LIKE '30/01/2023' OR date LIKE '06/02/2023' OR date LIKE '13/02/2023' OR date LIKE '20/02/2023' OR date LIKE '27/02/2023' OR date LIKE '06/03/2023' OR date LIKE '13/03/2023' OR date LIKE '20/03/2023' OR date LIKE '27/03/2023'";
            cmd.CommandType = CommandType.Text;
            int RowCount = 0;

            RowCount = Convert.ToInt32(cmd.ExecuteScalar());


            cmd.CommandText = "select count(name2) from daily where date LIKE '02/01/2023' OR date LIKE '09/01/2023' OR date LIKE '16/01/2023' OR date LIKE '23/01/2023' OR date LIKE '30/01/2023' OR date LIKE '06/02/2023' OR date LIKE '13/02/2023' OR date LIKE '20/02/2023' OR date LIKE '27/02/2023' OR date LIKE '06/03/2023' OR date LIKE '13/03/2023' OR date LIKE '20/03/2023' OR date LIKE '27/03/2023'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            this.segunda = RowCount;

            pieChart1.Series.Add(new PieSeries { Title = "Segunda", Fill = System.Windows.Media.Brushes.Red, StrokeThickness = 0, Values = new ChartValues<double> { segunda } });
       

        }
        private void showAverage2()
        {


            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);





            cmd.CommandText = "select count(name2) from daily where date LIKE '03/01/2023' OR date LIKE '10/01/2023' OR date LIKE '17/01/2023' OR date LIKE '24/01/2023' OR date LIKE '31/01/2023' OR date LIKE '07/02/2023' OR date LIKE '14/02/2023' OR date LIKE '21/02/2023' OR date LIKE '28/02/2023' OR date LIKE '07/03/2023' OR date LIKE '14/03/2023' OR date LIKE '21/03/2023' OR date LIKE '28/03/2023'";
            cmd.CommandType = CommandType.Text;
            int RowCount = 0;

            RowCount = Convert.ToInt32(cmd.ExecuteScalar());


            cmd.CommandText = "select count(name2) from daily where date LIKE '03/01/2023' OR date LIKE '10/01/2023' OR date LIKE '17/01/2023' OR date LIKE '24/01/2023' OR date LIKE '31/01/2023' OR date LIKE '07/02/2023' OR date LIKE '14/02/2023' OR date LIKE '21/02/2023' OR date LIKE '28/02/2023' OR date LIKE '07/03/2023' OR date LIKE '14/03/2023' OR date LIKE '21/03/2023' OR date LIKE '28/03/2023'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            this.terca = RowCount;


            pieChart1.Series.Add(new PieSeries { Title = "Terça", Fill = System.Windows.Media.Brushes.Green, StrokeThickness = 0, Values = new ChartValues<double> { terca } });
      

           

        }
        private void showAverage3()
        {


            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);





            cmd.CommandText = "select count(name2) from daily where date LIKE '04/01/2023' OR date LIKE '11/01/2023' OR date LIKE '18/01/2023' OR date LIKE '25/01/2023' OR date LIKE '01/02/2023' OR date LIKE '08/02/2023' OR date LIKE '15/02/2023' OR date LIKE '22/02/2023' OR date LIKE '01/03/2023' OR date LIKE '08/03/2023' OR date LIKE '15/03/2023' OR date LIKE '22/03/2023' OR date LIKE '29/03/2023'";
            cmd.CommandType = CommandType.Text;
            int RowCount = 0;

            RowCount = Convert.ToInt32(cmd.ExecuteScalar());


            cmd.CommandText = "select count(name2) from daily where date LIKE '04/01/2023' OR date LIKE '11/01/2023' OR date LIKE '18/01/2023' OR date LIKE '25/01/2023' OR date LIKE '01/02/2023' OR date LIKE '08/02/2023' OR date LIKE '15/02/2023' OR date LIKE '22/02/2023' OR date LIKE '01/03/2023' OR date LIKE '08/03/2023' OR date LIKE '15/03/2023' OR date LIKE '22/03/2023' OR date LIKE '29/03/2023'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            this.quarta = RowCount;


            pieChart1.Series.Add(new PieSeries { Title = "Quarta", Fill = System.Windows.Media.Brushes.Yellow, StrokeThickness = 0, Values = new ChartValues<double> { quarta } });




        }
        private void showAverage4()
        {


            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);





            cmd.CommandText = "select count(name2) from daily where date LIKE '05/01/2023' OR date LIKE '12/01/2023' OR date LIKE '19/01/2023' OR date LIKE '26/01/2023' OR date LIKE '02/02/2023' OR date LIKE '09/02/2023' OR date LIKE '16/02/2023' OR date LIKE '23/02/2023' OR date LIKE '02/03/2023' OR date LIKE '09/03/2023' OR date LIKE '16/03/2023' OR date LIKE '23/03/2023' OR date LIKE '30/03/2023'";
            cmd.CommandType = CommandType.Text;
            int RowCount = 0;

            RowCount = Convert.ToInt32(cmd.ExecuteScalar());


            cmd.CommandText = "select count(name2) from daily where date LIKE '05/01/2023' OR date LIKE '12/01/2023' OR date LIKE '19/01/2023' OR date LIKE '26/01/2023' OR date LIKE '02/02/2023' OR date LIKE '09/02/2023' OR date LIKE '16/02/2023' OR date LIKE '23/02/2023' OR date LIKE '02/03/2023' OR date LIKE '09/03/2023' OR date LIKE '16/03/2023' OR date LIKE '23/03/2023' OR date LIKE '30/03/2023'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            this.quinta = RowCount;


            pieChart1.Series.Add(new PieSeries { Title = "Quinta", Fill = System.Windows.Media.Brushes.Blue, StrokeThickness = 0, Values = new ChartValues<double> { quinta } });




        }
        private void showAverage5()
        {


            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);





            cmd.CommandText = "select count(name2) from daily where date LIKE '06/01/2023' OR date LIKE '13/01/2023' OR date LIKE '20/01/2023' OR date LIKE '27/01/2023' OR date LIKE '03/02/2023' OR date LIKE '10/02/2023' OR date LIKE '17/02/2023' OR date LIKE '24/02/2023' OR date LIKE '03/03/2023' OR date LIKE '10/03/2023' OR date LIKE '17/03/2023' OR date LIKE '24/03/2023' OR date LIKE '31/03/2023'";
            cmd.CommandType = CommandType.Text;
            int RowCount = 0;

            RowCount = Convert.ToInt32(cmd.ExecuteScalar());


            cmd.CommandText = "select count(name2) from daily where date LIKE '06/01/2023' OR date LIKE '13/01/2023' OR date LIKE '20/01/2023' OR date LIKE '27/01/2023' OR date LIKE '03/02/2023' OR date LIKE '10/02/2023' OR date LIKE '17/02/2023' OR date LIKE '24/02/2023' OR date LIKE '03/03/2023' OR date LIKE '10/03/2023' OR date LIKE '17/03/2023' OR date LIKE '24/03/2023' OR date LIKE '31/03/2023'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            this.sexta = RowCount;

            pieChart1.Series.Add(new PieSeries { Title = "Sexta", Fill = System.Windows.Media.Brushes.Orange, StrokeThickness = 0, Values = new ChartValues<double> { sexta } });




        }
        private void showAverage6()
        {


            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);





            cmd.CommandText = "select count(name2) from daily where date LIKE '07/01/2023' OR date LIKE '14/01/2023' OR date LIKE '21/01/2023' OR date LIKE '28/01/2023' OR date LIKE '04/02/2023' OR date LIKE '11/02/2023' OR date LIKE '18/02/2023' OR date LIKE '25/02/2023' OR date LIKE '04/03/2023' OR date LIKE '11/03/2023' OR date LIKE '18/03/2023' OR date LIKE '25/03/2023' OR date LIKE '01/04/2023'";
            cmd.CommandType = CommandType.Text;
            int RowCount = 0;

            RowCount = Convert.ToInt32(cmd.ExecuteScalar());


            cmd.CommandText = "select count(name2) from daily where date LIKE '07/01/2023' OR date LIKE '14/01/2023' OR date LIKE '21/01/2023' OR date LIKE '28/01/2023' OR date LIKE '04/02/2023' OR date LIKE '11/02/2023' OR date LIKE '18/02/2023' OR date LIKE '25/02/2023' OR date LIKE '04/03/2023' OR date LIKE '11/03/2023' OR date LIKE '18/03/2023' OR date LIKE '25/03/2023' OR date LIKE '01/04/2023'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
            this.sabado = RowCount;

            pieChart1.Series.Add(new PieSeries { Title = "Sábado", Fill = System.Windows.Media.Brushes.Salmon, StrokeThickness = 0, Values = new ChartValues<double> { sabado } });




        }
        private void showAverage7()
        {


            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);





            cmd.CommandText = "select count(name2) from daily where date LIKE '08/01/2023' OR date LIKE '15/01/2023' OR date LIKE '22/01/2023' OR date LIKE '29/01/2023' OR date LIKE '05/02/2023' OR date LIKE '12/02/2023' OR date LIKE '19/02/2023' OR date LIKE '26/02/2023' OR date LIKE '05/03/2023' OR date LIKE '12/03/2023' OR date LIKE '19/03/2023' OR date LIKE '26/03/2023' OR date LIKE '02/04/2023'";
            cmd.CommandType = CommandType.Text;
            int RowCount = 0;

            RowCount = Convert.ToInt32(cmd.ExecuteScalar());


            cmd.CommandText = "select count(name2) from daily where date LIKE '08/01/2023' OR date LIKE '15/01/2023' OR date LIKE '22/01/2023' OR date LIKE '29/01/2023' OR date LIKE '05/02/2023' OR date LIKE '12/02/2023' OR date LIKE '19/02/2023' OR date LIKE '26/02/2023' OR date LIKE '05/03/2023' OR date LIKE '12/03/2023' OR date LIKE '19/03/2023' OR date LIKE '26/03/2023' OR date LIKE '02/04/2023'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            this.domingo = RowCount;

            pieChart1.Series.Add(new PieSeries { Title = "Domingo", Fill = System.Windows.Media.Brushes.Purple, StrokeThickness = 0, Values = new ChartValues<double> { domingo } });




        }
        private void showTotalAverage()
        {


            int dias = segunda + terca + quarta + quinta + sexta + sabado + domingo;
            int newMedia = dias / 7;
            label4.Text = newMedia.ToString();


        }
        private void alphaGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    public static class DateUtils
    {
        public static List<DateTime> GetWeekdayInRange(this DateTime from, DateTime to, DayOfWeek day)
        {
            const int daysInWeek = 7;
            var result = new List<DateTime>();
            var daysToAdd = ((int)day - (int)from.DayOfWeek + daysInWeek) % daysInWeek;

            do
            {
                from = from.AddDays(daysToAdd);
                result.Add(from);
                daysToAdd = daysInWeek;
            } while (from < to);

            return result;
        }
    }





}
