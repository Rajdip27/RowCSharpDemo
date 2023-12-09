using System.Collections.Immutable;
using System.Threading.Channels;

//int[] arr = { 1,7, 2, 4, 3, 6, 5, 8 };
//var data = arr.OrderBy(_=>_);
//Console.WriteLine(data);

////foreach (var item in data)
////{
////    Console.WriteLine(item);
////}


int[] arr = { 1, 7, 2, 4, 3, 6, 5, 8 };
var data = arr.OrderBy(_=>_);
//var data = arr.

foreach (var number in data)
{
    Console.Write(number + ",");
}

Console.WriteLine();
Console.ReadKey(true);
