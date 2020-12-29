using System;

class Program {
    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
      float positives = 0;
      float negatives = 0;
      float zeros = 0;
      
      // percorres o array e pegar os dados positivos, negativos e zeros
      for (int i = 0; i < arr.Length; i++)
      {
        if(arr[i] < 0){
          negatives++;
        }
        else if(arr[i] > 0){
          positives++;
        }
        else{
          zeros++;
        }
      }

      String nPositives = String.Format("{0:f6}", (positives / arr.Length));
      String nNegatives = String.Format("{0:f6}", (negatives / arr.Length));
      String nZeros = String.Format("{0:f6}", (zeros / arr.Length));

      Console.WriteLine(nPositives + "\n" + nNegatives + "\n" + nZeros );
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}

