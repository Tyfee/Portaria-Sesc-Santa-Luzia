using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Portaria
{
    public partial class Form1 : Form
    {
        string path = "login.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\login.db";
        SQLiteCommand cmd;
        SQLiteConnection con;
        SQLiteDataReader dr;
        DataTable table;
        bool rightPassword1 = false;
        bool rightPassword2 = false;

       


        public Form1()
        {
            InitializeComponent();


       

            passwordBox.PasswordChar = '\u25CF';
            Icon myIcon = new Icon("Resources/yass.ico");
            this.Icon = myIcon;
            Button1.TabStop = false;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.FlatAppearance.BorderSize = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            userBox.Focus();
        }
















        private void Button1_CLick(object sender, EventArgs e)
        {
            Login();
           
        }

        private void Login()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM login";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();





            while (dr.Read())
            {
                string user = dr.GetString(0);
                string password = dr.GetString(1);
                string user2 = dr.GetString(2);
                string password2 = dr.GetString(3);



                if (passwordBox.Text == password && userBox.Text == user)
                {
                 
          rightPassword1 = true;
                    rightPassword2 = false;
                    this.Hide();

                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                
                    this.Close();
                    this.Visible = false;

              


                }
                if (passwordBox.Text == password2 && userBox.Text == user2)
                {
                    rightPassword1 = false;
                    rightPassword2 = true;
                    this.Hide();

                    Form3 f3 = new Form3();
                    f3.ShowDialog();

                    this.Close();
                    this.Visible = false;



                }
                if (rightPassword1 == false && rightPassword2 == false)
                {

                    MessageBox.Show("Usuário ou senha incorretos!", "Erro no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
            dr.Close();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            cmd.Dispose();
            System.Data.SQLite.SQLiteConnection.ClearAllPools();
        }

        private void userBox_Enter(object sender, EventArgs e)
        {
            if (userBox.Text == "Usuário")
            {
                userBox.Text = "";
                userBox.ForeColor = Color.Black;
            }
        }
        private void userBox_Leave(object sender, EventArgs e)
        {
            if (userBox.Text == "")
            {
                userBox.Text = "Usuário";
                userBox.ForeColor = Color.Silver;
            }
        }
        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Senha")
            {
                passwordBox.Text = "";
                passwordBox.ForeColor = Color.Black;
            }
        }
        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.Text = "Senha";
                passwordBox.ForeColor = Color.Silver;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordBox.Focus();
                e.SuppressKeyPress = true;
            }
        }
            private void passwordBox_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                Login();
                e.SuppressKeyPress = true;
            }
            }
    }
}
