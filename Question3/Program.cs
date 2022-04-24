Console.WriteLine("輸入第一個數值");
var Input = Console.ReadLine();
Console.WriteLine("輸入第二個數值");
var Input2 = Console.ReadLine();
Console.WriteLine("輸入第三個數值");
var Input3 = Console.ReadLine();

if (float.TryParse(Input, out float result) &&
   float.TryParse(Input2, out float result2) &&
   float.TryParse(Input3, out float result3))
{
    var Middle = FindMiddle(result, result2, result3);
    Console.WriteLine($"Question2 中間值為：{Middle}");
    var Max = FindMax(result, result2, result3);
    Console.WriteLine($"Question3 最大值為：{Max}");
}
else Console.WriteLine("格式輸入錯誤");

static float FindMiddle(float value1, float value2, float value3)
{
    var SortArray = SortArrary(new float[3] { value1, value2, value3 });

    return SortArray[1];
}

static float FindMax(float value1, float value2, float value3)
{
    var SortArray = SortArrary(new float[3] { value1, value2, value3 });

    return SortArray[2];
}

static float[] SortArrary(float[] arr)
{
    for (int index = 1; index < arr.Length; index++)
    {
        if (arr[index - 1] > arr[index])
        {
            var temp = arr[index];
            arr[index] = arr[index - 1];
            arr[index - 1] = temp;
        }
    }
    return arr;
}