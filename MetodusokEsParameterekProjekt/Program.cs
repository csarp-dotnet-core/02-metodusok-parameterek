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