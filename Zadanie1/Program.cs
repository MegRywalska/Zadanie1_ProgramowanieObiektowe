using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Jan Kowalski");
            osoba1.DataUrodzin = new DateTime(1990, 1, 1);

            Console.WriteLine("Osoba 1:");
            Console.WriteLine($"Imię i nazwisko: {osoba1.ImieNazwisko}");
            Console.WriteLine($"Data urodzin: {osoba1.DataUrodzin}");
            Console.WriteLine($"Wiek: {osoba1.Wiek?.Days / 365.25} lat");
            
            osoba1.ImieNazwisko = "Adam Nowak";
            Console.WriteLine("\nZmiana danych osoby 1:");
            Console.WriteLine($"Imię i nazwisko: {osoba1.ImieNazwisko}");
            
            Osoba osoba2 = new Osoba("Anna");
            Console.WriteLine("\nOsoba 2:");
            Console.WriteLine($"Imię i nazwisko: {osoba2.ImieNazwisko}");
            
            try
            {
                osoba2.Imie = "";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nBłąd: {ex.Message}");
            }

            
            osoba1.DataSmierci = new DateTime(2020, 1, 1);
            Console.WriteLine("\nPo ustawieniu daty śmierci osoby 1:");
            Console.WriteLine($"Data śmierci: {osoba1.DataSmierci}");
            Console.WriteLine($"Wiek: {osoba1.Wiek?.Days / 365.25} lat"); 
            
        }
    }
}