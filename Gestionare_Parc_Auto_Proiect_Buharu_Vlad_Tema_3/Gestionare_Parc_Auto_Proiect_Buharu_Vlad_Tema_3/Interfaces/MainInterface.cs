using Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Classes;
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
        #region Attributes
        private List<Car> _cars;
        private List<Driver> _drivers;
        private List<Rute> _rutes;
        private List<Transport> _transports;
        private List<AllData> DashBordGripList;
        private const string ConnectionCar = "Data Source=Cars.db";
        private const string ConnectionDriver = "Data Source=Drivers.db";
        private const string ConnectionRute = "Data Source=Rute.db";
        private const string ConnectionTransport = "Data Source=Transport.db";

        #endregion
        public Dashbord()
        {
            InitializeComponent();
            _cars = new List<Car>();
            _drivers = new List<Driver>();
            _rutes = new List<Rute>();
            _transports = new List<Transport>();
        }

        #region  Buttons 
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion //Buttons
         
        #region View Buttons
        private void ViewDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceDriver interfaceDriver = new InterfaceDriver();
            interfaceDriver.Show();
        } //Driver Interface
        private void ViewCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceCar interfaceCar = new InterfaceCar();
            interfaceCar.Show();
        } //Car Interface
        private void ViewRutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceRute interfaceRute = new InterfaceRute();
            interfaceRute.Show();
        } //Rute Interface

        private void ViewTransportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfaceTransport interfaceTransport = new InterfaceTransport();
            interfaceTransport.Show();
        } //Transport Interface

        #endregion

        #region Methods

        public void ConvertSQLiteDataInCar()
        {
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionCar))
            {
                connect.Open();
                using (SQLiteCommand command = connect.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT NameCar, ModelCar FROM Cars";
                    command.CommandType = CommandType.Text;
                    SQLiteDataReader r = command.ExecuteReader();
                    while (r.Read())
                    {
                        string NameCar = (string)r["NameCar"];
                        string ModelCar = (string)r["ModelCar"];
                        _cars.Add(new Car(NameCar, ModelCar));
                    }
                }
            }
        } // ConvertSQLiteDataInCar
        public void ConvertSQLiteDataInDriver()
        {
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionDriver))
            {
                connect.Open();
                using (SQLiteCommand command = connect.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT FirstName, SecondName, BirthDay, Salary, Adress FROM Drivers";
                    command.CommandType = CommandType.Text;
                    SQLiteDataReader r = command.ExecuteReader();
                    while (r.Read())
                    {
                        string FirstName = (string)r["FirstName"];
                        string SecondName = (string)r["SecondName"];
                        string BirthDay = (string)r["BirthDay"];
                        long Salary = (Int64)r["Salary"]; 
                        string Adress = (string)r["Adress"];
                        _drivers.Add(new Driver(FirstName, SecondName,BirthDay, Adress, Salary));
                    }
                }
            }
        } //ConvertSQLiteDataInDriver
        public void ConvertSQLiteDateInRute()
        {
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionRute))
            {
                connect.Open();
                using (SQLiteCommand command = connect.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT NameRute, FromRute, ToRute FROM Rute";
                    command.CommandType = CommandType.Text;
                    SQLiteDataReader r = command.ExecuteReader();
                    while (r.Read())
                    {
                        string NameRute = (string)r["NameRute"];
                        string FromRute = (string)r["FromRute"];
                        string ToRute = (string)r["ToRute"];
                        _rutes.Add(new Rute(NameRute, FromRute, ToRute));
                    }
                }
            }
        } // ConvertSQLiteDateInRute
        public void ConvertSQLiteDateInTransport()
        {
            using (SQLiteConnection connect = new SQLiteConnection(ConnectionTransport))
            {
                connect.Open();
                using (SQLiteCommand command = connect.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT ProductTransport, QuantityTransport FROM Transport";
                    command.CommandType = CommandType.Text;
                    SQLiteDataReader r = command.ExecuteReader();
                    while (r.Read())
                    {
                        string ProductTransport = (string)r["ProductTransport"];
                        int QuantityTransport = (int)r["QuantityTransport"];
                        _transports.Add(new Transport(ProductTransport, QuantityTransport));
                    }
                }
            }
        } // ConvertSQLiteDateInTransport



        #endregion
    }//Dashbord
}//Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
