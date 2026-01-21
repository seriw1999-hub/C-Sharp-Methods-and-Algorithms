#region TekveCutSaymaq
using System;

class Program
{
    static void Main()
    {
        int[] ededler = { 7, 65, 54, 33, 222, 1, 3333, 5, 6, 44, 101, 90 };
        TekveCutSay(ededler);
    }

    static void TekveCutSay(int[] arr)
    {
        int tek = 0;
        int cut = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                cut++;
            }
            else
            {
                tek++;
            }
        }

        Console.WriteLine("Tek ededlerin sayi: " + tek);
        Console.WriteLine("Cut ededlerin sayi: " + cut);
    }
}
#endregion