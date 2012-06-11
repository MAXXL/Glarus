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
    public partial class frmPacient : Form
    {
         public static Int32 iIdRecord { get; set; }
       static MySqlCommand myCmd;
        //public int frmPacientStatus;
        public frmPacient()
        {
            InitializeComponent();
            //frmMain fr = (frmMain)this.Owner;
            //frmPacientStatus = fr.frmPacientStatus;
            
            if (iIdRecord == 0)
            {
                // add new pacient
                this.btnAddUser.Text = "Создать";
            }
            else
            {
                // edit pacient
                this.btnAddUser.Text = "Записать";
                MySqlConnection myConnection = new MySqlConnection(Glarus.GlobalVars.ConnectionString);
                myConnection.Open();
                myCmd = new MySqlCommand();
                myCmd.Connection = myConnection;
                string sSQL;
                sSQL = "SELECT idPacient,Family,Name,SecondName,Birthday FROM pacient WHERE idPacient=" + iIdRecord.ToString();
                myCmd.CommandText = sSQL;
                MySqlDataReader datareader = myCmd.ExecuteReader();
                while (datareader.Read())
                { 
                    txtFamily.Text=datareader["Family"].ToString();
                    txtName.Text=datareader["Name"].ToString();
                    txtSecondName.Text = datareader["SecondName"].ToString();
                    BirthdayDate.Value = Convert.ToDateTime(datareader["Birthday"]);
                }
                datareader.Close();
                myConnection.Close();

            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            if (txtFamily.Text == "")
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            if (txtSecondName.Text == "")
            {
                MessageBox.Show("Введите отчество!");
                return;
            }
            //if (txtPassword.Text == "")
            //{
            //    MessageBox.Show("Введите пароль!");
            //    return;
            //}
            try
            {
                MySqlConnection myConnection = new MySqlConnection(Glarus.GlobalVars.ConnectionString);
                myConnection.Open();
                myCmd = new MySqlCommand();
                myCmd.Connection = myConnection;
                string sSQL;
                if (iIdRecord == 0)
                {
                    sSQL = "INSERT INTO pacient (Family,Name,SecondName,Birthday) VALUES                               (";
                    sSQL += "'" + txtFamily.Text + "',";
                    sSQL += "'" + txtName.Text + "',";
                    sSQL += "'" + txtSecondName.Text + "',";
                    sSQL += "'" + BirthdayDate.Value.ToString("yyyy'-'MM'-'dd") + "')";
                }
                else
                {
                    StringBuilder strSQL = new StringBuilder("UPDATE pacient SET ");
                    //strSQL.Append("idPacient='").Append(iIdRecord.ToString()).Append("',");
                    strSQL.Append("Family='").Append(txtFamily.Text).Append("',");
                    strSQL.Append("Name='").Append(txtName.Text).Append("',");
                    strSQL.Append("SecondName='").Append(txtSecondName.Text).Append("',");
                    strSQL.Append("Birthday='").Append(BirthdayDate.Value.ToString("yyyy'-'MM'-'dd")).Append("'");
                    strSQL.Append(" WHERE idPacient='").Append(iIdRecord.ToString()).Append("'");
                    sSQL = strSQL.ToString();
               }
                myCmd.CommandText = sSQL;
                myCmd.Prepare();
                myCmd.ExecuteNonQuery();
                myConnection.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }
    }
}
