string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//for (int i = 0; i < cars.Length; i++)
//{
//    Console.WriteLine(cars[i]);
//}

Array.Sort(cars);
foreach (var item in cars)
{
    Console.WriteLine(item);
}


