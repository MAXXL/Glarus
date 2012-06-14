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
    public partial class frmSelectPacient : Form
    {
        //static MySqlCommand myCmd;
        private BindingSource bindingSorce = new BindingSource();
        public frmSelectPacient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    dataGridView1.Columns[0].Visible=false;
        //    dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
        //    dataGridView1.Columns[2].HeaderCell.Value = "Имя";
        //    dataGridView1.Columns[3].HeaderCell.Value = "Отчество";
        //    dataGridView1.Columns[4].HeaderCell.Value = "Дата рождения";
        //    StringFormat sf = new StringFormat();
        //    sf.Alignment = StringAlignment.Far; // по горизонтали (к правому краю)
        //    sf.LineAlignment = StringAlignment.Center; // по вертикали (по центру)

        //    if ((e.ColumnIndex == -1) && (e.RowIndex >= 0))
        //    {
        //        int lastDisplyIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Displayed) + 1;

        //        dataGridView1.RowHeadersWidth = (int)(e.Graphics.MeasureString(lastDisplyIndex.ToString(),
        //        dataGridView1.RowHeadersDefaultCellStyle.Font).Width + 12);

        //        e.Handled = true;
        //        Rectangle rc = e.CellBounds;
        //        e.Paint(rc, DataGridViewPaintParts.All);
        //        rc.Inflate(-3, 0); //'Отступ слева, справа

        //        e.Graphics.DrawString((e.RowIndex + 1).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font,
        //        new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor), rc, sf);
        //    }
        //}
        private void btnFind_Click(object sender, EventArgs e)
        {
            frmPacient.iIdRecord = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            frmPacient fr = new frmPacient();
            //fr.Owner = this;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                //создан новый пациент
            }

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
            string strFullString,strFamily="",strName="",strSecondName="";
            strFullString = txtPacient.Text;
            if (strFullString.Trim() == "")
                return;
            //String[] stringM;
            string[] split = strFullString.Split(' ');
            int i=1;
            foreach (string s in split)
            {
                if (s != "")
                {
                    if (i == 1)
                    {
                        strFamily = s;
                        i++;
                        continue;
                    }
                    if (i == 2)
                    {
                        strName = s;
                        i++;
                        continue;
                    }
                    if (i == 3)
                    {
                        strSecondName = s;
                        break;
                    }

                }

            }

            MySqlConnection myConnection = new MySqlConnection(Glarus.GlobalVars.ConnectionString);
            MySqlCommand myCmd = new MySqlCommand();
            myCmd.Connection = myConnection;
            StringBuilder strSQL = new StringBuilder("SELECT * FROM pacient WHERE ");
            strSQL.Append("Family LIKE '").Append(strFamily).Append("%' AND ");
            strSQL.Append("Name LIKE '").Append(strName).Append("%' AND ");
            strSQL.Append("SecondName LIKE '").Append(strSecondName).Append("%'");
           myCmd.CommandText = strSQL.ToString();
            MySqlDataAdapter adapter = new MySqlDataAdapter(myCmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            bindingSorce.DataSource = dataset.Tables[0];
            dataGridView1.DataSource = bindingSorce;
            myConnection.Close();

        }

        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[2].HeaderCell.Value = "Имя";
            dataGridView1.Columns[3].HeaderCell.Value = "Отчество";
            dataGridView1.Columns[4].HeaderCell.Value = "Дата рождения";
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
            frmSelectObj.iIdRecord = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            frmSelectObj fr = new frmSelectObj();
            //fr.Owner = this;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                //
            }

        }
    }
}
