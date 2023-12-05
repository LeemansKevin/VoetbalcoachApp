using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalcoach
{
    public class Gegevens
    {
        //Maximu Groote array
        const int maxGroote = 12;

        //Array aanmaken
        int[,] invoeren = new int[maxGroote, 2];

        public void Input()
        {
            for (int i = 0; i < maxGroote; i++)
            {
                Console.WriteLine("Voer de rugnummer van de speler in : ");
                int rugnummer = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nVoer nu de beoordeling in voor speler ({rugnummer}) : ");
                int beoordeling = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Vorige speler : {rugnummer} ");

                // Opslaan in array
                invoeren[i,0] = rugnummer;
                invoeren[i,1] = beoordeling;
            }
        }

        public void Output()
        {
            Console.WriteLine("\nOpgeslagen gegevens:");

            for (int i = 0; i < maxGroote; i++)
            {
                Console.WriteLine($"Rugnummer = {invoeren[i, 0]},   Beoordeling = {invoeren[i, 1]}");
                Console.ReadLine();
            }
        }
}
}
