using Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces;
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

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    public partial class Dashbord : Form
    {
        
        private const string ConnectionCar = "Data Source=Cars.db";
        private const string ConnectionDriver = "Data Source=Drivers.db";
        public Dashbord()
        {
            InitializeComponent();
        }
        #region  Buttons       

        private void addDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDrivers addDrivers = new AddDrivers();
            addDrivers.Show();
        }

        private void addRuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRute addRute = new AddRute();
            addRute.Show();
        }

        private void addTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTransport addTransport = new AddTransport();
            addTransport.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        #region Driver

        private void viewDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayDriver();
        }
        #endregion //Driver
        #endregion //Buttons
        #region Driver
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

        #endregion //Driver
        private void viewCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceCar dsa = new InterfaceCar();
            dsa.Show();
        }
    }//Dashbord
}//Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
