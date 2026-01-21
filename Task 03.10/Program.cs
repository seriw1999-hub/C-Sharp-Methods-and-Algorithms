#region login

static void Login()
{
    string correctUser = "admin";
    string correctPass = "1234";

    for (int i = 1; i <= 3; i++)
    {
        Console.Write("Username: ");
        string u = Console.ReadLine();

        Console.Write("Password: ");
        string p = Console.ReadLine();

        if (u == correctUser && p == correctPass)
        {
            Console.WriteLine("Uğurla daxil oldunuz");
            return;
        }
        else
        {
            Console.WriteLine("Yanlış məlumat");
        }
    }
}

#endregion