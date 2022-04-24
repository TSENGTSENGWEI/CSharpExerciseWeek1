var result = 0;
for (int Num = 1; Num <= 10; Num++)
{
    result = result + Num.Factorial();
}

Console.WriteLine($"Question6 結果：{result}");

Console.WriteLine($"Question8 結果：{10.Factorial()}");

public static class ExtensionMethod
{
    public static int Factorial(this int num)
    {
        if (num == 0 || num == 1) return 1;
        else return Factorial(num - 1) * num;
    }
}