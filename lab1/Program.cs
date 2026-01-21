namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1: Pętla while do sprawdzania hasła
            string input = "";
            while (input != "admin123")
            {
                Console.Write("Podaj hasło: ");
                input = Console.ReadLine();
            }
            Console.WriteLine("Zalogowano pomyślnie!");

            // Zadanie 2: Pętla do...while do wczytywania liczby większej od zera

            int liczba;
            do
            {
                Console.Write("Podaj liczbę większą od zera: ");
                liczba = int.Parse(Console.ReadLine());
            }
            while (liczba <= 0);

            Console.WriteLine($"Podano poprawną liczbę: {liczba}");

            // Zadanie 3: Pętla foreach

            string[] miasta = { "Bydgoszcz", "Warszawa", "Kraków", "Gdańsk", "Wrocław" };

            foreach (string miasto in miasta)
            {
                Console.WriteLine(miasto);
            }

            // Zadanie 4: Utwórz klasę Osoba
        }
    }
        class Osoba
        {
            public string Imie;
            public int Wiek;

            public void PrzedstawSie()
            {
                Console.WriteLine($"Cześć, mam na imię {Imie} i mam {Wiek} lat.");
            }
        }

        // Zadanie 5: Dodaj metodę Wyplat
        class KontoBankowe
        {
            private double saldo;

            public void Wplata(double kwota) { saldo += kwota; }
            public double PobierzSaldo() { return saldo; }

            public void Wyplata(double kwota)
            {
                if (kwota <= saldo)
                {
                    saldo -= kwota;
                    Console.WriteLine($"Wypłacono: {kwota}");
                }
                else
                {
                    Console.WriteLine("Brak wystarczających środków na koncie.");
                }
            }
        }

        // Zadanie 6 i 7: Dziedziczenie - klasa Kot + Polimorfizm - metoda DajGlos
        class Zwierze
        {
            public virtual void DajGlos() => Console.WriteLine("Zwierzę wydaje dźwięk");
        }
        class Pies : Zwierze
        {
            public override void DajGlos() => Console.WriteLine("Hau hau!");
        }
        class Kot : Zwierze
        {
            public override void DajGlos() => Console.WriteLine("Miau!");
        }
        // tablica celowo poza metodą Main, aby pokazać którego zadania dotyczy kod
        Zwierze[] zwierzeta = new Zwierze[3];
        zwierzeta[0] = new Pies();
        zwierzeta[1] = new Kot();
        zwierzeta[2] = new Pies();

        foreach (Zwierze zwierze in zwierzeta)
        {
            zwierze.DajGlos();
       
        }
}


    




