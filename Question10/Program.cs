User Current = new User() { Name = "1", Password = "123456" };
var TestCount = 0;

while (TestCount < 3)
{
    Console.WriteLine("請輸入帳號");
    var Account = Console.ReadLine();
    Console.WriteLine("請輸入密碼");
    var Pass = Console.ReadLine();

    TestCount++;
    if (Current.Name == Account && Current.Password == Pass)
    {
        Console.WriteLine("比對成功");
        break;
    }
    else Console.WriteLine($"比對失敗 還有{3 - TestCount}次機會");
}

public class User
{
    public string? Name { get; set; }
    public string? Password { get; set; }
}