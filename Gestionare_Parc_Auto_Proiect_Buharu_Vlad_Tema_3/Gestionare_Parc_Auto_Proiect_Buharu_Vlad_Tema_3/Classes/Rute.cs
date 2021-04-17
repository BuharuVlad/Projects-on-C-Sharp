using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    class Rute
    {
        public long? Id { get; set; }
        public string NameRute { get; set; }
        public string FromRute { get; set; }
        public string ToRute { get; set; }

        public Rute()
        {
            NameRute = "";
            FromRute = "";
            ToRute = "";
        }

        public Rute(string nameRute, string fromRute, string toRute)
        {
            NameRute = nameRute;
            FromRute = fromRute;
            ToRute = toRute;
        }
    }
}
