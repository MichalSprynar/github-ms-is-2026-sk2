

Console.Clear();
String again = "a";
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("************** jméno programu ************");
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Michal Špryňar ************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");




    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   


