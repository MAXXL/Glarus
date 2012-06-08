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
                string server;
                string database;
                string uid;
                string password;

                server = "localhost";
                database = "GLARUS_DB";
                uid = "root";
                password = "RjvgfybzRBN25";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                MySqlConnection myConnection = new MySqlConnection(connectionString);
                myConnection.Open();
                //myConnection.Close();
                //MessageBox.Show("Подключение прошло успешно!");
                myCmd = new MySqlCommand();
                myCmd.Connection = myConnection;
                Glarus.GlobalVars.myCmd = myCmd;
                // читаем список пользователей 
                string sSQL = "SELECT Family FROM User";
                myCmd.CommandText = sSQL;
                MySqlDataReader datareader = myCmd.ExecuteReader();
                while (datareader.Read())
                    cmbUser.Items.Add(datareader["Family"]);
                datareader.Close();
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

            // перечитать список пользователей
            cmbUser.Items.Clear();
            string sSQL = "SELECT Family FROM User";
            myCmd.CommandText = sSQL;
            MySqlDataReader datareader = myCmd.ExecuteReader();
            while (datareader.Read())
                cmbUser.Items.Add(datareader["Family"]);
            datareader.Close();

            this.Show();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     }
}
