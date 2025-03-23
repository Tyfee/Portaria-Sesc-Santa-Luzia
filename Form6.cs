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

    public partial class Form6 : Form
    {

        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";
        SQLiteCommand cmd;
        SQLiteConnection con;
        SQLiteDataReader dr;
        Form2 fr2 = new Form2();
        public Form6()
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




        }
        private void button1_Click(object sender, EventArgs e)
        {



            delete();
           

            }


        private void delete()
        {
            string cellValue = nameRegister.Text;
            string cellValue2 = documentRegister.Text;
            string cellValue3 = documentRegister2.Text;
            string cellValue4 = adressRegister.Text;



            DialogResult dialogResult = MessageBox.Show("Você gostaria de deletar esse campo? " + cellValue, "Deletar cliente", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "DELETE FROM test WHERE name LIKE " + "'" + cellValue + "'" + " AND id LIKE " + "'" + cellValue2 + "'" + " AND id2 LIKE " + "'" + cellValue3 + "'" + " AND adress LIKE " + "'" + cellValue4 + "'";



                cmd.ExecuteNonQuery();


                MessageBox.Show("Cliente " + cellValue + ", " + cellValue2 + ", " + cellValue3 + ", " + cellValue4 + ", " + " apagado com sucesso", "Apagado!");
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                cmd.Dispose();
                System.Data.SQLite.SQLiteConnection.ClearAllPools();

                this.Close();
            }


        }
        private void delete2()
        {
            string cellValue = nameRegister.Text;
            string cellValue2 = documentRegister.Text;
            string cellValue3 = documentRegister2.Text;
            string cellValue4 = adressRegister.Text;



         

                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "DELETE FROM test WHERE name LIKE " + "'" + cellValue + "'";



                cmd.ExecuteNonQuery();
          
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();


            this.Close();
            
        }
            private void button2_Click(object sender, EventArgs e)
        {

            delete2();
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



      



            cmd.ExecuteNonQuery();




            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();




        }
        }

    }

