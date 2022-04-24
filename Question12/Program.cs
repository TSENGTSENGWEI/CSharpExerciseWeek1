ShowMulList(9);

static void ShowMulList(int Level)
{
    for (int mul = 1; mul <= Level; mul++)
    {
        for (int number = 1; number <= Level; number++)
        {
            Console.WriteLine($"{mul:d}X{number:d}={mul * number,2:d}");
        }
        Console.WriteLine("------------------------");
    }
}