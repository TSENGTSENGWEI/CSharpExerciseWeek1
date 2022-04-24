var NumberList = Enumerable.Range(10000, 90000).Where(x => IsPalindromic(x));

foreach (var PalindromicNum in NumberList)
{
    Console.WriteLine(PalindromicNum);
}

static bool IsPalindromic(int number)
{
    if (number < 0) return false;

    var temp = number;
    var PalindromicNum = 0;
    var Modulo = 0;
    while (temp > 0)
    {
        Modulo = temp % 10;
        PalindromicNum = PalindromicNum * 10 + Modulo;
        temp = temp / 10;
    }

    if (PalindromicNum == number) return true;
    else return false;
}