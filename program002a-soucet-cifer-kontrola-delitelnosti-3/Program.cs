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
int cislo = int.Parse(Console.ReadLine());;
int soucet = 0;

while (cislo > 0)
{
    soucet += cislo % 10;
    cislo /= 10;
}

if (soucet % 3 == 0)
    Console.WriteLine("Číslo je dělitelné 3");
else
    Console.WriteLine("Číslo není dělitelné 3");

    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   

