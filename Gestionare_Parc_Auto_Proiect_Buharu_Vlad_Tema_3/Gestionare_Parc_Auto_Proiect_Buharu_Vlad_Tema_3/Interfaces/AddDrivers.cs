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
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstNameDriver.Text != "" && txtSecondNameDriver.Text != "" 
                && txtBirthDayDriver.Text != "" && txtAdressDriver.Text != "" && txtSalaryDriver.Text != "" && 
                txtFirstNameDriver.Text != " " && txtSecondNameDriver.Text != " "
                && txtBirthDayDriver.Text != " " && txtAdressDriver.Text != "" && txtSalaryDriver.Text != " ")
            {
                Driver driver = new Driver(txtFirstNameDriver.Text, txtSecondNameDriver.Text, 
                    txtBirthDayDriver.Text, txtAdressDriver.Text, float.Parse(txtSalaryDriver.Text));
                //AddDriversSQLite(drivers);
            }
            else
            {
                MessageBox.Show("Please write the name or the model of the car!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//button1_Validationg

        #endregion //Buttons

        #region Methods
        private void AddDriversSQLite(Driver driver)
        {
            var query = "insert into Drivers(FirstName, SecondName, BirthDay, Salary, Adress)" +
                "values (@FirstNameDriver, @SecondNameDriver, @BirthDayDriver, @SalaryDriver, @AdressDriver)" +
                "SELECT last_insert_rowid()";
            using(SQLiteConnection connection = new SQLiteConnection())
            {
                connection.Open();

            }
        }
        #endregion//Methods



    }//AddDrivers
}
