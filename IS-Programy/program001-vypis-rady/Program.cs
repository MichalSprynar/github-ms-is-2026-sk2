Console.WriteLine("Zadejte začátek: ");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Zadejte konec: ");
int last = int.Parse(Console.ReadLine());
Console.WriteLine("Zadejte krok: ");
int step = int.Parse(Console.ReadLine());

for (int i = first; i <= last; i += step)
{
    Console.Write(i + " ");
}

Console.WriteLine();
