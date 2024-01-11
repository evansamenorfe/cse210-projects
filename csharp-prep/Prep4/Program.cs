using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        
        
        int numb = -1;
        while (numb != 0)
        {

        

            Console.Write("Enter a number, Type zero '0' to stop: ");
            string inputs = Console.ReadLine();
            numb = int.Parse(inputs);
            

            //Console.WriteLine(numbers.Count);

            if (numb != 0)
            {
                numbers.Add(numb);
            }

            //Console.WriteLine(numbers);
        }

        //Sum

        int sum = 0;
        foreach (int digit in numbers)
        {
            sum += digit;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Maximum

        int max = numbers[0];
        foreach (int digit in numbers)
        {
            if (digit > max)
            {
                max = digit;
            }
        }

        Console.WriteLine($"The maximum value is: {max}");
    }
}