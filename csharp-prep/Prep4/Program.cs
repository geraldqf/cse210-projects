using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    {
        int number = 1;
        string getNumber;
        List<int> numbers = new List<int>();
        int sum = 0;
        int largest = 0;
        int aux = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (number != 0)
        {
            
            Console.Write("Enter number: ");
            getNumber = Console.ReadLine();
            number = int.Parse(getNumber);
            numbers.Add(number);
            sum += number;
            
        }

        float average = sum / (numbers.Count - 1);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");

        for (int i = 1; i <= (numbers.Count - 1) ; i++)
        {
            for (int j = (numbers.Count - 1); j >= i ; j--)
            {
                if (numbers[j-1] > numbers[j])
                {
                    aux = numbers[j-1];
                    numbers[j-1] = numbers[i];
                    numbers[i] = aux;
                }
            }

        }
        largest = numbers[numbers.Count-1];
        Console.WriteLine($"The largest number is: {largest}");
    }
}