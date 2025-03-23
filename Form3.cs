using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Portaria
{
    public partial class Form3 : Form
    {


        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";
        SQLiteCommand cmd;
        SQLiteConnection con;
        SQLiteDataReader dr;
        bool IsOnTab1;
        bool IsOnTab2;
        bool IsOnTab3;
        bool IsOnTab4;
        bool IsOnTab5;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            IsOnTab1 = true;
            IsOnTab2 = false;
            IsOnTab3 = false;
            IsOnTab4 = false;
            IsOnTab5 = false;

            comboBox1.Items.Add("POSTO DE SAÚDE");
            comboBox1.Items.Add("TERCEIRA IDADE");
            comboBox1.SelectedItem = "POSTO DE SAÚDE";

            add.TabStop = false;
            add.FlatStyle = FlatStyle.Flat;
            add.FlatAppearance.BorderSize = 0;

            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;

            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;




            Icon myIcon = new Icon("Resources/yass.ico");
            this.Icon = myIcon;
            this.WindowState = FormWindowState.Maximized;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            dateTimePicker9.Format = DateTimePickerFormat.Custom;
            dateTimePicker9.CustomFormat = "dd/MM/yyyy";

            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.CustomFormat = "HH:mm";
            dateTimePicker6.ShowUpDown = true;

            dateTimePicker8.Format = DateTimePickerFormat.Custom;
            dateTimePicker8.CustomFormat = "HH:mm";
            dateTimePicker8.ShowUpDown = true;


            dateTimePicker11.Format = DateTimePickerFormat.Custom;
            dateTimePicker11.CustomFormat = "dd/MM/yyyy";


            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.ShowUpDown = true;

            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "HH:mm";
            dateTimePicker3.ShowUpDown = true;


            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd/MM/yyyy";


            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker5.CustomFormat = "HH:mm";
            dateTimePicker5.ShowUpDown = true;

            dateTimePicker7.Format = DateTimePickerFormat.Custom;
            dateTimePicker7.CustomFormat = "dd/MM/yyyy";


            comboBox2.Items.Add("EVENTO");
            comboBox2.Items.Add("PETECA");
            comboBox2.Items.Add("BASQUETE");
            comboBox2.Items.Add("VOLEIBOL");
            comboBox2.Items.Add("OUTRO");
            comboBox2.SelectedItem = "EVENTO";

            comboBox3.Items.Add("QUADRA");
            comboBox3.Items.Add("QUADRA POLIESPORTIVA I");
            comboBox3.Items.Add("QUADRA POLIESPORTIVA II");
            comboBox3.Items.Add("QUADRA DE VOLEIBOL");
            comboBox3.Items.Add("QUADRA DE PETECA I");
            comboBox3.Items.Add("QUADRA DE PETECA II");
            comboBox3.Items.Add("QUADRA DE BASQUETE");
            comboBox3.SelectedItem = "QUADRA";

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
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView4.RowHeadersVisible = false;


            dataGridView5.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView5.EnableHeadersVisualStyles = false;
            dataGridView5.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView5.RowHeadersVisible = false;

            cessao_show();
            agendados_show();
            day_use_show();
            veiculos_show();
            outros_show();
        }


        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertData2();

        }

        private void trocarDeUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 f1 = new Form1();
            f1.ShowDialog();

            this.Close();
            this.Visible = false;
        }


        public void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Portaria v1.4, Sesc Santa Luzia", "Sobre");
        }
        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?", "Sair", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
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

                using (var gridlinePen = new Pen(dataGridView2.GridColor, 1))

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

                using (var gridlinePen = new Pen(dataGridView1.GridColor, 1))

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
        //ALL THE HINT TEXT STUFF
        //DOWNDODA
        //SDAFKJASPJKDFPOKFDP´SDLDFAS
        //ASDJASIDHJIWEQFJWEOFKWEDFWED


        private void userBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nome")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }
        private void userBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nome";
                textBox1.ForeColor = Color.Silver;
            }
        }



        private void userBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "CPF")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
        private void userBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "CPF";
                textBox2.ForeColor = Color.Silver;
            }
        }
        private void userBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "RG")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }
        private void userBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "RG";
                textBox3.ForeColor = Color.Silver;
            }
        }
      

        private void userBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Auxiliar Responsável/Solicitante")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }
        private void userBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Auxiliar Responsável/Solicitante";
                textBox5.ForeColor = Color.Silver;
            }
        }


        private void userBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Nome")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }
        private void userBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Nome";
                textBox6.ForeColor = Color.Silver;
            }
        }


        private void userBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "CPF")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }
        private void userBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "CPF";
                textBox7.ForeColor = Color.Silver;
            }
        }
        private void userBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Serviço")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
            }
        }
        private void userBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Serviço";
                textBox8.ForeColor = Color.Silver;
            }
        }

        private void userBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Solicitante")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.Black;
            }
        }
        private void userBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Solicitante";
                textBox9.ForeColor = Color.Silver;
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








        private void userBox13_Enter(object sender, EventArgs e)
        {
            if (textBox13.Text == "Nome")
            {
                textBox13.Text = "";
                textBox13.ForeColor = Color.Black;
            }
        }
        private void userBox13_Leave(object sender, EventArgs e)
        {
            if (textBox13.Text == "")
            {
                textBox13.Text = "Nome";
                textBox13.ForeColor = Color.Silver;
            }
        }


        private void userBox14_Enter(object sender, EventArgs e)
        {
            if (textBox14.Text == "CPF")
            {
                textBox14.Text = "";
                textBox14.ForeColor = Color.Black;
            }
        }
        private void userBox14_Leave(object sender, EventArgs e)
        {
            if (textBox14.Text == "")
            {
                textBox14.Text = "CPF";
                textBox14.ForeColor = Color.Silver;
            }
        }

        private void userBox15_Enter(object sender, EventArgs e)
        {
            if (textBox15.Text == "Nº do Convite")
            {
                textBox15.Text = "";
                textBox15.ForeColor = Color.Black;
            }
        }
        private void userBox15_Leave(object sender, EventArgs e)
        {
            if (textBox15.Text == "")
            {
                textBox15.Text = "Nº do Convite";
                textBox15.ForeColor = Color.Silver;
            }
        }

        private void userBox16_Enter(object sender, EventArgs e)
        {
            if (textBox16.Text == "Acompanhante")
            {
                textBox16.Text = "";
                textBox16.ForeColor = Color.Black;
            }
        }
        private void userBox16_Leave(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                textBox16.Text = "Acompanhante";
                textBox16.ForeColor = Color.Silver;
            }
        }


        private void userBox17_Enter(object sender, EventArgs e)
        {
            if (textBox17.Text == "CPF ou RG do Acompanhante")
            {
                textBox17.Text = "";
                textBox17.ForeColor = Color.Black;
            }
        }
        private void userBox17_Leave(object sender, EventArgs e)
        {
            if (textBox17.Text == "")
            {
                textBox17.Text = "CPF ou RG do Acompanhante";
                textBox17.ForeColor = Color.Silver;
            }
        }


        private void userBox18_Enter(object sender, EventArgs e)
        {
            if (textBox18.Text == "Solicitante")
            {
                textBox18.Text = "";
                textBox18.ForeColor = Color.Black;
            }
        }
        private void userBox18_Leave(object sender, EventArgs e)
        {
            if (textBox18.Text == "")
            {
                textBox18.Text = "Solicitante";
                textBox18.ForeColor = Color.Silver;
            }
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

        //IT ENDS HERE
        //IT ENDS HERE
        //IT ENDS HERE
        //IT ENDS HERE
        //IT ENDS HERE 






        private void insertData()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO cessao(name3, id3, id33, evento3, date3, timeStart3, timeEnd3, quadra3, aux3) VALUES(@name3, @id3, @id33, @evento3, @date3, @timeStart3, @timeEnd3, @quadra3, @aux3)";






            string NAME3 = textBox1.Text;
            string ID3 = textBox2.Text;
            string ID33 = textBox3.Text;
            string EVENTO3 = comboBox2.SelectedItem.ToString();
            string DATE3 = dateTimePicker11.Text;
            string TIMESTART3 = dateTimePicker2.Text;
            string TIMEEND3 = dateTimePicker3.Text;
            string QUADRA3 = comboBox3.SelectedItem.ToString();
            string AUX3 = textBox5.Text;

            cmd.Parameters.AddWithValue("@name3", NAME3);
            cmd.Parameters.AddWithValue("@id3", ID3);
            cmd.Parameters.AddWithValue("@id33", ID33);
            cmd.Parameters.AddWithValue("@evento3", EVENTO3);
            cmd.Parameters.AddWithValue("@date3", DATE3);
            cmd.Parameters.AddWithValue("@timeStart3", TIMESTART3);
            cmd.Parameters.AddWithValue("@timeEnd3", TIMEEND3);
            cmd.Parameters.AddWithValue("@quadra3", QUADRA3);
            cmd.Parameters.AddWithValue("@aux3", AUX3);

            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = NAME3;
            dataGridView1.Columns[1].Name = ID3;
            dataGridView1.Columns[2].Name = ID33;
            dataGridView1.Columns[4].Name = EVENTO3;
            dataGridView1.Columns[4].Name = DATE3;
            dataGridView1.Columns[5].Name = TIMESTART3;
            dataGridView1.Columns[6].Name = TIMEEND3;
            dataGridView1.Columns[7].Name = QUADRA3;
            dataGridView1.Columns[8].Name = AUX3;



            string[] row = new string[] { NAME3, ID3, ID33, EVENTO3, DATE3, TIMESTART3, TIMEEND3, QUADRA3,AUX3 };
            dataGridView1.Rows.Add(row);
            cmd.ExecuteNonQuery();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            textBox1.Text = "Nome";

            textBox2.Text = "CPF";

            textBox3.Text = "RG";
            textBox1.ForeColor = Color.Silver;
            textBox2.ForeColor = Color.Silver;
            textBox3.ForeColor = Color.Silver;

        }

        private void insertData2()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO agendados(name4, id4, servico4, date4, time4, solicitante4) VALUES (@name4, @id4, @servico4, @date4, @time4, @solicitante4)";

            string NAME4 = textBox6.Text;
            string ID4 = textBox7.Text;
            string SERVICO4 = textBox8.Text;
            string DATE4 = dateTimePicker4.Text;
            string TIME4 = dateTimePicker5.Text;
            string SOLICITANTE4 = textBox9.Text;


            cmd.Parameters.AddWithValue("@name4", NAME4);
            cmd.Parameters.AddWithValue("@id4", ID4);
            cmd.Parameters.AddWithValue("@servico4", SERVICO4);
            cmd.Parameters.AddWithValue("@date4", DATE4);
            cmd.Parameters.AddWithValue("@time4", TIME4);
            cmd.Parameters.AddWithValue("@solicitante4", SOLICITANTE4);



            dataGridView4.ColumnCount = 6;
            dataGridView4.Columns[0].Name = NAME4;
            dataGridView4.Columns[1].Name = ID4;
            dataGridView4.Columns[2].Name = SERVICO4;
            dataGridView4.Columns[3].Name = DATE4;
            dataGridView4.Columns[4].Name = TIME4;
            dataGridView4.Columns[5].Name = SOLICITANTE4;




            string[] row = new string[] { NAME4, ID4, SERVICO4, DATE4, TIME4, SOLICITANTE4 };
            dataGridView4.Rows.Add(row);
            cmd.ExecuteNonQuery();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            textBox6.Text = "Nome";

            textBox7.Text = "CPF";

            textBox8.Text = "Serviço";

            textBox9.Text = "Solicitante";

            textBox6.ForeColor = Color.Silver;
            textBox7.ForeColor = Color.Silver;
            textBox8.ForeColor = Color.Silver;
            textBox9.ForeColor = Color.Silver;

        }

        private void insertData3()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO day_use(name5, id5, convite5, date5, acompanhante5, acompanhante_id5, solicitante5) VALUES (@name5, @id5, @convite5, @servico5, @date5, @time5, @solicitante5)";

            string NAME5 = textBox13.Text;
            string ID5 = textBox14.Text;
            string CONVITE5 = textBox15.Text;
            string DATE5 = dateTimePicker7.Text;
            string ACOMPANHANTE5 = textBox16.Text;
            string ACOMPANHANTE_ID5 = textBox17.Text;
            string SOLICITANTE5 = textBox18.Text;


            cmd.Parameters.AddWithValue("@name5", NAME5);
            cmd.Parameters.AddWithValue("@id5", ID5);
            cmd.Parameters.AddWithValue("@convite5", ID5);
            cmd.Parameters.AddWithValue("@servico5", DATE5);
            cmd.Parameters.AddWithValue("@date5", ACOMPANHANTE5);
            cmd.Parameters.AddWithValue("@time5", ACOMPANHANTE_ID5);
            cmd.Parameters.AddWithValue("@solicitante5", SOLICITANTE5);



            dataGridView5.ColumnCount = 7;
            dataGridView5.Columns[0].Name = NAME5;
            dataGridView5.Columns[1].Name = ID5;
            dataGridView5.Columns[2].Name = DATE5;
            dataGridView5.Columns[3].Name = CONVITE5;
            dataGridView5.Columns[4].Name = ACOMPANHANTE5;
            dataGridView5.Columns[5].Name = ACOMPANHANTE_ID5;
            dataGridView5.Columns[6].Name = SOLICITANTE5;




            string[] row = new string[] { NAME5, ID5, DATE5, CONVITE5, ACOMPANHANTE5, ACOMPANHANTE_ID5, SOLICITANTE5 };
            dataGridView5.Rows.Add(row);
            cmd.ExecuteNonQuery();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            textBox13.Text = "Nome";
            textBox14.Text = "CPF";
            textBox15.Text = "Nº do Convite";
            textBox16.Text = "Acompanhante";
            textBox17.Text = "CPF ou RG do Acompanhante";
            textBox18.Text = "Solicitante";

            textBox13.ForeColor = Color.Silver;
            textBox14.ForeColor = Color.Silver;
            textBox15.ForeColor = Color.Silver;
            textBox16.ForeColor = Color.Silver;
            textBox18.ForeColor = Color.Silver;

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
            string DEPARTAMENTO0 = comboBox1.SelectedItem.ToString();



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
            dataGridView3.Rows.Add(row);
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
            string DATA7 = dateTimePicker1.Text;
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


            dataGridView2.ColumnCount = 11;
            dataGridView2.Columns[0].Name = NAME7;
            dataGridView2.Columns[1].Name = ID7;
            dataGridView2.Columns[2].Name = ID77;
            dataGridView2.Columns[3].Name = EMPRESA7;
            dataGridView2.Columns[4].Name = DATA7;
            dataGridView2.Columns[5].Name = TIMESTART7;
            dataGridView2.Columns[6].Name = TIMEEND7;
            dataGridView2.Columns[7].Name = VEICULO7;
            dataGridView2.Columns[8].Name = PLACA7;
            dataGridView2.Columns[9].Name = SERVICO7;
            dataGridView2.Columns[10].Name = SOLICITANTE7;



            string[] row = new string[] { NAME7, ID7, ID77, EMPRESA7, DATA7, TIMESTART7, TIMEEND7, VEICULO7, PLACA7, SERVICO7, SOLICITANTE7 };
            dataGridView2.Rows.Add(row);
            cmd.ExecuteNonQuery();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            textBox10.Text = "Nome Completo do Prestador";

            textBox11.Text = "CPF";

            textBox12.Text = "RG";

            textBox23.Text = "Periodicidade";

            textBox20.ForeColor = Color.Silver;
            textBox21.ForeColor = Color.Silver;
            textBox22.ForeColor = Color.Silver;
            textBox23.ForeColor = Color.Silver;

        }



        private void add_Click(object sender, EventArgs e)
        {


            insertData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            insertData3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insertData4();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            insertData5();
        }
        private void cessao_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            DateTime today = DateTime.Today;
            var toDay = today.ToString("dd/MM/yyyy");
             string stm = "SELECT * FROM cessao WHERE date3 LIKE " + "'" + toDay + "'";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8));
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

            string stm = "SELECT * FROM agendados";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView4.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5));
            }
            dr.Close();
            con.Close();
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

            while (dr.Read())
            {
                dataGridView5.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));
            }
            dr.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }
        private void veiculos_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM veiculos";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView3.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
            }
            dr.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }
        private void outros_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM profissionais_outros";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView2.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetString(9), dr.GetString(10));
            }
            dr.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }


        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        //Change focus on enter press

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox2.Focus();
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox3.Focus();
           
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox5.Focus();
            
        }
      
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                insertData();
          
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




        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox14.Focus();
            
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox15.Focus();
           
        }
        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox16.Focus();
          
        }
        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox17.Focus();
            
        }
        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox18.Focus();
            
        }
        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                insertData3();
           
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
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                IsOnTab1 = true;
                IsOnTab2 = false;
                IsOnTab3 = false;
                IsOnTab4 = false;
                IsOnTab5 = false;
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
            {
                IsOnTab1 = false;
                IsOnTab2 = true;
                IsOnTab3 = false;
                IsOnTab4 = false;
                IsOnTab5 = false;
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage5"])
            {
                IsOnTab1 = false;
                IsOnTab2 = false;
                IsOnTab2 = true;
                IsOnTab4 = false;
                IsOnTab5 = false;
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage6"])
            {
                IsOnTab1 = false;
                IsOnTab2 = false;
                IsOnTab2 = false;
                IsOnTab4 = true;
                IsOnTab5 = false;
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                IsOnTab1 = false;
                IsOnTab2 = false;
                IsOnTab2 = false;
                IsOnTab4 = false;
                IsOnTab5 = true;
            }

        }


        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Delete && IsOnTab3 == true)
            {


                dataGridView5.Columns[0].Name = "name3";
                dataGridView5.Columns[1].Name = "cpf3";
                dataGridView5.Columns[2].Name = "date3";
                dataGridView5.Columns[3].Name = "convite3";
                dataGridView5.Columns[4].Name = "acompanhante3";
                dataGridView5.Columns[5].Name = "acompanhanteid3";
                dataGridView5.Columns[6].Name = "solicitante";


                int selectedrowindex3 = dataGridView5.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow3 = dataGridView5.Rows[selectedrowindex3];
                string cellValue__ = Convert.ToString(selectedRow3.Cells["name3"].Value);
                string cellValue__2 = Convert.ToString(selectedRow3.Cells["cpf3"].Value);
                string cellValue__3 = Convert.ToString(selectedRow3.Cells["date3"].Value);
                string cellValue__4 = Convert.ToString(selectedRow3.Cells["convite3"].Value);
                string cellValue__5 = Convert.ToString(selectedRow3.Cells["acompanhante3"].Value);
                string cellValue__6 = Convert.ToString(selectedRow3.Cells["acompanhanteid3"].Value);
                string cellValue__7 = Convert.ToString(selectedRow3.Cells["solicitante"].Value);


                DialogResult dialogResult4 = MessageBox.Show("Você gostaria de deletar esse campo? " + cellValue__, "Deletar cliente", MessageBoxButtons.YesNo);
                if (dialogResult4 == DialogResult.Yes)
                {

                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);

                    cmd.CommandText = "DELETE FROM day_use WHERE name5 LIKE " + "'" + cellValue__ + "'" + " AND id5 LIKE " + "'" + cellValue__2 + "'" + " AND date5 LIKE " + "'" + cellValue__3 + "'" + " AND convite5 LIKE " + "'" + cellValue__4 + "'" + " AND acompanhante5 LIKE " + "'" + cellValue__5 + "'" + "AND acompanhante_id5 LIKE " + "'" + cellValue__6 + "'";



                    cmd.ExecuteNonQuery();

                    dataGridView5.Rows.Clear();
                    cessao_show();
                    MessageBox.Show("Cliente " + cellValue__ + ", " + cellValue__2 + ", " + cellValue__3 + ", " + cellValue__4 + ", " + " apagado com sucesso", "Apagado!");
                    con.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    cmd.Dispose();
                    System.Data.SQLite.SQLiteConnection.ClearAllPools();

                }

            }
            if (e.KeyCode == Keys.Delete && IsOnTab2 == true)
            {


                dataGridView4.Columns[0].Name = "nome2";
                dataGridView4.Columns[1].Name = "cpf2";
                dataGridView4.Columns[2].Name = "serviço";
                dataGridView4.Columns[3].Name = "data2";
                dataGridView4.Columns[4].Name = "hora2";
                dataGridView4.Columns[5].Name = "solicitante2";

                int selectedrowindex2 = dataGridView4.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow2 = dataGridView4.Rows[selectedrowindex2];
                string cellValue_ = Convert.ToString(selectedRow2.Cells["nome2"].Value);
                string cellValue_2 = Convert.ToString(selectedRow2.Cells["cpf2"].Value);
                string cellValue_3 = Convert.ToString(selectedRow2.Cells["serviço"].Value);
                string cellValue_4 = Convert.ToString(selectedRow2.Cells["data2"].Value);
                string cellValue_5 = Convert.ToString(selectedRow2.Cells["hora2"].Value);
                string cellValue_6 = Convert.ToString(selectedRow2.Cells["solicitante2"].Value);

                DialogResult dialogResult2 = MessageBox.Show("Você gostaria de deletar esse campo? " + cellValue_, "Deletar cliente", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {

                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);

                    cmd.CommandText = "DELETE FROM agendados WHERE name4 LIKE " + "'" + cellValue_ + "'" + " AND id4 LIKE " + "'" + cellValue_2 + "'" + " AND servico4 LIKE " + "'" + cellValue_3 + "'" + " AND date4 LIKE " + "'" + cellValue_4 + "'" + " AND time4 LIKE " + "'" + cellValue_5 + "'" + "AND solicitante4 LIKE " + "'" + cellValue_6 + "'";



                    cmd.ExecuteNonQuery();

                    dataGridView4.Rows.Clear();
                    agendados_show();
                    MessageBox.Show("Cliente " + cellValue_ + ", " + cellValue_2 + ", " + cellValue_3 + ", " + cellValue_4 + ", " + " apagado com sucesso", "Apagado!");
                    con.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    cmd.Dispose();
                    System.Data.SQLite.SQLiteConnection.ClearAllPools();

                }


            }


            if (e.KeyCode == Keys.Delete && IsOnTab1 == true)
            {


                dataGridView1.Columns[0].Name = "Nome";
                dataGridView1.Columns[1].Name = "CPF";
                dataGridView1.Columns[2].Name = "RG";
                dataGridView1.Columns[3].Name = "Evento";
                dataGridView1.Columns[4].Name = "Data";
                dataGridView1.Columns[5].Name = "entrada";
                dataGridView1.Columns[6].Name = "saida";
                dataGridView1.Columns[7].Name = "quadra";
                dataGridView1.Columns[8].Name = "aux";

                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Nome"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["CPF"].Value);
                string cellValue3 = Convert.ToString(selectedRow.Cells["RG"].Value);
                string cellValue4 = Convert.ToString(selectedRow.Cells["Evento"].Value);
                string cellValue5 = Convert.ToString(selectedRow.Cells["Data"].Value);
                string cellValue6 = Convert.ToString(selectedRow.Cells["entrada"].Value);
                string cellValue7 = Convert.ToString(selectedRow.Cells["saida"].Value);
                string cellValue8 = Convert.ToString(selectedRow.Cells["quadra"].Value);
                string cellValue9 = Convert.ToString(selectedRow.Cells["aux"].Value);

                DialogResult dialogResult = MessageBox.Show("Você gostaria de deletar esse campo? " + cellValue, "Deletar cliente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);

                    cmd.CommandText = "DELETE FROM cessao WHERE name3 LIKE " + "'" + cellValue + "'" + " AND id3 LIKE " + "'" + cellValue2 + "'" + " AND id33 LIKE " + "'" + cellValue3 + "'" + " AND evento3 LIKE " + "'" + cellValue4 + "'" + " AND date3 LIKE " + "'" + cellValue5 + "'" + "AND timeStart3 LIKE " + "'" + cellValue6 + "'" + "AND timeEnd3 LIKE " + "'" + cellValue7 + "'" + "AND quadra3 LIKE " + "'" + cellValue8 + "'";



                    cmd.ExecuteNonQuery();

                    dataGridView1.Rows.Clear();
                    cessao_show();
                    MessageBox.Show("Cliente " + cellValue + ", " + cellValue2 + ", " + cellValue3 + ", " + cellValue4 + ", " + " apagado com sucesso", "Apagado!");
                    con.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    cmd.Dispose();
                    System.Data.SQLite.SQLiteConnection.ClearAllPools();

                }






            }
       



            if (e.KeyCode == Keys.Delete && IsOnTab4 == true)
            {


                dataGridView2.Columns[0].Name = "name4";
                dataGridView2.Columns[1].Name = "cpf4";
                dataGridView2.Columns[2].Name = "rg4";
                dataGridView2.Columns[3].Name = "empresa4";
                dataGridView2.Columns[4].Name = "data4";
                dataGridView2.Columns[5].Name = "timeStart4";
                dataGridView2.Columns[6].Name = "timeEnd4";


                int selectedrowindex4 = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow4 = dataGridView2.Rows[selectedrowindex4];
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

                    dataGridView2.Rows.Clear();
                    outros_show();
                    MessageBox.Show("Cliente " + cellValue___ + ", " + cellValue___2 + ", " + cellValue___3 + ", " + cellValue___4 + ", " + " apagado com sucesso", "Apagado!");
                    con.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    cmd.Dispose();
                    System.Data.SQLite.SQLiteConnection.ClearAllPools();

                }

            }
            if (e.KeyCode == Keys.Delete && IsOnTab5 == true)
            {


                dataGridView3.Columns[0].Name = "name5";
                dataGridView3.Columns[1].Name = "veiculo5";
                dataGridView3.Columns[2].Name = "placa5";
                dataGridView3.Columns[3].Name = "periodi5";
                dataGridView3.Columns[4].Name = "departamento5";
             

                int selectedrowindex5 = dataGridView3.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow5 = dataGridView3.Rows[selectedrowindex5];
                string cellValue____ = Convert.ToString(selectedRow5.Cells["name5"].Value);
                string cellValue____2 = Convert.ToString(selectedRow5.Cells["veiculo5"].Value);
                string cellValue____3 = Convert.ToString(selectedRow5.Cells["placa5"].Value);
                string cellValue____4 = Convert.ToString(selectedRow5.Cells["periodi5"].Value);
                string cellValue____5 = Convert.ToString(selectedRow5.Cells["departamento5"].Value);
         


                DialogResult dialogResult4 = MessageBox.Show("Você gostaria de deletar esse campo? " + cellValue____, "Deletar cliente", MessageBoxButtons.YesNo);
                if (dialogResult4 == DialogResult.Yes)
                {

                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);

                    cmd.CommandText = "DELETE FROM veiculos WHERE name0 LIKE " + "'" + cellValue____ + "'" + " AND veiculo0 LIKE " + "'" + cellValue____2 + "'" + " AND placa0 LIKE " + "'" + cellValue____3 + "'" + " AND periodicidade0 LIKE " + "'" + cellValue____4 + "'" + " AND departamento0 LIKE " + "'" + cellValue____5 + "'";



                    cmd.ExecuteNonQuery();

                    dataGridView3.Rows.Clear();
                    veiculos_show();
                    MessageBox.Show("Cliente " + cellValue____ + ", " + cellValue____2 + ", " + cellValue____3 + ", " + cellValue____4 + ", " + " apagado com sucesso", "Apagado!");
                    con.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    cmd.Dispose();
                    System.Data.SQLite.SQLiteConnection.ClearAllPools();

                }

            }
        }

        private void dateTimePicker9_ValueChanged(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            DateTime pickedDate = dateTimePicker9.Value;
            var pickedDateCustom = pickedDate.ToString("dd/MM/yyyy");

            string stm = "SELECT * FROM cessao WHERE date3 LIKE " + "'" + pickedDateCustom + "'";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7));
            }
            dr.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }
    }
}