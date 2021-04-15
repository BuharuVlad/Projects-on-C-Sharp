using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3
{
    class Transport
    {
        public long id { get; set; }
        public string ProductTransport { get; set; }
        public int QuantityTransport { get; set; }

        public Transport(string productTransport, int quantityTransport)
        {
            ProductTransport = productTransport;
            QuantityTransport = quantityTransport;
        }
    }
}
