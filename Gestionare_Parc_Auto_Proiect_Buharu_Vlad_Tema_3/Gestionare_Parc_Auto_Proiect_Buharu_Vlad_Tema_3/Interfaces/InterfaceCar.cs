using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Interfaces
{
    public partial class InterfaceCar : Form
    {
        private const string ConnectionCar = "Data Source=Cars.db";
        private static readonly List<string> carsTxt = new List<string>();
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

        private void InsertUpdateDeleteCar(string query)
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionCar);
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand
            {
                Connection = connection,
                CommandText = query
            };
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(sdr);
                sdr.Close();
                connection.Close();
                dtGridList.DataSource = dt;
            }
        } // InsertUpdateDeleteCar
        private void DtGridList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUpdateIdCar.Text = dtGridList.SelectedRows[0].Cells[0].Value.ToString();
                txtUpdateNameCar.Text = dtGridList.SelectedRows[0].Cells[1].Value.ToString();
                txtUpdateModelCar.Text = dtGridList.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Click only in the left side of the window, next to id", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } // dtGridList_CellClick

        #region Buttons Car
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCar();
        } // btnRefresh_Click

        private void BtnUpdateCar_Click(object sender, EventArgs e)
        {
           if (txtUpdateNameCar.Text == @"Scandia" && txtUpdateNameCar.Text == "Man")
           {
               string query = "update Cars set NameCar = '" + txtUpdateNameCar + "', ModelCar = '" + txtUpdateModelCar + "' where id = '" + txtUpdateIdCar + "' ;";
               InsertUpdateDeleteCar(query);
               DisplayCar();
           }
           else
           {
                MessageBox.Show(@"Please insert the corect name!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }           
        } // btnUpdateCar_Click

        private void BtnDeleteCar_Click(object sender, EventArgs e)
        {
            string query = "delete from Cars where id ='" + txtUpdateIdCar + "' ;";
            InsertUpdateDeleteCar(query);
            DisplayCar();
        } // btnDeleteCar_Click

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            AddCars addCars = new AddCars();
            addCars.Show();
        } // btnAddCar_Click

        #endregion // View Buttons

        private void BtnSerializareTxt_Click(object sender, EventArgs e)
        {
            List<string> carsTxt = ConvertSQLiteInList();
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text File | *.txt";
                saveFileDialog.Title = "Save as text file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.WriteLine("NameCar,ModelCar");

                        for (int i = 0; i < carsTxt.Count; i++)
                        {
                            sw.WriteLine(carsTxt[i]);
                        }
                    }
                }
            }
        }// btnSerializareTxt_Click

        public static List<string> ConvertSQLiteInList()
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
                        string NameModelCar = (string)r["NameCar"] + ", " + (string)r["ModelCar"];
                        carsTxt.Add(NameModelCar);
                    }
                }
            }
            return carsTxt;
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
