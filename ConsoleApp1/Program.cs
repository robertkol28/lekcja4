using System;

namespace lekcja4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to:
            a. Imię,
            b. Nazwisko
            c. Wiek
            d. Płeć (‘m’ albo ‘k’)
            e. PESEL
            f. Numer pracownika (np. 2509324094)
            Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje*/
            string firstName;
            string lastName;
            byte age;
            char gender;
            string PESEL;
            string employeeNumber;

            /*Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.*/
        char character1 = 'A';
        char character2 = 'B';
        char character3 = 'C';

        Console.WriteLine(character3);
        Console.WriteLine(character2);
        Console.WriteLine(character1);

            /*Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())*/

            uint length = 5;
            uint width = 10;

            double diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));
            Console.WriteLine($"diagonal is:{diagonal}");

            /*Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie przypiszesz im następujące wartości:
            a. 10
            b. Szkoła Dotneta
            c. 12,5*/

            int a = 10;
            string b = "Szkoła Dotneta";
            double c = 12.5;

            /*Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko, numer telefonu, adres email, wzrost, waga (np. 85,7),
             itp (postaraj się wymyślić jak najwięcej) i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody: 
            typDanych.Parse(odpowiedźOdUżytkownika) */

            Console.WriteLine("Type Your First name");

            string firstName1 = Console.ReadLine();

            Console.WriteLine("Type Your Last Name");

            string lastName1 = Console.ReadLine();

            Console.WriteLine("type Your phone number");

            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Type Your age");

            string age1 = Console.ReadLine();
            byte age2 = Byte.Parse(age1);

            Console.WriteLine("type Your e-mail");

            string email = Console.ReadLine();

            Console.WriteLine("Type Your height in cm");

            string height = Console.ReadLine();
            byte height1 = Byte.Parse(height);
            
            Console.WriteLine("Type your weight in kg");

            string weight = Console.ReadLine();
            double weight1 = Double.Parse(weight);


        }
    }
}