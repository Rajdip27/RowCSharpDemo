using System.Threading.Channels;

List<int> myList = new List<int> { 1, 5, 3, 6, 8, 7, 6, 2, 4, 9 };

var data = myList.OrderBy(_ => _);
foreach (var item in data)
{
    Console.WriteLine($"{data} ','");
}

Console.WriteLine();
Console.ReadKey(true);

 
