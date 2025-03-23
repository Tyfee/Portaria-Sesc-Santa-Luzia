using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria
{
    public partial class Form7 : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";
        SQLiteCommand cmd;
        SQLiteConnection con;
        SQLiteDataReader dr;
        Form2 fr2 = new Form2();
        public Form7()
        {


            InitializeComponent();
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon myIcon = new Icon("Resources/yass.ico");
            this.Icon = myIcon;
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;


            comboBox6.Items.Add("POSTO DE SAÚDE");
            comboBox6.Items.Add("TERCEIRA IDADE");
            comboBox6.Items.Add("OUTRO");
            comboBox6.SelectedItem = "POSTO DE SAÚDE";



        }
        private void button1_Click(object sender, EventArgs e)
        {



            delete();


        }


        private void delete()
        {
            string cellValue = textBox201.Text;
            string cellValue2 = textBox202.Text;
            string cellValue3 = textBox203.Text;
            string cellValue4 = textBox204.Text;
            string cellValue5 = comboBox6.SelectedItem.ToString();


            DialogResult dialogResult = MessageBox.Show("Você gostaria de deletar esse campo? " + cellValue, "Deletar veículo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "DELETE FROM veiculos WHERE name0 LIKE " + "'" + cellValue + "'" + " AND veiculo0 LIKE " + "'" + cellValue2 + "'" + " AND placa0 LIKE " + "'" + cellValue3 + "'" + " AND periodicidade0 LIKE " + "'" + cellValue4 + "'" + " AND departamento0 LIKE " + "'" + cellValue5 + "'";



                cmd.ExecuteNonQuery();


                MessageBox.Show("Cliente " + cellValue + ", " + cellValue2 + ", " + cellValue3 + ", " + cellValue4 + ", " + " apagado com sucesso", "Apagado!");
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();

                this.Close();


                Form2 f2 = new Form2();
 
            }


        }


        
        private void delete2()
        {
            string cellValue = textBox201.Text;
            string cellValue2 = textBox202.Text;
            string cellValue3 = textBox203.Text;
            string cellValue4 = textBox204.Text;
            string cellValue5 = comboBox6.SelectedItem.ToString();

            string newCellValue = label7.Text;
            string newCellValue2 = label8.Text;
            string newCellValue3 = label9.Text;
            string newCellValue4 = label10.Text;
            string newCellValue5 = label11.Text;





            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DELETE FROM veiculos WHERE name0 LIKE " + "'" + newCellValue + "'" + " AND veiculo0 LIKE " + "'" + newCellValue2 + "'" + " AND placa0 LIKE " + "'" + newCellValue3 + "'" + " AND periodicidade0 LIKE " + "'" + newCellValue4 + "'" + " AND departamento0 LIKE " + "'" + newCellValue5 + "'";



            cmd.ExecuteNonQuery();


            MessageBox.Show("Cliente " + newCellValue + ", " + newCellValue2 + ", " + newCellValue3 + ", " + newCellValue4 + ", " + " editado com sucesso", "Editado!");
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();


         

        }



        private void button2_Click(object sender, EventArgs e)
        {


            delete2();
         Edit();


        }
        private void Edit()
        {

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO veiculos(name0, veiculo0, placa0, periodicidade0, departamento0) VALUES(@name0, @veiculo0, @placa0, @periodicidade0, @departamento0)";





            string NAME = textBox201.Text;
            string VEICULO = textBox202.Text;
            string PLACA = textBox203.Text;
            string PERIODICIDADE = textBox204.Text;
            string DEPARTAMENTO = comboBox6.SelectedItem.ToString();





            cmd.Parameters.AddWithValue("@name0", NAME);
            cmd.Parameters.AddWithValue("@veiculo0", VEICULO);
            cmd.Parameters.AddWithValue("@placa0", PLACA);
            cmd.Parameters.AddWithValue("@periodicidade0", PERIODICIDADE);
            cmd.Parameters.AddWithValue("@departamento0", DEPARTAMENTO);





            cmd.ExecuteNonQuery();




            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();


            this.Close();

        }
        }
    }

