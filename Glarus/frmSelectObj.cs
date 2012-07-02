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
    public partial class frmSelectObj : Form
    {
        public static Int32 iIdRecord { get; set; }
        static MySqlCommand myCmd;
        private BindingSource bindingSorce = new BindingSource();
        public frmSelectObj()
        {
            InitializeComponent();
            if (iIdRecord == 0)
            {
                // ошибка. не пришел ИД пациента
                MessageBox.Show("Ошибка! Не выбран пациент!","Ошибка",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
            }
            else
            {
                // выводим данные по пациенту
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
                    lblPacient.Text = "Пациент: "+datareader["Family"].ToString();
                    lblPacient.Text = lblPacient.Text+" "+ datareader["Name"].ToString();
                    lblPacient.Text = lblPacient.Text+" "+ datareader["SecondName"].ToString();
                    lblPacient.Text = lblPacient.Text + ", " + Convert.ToDateTime(datareader["Birthday"]).ToString("dd'/'MM'/'yyyy") + " г.р.";
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
                dataGridView1.DataSource = bindingSorce;
                myConnection.Close();

                

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderCell.Value = "Дата";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderCell.Value = "Вид";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].HeaderCell.Value = "Врач";
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false; 
             StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Far; // по горизонтали (к правому краю)
            sf.LineAlignment = StringAlignment.Center; // по вертикали (по центру)

            if ((e.ColumnIndex == -1) && (e.RowIndex >= 0))
            {
                int lastDisplyIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Displayed) + 1;

                dataGridView1.RowHeadersWidth = (int)(e.Graphics.MeasureString(lastDisplyIndex.ToString(),
                dataGridView1.RowHeadersDefaultCellStyle.Font).Width + 12);

                e.Handled = true;
                Rectangle rc = e.CellBounds;
                e.Paint(rc, DataGridViewPaintParts.All);
                rc.Inflate(-3, 0); //'Отступ слева, справа

                e.Graphics.DrawString((e.RowIndex + 1).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font,
                new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor), rc, sf);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value)!=0)
            {
            frmAnalizy.iIdRecord = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            frmAnalizy fr = new frmAnalizy();
            //fr.Owner = this;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                //
            }
            }

        }

     }
}
