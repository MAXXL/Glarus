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
        //public int frmPacientStatus;
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmPacient fr = new frmPacient();
            //fr.iIdRecord = Convert.ToInt32(txtPacient.Text);
            fr.iIdRecord = 5;
            fr.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Glarus.GlobalVars.BufferString = "1"; //add new pacient
            frmPacient fr = new frmPacient();
            fr.iIdRecord = 0;
            //fr.Owner = this;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                //создан новый пациент
            }
            
        }
    }
}
