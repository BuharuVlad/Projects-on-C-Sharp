using Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Classes;
using Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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

        bool testClickEventCar = false, testClickEventRuteFrom = false, testClickEventRuteTo = false;

        #endregion
        public Dashbord()
        {
            InitializeComponent();
            _cars = new List<Car>();
            _drivers = new List<Driver>();
            _rutes = new List<Rute>();
            _transports = new List<Transport>();
            CheckProductsTransport();
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
        #region Convert methods from SQLite in List
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
                        DateTime birthDateTime = DateTime.Parse(BirthDay);
                        long Salary = (Int64)r["Salary"]; 
                        string Adress = (string)r["Adress"];
                        _drivers.Add(new Driver(FirstName, SecondName, birthDateTime, Adress, Salary));
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
                        var quantityVar = r["QuantityTransport"];
                        int QuantityTransport = int.Parse(string.Format("{0}", quantityVar));
                        _transports.Add(new Transport(ProductTransport, QuantityTransport));
                    }
                }
            }
        } // ConvertSQLiteDateInTransport
        #endregion // Convert methods from SQLite in List

        #region Check TextBoxs, Enter

        private void CheckProductsTransport()
        {
            ConvertSQLiteDateInTransport();
            txtProductsTransport.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductsTransport.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            foreach(Transport transport in _transports)
            {
                coll.Add(transport.ProductTransport);
            }
            txtProductsTransport.AutoCompleteCustomSource = coll;
        }

        private void CheckQuantityTransport()
        {
            ConvertSQLiteDateInTransport();
            foreach (Transport transport in _transports)
            {
               if(txtProductsTransport.Text == transport.ProductTransport)
                {
                    if (txtQuantityTransport.Text != transport.QuantityTransport.ToString())
                    {
                        MessageBox.Show(@"this quantity is wrong!", @"Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        txtQuantityTransport.Focus();
                    }
                }
            }
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConnectionCar))
            {
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("SELECT DISTINCT NameCar FROM Cars", con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbNameCar.Items.Add(dr.GetString(0));
                }
            }

            using (SQLiteConnection con = new SQLiteConnection(ConnectionRute))
            {
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("SELECT DISTINCT NameRute FROM Rute", con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbNameRute.Items.Add(dr.GetString(0));
                }
            }

            using (SQLiteConnection con = new SQLiteConnection(ConnectionDriver))
            {
                SQLiteCommand cmd;
                cmd = new SQLiteCommand("SELECT FirstName FROM Drivers", con);
                con.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbFirstNameDriver.Items.Add(dr.GetString(0));
                }
            }

        }

        #endregion //Check TextBoxs, Enter
        #endregion // Methods


        #region KeyDown
        private void txtProductsTransport_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtQuantityTransport.Focus();
            }
        }

        private void txtQuantityTransport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbNameCar.Focus();
            }
        }
        private void cbNameCar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbModelCar.Focus();
            }
        }

        #endregion KeyDown
        
        private void txtProductsTransport_Validating(object sender, CancelEventArgs e)
        {
            
            foreach (Transport transport in _transports)
            {
                if (txtProductsTransport.Text.Equals(transport.ProductTransport))
                {
                    break;
                }
                else
                {
                    ErrorProvider errorProvider = new ErrorProvider();
                    e.Cancel = true;
                    txtProductsTransport.Focus();
                    errorProvider.SetError((Control)txtProductsTransport, "Check the list again!"); 
                }
            }
        }

        private void cbFirstNameDriver_Leave(object sender, EventArgs e)
        {
            
            foreach (var driver in _drivers)
            {
                if (cbFirstNameDriver.Text.Equals(driver.FirstNameDriver))
                {
                    cbSecondNameDriver.Items.Add(driver.SecondNameDriver);
                }
            }
        }
        private void cbSecondNameDriver_Leave(object sender, EventArgs e)
        {
            ConvertSQLiteDataInDriver();
            foreach (var driver in _drivers)
            {
                if (cbSecondNameDriver.Text.Equals(driver.SecondNameDriver))
                {
                    cbBirthDayDriver.Items.Add(driver.BirthDayDriver);
                }
            }
        }

        private void cbNameCar_Leave(object sender, EventArgs e)
        {
            ConvertSQLiteDataInCar();
            foreach (var car in _cars)
            {
                if (cbNameCar.Text.Equals(car.NameCar))
                {
                    cbModelCar.Items.Add(car.ModelCar);
                }
            }
        }

        

        private void cbNameRute_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertSQLiteDateInRute();
            foreach (var rute in _rutes)
            {
                if (cbNameRute.Text.Equals(rute.NameRute))
                {
                    txtFromRute.Text = rute.FromRute;
                    txtToRute.Text = rute.ToRute;
                }
            }

        }

        private void txtQuantityTransport_Leave(object sender, EventArgs e)
        {
            CheckQuantityTransport();
        }

    }//Dashbord
}//Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
