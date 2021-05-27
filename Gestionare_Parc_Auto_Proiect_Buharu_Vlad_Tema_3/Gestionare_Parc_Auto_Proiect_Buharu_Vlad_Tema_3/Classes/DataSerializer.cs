using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gestionare_Parc_Auto_Proiect_Buharu_Vlad_Tema_3.Classes
{
    class DataSerializer
    {
        public void BinarySerializeObject(List<AllData> transport)
        {
            if (!File.Exists("serializeb.bin"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream s = File.Create("serializeb.bin"))
                    binaryFormatter.Serialize(s, transport);
            }
            else
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream s = File.OpenWrite("serializeb.bin"))
                    binaryFormatter.Serialize(s, transport);
            }
        }
        public List<AllData> Deserialize()
        {
           List<AllData> transportAllData = new List<AllData>();
           if (File.Exists("serializeb.bin"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream s = File.OpenRead("serializeb.bin"))
                {
                    transportAllData = (List<AllData>)binaryFormatter.Deserialize(s);
                    return transportAllData;
                }
            }
           else
           {
               return null;
           }
               
        }
    }
}
