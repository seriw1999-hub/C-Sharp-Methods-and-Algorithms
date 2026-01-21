#region reqem cemi
static int ReqemCemi(int eded)
{
    if (eded < 0)
        eded = -eded;

    int cem = 0;

    while (eded > 0)
    {
        cem += eded % 10;
        eded /= 10;
    }

    return cem;
}
int eded;
bool ok = int.TryParse(Console.ReadLine(), out eded);

if (ok)
    Console.WriteLine(ReqemCemi(eded));
else
    Console.WriteLine("Ədəd daxil edin");

#endregion