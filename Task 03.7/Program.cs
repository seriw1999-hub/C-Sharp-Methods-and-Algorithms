#region boyuk reqemlerinin cemi
static void BoyukReqemCemi(int a, int b)
{
    int cem1 = ReqemCemi(a);
    int cem2 = ReqemCemi(b);

    if (cem1 > cem2)
        Console.WriteLine(a);
    else if (cem2 > cem1)
        Console.WriteLine(b);
    else
        Console.WriteLine("Cemler beraberdir");
}

#endregion