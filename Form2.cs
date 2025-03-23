using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Threading;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.ConstrainedExecution;
using System.Windows.Controls;
using System.Net.Mail;

namespace Portaria
{
    public partial class Form2 : Form
    {

        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";
        SQLiteCommand cmd;
        SQLiteConnection con;
        SQLiteDataReader dr;
        DataTable table;



        string cellValue;
        string cellValue2;
        string cellValue3;
        string cellValue4;
        bool isOnRightTab;
        bool isOnRightTab2;
        bool isOnRightTab3;
        bool isOnRightTab10;

        int selectedrowindex;
        DataGridViewRow selectedRow;

        public Form2()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;


            comboBox7.Items.Add("NOME");
            comboBox7.Items.Add("CPF");
            comboBox7.Items.Add("RG");
            comboBox7.SelectedItem = "NOME";

            comboBox6.Items.Add("POSTO DE SAÚDE");
            comboBox6.Items.Add("TERCEIRA IDADE");
            comboBox6.Items.Add("OUTRO");
            comboBox6.SelectedItem = "POSTO DE SAÚDE";

            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;


            registerbutton.TabStop = false;
            registerbutton.FlatStyle = FlatStyle.Flat;
            registerbutton.FlatAppearance.BorderSize = 0;


            entryButton.TabStop = false;
            entryButton.FlatStyle = FlatStyle.Flat;
            entryButton.FlatAppearance.BorderSize = 0;

            searchButton.TabStop = false;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.FlatAppearance.BorderSize = 0;

            findEntry.TabStop = false;
            findEntry.FlatStyle = FlatStyle.Flat;
            findEntry.FlatAppearance.BorderSize = 0;

            findEntry2.TabStop = false;
            findEntry2.FlatStyle = FlatStyle.Flat;
            findEntry2.FlatAppearance.BorderSize = 0;

            searchByDate.TabStop = false;
            searchByDate.FlatStyle = FlatStyle.Flat;
            searchByDate.FlatAppearance.BorderSize = 0;


            isOnRightTab = false;
            isOnRightTab2 = false;
            isOnRightTab3 = false;
            isOnRightTab10 = false;

            Icon myIcon = new Icon("Resources/yass.ico");
            this.Icon = myIcon;

            birthdayRegister.CustomFormat = "dd/MMM/yyyy";


            KeyPreview = true;


            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";


            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.CustomFormat = "HH:mm";
            dateTimePicker6.ShowUpDown = true;

            dateTimePicker8.Format = DateTimePickerFormat.Custom;
            dateTimePicker8.CustomFormat = "HH:mm";
            dateTimePicker8.ShowUpDown = true;

            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd/MM/yyyy";

            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;

            comboBox2.Items.Add("CPF");
            comboBox2.Items.Add("RG");
            comboBox2.Items.Add("NOME");
            comboBox2.SelectedItem = "CPF";

            comboBox1.Items.Add("SESC");
            comboBox1.Items.Add("Posto de Saúde");
            comboBox1.Items.Add("Visitantes");
            comboBox1.Items.Add("Outros");
            comboBox1.SelectedItem = "SESC";


            comboBox3.Items.Add("NOME");
            comboBox3.Items.Add("CPF");
            comboBox3.Items.Add("RG");
            comboBox3.SelectedItem = "NOME";

            comboBox4.Items.Add("NOME");
            comboBox4.Items.Add("CPF");
            comboBox4.Items.Add("RG");
            comboBox4.SelectedItem = "NOME";


            comboBox5.Items.Add("FILTRAR POR MÊS");
            comboBox5.Items.Add("JANEIRO");
            comboBox5.Items.Add("FEVEREIRO");
            comboBox5.Items.Add("MARÇO");
            comboBox5.Items.Add("ABRIL");
            comboBox5.Items.Add("MAIO");
            comboBox5.Items.Add("JUNHO");
            comboBox5.Items.Add("JULHO");
            comboBox5.Items.Add("AGOSTO");
            comboBox5.Items.Add("SETEMBRO");
            comboBox5.Items.Add("OUTUBRO");
            comboBox5.Items.Add("NOVEMBRO");
            comboBox5.Items.Add("DEZEMBRO");
            comboBox5.SelectedItem = "FILTRAR POR MÊS";



            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.RowHeadersVisible = false;

            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.RowHeadersVisible = false;

            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView4.RowHeadersVisible = false;

            dataGridView5.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView5.EnableHeadersVisualStyles = false;
            dataGridView5.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView5.RowHeadersVisible = false;

            dataGridView6.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView6.EnableHeadersVisualStyles = false;
            dataGridView6.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView6.RowHeadersVisible = false;

            dataGridView7.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView7.EnableHeadersVisualStyles = false;
            dataGridView7.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView7.RowHeadersVisible = false;

            dataGridView8.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView8.EnableHeadersVisualStyles = false;
            dataGridView8.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView8.RowHeadersVisible = false;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Enabled = true;
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timer_Tick);
            void timer_Tick(object sender, EventArgs e)
            {

                cessao_show();
                agendados_show();

            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            insertData5();
        }

        private void insertData5()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO profissionais_outros(name7, id7, id77, empresa7, data7, timeStart7, timeEnd7, veiculo7, placa7, servico7, solicitante7) VALUES (@name7, @id7, @id77, @empresa7, @data7, @timeStart7, @timeEnd7, @veiculo7, @placa7, @servico7, @solicitante7)";

            string NAME7 = textBox10.Text;
            string ID7 = textBox11.Text;
            string ID77 = textBox12.Text;
            string EMPRESA7 = textBox19.Text;
            string DATA7 = dateTimePicker2.Text;
            string TIMESTART7 = dateTimePicker6.Text;
            string TIMEEND7 = dateTimePicker8.Text;
            string VEICULO7 = textBox24.Text;
            string PLACA7 = textBox25.Text;
            string SERVICO7 = textBox26.Text;
            string SOLICITANTE7 = textBox27.Text;

            cmd.Parameters.AddWithValue("@name7", NAME7);
            cmd.Parameters.AddWithValue("@id7", ID7);
            cmd.Parameters.AddWithValue("@id77", ID77);
            cmd.Parameters.AddWithValue("@empresa7", EMPRESA7);
            cmd.Parameters.AddWithValue("@data7", DATA7);
            cmd.Parameters.AddWithValue("@timeStart7", TIMESTART7);
            cmd.Parameters.AddWithValue("@timeEnd7", TIMEEND7);
            cmd.Parameters.AddWithValue("@veiculo7", VEICULO7);
            cmd.Parameters.AddWithValue("@placa7", PLACA7);
            cmd.Parameters.AddWithValue("@servico7", SERVICO7);
            cmd.Parameters.AddWithValue("@solicitante7", SOLICITANTE7);


            dataGridView6.ColumnCount = 11;
            dataGridView6.Columns[0].Name = NAME7;
            dataGridView6.Columns[1].Name = ID7;
            dataGridView6.Columns[2].Name = ID77;
            dataGridView6.Columns[3].Name = EMPRESA7;
            dataGridView6.Columns[4].Name = DATA7;
            dataGridView6.Columns[5].Name = TIMESTART7;
            dataGridView6.Columns[6].Name = TIMEEND7;
            dataGridView6.Columns[7].Name = VEICULO7;
            dataGridView6.Columns[8].Name = PLACA7;
            dataGridView6.Columns[9].Name = SERVICO7;
            dataGridView6.Columns[10].Name = SOLICITANTE7;



            string[] row = new string[] { NAME7, ID7, ID77, EMPRESA7, DATA7, TIMESTART7, TIMEEND7, VEICULO7, PLACA7, SERVICO7, SOLICITANTE7 };
            dataGridView6.Rows.Add(row);
            cmd.ExecuteNonQuery();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            textBox10.Text = "Nome Completo do Prestador";

