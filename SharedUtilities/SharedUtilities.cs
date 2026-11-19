
namespace SharedUtilities;

public class Programs
{

//Generátor pseudonáhodných čísel 
//using SharedUtilities;   

/**
 * Generates an array of random numbers within a specified range.
 * @param length The number of random numbers to generate.
 * @param min The minimum value (inclusive) for the random numbers.
 * @param max The maximum value (inclusive) for the random numbers.
 * @return An array of random numbers.
 */
public static int[] GenerateRandomNumbers(int length, int min, int max)
    {
        int[] numbers = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            numbers[i] = random.Next(min, max + 1);
        }

        return numbers;
    }


    public static int Test()
{
    Random random = new Random();
    return random.Next(-100, -19);
}
}
