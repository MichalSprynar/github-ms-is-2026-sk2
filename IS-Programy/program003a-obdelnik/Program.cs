

Console.Clear();
String again = "a";
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Vykreslení obrazce ********");
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Michal Špryňar ************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    Console.WriteLine("Zadejte šířku obdelníku: ");
    int width = int.Parse(Console.ReadLine());
    Console.WriteLine("Zadejte výšku obdelníku: ");
    int height = int.Parse(Console.ReadLine());

    

 for(int i = 1; i <= height ; i++)
    {
        if(i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
          
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        
        
       
        for(int j = 1; j <= width; j++)
        {
        Console.Write("█");
        }

        Console.WriteLine();

    }


    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   


