using System;

namespace T2L4Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1

            Console.Write("Zadanie 1 \r\nWprowadź dane pracownika: \r\nImię: ");
            string firstName = Console.ReadLine();
            
            Console.Write("Nazwisko: ");
            string surname = Console.ReadLine();

            Console.Write("Wiek: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Płeć M/K: ");
            char gender = char.Parse(Console.ReadLine());

            Console.Write("Pesel: ");
            long pesel = long.Parse(Console.ReadLine());

            Console.Write("Numer pracownika: ");
            int idEmployee = int.Parse(Console.ReadLine());

            Console.WriteLine($"\r\nImię: {firstName} \r\nNazwisko: {surname} \r\nWiek: {age} \r\nPłeć: {gender} " +
                $"\r\nPesel: {pesel} \r\nNumer pracownika: {idEmployee}");

            // Zadanie 2

            Console.WriteLine("\r\nZadanie 2: ");

            char ch1 = 'A';
            char ch2 = 'B';
            char ch3 = 'C';

            Console.WriteLine($"{ch3}{ch2}{ch1}");

            //Zadanie 3
            Console.WriteLine("\r\nZadanie 3");
            Console.WriteLine("Wprowadź szerokość prostokąta: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadź długość prostokąta: ");
            double length = double.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));
            Console.WriteLine($"Przekątna prostkąta: {diagonal}");

            //Zadanie 4
            Console.WriteLine("\r\nZadanie 4");
            int a = 10;
            string b = "Szkoła Dotneta";
            double c = 12.5;
            Console.WriteLine($"a. {a} \r\nb. {b} \r\nc. {c}");

            //Zadanie 5

            Console.WriteLine("Zadanie 5 \r\nWprowadź dane: \r\nImię: ");
            firstName = Console.ReadLine();

            Console.Write("Nazwisko: ");
            surname = Console.ReadLine();

            Console.Write("Numer telefonu: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Adres email: ");
            string email = Console.ReadLine();

            Console.Write("Wzrost: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Waga: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Adres zamieszkania: ");
            string address = Console.ReadLine();

            Console.WriteLine($"\r\nImię: {firstName} \r\nNazwisko: {surname} \r\nNumer telefonu: {phoneNumber} " +
                $"\r\nAdres email: {email} \r\nWzrost: {height} \r\nWaga: {weight} \r\nAdres zamieszkania: {address}");
        }
    }
}
