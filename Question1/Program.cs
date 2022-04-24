//Switch與輸入練習
try
{
    Console.WriteLine($"請輸入分數0-100");
    var Input = Console.ReadLine();
    var result = string.Empty;
    if (int.TryParse(Input, out var value))
    {
        result = ScoreGrade(value);
    }
    else result = "輸入非數字";

    Console.WriteLine(result);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message.ToString());
}

static string ScoreGrade(int score)
{
    if (score < 0 || score > 100) throw new ArgumentException("輸入範圍錯誤0-100");
    var Grade = string.Empty;
    switch (score)
    {
        case >= 90:
            Grade = "考試優秀";
            break;

        case >= 80:
            Grade = "考試良好";
            break;

        case >= 60:
            Grade = "考試及格";
            break;

        case < 60:
            Grade = "下次繼續努力";
            break;
    };

    return Grade;
}