

using System.Reflection.Emit;

Console.Clear();
String again = "a";
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("*****Generátor pseudonáhodných čísel *****");
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Michal Špryňar ************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    Console.Write("Zadejte počet čísel: ");
    
    int length;
    while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
    {
        Console.WriteLine("Neplatný vstup. Zadejte prosím kladné celé číslo.");
        Console.Write("Zadejte počet čísel: ");
    }

    Console.Write("Zadejte minimální hodnotu: ");

    int min;
    while (!int.TryParse(Console.ReadLine(), out min))
    {
        Console.WriteLine("Neplatný vstup. Zadejte prosím celé číslo.");
        Console.Write("Zadejte minimální hodnotu: ");
    }

    Console.Write("Zadejte maximální hodnotu: ");

    int max;
    while (!int.TryParse(Console.ReadLine(), out max) || max <= min)
    {
        Console.WriteLine("Neplatný vstup. Zadejte prosím celé číslo větší než minimální hodnota.");
        Console.Write("Zadejte maximální hodnotu: ");
    }

    int [] numbers = new int[length];
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        numbers[i] = random.Next(min, max + 1);

    }


    for (int i = 0; i < length; i++)
    {
        Console.Write(numbers[i] + " ");
    }

    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   



