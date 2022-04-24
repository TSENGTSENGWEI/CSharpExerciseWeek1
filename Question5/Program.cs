var result = Enumerable.Range(1, 100).Where(x => x % 3 == 0 && x % 5 != 0);

var ShowWithFive = string.Empty;
var count = 0;
foreach (var item in result)
{
    ShowWithFive = ShowWithFive + $"{item,3}  "; //{索引,對齊值:格式字串}
    count++;

    if (count == 5)
    {
        Console.WriteLine(ShowWithFive);
        ShowWithFive = string.Empty;
        count = 0;
    }
}