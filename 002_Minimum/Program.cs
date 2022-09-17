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
int FindMin(int[,] array,int cr)
{
    int min = array[0,0];
    int imin = 0;
    int jmin = 0;
    for (int i = 0; i <= array.GetUpperBound(0); i += 1)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j += 1)
        {
           if (array[i,j] <= min)
           {
            min = array[i,j];
            imin = i;
            jmin = j;
           } 
        }
    } 
    if (cr == 0) return imin;
    else if (cr == 1) return jmin;
    else return 0;
}

Console.WriteLine("Введите количевство строк массива");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количевство столбцов массива");
int collumns = int.Parse(Console.ReadLine() ?? "0");


int[,] array = new int[rows,collumns];

FillArray(array);
PrintArray(array);
int im = FindMin(array,0);
int jm = FindMin(array,1);

for (int i = 0; i <= array.GetUpperBound(0); i += 1)
   {
        for (int j = 0; j <= array.GetUpperBound(1); j += 1)
       {
           if ( (i == im) | (j == jm) )
            {
                array[i,j] = 0;
            }
       }
   } 

Console.WriteLine();
PrintArray(array);