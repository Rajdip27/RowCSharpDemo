//int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        Console.WriteLine(numbers[i, j]);
//    }
//}

//int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}
int[] myNumbers = { 5, 1, 8, 9 };
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
    Console.WriteLine(i);
}