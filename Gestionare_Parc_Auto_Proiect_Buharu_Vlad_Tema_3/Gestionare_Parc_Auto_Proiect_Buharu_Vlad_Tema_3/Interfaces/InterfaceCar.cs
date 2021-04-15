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
    public partial class InterfaceCar : Form
    {
        private const string ConnectionCar = "Data Source=Cars.db";
        public InterfaceCar()
        {
            InitializeComponent();
            DisplayCar();
        } 

        private void DisplayCar()
        {
            string query = "Select * FROM Cars";
            InsertUpdateDeleteCar(query);

        }//DisplayCar

        private void InsertUpdateDeleteCar(string Query)
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionCar);
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = connection;
            cmd.CommandText = Query;
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(sdr);
                sdr.Close();
                connection.Close();
                dtGridList.DataSource = dt;
            }
        } // InsertUpdateDeleteCar
        private void dtGridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUpdateIdCar.Text = dtGridList.SelectedRows[0].Cells[0].Value.ToString();
                txtUpdateNameCar.Text = dtGridList.SelectedRows[0].Cells[1].Value.ToString();
                txtUpdateModelCar.Text = dtGridList.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Click only in the left side of the window, next to id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } // dtGridList_CellClick

        #region Buttons Car
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCar();
        } // btnRefresh_Click

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            string query = "update Cars set NameCar = '" + txtUpdateNameCar + "', ModelCar = '" + txtUpdateModelCar + "' where id = '" + txtUpdateIdCar + "' ;";
            InsertUpdateDeleteCar(query);
            DisplayCar();
        } // btnUpdateCar_Click

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            string query = "delete from Cars where id ='" + txtUpdateIdCar + "' ;";
            InsertUpdateDeleteCar(query);
            DisplayCar();
        } // btnDeleteCar_Click

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddCars addCars = new AddCars();
            addCars.Show();
        } // btnAddCar_Click

        #endregion // View Buttons
    }
}
