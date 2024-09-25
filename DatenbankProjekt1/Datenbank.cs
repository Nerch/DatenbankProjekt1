using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DatenbankProjekt1
{
    internal class Datenbank
    {
        //Eigenschaften der Klasse
        String Name = "Name der Datenbank.";
        String Ort = "Datenbanken/data.sqlite"; //Datenbankpfad
        String Beschreibung = "Platzhalter für die Beschreibeung.";

        private SQLiteConnection connection; // Datenbankverbindung

        public Datenbank() //Konstruktor für die Klasse.
        {
            // Konstruktor-Code hier einfügen
        }

        public void DatabaseConnect() //Methode zum verbinden der Datenbank.
        {
            string connectionString = $"Data Source={Ort};"; // Verbindungszeichenfolge erstellen
            connection = new SQLiteConnection(connectionString); // Verbindung erstellen
            connection.Open(); // Verbindung öffnen
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
