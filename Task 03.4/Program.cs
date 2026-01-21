#region tersine cevir

static void TersSozYaz(string soz)
{
    if (soz == null)
    {
        Console.WriteLine("Boş dəyər");
        return;
    }

    string ters = "";

    for (int i = soz.Length - 1; i >= 0; i--)
    {
        ters += soz[i];
    }

    Console.WriteLine(ters);
}
#endregion