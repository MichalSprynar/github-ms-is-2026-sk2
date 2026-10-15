// Read the first value of the sequence from the user.
Console.WriteLine("Zadejte začátek: ");
int first = int.Parse(Console.ReadLine());

// Read the last value to include in the sequence.
Console.WriteLine("Zadejte konec: ");
int last = int.Parse(Console.ReadLine());

// Read the amount by which each value should increase.
Console.WriteLine("Zadejte krok: ");
int step = int.Parse(Console.ReadLine());

// Print each value from the first value up to and including the last value.
for (int i = first; i <= last; i += step)
{
    Console.Write(i + " ");
}

