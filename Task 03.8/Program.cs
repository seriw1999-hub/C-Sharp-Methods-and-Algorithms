#region cut cemi
static long CutCemi(int start, int end)
{
    if (start > end)
    {
        int t = start;
        start = end;
        end = t;
    }

    long cem = 0;

    if (start % 2 != 0)
        start++;

    for (int i = start; i <= end; i += 2)
    {
        cem += i;
    }

    return cem;
}
#endregion