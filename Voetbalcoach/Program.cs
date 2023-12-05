using System;
using Voetbalcoach;
class Program
{
    static void Main()
    {
        StartClass startClass = new StartClass();
        Gegevens gegevens = new Gegevens();
        BestandsManager bestandsManager = new BestandsManager();

        

        startClass.Start();
        gegevens.Input();
        gegevens.Output();
        bestandsManager.OpslaanNaarBestand(gegevens.array ,gegevens.bestandsNaam);

    }

    


}