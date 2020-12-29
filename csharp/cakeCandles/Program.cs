using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static int birthdayCakeCandles(List<int> candles){
        int max = candles.Max();
        int cont = 0;
        foreach (int item in candles)
        {
            if(item == max) cont++;
        }
        return cont;
    }

    public static void Main(string[] args)
    {
        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = birthdayCakeCandles(candles);

        Console.WriteLine(result);
    }
}
