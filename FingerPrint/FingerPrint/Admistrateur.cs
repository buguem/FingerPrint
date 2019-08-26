using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FingerPrint
{
    public partial class Admistrateur : Form
    {
        string connectionString = @"Server=localhost;Database=presence_db;Uid=root;Pwd='';";
        int adminID = 0;
        public Admistrateur()
        {
            InitializeComponent();
        }

        private void Admistrateur_Load(object sender, EventArgs e)
        {
            GridAdminFill();
        }

        #region Enregistrement Administrateur 
        private void BTN_EnregisterAdmin_Click(object sender, EventArgs e)
        {
            using(MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("AdminAddOrEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_AdminID",adminID);
                mySqlCmd.Parameters.AddWithValue("_AdminNom",TXB_NomAdmin.Text.Trim() );
                mySqlCmd.Parameters.AddWithValue("_AdminPremon", TXB_PrenomAdmin.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_AdminLogin", TXB_LoginAdmin.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_AdminPwd", TXB_MotDePasseAdmin.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submited successful");
                GridAdminFill();
            }
        }

        private void BTN_AnnulerAdmin_Click(object sender, EventArgs e)
        {
            cleanForm(GBX_FormAdmin);
        }

        void GridAdminFill()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("AdminViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbAdmin = new DataTable();
                sqlDa.Fill(dtbAdmin);
                DGV_ListeAdmin.DataSource = dtbAdmin;
                DGV_ListeAdmin.Columns[0].Visible = false;
            }
        }

        void cleanForm(GroupBox groupBox)
        {
            foreach (Control oControlFormulaire in groupBox.Controls)
                if (oControlFormulaire is TextBox)
                    oControlFormulaire.Text = String.Empty;
            adminID = 0;
            BTN_EnregisterAdmin.Text = "Enregistrer";

        }
        #endregion

        #region Classe
        private void BTN_EnregisterClasse_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void DGV_ListeAdmin_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_ListeAdmin.CurrentRow.Index != -1)
            {
                TXB_NomAdmin.Text = DGV_ListeAdmin.CurrentRow.Cells[1].Value.ToString();
                TXB_PrenomAdmin.Text = DGV_ListeAdmin.CurrentRow.Cells[2].Value.ToString();
                TXB_LoginAdmin.Text = DGV_ListeAdmin.CurrentRow.Cells[3].Value.ToString();
                TXB_MotDePasseAdmin.Text = DGV_ListeAdmin.CurrentRow.Cells[4].Value.ToString();
                adminID = Convert.ToInt32(DGV_ListeAdmin.CurrentRow.Cells[0].Value.ToString());
                BTN_EnregisterAdmin.Text = "Modifier";
            }
            
        }

        private void DGV_ListeProf_DoubleClick(object sender, EventArgs e)
        {

        }

        private void GBX_FormMatiere_Enter(object sender, EventArgs e)
        {

        }

        private void GBX_FormProg_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LBL_SelectNomProgramme_Click(object sender, EventArgs e)
        {

        }
    }
}
