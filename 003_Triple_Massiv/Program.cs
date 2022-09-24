void FillArray(int[,,] array)
{
    for (int i = 0; i <= array.GetUpperBound(0); i += 1)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j += 1)
        {
            for (int n = 0; n <= array.GetUpperBound(2); n += 1)
            {
                array[i,j,n] = new Random().Next(10,100);
            }
        }
    }
}
void PrintArray(int[,,] array)
{
   for (int i = 0; i <= array.GetUpperBound(1); i += 1)
    {  
        Console.WriteLine();
        for (int j = 0; j <= array.GetUpperBound(0); j += 1)
        {
            Console.Write($"\t");
            for (int n = 0; n <= array.GetUpperBound(2); n++)
            {
                Console.Write(array[j,i,n] + " ");
            }
        }
    } 
}

Console.WriteLine("Введите кол-во двумерных массивов");
int countmas = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите кол-во строк в двумерном массиве");
int countrows = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите кол-во столбцов в двумерном массиве");
int countcollumns = int.Parse(Console.ReadLine() ?? "0");

int[,,] array = new int[countmas , countrows , countcollumns];

FillArray(array);
PrintArray(array);