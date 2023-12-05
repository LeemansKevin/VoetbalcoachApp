using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalcoach
{
    public class BestandsManager
    {
        public void OpslaanNaarBestand(int[,] array, string bestandsnaam)
        {
            using (StreamWriter sw = new StreamWriter(bestandsnaam))
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    sw.WriteLine($"{array[i, 0]},{array[i, 1]}");
                }
            }
            
            Console.WriteLine($"Gegevens zijn opgeslagen naar {bestandsnaam}.");
            Console.ReadLine();
        }
    }
}

