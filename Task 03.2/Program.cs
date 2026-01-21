#region palindrom
using System;

class Program
{
    static void Main()
    {
        Console.Write("Soz daxil edin: ");
        string soz = Console.ReadLine();

        if (Palindromlu(soz))
        {
            Console.WriteLine("Daxil etdiyiniz soz palindromdur.");
        }
        else
        {
            Console.WriteLine("Daxil etdiyiniz soz palindrom deyil.");
        }
    }
    static bool Palindromlu(string soz)
    {
        int sol = 0;
        int sag = soz.Length - 1;

        while (sol < sag)
        {
            if (soz[sol] != soz[sag])
            {
                return false;
            }
            sol++;
            sag--;
        }

        return true;
    }
}

#endregion