using System.ComponentModel;

namespace DatenbankProjekt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Datenbankeinbindung Test Programm"); 

            Datenbank Testaufruf = new Datenbank(); // Instanzierung der Klasse Datenbank als neues Objekt mit dem Namen Testaufruf.
            Testaufruf.DatabaseAnzeige(); // Aufruf der Methode der Instanz Testaufruf

        }
    }
}