internal class Program
{
    private static void Main(string[] args)
    {
        int number = 1;
        Console.WriteLine("Consecutive integers from 1 to 20 and squared value of each");
        do
        {
            int squaredNumber = number * number;
            Console.WriteLine($"{number}^ = {squaredNumber}");
            number++;
        } while (number <= 20);
        Console.ReadKey();
    }

}