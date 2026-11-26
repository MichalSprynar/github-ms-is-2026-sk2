using System.Xml.Resolvers;

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

    int maxValue = numbers[0];
    int positionOfMaxValue = 0;
    int minValue = numbers[0];
    int positionOfMinValue = 0;

    for (int i = 1; i < length; i++)
    {
        if (numbers[i] > maxValue)
        {
            maxValue = numbers[i];
            positionOfMaxValue = i;
            
        }

         if (numbers[i] < minValue)
        {
            minValue = numbers[i];
            positionOfMinValue = i;
            
        }
    }
    Console.WriteLine("Maximální hodnota: " + maxValue + "  na pozici: " + positionOfMaxValue + ".");
    Console.WriteLine("Maximální hodnota: " + minValue + "  na pozici: " + positionOfMinValue + ".");


if (maxValue >= 3)

for(int i = 0; i < maxValue; i++)
    {
        int spaces = 0;
        int stars = 0; 

        if(i < maxValue / 2)
        {
        spaces = i;
        stars = maxValue - (2*i);
        for(int sp = 0; sp < spaces; sp++)
            {
                Console.Write(" ");
            }

            for(int st = 0; st < stars; st++)
            {
                Console.Write("*");
            }
        Console.WriteLine();
        }
        else
        {
        spaces = maxValue - i - 1;
        stars = 2 * (i - maxValue / 2) + 1;
        for(int sp = 0; sp < spaces; sp++)
            {
                Console.Write(" ");
            }

            for(int st = 0; st < stars; st++)
            {
                Console.Write("*");
            }
        Console.WriteLine();
        }


    }


{
    



}