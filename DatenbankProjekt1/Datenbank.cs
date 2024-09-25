using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DatenbankProjekt1
{
    internal class Datenbank
    {
        //Eigenschaften der Klasse
        String Name = "Name der Datenbank.";
        String Ort = "Pfad zum Ordner wo die Datenbank hinterlegt ist.";
        String Beschreibung = "Platzhalter für die Beschreibeung.";


        public Datenbank() //Konstruktor für die Klasse.
        {
            // Konstruktor-Code hier einfügen
        }

        public void DatabaseConnect() //Methode zum verbinden der Datenbank.
        {
            // Code zum Verbinden der Datenbank hier einfügen
        }

        public void SqliteAbfrage() //Methode um SQL Abfragen zu ermöglichen.
        {
            // Code für SQL-Abfragen hier einfügen
        }

        public string DatabaseAnzeige() //Methode zur Anzeige der Datenbank.
        {
            string placeholder = "Platzhalter";
            Console.WriteLine(placeholder);
            return placeholder; // Rückgabewert hinzufügen
        }
    }
}
