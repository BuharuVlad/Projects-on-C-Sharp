using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces
{
    public partial class InterfaceDriver : Form
    {

        private const string ConnectionDriver = "Data Source=Drivers.db";
        private static readonly List<string> DriversTxt = new List<string>();
        public InterfaceDriver()
        {
            InitializeComponent();
        }

        private void BtnAddCar_Click(object sender, EventArgs e)
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

        private void DtGridList_CellClick(object sender, DataGridViewCellEventArgs e)
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
                MessageBox.Show(@"Click only in the left side of the window, next to id", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DisplayDriver();
        }

        private void BtnUpdateDriver_Click(object sender, EventArgs e)
        {
            DateTime birthDayDriver = new DateTime();
            birthDayDriver = DateTime.Parse(txtBirthDayDriver.Text);
            string birth = birthDayDriver.ToLongDateString();
            string query = "update Drivers set FirstName = '" + txtFirstNameDriver + "'," +
                " SecondName = '" + txtSecondNameDriver + "', " +
                "BirthDay = '" + birth + "', " +
                "Salary = '" + txtSalaryDriver + "'," +
                "Adress = '" + txtAdressDriver + "'" +
                "where id = '" + txtIdDriver + "' ;";
            InsertUpdateDeleteDriver(query);
            DisplayDriver();
        }

        private void BtnDeleteDriver_Click(object sender, EventArgs e)
        {
            string query = "delete from Drivers where id ='" + txtIdDriver + "' ;";
            InsertUpdateDeleteDriver(query);
            DisplayDriver();
        }

        private void BtnSerializareTxtDriver_Click(object sender, EventArgs e)
        {
            List<string> DriversTxt = ConvertSQLiteInList();
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text File | *.txt";
                saveFileDialog.Title = "Save as text file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.WriteLine("FirstName, SecondName, BirthDay,Salary,Adress");

                        for (int i = 0; i < DriversTxt.Count; i++)
                        {
                            sw.WriteLine(DriversTxt[i]);
                        }
                    }
                }
            }
        } //btnSerializareTxtDriver_Click

        public static List<string> ConvertSQLiteInList()
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
                        string Driver = (string)r["FirstName"] + " " 
                            + (string)r["SecondName"] + "," 
                            + (DateTime)r["BirthDay"] + "," 
                            + (Int64)r["Salary"] + "," 
                            + (string)r["Adress"];
                        DriversTxt.Add(Driver);
                    }
                }
            }
            return DriversTxt;
        }//ConvertSQLiteInList
    }
}
