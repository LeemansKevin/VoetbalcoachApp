using System;
using Voetbalcoach;
class Program
{
    static void Main()
    {
        StartClass startClass = new StartClass();
        Gegevens gegevens = new Gegevens();

        startClass.Start();
        gegevens.Input();
        gegevens.Output();

    }

    


}