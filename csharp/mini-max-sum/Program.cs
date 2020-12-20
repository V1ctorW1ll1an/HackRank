using System;

namespace mini_max_sum
{
    class Program
    {
        static void miniMaxSum(int[] arr) {
          long max = arr[0];
          long min = arr[0];
          long maxi, mini;
          long sum = 0;

          foreach (int item in arr)
          {
              if(item < min) min = item;
              if(item > max) max = item;
              sum += item;
          }

          maxi = sum - min;
          mini = sum - max;
          Console.WriteLine(mini + " " + maxi);
        }

        static void Main(string[] args) {
          int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
          miniMaxSum(arr);
        }
    }
}
