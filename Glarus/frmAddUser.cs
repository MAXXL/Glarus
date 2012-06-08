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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtFamily.Text=="")
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }
            if (txtName.Text=="")
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            if (txtSecondName.Text == "")
            {
                MessageBox.Show("Введите отчество!");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }
            try
            {
                MySqlCommand myCmd;
                //myCmd = new MySqlCommand();
                myCmd = Glarus.GlobalVars.myCmd;
                string sSQL = "INSERT INTO User (Family,Name,SecondName,Password) VALUES                               (";
                sSQL += "'" + txtFamily.Text + "',";
                sSQL += "'" + txtName.Text + "',";
                sSQL += "'" + txtSecondName.Text + "',";
                sSQL += "'" + txtPassword.Text + "')";

                myCmd.CommandText = sSQL;
                myCmd.Prepare();
                myCmd.ExecuteNonQuery();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     }
}
