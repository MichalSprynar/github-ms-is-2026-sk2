// Read the first value, last value, and increment using validated integer input.
int first = ReadInt("Zadejte začátek: ");
int last = ReadInt("Zadejte konec: ");
int step = ReadInt("Zadejte krok: ");

// Print each value from the first value up to and including the last value.
for (int i = first; i <= last; i += step)
{
    Console.Write(i + " ");
}

// Keep asking until the user enters a value that can be parsed as an integer.
int ReadInt(string prompt)
{
    while (true)
    {
        Console.WriteLine(prompt);

        if (int.TryParse(Console.ReadLine(), out int value))
        {
            return value;
        }

        Console.WriteLine("Zadejte prosím platné celé číslo.");
    }
}
