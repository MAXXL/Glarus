using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        //static MySqlConnection myConnection;
        static MySqlCommand myCmd;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                //CREATE SCHEMA `GLARUS_DB` ;
                //
                MySqlConnection myConnection = new MySqlConnection(Glarus.GlobalVars.ConnectionString);
                myConnection.Open();
                myCmd = new MySqlCommand();
                myCmd.Connection = myConnection;
                // читаем список пользователей 
                string sSQL = "SELECT idUser,Family,Name,SecondName FROM User";
                myCmd.CommandText = sSQL;
                MySqlDataReader datareader = myCmd.ExecuteReader();
                while (datareader.Read())
                    cmbUser.Items.Add(datareader["Family"] + " " + datareader["Name"] + " " + datareader["SecondName"]);
                datareader.Close();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            
            frmAddUser fr = new frmAddUser();
            this.Hide();
            fr.ShowDialog();

            MySqlConnection myConnection = new MySqlConnection(Glarus.GlobalVars.ConnectionString);
            myConnection.Open();
            myCmd = new MySqlCommand();
            myCmd.Connection = myConnection;

            // перечитать список пользователей
            cmbUser.Items.Clear();
            string sSQL = "SELECT idUser,Family,Name,SecondName FROM User";
            myCmd.CommandText = sSQL;
            MySqlDataReader datareader = myCmd.ExecuteReader();
            while (datareader.Read())
                cmbUser.Items.Add(datareader["Family"] + " " + datareader["Name"] + " " + datareader["SecondName"]);
            datareader.Close();
            myConnection.Close();

            this.Show();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sSQL = "SELECT idUser,Family,Name,SecondName,Password FROM User";
            string FIO;
 //           int count;
            //count =0;
            MySqlConnection myConnection = new MySqlConnection(Glarus.GlobalVars.ConnectionString);
            myConnection.Open();
            myCmd = new MySqlCommand();
            myCmd.Connection = myConnection;
            myCmd.CommandText = sSQL;
            MySqlDataReader datareader = myCmd.ExecuteReader();
            while (datareader.Read())
            {
                FIO = datareader["Family"] + " " + datareader["Name"] + " " + datareader["SecondName"];
                if (FIO == cmbUser.Text)
                {
                    if (datareader["Password"].ToString() == txtPassword.Text)
                    {
                        txtPassword.Text="";
                        frmSelectPacient fr = new frmSelectPacient();
                        this.Hide();
                        fr.ShowDialog();
                        this.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Неправильный пароль!");
                        break;
                    }

                }
 //               count++;
            }    
            datareader.Close();
            myConnection.Close();
        }

     }
}
