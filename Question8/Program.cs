var ResultList = Enumerable.Range(100, 900).Where(x => IsNarcissisticNumeber(x));

foreach (var item in ResultList)
{
    Console.WriteLine(item);
}

static bool IsNarcissisticNumeber(int numeber)
{
    var result = 0d;
    var temp = numeber;
    while (temp > 0)
    {
        result = result + Math.Pow(temp % 10, numeber.GetDigit());
        temp = temp / 10;
    }

    if (result == numeber) return true;
    else return false;
}

public static class Extension
{
    public static double GetDigit(this int num)
    {
        var digit = 0;
        while (num > 0)
        {
            num = num / 10;
            digit++;
        }
        return digit;
    }
}