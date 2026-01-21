#region ucbucagin novu
static string UcbucaqNovu(int a, int b, int c)
{
    if (a <= 0 || b <= 0 || c <= 0)
        return "Yanlış tərəflər";

    if (a + b <= c || a + c <= b || b + c <= a)
        return "Üçbucaq deyil";

    if (a == b && b == c)
        return "Bərabərtərəfli";
    else if (a == b || a == c || b == c)
        return "Bərabəryanlı";
    else
        return "Müxtəliftərəfli";
}

#endregion