            textBox11.Text = "CPF";

            textBox12.Text = "RG";
            textBox19.Text = "Empresa";
            textBox24.Text = "Veículo";
            textBox25.Text = "Placa";
            textBox26.Text = "Serviço a ser realizado";
            textBox27.Text = "Solicitante";

            textBox23.Text = "Periodicidade";
            textBox10.ForeColor = Color.Silver;
            textBox11.ForeColor = Color.Silver;
            textBox12.ForeColor = Color.Silver;
            textBox19.ForeColor = Color.Silver;
            textBox24.ForeColor = Color.Silver;
            textBox25.ForeColor = Color.Silver;
            textBox23.ForeColor = Color.Silver;
            textBox20.ForeColor = Color.Silver;
            textBox21.ForeColor = Color.Silver;
            textBox22.ForeColor = Color.Silver;
            textBox23.ForeColor = Color.Silver;
            textBox26.ForeColor = Color.Silver;
            textBox27.ForeColor = Color.Silver;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            insertData4();
        }

        private void insertData4()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO veiculos(name0, veiculo0, placa0, periodicidade0, departamento0) VALUES (@name0, @veiculo0, @placa0, @periodicidade0, @departamento0)";

            string NAME0 = textBox20.Text;
            string VEICULO0 = textBox21.Text;
            string PLACA0 = textBox22.Text;
            string PERIODICIDADE0 = textBox23.Text;
            string DEPARTAMENTO0 = comboBox6.SelectedItem.ToString();



            cmd.Parameters.AddWithValue("@name0", NAME0);
            cmd.Parameters.AddWithValue("@veiculo0", VEICULO0);
            cmd.Parameters.AddWithValue("@placa0", PLACA0);
            cmd.Parameters.AddWithValue("@periodicidade0", PERIODICIDADE0);
            cmd.Parameters.AddWithValue("@departamento0", DEPARTAMENTO0);




            dataGridView3.ColumnCount = 5;
            dataGridView3.Columns[0].Name = NAME0;
            dataGridView3.Columns[1].Name = VEICULO0;
            dataGridView3.Columns[2].Name = PLACA0;
            dataGridView3.Columns[3].Name = PERIODICIDADE0;
            dataGridView3.Columns[4].Name = DEPARTAMENTO0;





            string[] row = new string[] { NAME0, VEICULO0, PLACA0, PERIODICIDADE0, DEPARTAMENTO0 };
            dataGridView7.Rows.Add(row);
            cmd.ExecuteNonQuery();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            textBox20.Text = "Nome";

            textBox21.Text = "Veículo";

            textBox22.Text = "Placa";

            textBox23.Text = "Periodicidade";

            textBox20.ForeColor = Color.Silver;
            textBox21.ForeColor = Color.Silver;
            textBox22.ForeColor = Color.Silver;
            textBox23.ForeColor = Color.Silver;

            veiculos_show();

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchOutros();

        }
        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox21.Focus();

        }
        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox22.Focus();

        }
        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox23.Focus();

        }
        private void textBox23_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insertData4();

            }
        }





        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                textBox7.Focus();

        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox8.Focus();

        }
        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox9.Focus();

        }
        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                insertData2();

        }




        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox11.Focus();

        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox12.Focus();

        }
        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox19.Focus();

        }
        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox24.Focus();

        }
        private void textBox24_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox25.Focus();

        }
        private void textBox25_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox26.Focus();

        }

        private void textBox26_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox27.Focus();
        }
        private void textBox27_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insertData5();
            }

        }

        //ANNOYING DATAGRID STYLING STUFF SASGUFHRJKFVB I HATE DOING THIS
        //SDFASDIFOAJSDFA
        //DFKSADFASDNKFGMsdf
        //aSDJiaofçhnfiksid

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {

                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    SelectionBackColor = Color.White,
                    SelectionForeColor = Color.Black

                };
            }
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {

                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))

                using (var gridlinePen = new Pen(dataGridView1.GridColor, 1))

                using (var selectedPen = new Pen(Color.RoyalBlue, 2))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

                    if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));
                        e.Handled = true;
                    }
                    else
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        if (e.RowIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, bottomleftPoint);

                        if (e.RowIndex == dataGridView1.RowCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

                        if (e.ColumnIndex == dataGridView1.ColumnCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, topRightPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, topRightPoint);

                        if (e.RowIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, bottomleftPoint);

                        e.Handled = true;
                    }
                }
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {

                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    SelectionBackColor = Color.White,
                    SelectionForeColor = Color.Black

                };
            }
        }
        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {

                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))

                using (var gridlinePen = new Pen(dataGridView1.GridColor, 1))

                using (var selectedPen = new Pen(Color.RoyalBlue, 2))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

                    if (this.dataGridView2[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));
                        e.Handled = true;
                    }
                    else
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        if (e.RowIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, bottomleftPoint);

                        if (e.RowIndex == dataGridView2.RowCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

                        if (e.ColumnIndex == dataGridView2.ColumnCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, topRightPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, topRightPoint);

                        if (e.RowIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, bottomleftPoint);

                        e.Handled = true;
                    }
                }
            }
        }
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {

                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    SelectionBackColor = Color.White,
                    SelectionForeColor = Color.Black

                };
            }
        }
        private void dataGridView3_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {

                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))

                using (var gridlinePen = new Pen(dataGridView3.GridColor, 1))

                using (var selectedPen = new Pen(Color.RoyalBlue, 2))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

                    if (this.dataGridView3[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));
                        e.Handled = true;
                    }
                    else
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        if (e.RowIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, bottomleftPoint);

                        if (e.RowIndex == dataGridView3.RowCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

                        if (e.ColumnIndex == dataGridView3.ColumnCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, topRightPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, topRightPoint);

                        if (e.RowIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, bottomleftPoint);

                        e.Handled = true;
                    }
                }
            }
        }
        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {

                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    SelectionBackColor = Color.White,
                    SelectionForeColor = Color.Black

                };
            }
        }
        private void dataGridView4_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {

                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))

                using (var gridlinePen = new Pen(dataGridView4.GridColor, 1))

                using (var selectedPen = new Pen(Color.RoyalBlue, 2))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

                    if (this.dataGridView4[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));
                        e.Handled = true;
                    }
                    else
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        if (e.RowIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, bottomleftPoint);

                        if (e.RowIndex == dataGridView4.RowCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

                        if (e.ColumnIndex == dataGridView4.ColumnCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, topRightPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, topRightPoint);

                        if (e.RowIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, bottomleftPoint);

                        e.Handled = true;
                    }
                }
            }
        }

        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {

                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    SelectionBackColor = Color.White,
                    SelectionForeColor = Color.Black

                };
            }
        }
        private void dataGridView5_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {

                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))

                using (var gridlinePen = new Pen(dataGridView5.GridColor, 1))

                using (var selectedPen = new Pen(Color.RoyalBlue, 2))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

                    if (this.dataGridView5[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));
                        e.Handled = true;
                    }
                    else
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        if (e.RowIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, bottomleftPoint);

                        if (e.RowIndex == dataGridView5.RowCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

                        if (e.ColumnIndex == dataGridView5.ColumnCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, topRightPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, topRightPoint);

                        if (e.RowIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, bottomleftPoint);

                        e.Handled = true;
                    }
                }
            }
        }
        private void dataGridView6_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {

                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    SelectionBackColor = Color.White,
                    SelectionForeColor = Color.Black

                };
            }
        }
        private void dataGridView6_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {

                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))

                using (var gridlinePen = new Pen(dataGridView6.GridColor, 1))

                using (var selectedPen = new Pen(Color.RoyalBlue, 2))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

                    if (this.dataGridView6[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));
                        e.Handled = true;
                    }
                    else
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        if (e.RowIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, bottomleftPoint);

                        if (e.RowIndex == dataGridView6.RowCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

                        if (e.ColumnIndex == dataGridView6.ColumnCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, topRightPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, topRightPoint);

                        if (e.RowIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, bottomleftPoint);

                        e.Handled = true;
                    }
                }
            }
        }

        private void dataGridView7_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {

                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    SelectionBackColor = Color.White,
                    SelectionForeColor = Color.Black

                };
            }
        }
        private void dataGridView7_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {

                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))

                using (var gridlinePen = new Pen(dataGridView7.GridColor, 1))

                using (var selectedPen = new Pen(Color.RoyalBlue, 2))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

                    if (this.dataGridView7[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));
                        e.Handled = true;
                    }
                    else
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        if (e.RowIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, bottomleftPoint);

                        if (e.RowIndex == dataGridView7.RowCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

                        if (e.ColumnIndex == dataGridView7.ColumnCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, topRightPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, topRightPoint);

                        if (e.RowIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, bottomleftPoint);

                        e.Handled = true;
                    }
                }
            }
        }
        private void dataGridView8_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {

                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    SelectionBackColor = Color.White,
                    SelectionForeColor = Color.Black

                };
            }
        }
        private void dataGridView8_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {

                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))

                using (var gridlinePen = new Pen(dataGridView8.GridColor, 1))

                using (var selectedPen = new Pen(Color.RoyalBlue, 2))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

                    if (this.dataGridView8[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));
                        e.Handled = true;
                    }
                    else
                    {
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        if (e.RowIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, bottomleftPoint);

                        if (e.RowIndex == dataGridView8.RowCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

                        if (e.ColumnIndex == dataGridView8.ColumnCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, topRightPoint);
                        else
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, topRightPoint);

                        if (e.RowIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, topRightPoint);

                        if (e.ColumnIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, bottomleftPoint);

                        e.Handled = true;
                    }
                }
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            inputUser.Focus();
        }



        private void stats_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.ShowDialog();
        }









        // REGISTER
        private void registerbutton_Click(object sender, EventArgs e)
        {
            registerNow();
        }


        private void registerNow()
        {
            if (nameRegister.Text == "" && documentRegister.Text == "")
            {
                MessageBox.Show("Por favor, insira dados válidos.", "Erro no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Novo usuário cadastrado com sucesso!", "Cadastro Realizado", MessageBoxButtons.OK);


                // INPUTING NEW PERSON 

                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO test(name, id, id2, adress, birthday, email, telephone) VALUES(@name, @id, @id2, @adress, @birthday, @email, @telephone)";





                string NAME = nameRegister.Text;
                string ID = documentRegister.Text;
                string ID2 = documentRegister2.Text;
                string ADRESS = adressRegister.Text;
                string BIRTHDAY = birthdayRegister.Text;
                string EMAIL = emailRegister.Text;
                string TELEPHONE = phoneRegister.Text;






                cmd.Parameters.AddWithValue("@name", NAME);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@id2", ID2);
                cmd.Parameters.AddWithValue("@adress", ADRESS);
                cmd.Parameters.AddWithValue("@birthday", BIRTHDAY);
                cmd.Parameters.AddWithValue("@email", EMAIL);
                cmd.Parameters.AddWithValue("@telephone", TELEPHONE);



                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].Name = NAME;
                dataGridView1.Columns[1].Name = ID;
                dataGridView1.Columns[2].Name = ID2;
                dataGridView1.Columns[3].Name = ADRESS;
                dataGridView1.Columns[4].Name = BIRTHDAY;
                dataGridView1.Columns[5].Name = EMAIL;
                dataGridView1.Columns[6].Name = TELEPHONE;





                string[] row = new string[] { NAME, ID, ID2, ADRESS, BIRTHDAY, EMAIL, TELEPHONE };

                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();





                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();

                addAndRegister();
            }
        }

        private void addAndRegister()
        {

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);


            cmd.CommandText = "INSERT INTO daily(name2, id2, id22, date, time, company, obs) VALUES(@name22, @id22, @id222, @date22, @time22, @company22, @obs22)";

            DateTime today = DateTime.Today;


            string NAME22 = nameRegister.Text;
            string ID22 = documentRegister.Text;
            string ID222 = documentRegister2.Text;
            string DATE22 = today.ToString("dd/MM/yyyy");
            string TIME22 = DateTime.Now.ToString("HH:mm");
            string COMPANY22 = "SESC";
            string OBS22 = "N/A";

            cmd.Parameters.AddWithValue("@name22", NAME22);
            cmd.Parameters.AddWithValue("@id22", ID22);
            cmd.Parameters.AddWithValue("@id222", ID222);
            cmd.Parameters.AddWithValue("@date22", DATE22);
            cmd.Parameters.AddWithValue("@time22", TIME22);
            cmd.Parameters.AddWithValue("@company22", COMPANY22);
            cmd.Parameters.AddWithValue("obs22", OBS22);

            dataGridView2.ColumnCount = 7;
            dataGridView2.Columns[0].Name = NAME22;
            dataGridView2.Columns[1].Name = ID22;
            dataGridView2.Columns[2].Name = ID222;
            dataGridView2.Columns[3].Name = DATE22;
            dataGridView2.Columns[4].Name = TIME22;
            dataGridView2.Columns[5].Name = COMPANY22;
            dataGridView2.Columns[6].Name = OBS22;


            string[] row2 = new string[] { NAME22, ID22, ID222, DATE22, TIME22, COMPANY22, OBS22 };
            dataGridView2.Rows.Add(row2);
            cmd.ExecuteNonQuery();


            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            nameRegister.Text = "";
            documentRegister.Text = "";
            documentRegister2.Text = "";
            adressRegister.Text = "";
            birthdayRegister.Text = "";
            emailRegister.Text = "";
            phoneRegister.Text = "";
        }




        private void inputUser_Click(object sender, EventArgs e)
        {


            searchNow();

        }

        private void searchNow()
        {

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE FROM search WHERE search1 != ''";
            cmd.ExecuteNonQuery();


            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

        }

        //DAILY REGSITER INPUT 

        private void entrybutton_Click(object sender, EventArgs e)
        {
            if (nameSearch.Text == "")
            {
                MessageBox.Show("Usuário Inválido.", "Erro no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {




                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO daily(name2, id2, id22, date, time, company , obs) VALUES(@name2, @id2, @id22, @date, @time, @company, @obs)";


                DateTime today = DateTime.Today;



                string NAME2 = nameSearch.Text;
                string ID2 = idSearch.Text;
                string ID22 = id2Search.Text;
                string DATE2 = today.ToString("dd/MM/yyyy");
                string TIME2 = DateTime.Now.ToString("HH:mm");
                string COMPANY2 = comboBox1.SelectedItem.ToString();
                string OBS = obs.Text;

                cmd.Parameters.AddWithValue("@name2", NAME2);
                cmd.Parameters.AddWithValue("@id2", ID2);
                cmd.Parameters.AddWithValue("@id22", ID22);
                cmd.Parameters.AddWithValue("@date", DATE2);
                cmd.Parameters.AddWithValue("@time", TIME2);
                cmd.Parameters.AddWithValue("@company", COMPANY2);
                cmd.Parameters.AddWithValue("obs", OBS);

                dataGridView2.ColumnCount = 7;
                dataGridView2.Columns[0].Name = NAME2;
                dataGridView2.Columns[1].Name = ID2;
                dataGridView2.Columns[2].Name = ID22;
                dataGridView2.Columns[3].Name = DATE2;
                dataGridView2.Columns[4].Name = TIME2;
                dataGridView2.Columns[5].Name = COMPANY2;
                dataGridView2.Columns[6].Name = OBS;



                string[] row = new string[] { NAME2, ID2, ID22, DATE2, TIME2, COMPANY2, OBS };
                dataGridView2.Rows.Add(row);
                cmd.ExecuteNonQuery();


                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();

                inputUser.Text = "";

                nameSearch.Text = "";

                idSearch.Text = "";

                id2Search.Text = "";

                adressSearch.Text = "";

                emailSearch.Text = "";

                phoneSearch.Text = "";

                birthdaySearch.Text = "";

                obs.Text = "";
            }
        }
        private void veiculos_show()
        {
            dataGridView7.Rows.Clear();
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM veiculos";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            dataGridView7.Rows.Clear();


            while (dr.Read())
            {
                dataGridView7.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));

            }
            dr.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

        }



        private void cessao_show()
        {

            var con = new SQLiteConnection(cs);
            con.Open();
            DateTime today = DateTime.Today;
            var toDay = today.ToString("dd/MM/yyyy");
            dataGridView3.Rows.Clear();
            string stm = "SELECT * FROM cessao WHERE date3 LIKE " + "'" + toDay + "'";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                dataGridView3.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8));

            }
            dr.Close();
            con.Close();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }

        private void agendados_show()
        {

            var con = new SQLiteConnection(cs);
            con.Open();
            DateTime today = DateTime.Today;
            dataGridView4.Rows.Clear();
            var toDay = today.ToString("dd/MM/yyyy");
            string stm = "SELECT * FROM agendados WHERE date4 LIKE " + "'" + toDay + "'";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                dataGridView4.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5));

            }
            dr.Close();

            con.Close();
            dr.Close();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }
        private void day_use_show()
        {

            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM day_use";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            dataGridView5.Rows.Clear();

            while (dr.Read())
            {
                dataGridView5.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

            }
            dr.Close();
            con.Close();
        }
        private void outros_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM profissionais_outros";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            dataGridView6.Rows.Clear();

            while (dr.Read())
            {
                dataGridView6.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetString(9), dr.GetString(10));
            }
            dr.Close();

            con.Close();
            dr.Close();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }

        private void data_show()
        {

            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM test";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

            }

            dr.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();






        }

        private void data_show2()
        {

            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM daily";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

            }

            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }
        private void data_show3()
        {
            if (comboBox2.SelectedItem.ToString() != "CPF" && comboBox2.SelectedItem.ToString() != "RG" && comboBox2.SelectedItem.ToString() != "NOME")
            {
                MessageBox.Show("Favor inserir um critério válido de pesquisa!", "Erro na busca.");
            }


            if (comboBox2.SelectedItem.ToString() == "CPF")
            {


                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM test WHERE id LIKE " + "'" + inputUser.Text + "'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    nameSearch.Text = dr.GetString(0);
                    idSearch.Text = dr.GetString(1);
                    id2Search.Text = dr.GetString(2);
                    adressSearch.Text = dr.GetString(3);
                    birthdaySearch.Text = dr.GetString(4);
                    emailSearch.Text = dr.GetString(5);
                    phoneSearch.Text = dr.GetString(6);

                }

                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();

            }

            if (comboBox2.SelectedItem.ToString() == "RG")
            {


                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM test WHERE id2 LIKE " + "'" + inputUser.Text + "'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    nameSearch.Text = dr.GetString(0);
                    idSearch.Text = dr.GetString(1);
                    id2Search.Text = dr.GetString(2);
                    adressSearch.Text = dr.GetString(3);
                    birthdaySearch.Text = dr.GetString(4);
                    emailSearch.Text = dr.GetString(5);
                    phoneSearch.Text = dr.GetString(6);

                }


                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
            if (comboBox2.SelectedItem.ToString() == "NOME")
            {


                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM test WHERE name LIKE " + "'" + inputUser.Text + "'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    nameSearch.Text = dr.GetString(0);
                    idSearch.Text = dr.GetString(1);
                    id2Search.Text = dr.GetString(2);
                    adressSearch.Text = dr.GetString(3);
                    birthdaySearch.Text = dr.GetString(4);
                    emailSearch.Text = dr.GetString(5);
                    phoneSearch.Text = dr.GetString(6);

                }

                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }


        }
        private void data_show4()
        {


            if (comboBox3.SelectedItem.ToString() == "NOME")
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM daily INNER JOIN search ON daily.name2 LIKE '%'||search.search1||'%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();




                while (dr.Read())
                {



                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));


                }

                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }


            if (comboBox3.SelectedItem.ToString() == "CPF")
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM daily INNER JOIN search ON daily.id2 LIKE '%'||search.search1||'%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();




                while (dr.Read())
                {



                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));


                }

                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }



            if (comboBox3.SelectedItem.ToString() == "RG")
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM daily INNER JOIN search ON daily.id22 LIKE '%'||search.search1||'%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();




                while (dr.Read())
                {



                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));



                }
                dr.Close();

                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();

            }
            if (comboBox3.SelectedItem.ToString() != "RG" && comboBox3.SelectedItem.ToString() != "CPF" && comboBox3.SelectedItem.ToString() != "NOME")
            {


                MessageBox.Show("Selecione um critério de busca!", "Erro na busca.");
            }




        }



        //Seaarch database data show stuff idlk im very lost here

        private void data_show5()
        {


            if (comboBox4.SelectedItem.ToString() == "NOME")
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM test INNER JOIN search ON test.name LIKE '%'||search.search1||'%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();




                while (dr.Read())
                {



                    dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));


                }

                dr.Close();

                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }


            if (comboBox4.SelectedItem.ToString() == "CPF")
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM test INNER JOIN search ON test.id LIKE '%'||search.search1||'%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();




                while (dr.Read())
                {



                    dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));


                }
                dr.Close();

                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }



            if (comboBox4.SelectedItem.ToString() == "RG")
            {
                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM test INNER JOIN search ON test.id2 LIKE '%'||search.search1||'%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();




                while (dr.Read())
                {



                    dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));


                }
                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }




        }
        private void data_show6()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM daily INNER JOIN search ON daily.date LIKE '%'||search.search1||'%'";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();




            while (dr.Read())
            {



                dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));


            }
            dr.Close();
            dr.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }



        public void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table test(name varchar (20), id varchar(12), id2 varchar(12), adress varchar(20), birthday varchar(20), email varchar(20), telephone varchar(20))";
                    string sql2 = "create table daily(name2 varchar (20), id2 varchar(12), id22 varchar(12), date varchar(12), time varchar(20), company varchar(20), obs varchar(20))";
                    string sql3 = "create table search(search1 varchar(12))";
                    string sql4 = "create table cessao(name3 varchar (20), id3 varchar(12), id33 varchar(12), evento3 varchar(20), date3 varchar(12), timeStart3 varchar(20), timeEnd3 varchar(20), quadra3 varchar(20), aux3 varchar(20))";
                    string sql5 = "create table agendados(name4 varchar (20), id4 varchar(12), servico4 varchar(20), date4 varchar(20), time4 varchar(12), solicitante4 varchar(20))";
                    string sql6 = "create table day_use(name5 varchar (20), id5 varchar(12), date5 varchar(20), convite5 varchar(20), acompanhante5 varchar(12), acompanhante_id5 varchar(20), solicitante5 varchar(20))";
                    string sql7 = "create table ocorrencias(date6 varchar (20), porteiro6 varchar(12), name6 varchar(20), matricula6 varchar(20), motivo6 varchar(12))";

                    string sql0 = "create table veiculos(name0 varchar (20), veiculo0 varchar(20), placa0 varchar(20), periodicidade0 varchar(20), departamento0 varchar(20))";


                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    SQLiteCommand command2 = new SQLiteCommand(sql2, sqlite);
                    SQLiteCommand command3 = new SQLiteCommand(sql3, sqlite);
                    SQLiteCommand command4 = new SQLiteCommand(sql4, sqlite);
                    SQLiteCommand command5 = new SQLiteCommand(sql5, sqlite);
                    SQLiteCommand command6 = new SQLiteCommand(sql6, sqlite);
                    SQLiteCommand command7 = new SQLiteCommand(sql7, sqlite);

                    SQLiteCommand command0 = new SQLiteCommand(sql0, sqlite);

                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    command4.ExecuteNonQuery();
                    command5.ExecuteNonQuery();
                    command6.ExecuteNonQuery();
                    command7.ExecuteNonQuery();
                    command0.ExecuteNonQuery();


                    sqlite.Close();

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    command.Dispose();
                    System.Data.SQLite.SQLiteConnection.ClearAllPools();



                }


            }
            else
            {



                Console.WriteLine("not cool dude");
                return;

            }
        }




        private void Form2_Load(object sender, EventArgs e)
        {
            Create_db();

            data_show2();
            cessao_show();
            agendados_show();
            day_use_show();
            veiculos_show();
            ocorrencia_show();
            outros_show();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?", "Sair", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }









        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //SEARCH PERSON AYEEE
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (inputUser.Text == "")
            {
                MessageBox.Show("Por favor, insira dados válidos.", "Erro na busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                insertData();

            }
        }

        public void insertData()
        {

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO search(search1) VALUES(@search1)";

            string SEARCH = inputUser.Text;


            cmd.Parameters.AddWithValue("@search1", SEARCH);



            cmd.ExecuteNonQuery();



            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();


            data_show3();

        }






        private void label7_Click(object sender, EventArgs e)
        {

        }











        // Botão Deslogar e botão sair

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //EXPORTAR BAGULHOS PARA EXCEL E ETC

        private void copyAlltoClipboard()
        {
            if (isOnRightTab3 == true)
            {
                dataGridView3.RowHeadersVisible = false;
                dataGridView3.SelectAll();
                DataObject dataObj = dataGridView3.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
            }
            if (isOnRightTab2 == true)
            {
                dataGridView2.RowHeadersVisible = false;
                dataGridView2.SelectAll();
                DataObject dataObj = dataGridView2.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
            }
            if (isOnRightTab == true)
            {
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.SelectAll();
                DataObject dataObj = dataGridView1.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
            }
            if (isOnRightTab10 == true)
            {
                dataGridView6.RowHeadersVisible = false;
                dataGridView6.SelectAll();
                DataObject dataObj = dataGridView6.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
            }
        }
        private void exportExcel_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;

            xlWorkBook = xlexcel.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }


        private void imprimirTabela_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;

            printPreviewDialog1.ShowDialog();

        }


        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //Search stuff idk

        private void findEntry_Click(object sender, EventArgs e)
        {
            search1();

        }

        private void search1()
        {
            if (dataGridView2.Rows.Count == 0)
            {




                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO search(search1) VALUES(@search1)";

                string SEARCH = filterEntries.Text;


                cmd.Parameters.AddWithValue("@search1", SEARCH);



                cmd.ExecuteNonQuery();



                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
            else
            {
                return;
            }

            if (filterEntries.Text == "")
            {
                dataGridView2.Rows.Clear();
                data_show2();
            }
            else
            {
                data_show4();
            }


        }


        private void filterEntries_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();


            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE FROM search";
            cmd.ExecuteNonQuery();


            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }




        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void findEntry2_Click(object sender, EventArgs e)
        {
            search2();
        }


        private void search2()
        {

            if (dataGridView1.Rows.Count == 0)
            {




                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO search(search1) VALUES(@search1)";

                string SEARCH = filterEntries2.Text;


                cmd.Parameters.AddWithValue("@search1", SEARCH);



                cmd.ExecuteNonQuery();

                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();

            }
            else
            {
                return;
            }

            if (filterEntries2.Text == "")
            {
                dataGridView1.Rows.Clear();
                data_show();
            }
            else
            {
                data_show5();
            }
        }




        private void filterEntries2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();


            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE FROM search";
            cmd.ExecuteNonQuery();
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();


            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE FROM search";
            cmd.ExecuteNonQuery();

            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }

        private void resetDatabase()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE FROM search";
            cmd.ExecuteNonQuery();


            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }



        private void searchByDate_Click(object sender, EventArgs e)
        {

            data_show6();


            if (dataGridView2.Rows.Count == 0)
            {




                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO search(search1) VALUES(@search1)";

                string SEARCH = dateTimePicker1.Text;


                cmd.Parameters.AddWithValue("@search1", SEARCH);



                cmd.ExecuteNonQuery();



                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();


            }
            else
            {
                resetDatabase();
            }




        }

        public void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Portaria v1.4, Sesc Santa Luzia. Tyfee Solutions, 2023", "Sobre");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage10"])
            {
                isOnRightTab = false;
                isOnRightTab2 = false;
                isOnRightTab3 = false;
                isOnRightTab10 = true;
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage5"])
            {
                isOnRightTab = false;
                isOnRightTab2 = false;
                isOnRightTab3 = true;
                isOnRightTab10 = false;
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
            {
                isOnRightTab = true;
                isOnRightTab2 = false;
                isOnRightTab3 = false;
                isOnRightTab10 = false;
                filterEntries2.Focus();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                isOnRightTab = false;
                isOnRightTab2 = true;
                isOnRightTab3 = false;
                isOnRightTab10 = false;
                filterEntries.Focus();

            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                isOnRightTab = false;
                isOnRightTab2 = false;
                isOnRightTab3 = false;
                isOnRightTab10 = false;
                nameRegister.Focus();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                isOnRightTab = true;
                isOnRightTab2 = false;
                isOnRightTab3 = false;
                isOnRightTab10 = false;
                inputUser.Focus();




            }

        }




        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete && isOnRightTab == true)
            {


                dataGridView1.Columns[0].Name = "name";
                dataGridView1.Columns[1].Name = "cpf";
                dataGridView1.Columns[2].Name = "RG";
                dataGridView1.Columns[3].Name = "adress";
                dataGridView1.Columns[4].Name = "birth";
                dataGridView1.Columns[5].Name = "email";
                dataGridView1.Columns[6].Name = "tel";

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["name"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["cpf"].Value);
                string cellValue3 = Convert.ToString(selectedRow.Cells["RG"].Value);
                string cellValue4 = Convert.ToString(selectedRow.Cells["adress"].Value);
                string cellValue5 = Convert.ToString(selectedRow.Cells["birth"].Value);
                string cellValue6 = Convert.ToString(selectedRow.Cells["email"].Value);
                string cellValue7 = Convert.ToString(selectedRow.Cells["tel"].Value);


                DialogResult dialogResult = MessageBox.Show("Você gostaria de deletar esse campo? " + cellValue, "Deletar cliente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);

                    cmd.CommandText = "DELETE FROM test WHERE name LIKE " + "'" + cellValue + "'" + " AND id LIKE " + "'" + cellValue2 + "'" + " AND id2 LIKE " + "'" + cellValue3 + "'" + " AND adress LIKE " + "'" + cellValue4 + "'" + "AND birthday LIKE " + "'" + cellValue5 + "'" + "AND telephone LIKE " + "'" + cellValue7 + "'";



                    cmd.ExecuteNonQuery();

                    con.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    cmd.Dispose();
                    System.Data.SQLite.SQLiteConnection.ClearAllPools();




                    dataGridView1.Rows.Clear();
                    data_show();
                    MessageBox.Show("Cliente " + cellValue + ", " + cellValue2 + ", " + cellValue3 + ", " + cellValue4 + ", " + " apagado com sucesso", "Apagado!");
                    con.Close();

                }










            }
            if (e.KeyCode == Keys.Delete && isOnRightTab2 == true)
            {

                dataGridView2.Columns[0].Name = "nome";
                dataGridView2.Columns[1].Name = "CPF2";
                dataGridView2.Columns[2].Name = "RG2";
                dataGridView2.Columns[3].Name = "data";
                dataGridView2.Columns[4].Name = "time";

                int selectedrowindex2 = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow2 = dataGridView2.Rows[selectedrowindex2];
                string cellValue_ = Convert.ToString(selectedRow2.Cells["nome"].Value);
                string cellValue_2 = Convert.ToString(selectedRow2.Cells["CPF2"].Value);
                string cellValue_3 = Convert.ToString(selectedRow2.Cells["RG2"].Value);
                string cellValue_4 = Convert.ToString(selectedRow2.Cells["data"].Value);
                string cellValue_5 = Convert.ToString(selectedRow2.Cells["time"].Value);

                DialogResult dialogResult2 = MessageBox.Show("Você gostaria de deletar esse campo?" + cellValue_ + ", " + cellValue_2 + ", " + cellValue_4 + ", " + cellValue_5, "Deletar cliente", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);

                    cmd.CommandText = "DELETE FROM daily WHERE name2 LIKE " + "'" + cellValue_ + "'" + "AND id2 LIKE " + "'" + cellValue_2 + "'" + "AND id22 LIKE " + "'" + cellValue_3 + "'" + "AND date LIKE " + "'" + cellValue_4 + "'" + "AND time LIKE " + "'" + cellValue_5 + "'";



                    cmd.ExecuteNonQuery();

                    con.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    cmd.Dispose();
                    System.Data.SQLite.SQLiteConnection.ClearAllPools();


                    MessageBox.Show("Registro " + cellValue_ + ", " + cellValue_2 + ", " + cellValue_4 + ", " + cellValue_5 + "apagado com sucesso", "Apagado!");

                    dataGridView2.Rows.Clear();
                    data_show2();

                }
            }
            if (e.KeyCode == Keys.Delete && isOnRightTab10 == true)
            {


                dataGridView6.Columns[0].Name = "name4";
                dataGridView6.Columns[1].Name = "cpf4";
                dataGridView6.Columns[2].Name = "rg4";
                dataGridView6.Columns[3].Name = "empresa4";
                dataGridView6.Columns[4].Name = "data4";
                dataGridView6.Columns[5].Name = "timeStart4";
                dataGridView6.Columns[6].Name = "timeEnd4";


                int selectedrowindex4 = dataGridView6.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow4 = dataGridView6.Rows[selectedrowindex4];
                string cellValue___ = Convert.ToString(selectedRow4.Cells["name4"].Value);
                string cellValue___2 = Convert.ToString(selectedRow4.Cells["cpf4"].Value);
                string cellValue___3 = Convert.ToString(selectedRow4.Cells["rg4"].Value);
                string cellValue___4 = Convert.ToString(selectedRow4.Cells["empresa4"].Value);
                string cellValue___5 = Convert.ToString(selectedRow4.Cells["data4"].Value);
                string cellValue___6 = Convert.ToString(selectedRow4.Cells["timeStart4"].Value);
                string cellValue___7 = Convert.ToString(selectedRow4.Cells["timeEnd4"].Value);


                DialogResult dialogResult4 = MessageBox.Show("Você gostaria de deletar esse campo? " + cellValue___, "Deletar cliente", MessageBoxButtons.YesNo);
                if (dialogResult4 == DialogResult.Yes)
                {

                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);

                    cmd.CommandText = "DELETE FROM profissionais_outros WHERE name7 LIKE " + "'" + cellValue___ + "'" + " AND id7 LIKE " + "'" + cellValue___2 + "'" + " AND id77 LIKE " + "'" + cellValue___3 + "'" + " AND empresa7 LIKE " + "'" + cellValue___4 + "'" + " AND data7 LIKE " + "'" + cellValue___5 + "'" + "AND timeStart7 LIKE " + "'" + cellValue___6 + "'";



                    cmd.ExecuteNonQuery();

                    dataGridView6.Rows.Clear();
                    outros_show();
                    MessageBox.Show("Cliente " + cellValue___ + ", " + cellValue___2 + ", " + cellValue___3 + ", " + cellValue___4 + ", " + " apagado com sucesso", "Apagado!");
                    con.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    cmd.Dispose();
                    System.Data.SQLite.SQLiteConnection.ClearAllPools();

                }



            }
            if (e.KeyCode == Keys.F5)
            {

                dataGridView3.Rows.Clear();
                cessao_show();

                dataGridView4.Rows.Clear();
                agendados_show();


                dataGridView5.Rows.Clear();
                day_use_show();

                dataGridView6.Rows.Clear();
                outros_show();

                dataGridView7.Rows.Clear();
                veiculos_show();

            }
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {


            dataGridView1.Columns[0].Name = "name";
            dataGridView1.Columns[1].Name = "cpf";
            dataGridView1.Columns[2].Name = "RG";
            dataGridView1.Columns[3].Name = "adress";
            dataGridView1.Columns[4].Name = "birth";
            dataGridView1.Columns[5].Name = "email";
            dataGridView1.Columns[6].Name = "tel";

            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["name"].Value);
            string cellValue2 = Convert.ToString(selectedRow.Cells["cpf"].Value);
            string cellValue3 = Convert.ToString(selectedRow.Cells["RG"].Value);
            string cellValue4 = Convert.ToString(selectedRow.Cells["adress"].Value);
            string cellValue5 = Convert.ToString(selectedRow.Cells["birth"].Value);
            string cellValue6 = Convert.ToString(selectedRow.Cells["email"].Value);
            string cellValue7 = Convert.ToString(selectedRow.Cells["tel"].Value);

            Form6 f6 = new Form6();



            ((System.Windows.Forms.TextBox)f6.Controls["nameRegister"]).Text = cellValue;
            ((System.Windows.Forms.TextBox)f6.Controls["documentRegister"]).Text = cellValue2;
            ((System.Windows.Forms.TextBox)f6.Controls["documentRegister2"]).Text = cellValue3;
            ((System.Windows.Forms.TextBox)f6.Controls["adressRegister"]).Text = cellValue4;

            ((System.Windows.Forms.TextBox)f6.Controls["emailRegister"]).Text = cellValue6;
            ((System.Windows.Forms.TextBox)f6.Controls["phoneRegister"]).Text = cellValue7;


            f6.ShowDialog();
        }
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {


            dataGridView2.Columns[0].Name = "nome";
            dataGridView2.Columns[1].Name = "CPF2";
            dataGridView2.Columns[2].Name = "RG2";
            dataGridView2.Columns[3].Name = "data";
            dataGridView2.Columns[4].Name = "time";
            dataGridView2.Columns[5].Name = "obsCol";
            dataGridView2.Columns[6].Name = "companyCol";


            int selectedrowindex2 = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow2 = dataGridView2.Rows[selectedrowindex2];
            string cellValue_ = Convert.ToString(selectedRow2.Cells["nome"].Value);
            string cellValue_2 = Convert.ToString(selectedRow2.Cells["CPF2"].Value);
            string cellValue_3 = Convert.ToString(selectedRow2.Cells["RG2"].Value);
            string cellValue_4 = Convert.ToString(selectedRow2.Cells["data"].Value);
            string cellValue_5 = Convert.ToString(selectedRow2.Cells["time"].Value);
            string cellValue_6 = Convert.ToString(selectedRow2.Cells["obsCol"].Value);
            string cellValue_7 = Convert.ToString(selectedRow2.Cells["companyCol"].Value);

            Form4 frm4 = new Form4();
            ((System.Windows.Forms.Label)frm4.Controls["label1"]).Text = cellValue_;
            ((System.Windows.Forms.Label)frm4.Controls["label2"]).Text = cellValue_2;
            ((System.Windows.Forms.Label)frm4.Controls["label8"]).Text = cellValue_3;
            ((System.Windows.Forms.DataGridView)frm4.Controls["dataGridView2"]).Rows.Clear();

            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM daily WHERE name2 LIKE" + "'" + cellValue_ + "'";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                ((System.Windows.Forms.DataGridView)frm4.Controls["dataGridView2"]).Rows.Insert(0, dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

            }

            dr.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();

            System.Data.SQLite.SQLiteConnection.ClearAllPools();
            ((System.Windows.Forms.Label)frm4.Controls["label6"]).Text = ((System.Windows.Forms.DataGridView)frm4.Controls["dataGridView2"]).Rows.Count.ToString();



            DialogResult dr1 = frm4.ShowDialog(this);


        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();

            var con = new SQLiteConnection(cs);
            con.Open();

            DateTime year = DateTime.Today;
            var currentYear = year.ToString("yyyy");


            if (comboBox5.SelectedItem.ToString() == "FILTRAR POR MÊS" && dataGridView2.Rows.Count == 0)
            {


            }



            if (comboBox5.SelectedItem.ToString() == "JANEIRO" && dataGridView2.Rows.Count == 0)
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/01/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }

                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
            if (comboBox5.SelectedItem.ToString() == "FEVEREIRO")
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/02/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }

                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
            if (comboBox5.SelectedItem.ToString() == "MARÇO")
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/03/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }
                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
            if (comboBox5.SelectedItem.ToString() == "ABRIL")
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/04/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }
                dr.Close();

                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
            if (comboBox5.SelectedItem.ToString() == "MAIO")
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/05/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }

                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
            if (comboBox5.SelectedItem.ToString() == "JUNHO")
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/06/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }

                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
            if (comboBox5.SelectedItem.ToString() == "JULHO")
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/07/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }
                dr.Close();

                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
            if (comboBox5.SelectedItem.ToString() == "AGOSTO")
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/08/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }
                dr.Close();

                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }

            if (comboBox5.SelectedItem.ToString() == "SETEMBRO")
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/09/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }
                dr.Close();

                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }


            if (comboBox5.SelectedItem.ToString() == "OUTUBRO")
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/10/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }
                dr.Close();

                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
            if (comboBox5.SelectedItem.ToString() == "NOVEMBRO")
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/11/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }
                dr.Close();

                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }




            if (comboBox5.SelectedItem.ToString() == "DEZEMBRO")
            {


                dataGridView2.Rows.Clear();
                string stm = "SELECT * FROM daily WHERE date LIKE '%/12/" + currentYear + "%'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                }
                dr.Close();
                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //Change focus on enter press

        private void nameRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                documentRegister.Focus();

        }

        private void documentRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                documentRegister2.Focus();

        }
        private void documentRegister2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                adressRegister.Focus();
        }
        private void address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                emailRegister.Focus();
        }
        private void birthday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                emailRegister.Focus();
        }


        private void emailRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                phoneRegister.Focus();
        }
        private void phoneRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerNow();
                e.SuppressKeyPress = true;
            }

        }
        private void inputUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                searchNow();
                insertData();
                e.SuppressKeyPress = true;
            }
        }

        private void filterEntries_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search1();
                e.SuppressKeyPress = true;
            }

        }
        private void filterEntries2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search2();
                e.SuppressKeyPress = true;
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        //Hint text for the textboxes

        private void userBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Critério de Busca")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void userBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Critério de Busca";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void userBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Porteiro")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }
        private void userBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Porteiro";
                textBox6.ForeColor = Color.Silver;
            }
        }


        private void userBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Nome do Solicitante")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }
        private void userBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Nome do Solicitante";
                textBox7.ForeColor = Color.Silver;
            }
        }
        private void userBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Matrícula")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
            }
        }
        private void userBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Matrícula";
                textBox8.ForeColor = Color.Silver;
            }
        }


        private void userBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Motivo")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.Black;
            }
        }
        private void userBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Motivo";
                textBox9.ForeColor = Color.Silver;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            insertData2();
        }


        private void ocorrencia_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM ocorrencias";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();




            while (dr.Read())
            {



                dataGridView8.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));



            }

            dr.Close();
            dr.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }



        private void insertData2()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO ocorrencias(date6, porteiro6, name6, matricula6, motivo6) VALUES(@date6, @porteiro6, @name6, @matricula6, @motivo6)";


            String DATE6 = dateTimePicker4.Text;
            String PORTEIRO6 = textBox6.Text;
            String NAME6 = textBox7.Text;
            String MATRICULA6 = textBox8.Text;
            String MOTIVO6 = textBox9.Text;



            cmd.Parameters.AddWithValue("@date6", DATE6);
            cmd.Parameters.AddWithValue("@porteiro6", PORTEIRO6);
            cmd.Parameters.AddWithValue("@name6", NAME6);
            cmd.Parameters.AddWithValue("@matricula6", MATRICULA6);
            cmd.Parameters.AddWithValue("@motivo6", MOTIVO6);

            dataGridView8.ColumnCount = 5;

            dataGridView8.Columns[0].Name = DATE6;
            dataGridView8.Columns[1].Name = PORTEIRO6;
            dataGridView8.Columns[2].Name = NAME6;
            dataGridView8.Columns[3].Name = MATRICULA6;
            dataGridView8.Columns[4].Name = MOTIVO6;

            string[] row = new string[] { DATE6, PORTEIRO6, NAME6, MATRICULA6, MOTIVO6 };
            dataGridView8.Rows.Add(row);

            cmd.ExecuteNonQuery();




            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }


        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            if (isOnRightTab == true)
            {


                Bitmap imagebmp = new Bitmap(this.Width, this.Height);
                dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, this.Width, this.Height));
                e.Graphics.DrawImage(imagebmp, 0, 00);

            }
            if (isOnRightTab2 == true)
            {


                Bitmap imagebmp = new Bitmap(this.Width, this.Height);
                dataGridView2.DrawToBitmap(imagebmp, new Rectangle(0, 0, this.Width, this.Height));
                e.Graphics.DrawImage(imagebmp, 0, 00);
            }
            if (isOnRightTab3 == true)
            {


                Bitmap imagebmp = new Bitmap(this.Width, this.Height);
                dataGridView3.DrawToBitmap(imagebmp, new Rectangle(0, 0, this.Width, this.Height));
                e.Graphics.DrawImage(imagebmp, 0, 00);
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }


        private void trocarDeUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 f1 = new Form1();
            f1.ShowDialog();

            this.Close();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void userBox20_Enter(object sender, EventArgs e)
        {
            if (textBox20.Text == "Nome")
            {
                textBox20.Text = "";
                textBox20.ForeColor = Color.Black;
            }
        }
        private void userBox20_Leave(object sender, EventArgs e)
        {
            if (textBox20.Text == "")
            {
                textBox20.Text = "Nome";
                textBox20.ForeColor = Color.Silver;
            }
        }


        private void userBox21_Enter(object sender, EventArgs e)
        {
            if (textBox21.Text == "Veículo")
            {
                textBox21.Text = "";
                textBox21.ForeColor = Color.Black;
            }
        }
        private void userBox21_Leave(object sender, EventArgs e)
        {
            if (textBox21.Text == "")
            {
                textBox21.Text = "Veículo";
                textBox21.ForeColor = Color.Silver;
            }
        }

        private void userBox22_Enter(object sender, EventArgs e)
        {
            if (textBox22.Text == "Placa")
            {
                textBox22.Text = "";
                textBox22.ForeColor = Color.Black;
            }
        }
        private void userBox22_Leave(object sender, EventArgs e)
        {
            if (textBox22.Text == "")
            {
                textBox22.Text = "Placa";
                textBox22.ForeColor = Color.Silver;
            }
        }

        private void userBox23_Enter(object sender, EventArgs e)
        {
            if (textBox23.Text == "Periodicidade")
            {
                textBox23.Text = "";
                textBox23.ForeColor = Color.Black;
            }
        }
        private void userBox23_Leave(object sender, EventArgs e)
        {
            if (textBox23.Text == "")
            {
                textBox23.Text = "Periodicidade";
                textBox23.ForeColor = Color.Silver;
            }
        }




        private void userBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Nome Completo do Prestador")
            {
                textBox10.Text = "";
                textBox10.ForeColor = Color.Black;
            }
        }
        private void userBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "Nome Completo do Prestador";
                textBox10.ForeColor = Color.Silver;
            }
        }
        private void userBox11_Enter(object sender, EventArgs e)
        {
            if (textBox11.Text == "CPF")
            {
                textBox11.Text = "";
                textBox11.ForeColor = Color.Black;
            }
        }
        private void userBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "CPF";
                textBox11.ForeColor = Color.Silver;
            }
        }
        private void userBox12_Enter(object sender, EventArgs e)
        {
            if (textBox12.Text == "RG")
            {
                textBox12.Text = "";
                textBox12.ForeColor = Color.Black;
            }
        }
        private void userBox12_Leave(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                textBox12.Text = "RG";
                textBox12.ForeColor = Color.Silver;
            }
        }
        private void userBox19_Enter(object sender, EventArgs e)
        {
            if (textBox19.Text == "Empresa")
            {
                textBox19.Text = "";
                textBox19.ForeColor = Color.Black;
            }
        }
        private void userBox19_Leave(object sender, EventArgs e)
        {
            if (textBox19.Text == "")
            {
                textBox19.Text = "Empresa";
                textBox19.ForeColor = Color.Silver;
            }
        }
        private void userBox24_Enter(object sender, EventArgs e)
        {
            if (textBox24.Text == "Veículo")
            {
                textBox24.Text = "";
                textBox24.ForeColor = Color.Black;
            }
        }
        private void userBox24_Leave(object sender, EventArgs e)
        {
            if (textBox24.Text == "")
            {
                textBox24.Text = "Veículo";
                textBox24.ForeColor = Color.Silver;
            }
        }
        private void userBox25_Enter(object sender, EventArgs e)
        {
            if (textBox25.Text == "Placa")
            {
                textBox25.Text = "";
                textBox25.ForeColor = Color.Black;
            }
        }
        private void userBox25_Leave(object sender, EventArgs e)
        {
            if (textBox25.Text == "")
            {
                textBox25.Text = "Placa";
                textBox25.ForeColor = Color.Silver;
            }
        }



        private void userBox26_Enter(object sender, EventArgs e)
        {
            if (textBox26.Text == "Serviço a ser realizado")
            {
                textBox26.Text = "";
                textBox26.ForeColor = Color.Black;
            }
        }
        private void userBox26_Leave(object sender, EventArgs e)
        {
            if (textBox26.Text == "")
            {
                textBox26.Text = "Serviço a ser realizado";
                textBox26.ForeColor = Color.Silver;
            }
        }
        private void userBox27_Enter(object sender, EventArgs e)
        {
            if (textBox27.Text == "Solicitante")
            {
                textBox27.Text = "";
                textBox27.ForeColor = Color.Black;
            }
        }
        private void userBox27_Leave(object sender, EventArgs e)
        {
            if (textBox27.Text == "")
            {
                textBox27.Text = "Solicitante";
                textBox27.ForeColor = Color.Silver;
            }
        }



        private void dataGridView7_DoubleClick(object sender, EventArgs e)
        {


            dataGridView7.Columns[0].Name = "name0";
            dataGridView7.Columns[1].Name = "veiculo0";
            dataGridView7.Columns[2].Name = "placa0";
            dataGridView7.Columns[3].Name = "periodicidade0";
            dataGridView7.Columns[4].Name = "departamento0";


            int selectedrowindex = dataGridView7.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView7.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["name0"].Value);
            string cellValue2 = Convert.ToString(selectedRow.Cells["veiculo0"].Value);
            string cellValue3 = Convert.ToString(selectedRow.Cells["placa0"].Value);
            string cellValue4 = Convert.ToString(selectedRow.Cells["periodicidade0"].Value);
            string cellValue5 = Convert.ToString(selectedRow.Cells["departamento0"].Value);


            Form7 f7 = new Form7();



            ((System.Windows.Forms.TextBox)f7.Controls["textBox201"]).Text = cellValue;
            ((System.Windows.Forms.TextBox)f7.Controls["textBox202"]).Text = cellValue2;
            ((System.Windows.Forms.TextBox)f7.Controls["textBox203"]).Text = cellValue3;
            ((System.Windows.Forms.TextBox)f7.Controls["textBox204"]).Text = cellValue4;
            ((System.Windows.Forms.ComboBox)f7.Controls["comboBox6"]).SelectedItem = cellValue5;


            ((System.Windows.Forms.Label)f7.Controls["label7"]).Text = cellValue;
            ((System.Windows.Forms.Label)f7.Controls["label8"]).Text = cellValue2;
            ((System.Windows.Forms.Label)f7.Controls["label9"]).Text = cellValue3;
            ((System.Windows.Forms.Label)f7.Controls["label10"]).Text = cellValue4;

            ((System.Windows.Forms.Label)f7.Controls["label11"]).Text = cellValue5;


            f7.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchOutros();
        }
        private void searchOutros()
        {
            if (comboBox7.SelectedItem.ToString() != "CPF" && comboBox7.SelectedItem.ToString() != "RG" && comboBox7.SelectedItem.ToString() != "NOME")
            {
                MessageBox.Show("Favor inserir um critério válido de pesquisa!", "Erro na busca.");
            }


            if (comboBox7.SelectedItem.ToString() == "CPF")
            {


                textBox10.ForeColor = Color.Black;
                textBox11.ForeColor = Color.Black;
                textBox12.ForeColor = Color.Black;
                textBox19.ForeColor = Color.Black;
                textBox24.ForeColor = Color.Black;
                textBox25.ForeColor = Color.Black;


                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM profissionais_outros WHERE id7 LIKE " + "'" + textBox1.Text + "'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    textBox10.Text = dr.GetString(0);
                    textBox11.Text = dr.GetString(1);
                    textBox12.Text = dr.GetString(2);
                    textBox19.Text = dr.GetString(3);
                    textBox24.Text = dr.GetString(7);
                    textBox25.Text = dr.GetString(8);


                }

                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();

            }

            if (comboBox7.SelectedItem.ToString() == "RG")
            {
                textBox10.ForeColor = Color.Black;
                textBox11.ForeColor = Color.Black;
                textBox12.ForeColor = Color.Black;
                textBox19.ForeColor = Color.Black;
                textBox24.ForeColor = Color.Black;
                textBox25.ForeColor = Color.Black;

                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM profissionais_outros WHERE id77 LIKE " + "'" + textBox1.Text + "'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    textBox10.Text = dr.GetString(0);
                    textBox11.Text = dr.GetString(1);
                    textBox12.Text = dr.GetString(2);
                    textBox19.Text = dr.GetString(3);
                    textBox24.Text = dr.GetString(7);
                    textBox25.Text = dr.GetString(8);

                    textBox24.ForeColor = Color.Black;
                    textBox25.ForeColor = Color.Black;

                }


                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
            if (comboBox7.SelectedItem.ToString() == "NOME")
            {

                textBox10.ForeColor = Color.Black;
                textBox11.ForeColor = Color.Black;
                textBox12.ForeColor = Color.Black;
                textBox19.ForeColor = Color.Black;

                var con = new SQLiteConnection(cs);
                con.Open();

                string stm = "SELECT * FROM profissionais_outros WHERE name7 LIKE " + "'" + textBox1.Text + "'";
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    textBox10.Text = dr.GetString(0);
                    textBox11.Text = dr.GetString(1);
                    textBox12.Text = dr.GetString(2);
                    textBox19.Text = dr.GetString(3);
                    textBox24.Text = dr.GetString(7);
                    textBox25.Text = dr.GetString(8);
                }

                dr.Close();
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();
            }
        }

    }
}









       





    
    



  
