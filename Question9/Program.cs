//var ResultList = Enumerable.Range(101, 100);
var ResultList = Enumerable.Range(101, 100).Where(x => IsPrimeNumber(x));
foreach (var Result in ResultList)
{
    Console.WriteLine(Result);
}

static bool IsPrimeNumber(int number)
{
    //試除法 2-該數開根號
    var result = true;
    for (int divisor = 2; divisor < Math.Sqrt(number); divisor++)
    {
        if (number % divisor == 0) { result = false; break; }
    }

    return result;
}