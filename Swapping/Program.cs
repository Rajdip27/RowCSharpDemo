int number1=10;
int number2=20;
int temp=0;
Console.WriteLine($"Before Number1: {number1}- number2: {number2}");
Console.WriteLine();
temp =number1;
number1=number2;
number2=temp;
Console.WriteLine();
Console.WriteLine($"After Number1: {number1}- number2: {number2}");

Console.ReadKey(true);