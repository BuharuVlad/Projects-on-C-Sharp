using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces
{
    public partial class InterfaceRute : Form
    {
        private const string ConnectionRute = "Data Source=Rute.db";
        public InterfaceRute()
        {
            InitializeComponent();
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DisplayRute();
        }
        private void BtnAddRute_Click(object sender, EventArgs e)
        {
            AddRute addRute = new AddRute();
            addRute.Show();
        }
        private void DisplayRute()
        {
            string query = "Select * FROM Rute";
            InsertUpdateDeleteRute(query);
        }
        private void InsertUpdateDeleteRute(string Query)
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionRute);
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand
            {
                Connection = connection,
                CommandText = Query
            };
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(sdr);
                sdr.Close();
                connection.Close();
                dtGridList.DataSource = dt;
            }
        }

        private void BtnDeleteRute_Click(object sender, EventArgs e)
        {
            string query = "delete from Rute where id ='" + txtIdRute + "' ;";
            InsertUpdateDeleteRute(query);
            DisplayRute();
        }

        private void BtnUpdateRute_Click(object sender, EventArgs e)
        {
            string query = "update Rute set NameRute = '" + txtNameRute + "'," +
               " FromRute = '" + txtFromRute + "', " +
               "ToRute = '" + txtToRute + "' ;";
            InsertUpdateDeleteRute(query);
            DisplayRute();
        }

        private void DtGridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdRute.Text = dtGridList.SelectedRows[0].Cells[0].Value.ToString();
                txtNameRute.Text = dtGridList.SelectedRows[0].Cells[1].Value.ToString();
                txtFromRute.Text = dtGridList.SelectedRows[0].Cells[2].Value.ToString();
                txtToRute.Text = dtGridList.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Click only in the left side of the window, next to id", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
