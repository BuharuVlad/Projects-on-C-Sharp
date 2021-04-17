using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Classes
{
    class AllData
    {
        #region Attributes
        public string NameCar { get; set; }
        public string ModelCar { get; set; }
        public string FirstNameDriver { get; set; }
        public string SecondNameDriver { get; set; }
        public string BirthDayDriver { get; set; }
        public string AdressDriver { get; set; }
        public float SalaryDriver { get; set; }
        public string NameRute { get; set; }
        public string FromRute { get; set; }
        public string ToRute { get; set; }
        public string ProductTransport { get; set; }
        public int QuantityTransport { get; set; }
        #endregion

        public AllData()
        {
            {
                NameCar = "";
                ModelCar = "";
                FirstNameDriver = "";
                SecondNameDriver = "";
                BirthDayDriver = "";
                AdressDriver = "";
                SalaryDriver = 0;
                NameRute = "";
                FromRute = "";
                ToRute = "";
                ProductTransport = "";
                QuantityTransport = 0;
            }
        }
        public AllData(string nameCar, string modelCar, string firstNameDriver,
            string secondNameDriver, string birthDayDriver, string adressDriver,
            float salaryDriver, string nameRute, string fromRute, string toRute,
            string productTransport, int quantityTransport)
        {
            NameCar = nameCar;
            ModelCar = modelCar;
            FirstNameDriver = firstNameDriver;
            SecondNameDriver = secondNameDriver;
            BirthDayDriver = birthDayDriver;
            AdressDriver = adressDriver;
            SalaryDriver = salaryDriver;
            NameRute = nameRute;
            FromRute = fromRute;
            ToRute = toRute;
            ProductTransport = productTransport;
            QuantityTransport = quantityTransport;
        }


    }
}
