Console.Write("Enter the number of rows: ");
int numRows = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int numColumns = int.Parse(Console.ReadLine());

int[,] twoDimArray = new int[numRows, numColumns];

Console.WriteLine("Enter the elements of the 2D array:");

// Input values into the 2D array
for (int i = 0; i < numRows; i++)
{
    for (int j = 0; j < numColumns; j++)
    {
        Console.Write($"Enter element at row {i}, column {j}: ");
        twoDimArray[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("2D Array Contents:");

// Display the contents of the 2D array
for (int i = 0; i < numRows; i++)
{
    for (int j = 0; j < numColumns; j++)
    {
        Console.Write(twoDimArray[i, j] + " ");
    }
    Console.WriteLine(); // Move to the next row
}
