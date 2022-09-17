void FillArray(int[,] array)
{
    for (int i = 0; i <= array.GetUpperBound(0); i += 1)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j += 1)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}
void PrintArray(int[,] array)
{
   for (int i = 0; i <= array.GetUpperBound(0); i += 1)
    {
        Console.WriteLine();
        for (int j = 0; j <= array.GetUpperBound(1); j += 1)
        {
            Console.Write(array[i,j] + " ");
        }
    } 
}
void MultiplyArrays(int[,] array, int[,] collection)
{
    for (int i = 0; i <= array.GetUpperBound(0); i += 1)
    {
        Console.WriteLine();
        for (int j = 0; j <= array.GetUpperBound(1); j += 1)
        {
            Console.Write((array[i,j]*collection[i,j]) + " ");
        }
    } 
}

Console.WriteLine("Введите количевство строк массива");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количевство столбцов массива");
int collumns = int.Parse(Console.ReadLine() ?? "0");


int[,] array = new int[rows,collumns];
int[,] collection = new int[rows,collumns];

Console.ForegroundColor = ConsoleColor.Blue;
FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;
FillArray(collection);
PrintArray(collection);
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Magenta;
MultiplyArrays(array,collection);
Console.ResetColor();