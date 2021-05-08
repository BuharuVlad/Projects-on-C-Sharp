using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    public partial class AddCars : Form
    {
        private readonly List<Car> listCar = new List<Car>();
        private const string ConnectionString = "Data Source=Cars.db";
        public AddCars()
        {
            InitializeComponent();
        }

        private void SaveCar_Click(object sender, EventArgs e)
        {
            if (txtNameCar.Text != "" && txtModelCar.Text != "" && txtNameCar.Text != " " && txtModelCar.Text != " ")
            {
                Car car = new Car(txtNameCar.Text, txtModelCar.Text);
                AddCarsSQLite(car);
            }
            else
            {
               MessageBox.Show(@"Please write the name or the model of the car!", @"Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//SaveCar_Click
        private void AddCarsSQLite(Car car)
        {
            var queryString = "insert into Cars(NameCar, ModelCar)" +
                              " values(@NameCar,@ModelCar);  " +
                              "SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(queryString, connection);
                var nameCar = new SQLiteParameter("@NameCar")
                {
                    Value = car.NameCar
                };
                var modelCar = new SQLiteParameter("@ModelCar")
                {
                    Value = car.ModelCar
                };

                command.Parameters.Add(nameCar);
                command.Parameters.Add(modelCar);

                car.Id = (long)command.ExecuteScalar();

                var countStart = listCar.Count;
                listCar.Add(car);
                var countEnd = listCar.Count;
                if (countStart < countEnd)
                {
                    MessageBox.Show("You add a new car", "Succes Add", MessageBoxButtons.OK);
                    if(MessageBoxButtons.OK == 0)
                    {
                        this.Close();
                    }
                }
            }
        }//AddCarsSQLite

        private void CancelCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Are you sure? Data will be delete!", @"Unsaved data", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            this.Close();
        }//CancelCar_Click 
    }//AddCars

}//Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
