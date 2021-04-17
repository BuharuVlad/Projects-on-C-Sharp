using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    class Car
    {
        public long? Id { get; set; }
        public string NameCar { get; set; }
        public string ModelCar { get; set; }

        public Car()
        {
            Id = 0;
            NameCar = "";
            ModelCar = "";
        }

        public Car(string nameCar, string modelCar)
        {
            NameCar = nameCar;
            ModelCar = modelCar;
        }

    }
}
