//using System.Threading.Channels;

//for (int i = 0; i < 5; i++)
//{

//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//Console.ReadKey(true);

//Console.Write("Enter Your Last Value : ");
//double num = Convert.ToDouble(Console.ReadLine());

//double result = 0;

//for (int i = 0; i < num; i++)
//{
//    if (i % 2 != 0)
//    {
//        result += i;
//    }
//}
//Console.Write($"The Ans is {result}");

//Console.WriteLine("Enter the radius (R):");
//double radius = double.Parse(Console.ReadLine());

//// Calculate the area using the formula A = π * R^2
//double area = Math.PI * Math.Pow(radius, 2);

//// Print the result with four decimal places
//Console.WriteLine("A=" + area.ToString("F4"));

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 5; j >=i; j--)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine();
//}

//Console.ReadKey();


string myString = "Hello, World!";
bool startsWithHello = myString.StartsWith("Hello");
bool endsWithWorld = myString.EndsWith("World!");
Console.WriteLine("Starts with 'Hello': " + startsWithHello);
Console.WriteLine("Ends with 'World!': " + endsWithWorld);

