string[] Row = { "Kazan", "Moscow", "Rome", "LA", "Ufa", "2", "897", "Pho", "0"};
var result = new string[Row.Length];
var Index = 0;
foreach (var value in Row)
{
    if (value.Length <=3)
    {
        result[Index] = value;
        Index++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, Index));