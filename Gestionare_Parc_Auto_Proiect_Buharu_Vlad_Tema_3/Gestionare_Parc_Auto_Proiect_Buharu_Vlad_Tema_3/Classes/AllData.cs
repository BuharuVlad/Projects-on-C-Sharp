using System;
using System.Text;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Classes
{   
    [Serializable]
    class AllData
    {
        #region Attributes
        public string NameCar { get; set; }
        public string ModelCar { get; set; }
        public string FirstNameDriver { get; set; }
        public string SecondNameDriver { get; set; }
        public DateTime BirthDayDriver { get; set; }
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
                BirthDayDriver = new DateTime();
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
            string secondNameDriver, DateTime birthDayDriver,
            string nameRute, string fromRute, string toRute,
            string productTransport, int quantityTransport)
        {
            NameCar = nameCar;
            ModelCar = modelCar;
            FirstNameDriver = firstNameDriver;
            SecondNameDriver = secondNameDriver;
            BirthDayDriver = birthDayDriver;
            NameRute = nameRute;
            FromRute = fromRute;
            ToRute = toRute;
            ProductTransport = productTransport;
            QuantityTransport = quantityTransport;
        }
        public AllData(string nameCar, string modelCar, string firstNameDriver,
            string secondNameDriver, DateTime birthDayDriver,
            string nameRute, string productTransport, int quantityTransport)
        {
            NameCar = nameCar;
            ModelCar = modelCar;
            FirstNameDriver = firstNameDriver;
            SecondNameDriver = secondNameDriver;
            BirthDayDriver = birthDayDriver;
            NameRute = nameRute;
            ProductTransport = productTransport;
            QuantityTransport = quantityTransport;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (NameCar != null)
            {
                stringBuilder.Append(NameCar);
                stringBuilder.Append(" ");
            }

            if (ModelCar != null)
            {
                stringBuilder.Append(ModelCar);
                stringBuilder.Append(" ");
            }

            if (FirstNameDriver != null)
            {
                stringBuilder.Append(FirstNameDriver);
                stringBuilder.Append(" ");
            }

            if (SecondNameDriver != null)
            {
                stringBuilder.Append(SecondNameDriver);
                stringBuilder.Append(" ");
            }

            if (BirthDayDriver != DateTime.MinValue)
            {
                stringBuilder.Append(BirthDayDriver);
                stringBuilder.Append(" ");
            }

            if (AdressDriver != null)
            {
                stringBuilder.Append(AdressDriver);
                stringBuilder.Append(" ");
            }

            if (SalaryDriver > 0)
            {
                stringBuilder.Append(SalaryDriver);
                stringBuilder.Append(" ");
            }

            if (NameRute != null)
            {
                stringBuilder.Append(NameRute);
                stringBuilder.Append(" ");
            }

            if (FromRute != null)
            {
                stringBuilder.Append(FromRute);
                stringBuilder.Append(" ");
            }

            if (ToRute != null)
            {
                stringBuilder.Append(ToRute);
                stringBuilder.Append(" ");
            }

            if (ProductTransport != null)
            {
                stringBuilder.Append(ProductTransport);
                stringBuilder.Append(" ");
            }

            if (QuantityTransport > 0)
            {
                stringBuilder.Append(QuantityTransport);
            }

            return stringBuilder.ToString();
        }
    }
}
