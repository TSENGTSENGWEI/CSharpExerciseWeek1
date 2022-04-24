var TaskList = new List<string>();

TaskList.Add("上午閱讀教材，學習理論");
TaskList.Add("下午上教程式設計");

foreach (var item in TaskList)
{
    Console.WriteLine($"{item} 是否通過？");
    if (IsPass(Console.ReadLine())) Console.WriteLine("通過");
    else Console.WriteLine("不通過");
}

static bool IsPass(string? input)
{
    if (input == null) return false;
    if (input.ToUpper() == "Y") return true;
    else return false;
}