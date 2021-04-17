using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    class Driver : Car
    {
        public static long? IdDriver { get; set; }
        public string FirstNameDriver { get; set; }
        public string SecondNameDriver { get; set; }
        public string BirthDayDriver { get; set; }
        public string AdressDriver { get; set; }
        public float SalaryDriver { get; set; }

        public Driver(string firstNameDriver, string secondNameDriver, string birthDayDriver, string adressDriver, float salaryDriver)
        {
            FirstNameDriver = firstNameDriver;
            SecondNameDriver = secondNameDriver;
            BirthDayDriver = birthDayDriver;
            AdressDriver = adressDriver;
            SalaryDriver = salaryDriver;
        }

        public Driver()
        {
            IdDriver = 0;
            FirstNameDriver = "";
            SecondNameDriver = "";
            BirthDayDriver = "01.01.2013";
            SalaryDriver = 2000f;
        }
    }//Driver
}//Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
