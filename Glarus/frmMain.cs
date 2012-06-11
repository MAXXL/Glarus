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
    public partial class frmMain : Form
    {
        //static MySqlCommand myCmd;
        private BindingSource bindingSorce = new BindingSource();
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //frmPacient.iIdRecord = Convert.ToInt32(txtPacient.Text);
            //frmPacient fr = new frmPacient();
            //fr.ShowDialog();
            //MySqlConnection myConnection = new MySqlConnection(Glarus.GlobalVars.ConnectionString);
            //myConnection.Open();
            //MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            //DataSet myDataSet = new DataSet();
            //myCmd = new MySqlCommand();
            //myCmd.Connection = myConnection;
            //string sSQL;
            //sSQL = "SELECT idPacient,Family,Name,SecondName,Birthday FROM pacient WHERE idPacient=" ;
            //myCmd.CommandText = sSQL;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Glarus.GlobalVars.BufferString = "1"; //add new pacient
            frmPacient.iIdRecord = 0;
            frmPacient fr = new frmPacient();
            //fr.Owner = this;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                //создан новый пациент
            }
            
        }

        private void txtPacient_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(Glarus.GlobalVars.ConnectionString);
            MySqlCommand myCmd = new MySqlCommand();
            myCmd.Connection = myConnection;
            myCmd.CommandText = "SELECT * FROM pacient";
            MySqlDataAdapter adapter = new MySqlDataAdapter(myCmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSorce.DataSource = dataset.Tables[0];
            dataGridView1.DataSource = bindingSorce;
            myConnection.Close();

        }
    }
}
