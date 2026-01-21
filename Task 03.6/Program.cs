#region 3 5e bolunme

static void Bolunme(int eded)
{
    if (eded % 3 == 0 && eded % 5 == 0)
        Console.WriteLine("Hər ikisinə bölünür");
    else if (eded % 3 == 0)
        Console.WriteLine("Yalnız 3-ə bölünür");
    else if (eded % 5 == 0)
        Console.WriteLine("Yalnız 5-ə bölünür");
    else
        Console.WriteLine(eded);
}

#endregion