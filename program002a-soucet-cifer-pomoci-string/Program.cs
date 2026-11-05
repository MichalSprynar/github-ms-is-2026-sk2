Console.Clear();
String again = "a";
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Součet cifer **************");
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Michal Špryňar ************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

Console.WriteLine("Zadej číslo:");
string cislo = Console.ReadLine();

int soucet = 0;
int soucin = 1;

foreach (char znak in cislo)
{
    soucet += int.Parse(znak.ToString());
    soucin *= int.Parse(znak.ToString());
}

Console.WriteLine("Součet cifer je: " + soucet);
Console.WriteLine("Součin cifer je: " + soucin);

    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   
