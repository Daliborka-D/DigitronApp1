// See https://aka.ms/new-console-template for more information
using DigitronApp1.BusinessLayer;

Console.WriteLine("Unesi prvi broj: ");
int prviBroj = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Unesi drugi broj: ");
int drugiBroj = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Unesi redni broj zeljene operacije: 1 Sabiranje 2 Oduzimanje 3 Mnozenje 4 Deljenje");
int operacija = Convert.ToInt32(Console.ReadLine());


OsnovnaKlasa osnovna = new OsnovnaKlasa();

switch (operacija)
{
    case 1:
        int rezultat1 = osnovna.Sabiranje(prviBroj, drugiBroj);
        Console.WriteLine($"Rezultat sabiranja je: {rezultat1}");
        break;

        case 2:
        int rezultat2 = osnovna.Oduzimanje(prviBroj, drugiBroj);
        Console.WriteLine($"Rezultat oduzimanja je: {rezultat2}");
        break;

        case 3:
        int rezultat3 = osnovna.Mnozenje(prviBroj, drugiBroj);
        Console.WriteLine($"Rezultat mnozenja je: {rezultat3}");
        break;
        
        case 4:
        double rezultat4 = osnovna.Deljenje(prviBroj, drugiBroj);
        Console.WriteLine($"Rezultat deljenja je: {rezultat4}");
        break;

}


