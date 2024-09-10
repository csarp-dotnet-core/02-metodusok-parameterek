// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
// Paraméter nélküli metódus
static void Udvozlet()
{
    Console.WriteLine("Köszöntelek a programban!");
}

// Paraméterrel rendelkező metódus
static void Udvozlet2(string nev)
{
    Console.WriteLine($"Köszöntelek {nev} a programban!");
}
*/

// Alapértelmezett értékkel rendelkező paraméter
static void Udvozlet(string nev="")
{
    Console.WriteLine($"Köszöntelek {nev} a programban!");
}

Udvozlet();
Udvozlet("Lukrécia");

// Több paraméterrel rendelkező metódus
static void ErtekKiiras(int a, int b)
{
    Console.WriteLine("Első szám értéke: {0}, második szám értéke: {1}", a, b);
}

int a = 2, b = 2;
ErtekKiiras(a, b);