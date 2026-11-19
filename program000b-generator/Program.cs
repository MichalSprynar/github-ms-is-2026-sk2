using SharedUtilities;

int[] numbers = Programs.GenerateRandomNumbers(10, -100, -20);

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}