var DoTask = WhateShouldIDo(new DateTime(2022, 4, 24, 10, 55, 50), 33, "天氣差");
Console.WriteLine(DoTask);
DoTask = WhateShouldIDo(new DateTime(2022, 4, 25, 10, 55, 50), 31, "天氣好");
Console.WriteLine(DoTask);

static string WhateShouldIDo(DateTime Date, float TempeRature, string Weather)
{
    var Task = string.Empty;
    if (Date.DayOfWeek == DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday)
    {
        //外出
        if (TempeRature >= 30) Task = "游泳";
        else Task = "爬山";
    }
    else
    {
        //工作
        if (Weather == "天氣好") Task = "談業務";
        else Task = "上網查資料";
    }
    return Task;
}