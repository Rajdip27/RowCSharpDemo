Console.Write("Enter Your Name : ");
string name=Convert.ToString( Console.ReadLine());

Console.Write("How Old Are You :");
//int age= Convert.ToInt32( Console.ReadLine());
int age = int.Parse( Console.ReadLine());

Console.WriteLine("Your Name is :"+name);
Console.WriteLine("Your age is :"+age);
Console.ReadKey();
