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
        public int[,] array = new int[maxGroote, 2];

        public string bestandsNaam = "";

        public void Input()
        {
            for (int i = 0; i < maxGroote; i++)
            {
                Console.WriteLine("Voer de rugnummer van de speler in : ");
                int rugnummer;
                while (!int.TryParse(Console.ReadLine(), out rugnummer))
                {
                    Console.WriteLine("Voer de rugnummer van de speler in : ");
                }

                Console.WriteLine($"\nVoer nu de beoordeling in voor speler ({rugnummer}) : ");
                int beoordeling;
                while (!int.TryParse(Console.ReadLine(), out beoordeling))
                {
                    Console.WriteLine("Voer de rugnummer van de speler in : ");
                }
                Console.Clear();
                Console.WriteLine($"Vorige speler : {rugnummer} ");

                // Opslaan in array
                array[i,0] = rugnummer;
                array[i,1] = beoordeling;
            }
        }

        public void Output()
        {
            Console.WriteLine("\nOpgeslagen gegevens:");

            for (int i = 0; i < maxGroote; i++)
            {
                Console.WriteLine($"Rugnummer = {array[i, 0]},   Beoordeling = {array[i, 1]}");
                
            }

            Console.ReadLine();
            Console.WriteLine("Geef de gewenste bestandsnaam op : ");
            bestandsNaam = (Console.ReadLine() + ".txt");
            
        }
}
}
