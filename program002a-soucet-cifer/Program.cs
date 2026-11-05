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
int cislo = int.Parse(Console.ReadLine());

int soucet = 0;
int soucin = 1;

while (cislo > 0)
{
    int cifra = cislo % 10;
    soucet += cifra;
    soucin *= cifra;

    cislo /= 10
    ;
}

Console.WriteLine("Součet cifer je: " + soucet);
Console.WriteLine("Součin cifer je: " + soucin);

    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   
