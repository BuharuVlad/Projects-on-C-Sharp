using System;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Classes
{
    class CustomException : Exception
    {
        private string NameCar { get; set; }
        private string NameRute { get; set; }
        private string NameDriver { get; set; }
        private string LastNameDriver { get; set; }

        public CustomException(string nameCar, string nameRute, string nameDriver, string lastNameDriver)
        {
            NameCar = nameCar;
            NameRute = nameRute;
            NameDriver = nameDriver;
            LastNameDriver = lastNameDriver;
        }

        public override string Message
        {
            get
            {
                return "ComboBox  is null!";
            }
        }
    }
}
