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
    public partial class frmAnalizy : Form
    {
        public static Int32 iIdRecord { get; set; }
        static MySqlCommand myCmd;
        private BindingSource bindingSorce = new BindingSource();

        public frmAnalizy()
        {
            InitializeComponent();
            if (iIdRecord == 0)
            {
                // ошибка. не пришел ИД 
                MessageBox.Show("Ошибка! Не выбрано обследование!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection myConnection = new MySqlConnection(Glarus.GlobalVars.ConnectionString);
                myConnection.Open();
                myCmd = new MySqlCommand();
                myCmd.Connection = myConnection;
                string sSQL;
                sSQL = "SELECT idanaliz,user,pacient,visit,analiz_type,analiz_date,result,comment FROM analiz WHERE idanaliz=" + iIdRecord.ToString();
                myCmd.CommandText = sSQL;
                MySqlDataReader datareader = myCmd.ExecuteReader();
                while (datareader.Read())
                {
                    //lblPacient.Text = "Пациент: " + datareader["Family"].ToString();
                    //lblPacient.Text = lblPacient.Text + " " + datareader["Name"].ToString();
                    //lblPacient.Text = lblPacient.Text + " " + datareader["SecondName"].ToString();
                    //lblPacient.Text = lblPacient.Text + ", " + Convert.ToDateTime(datareader["Birthday"]).ToString("dd'/'MM'/'yyyy") + " г.р.";
                }
                datareader.Close();
                myConnection.Close();
                // выводим данные по визитам
                myConnection.Open();
                myCmd = new MySqlCommand();
                myCmd.Connection = myConnection;

                //sSQL = "SELECT idvisit,user,pacient,visit_type,visit_date FROM visit WHERE pacient=" + iIdRecord.ToString();
                //myCmd.CommandText = sSQL;
                //MySqlDataReader datareader = myCmd.ExecuteReader();
                //while (datareader.Read())
                //{
                //    lblPacient.Text = "Пациент: " + datareader["Family"].ToString();
                //    lblPacient.Text = lblPacient.Text + " " + datareader["Name"].ToString();
                //    lblPacient.Text = lblPacient.Text + " " + datareader["SecondName"].ToString();
                //    lblPacient.Text = lblPacient.Text + ", " + Convert.ToDateTime(datareader["Birthday"]).ToString("dd'/'MM'/'yyyy") + " г.р.";
                //}
                //datareader.Close();
                //MySqlConnection myConnection = new MySqlConnection(Glarus.GlobalVars.ConnectionString);
                //MySqlCommand myCmd = new MySqlCommand();
                //myCmd.Connection = myConnection;
                StringBuilder strSQL = new StringBuilder("SELECT visit.idvisit,visit.id_record,analiz.idanaliz,analiz.analiz_date,visit.visit_type,visit.user,visit.pacient,visit_type.idvisit_type,visit_type.name,user.idUser,user.Family,user.Name,user.SecondName FROM visit,visit_type,user,analiz WHERE (pacient=" + iIdRecord.ToString() + " AND (visit.visit_type=visit_type.idvisit_type) AND (visit.user=user.idUser) AND (visit.idvisit=analiz.visit))");
                //StringBuilder strSQL = new StringBuilder("SELECT visit.idvisit,visit.id_record,analiz.idanaliz,analiz.analiz_date,visit.visit_type,visit.user,visit.pacient,visit_type.idvisit_type,visit_type.name,user.idUser,user.Family,user.Name,user.SecondName FROM visit,visit_type,user,analiz WHERE (pacient=" + iIdRecord.ToString() + " AND (visit.visit_type=visit_type.idvisit_type) AND (visit.user=user.idUser) AND (visit.id_record=analiz.idanaliz))");
                //strSQL.Append("pacient.id,pacient.famile,pacient.Name,pacient.SecondName").Append(txtFamily.Text).Append("',");
                //strSQL.Append("Family='").Append(txtFamily.Text).Append("',");
                myCmd.CommandText = strSQL.ToString();
                MySqlDataAdapter adapter = new MySqlDataAdapter(myCmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                bindingSorce.DataSource = dataset.Tables[0];
                //dataGridView1.DataSource = bindingSorce;
                myConnection.Close();

            }

        }
    }
}
