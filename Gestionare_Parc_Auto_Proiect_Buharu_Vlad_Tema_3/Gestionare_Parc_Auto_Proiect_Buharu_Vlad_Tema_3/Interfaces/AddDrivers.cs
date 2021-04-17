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
    public partial class AddDrivers : Form
    {
        private List<Driver> listDrivers = new List<Driver>();
        private const string ConnectiongString = "Data Source = Drivers.db";
        public AddDrivers()
        {
            InitializeComponent();
        }
        #region Buttons
        private void btnSaveDriver_Click(object sender, EventArgs e)
        {
            if (txtFirstNameDriver.Text != "" && txtSecondNameDriver.Text != ""
                 && txtBirthDayDriver.Text != "" && txtAdressDriver.Text != "" && txtSalaryDriver.Text != "" &&
                 txtFirstNameDriver.Text != " " && txtSecondNameDriver.Text != " "
                 && txtBirthDayDriver.Text != " " && txtAdressDriver.Text != "" && txtSalaryDriver.Text != " ")
            {
                Driver driver = new Driver(txtFirstNameDriver.Text, txtSecondNameDriver.Text,
                    txtBirthDayDriver.Text, txtAdressDriver.Text, float.Parse(txtSalaryDriver.Text));
                AddDriversSQLite(driver);
            }
            else
            {
                MessageBox.Show("Please write all the date about the driver!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelDriver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure? Data will be delete!", "Unsaved data", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            this.Close();
        }

        #endregion //Buttons

        #region Methods
        private void AddDriversSQLite(Driver driver)
        {
            var query = "insert into Drivers(FirstName, SecondName, BirthDay, Salary, Adress)" +
                "values (@FirstNameDriver, @SecondNameDriver, @BirthDayDriver, @SalaryDriver, @AdressDriver);" +
                              "SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectiongString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                var FirstNameDriver = new SQLiteParameter("@FirstNameDriver");
                FirstNameDriver.Value = driver.FirstNameDriver;
                var SecondNameDriver = new SQLiteParameter("@SecondNameDriver");
                SecondNameDriver.Value = driver.SecondNameDriver;
                var BirthDayDriver = new SQLiteParameter("@BirthDayDriver");
                BirthDayDriver.Value = driver.BirthDayDriver;
                var SalaryDriver = new SQLiteParameter("@SalaryDriver");
                SalaryDriver.Value = driver.SalaryDriver;
                var AdressDriver = new SQLiteParameter("@AdressDriver");
                AdressDriver.Value = driver.AdressDriver;

                command.Parameters.Add(FirstNameDriver);
                command.Parameters.Add(SecondNameDriver);
                command.Parameters.Add(BirthDayDriver);
                command.Parameters.Add(SalaryDriver);
                command.Parameters.Add(AdressDriver);

                driver.Id = (long)command.ExecuteScalar();

                var countStart = listDrivers.Count;
                listDrivers.Add(driver);
                var countEnd = listDrivers.Count;
                if (countStart < countEnd)
                {
                    MessageBox.Show("You add a new driver", "Succes Add", MessageBoxButtons.OK);
                    if (MessageBoxButtons.OK == 0)
                    {
                        this.Close();
                    }
                }
            }
        }


        #endregion//Methods

    }//AddDrivers
}
