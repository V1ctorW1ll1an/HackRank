using System;
class Solution
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
            Console.WriteLine(new String('#', i + 1).PadLeft(N, ' '));
    }
}
