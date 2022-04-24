ShowArrary(10, 5);

static void ShowArrary(int col, int row)
{
    for (int mul = 1; mul <= row; mul++)
    {
        for (int number = 1; number <= col; number++)
        {
            Console.Write($"* ");
        }
        Console.WriteLine();
    }
}