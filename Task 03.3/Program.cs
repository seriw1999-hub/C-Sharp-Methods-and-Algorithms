#region ArtanArdicilliq
using System;
class Program
{
    static void Main()
    {
        int a = 2;
        int b = 5;
        int c = 8;

        if (ArtanArdicilliq(a, b, c))
        {
            Console.WriteLine("ededleri artan ardicilliqla sıralanıb.");
        }
        else
        {
            Console.WriteLine("ededleri artan ardıcıllıqla deyil.");
        }
    }

    static bool ArtanArdicilliq(int x, int y, int z)
    {
        if (x < y && y < z)
        {
            return true;
        }
        return false;
    }
}

#endregion