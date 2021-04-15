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
    public partial class InterfaceDriver : Form
    {

        private const string ConnectionDriver = "Data Source=Drivers.db";
        public InterfaceDriver()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddDrivers addDrivers = new AddDrivers();
            addDrivers.Show();
        }

        private void DisplayDriver()
        {
            string query = "Select * FROM Drivers";
            InsertUpdateDeleteDriver(query);
        }
        private void InsertUpdateDeleteDriver(string Query)
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionDriver);
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
        }

        private void dtGridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdDriver.Text = dtGridList.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstNameDriver.Text = dtGridList.SelectedRows[0].Cells[1].Value.ToString();
                txtSecondNameDriver.Text = dtGridList.SelectedRows[0].Cells[2].Value.ToString();
                txtBirthDayDriver.Text = dtGridList.SelectedRows[0].Cells[3].Value.ToString();
                txtSalaryDriver.Text = dtGridList.SelectedRows[0].Cells[4].Value.ToString();
                txtAdressDriver.Text = dtGridList.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Click only in the left side of the window, next to id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayDriver();
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            
            string query = "update Drivers set FirstName = '" + txtFirstNameDriver + "'," +
                " SecondName = '" + txtSecondNameDriver + "', " +
                "BirthDay = '" + txtBirthDayDriver + "', " +
                "Salary = '" + txtSalaryDriver + "'," +
                "Adress = '" + txtAdressDriver + "'" +
                "where id = '" + txtIdDriver + "' ;";
            InsertUpdateDeleteDriver(query);
            DisplayDriver();
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            string query = "delete from Drivers where id ='" + txtIdDriver + "' ;";
            InsertUpdateDeleteDriver(query);
            DisplayDriver();
        }
    }
}
