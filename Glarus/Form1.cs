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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //CREATE SCHEMA `GLARUS_DB` ;
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
                myConnection.Close();
                MessageBox.Show("Подключение прошло успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }
    }
}
