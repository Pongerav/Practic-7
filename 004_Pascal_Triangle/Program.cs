void FillArrayRow(int[][] array, int n)
{
    array[n][0] = 1;
    array[n][n] = 1;
    for (int i = 1; i < n; i++)
    {
        array[n][i] = array[n-1][i-1] + array[n-1][i];
    }
}
void PrintArray(int[][] array, int n, int l)
{
    for (int i = 0; i < l - n; i++) Console.Write($" ");
    for (int i = 0; i <= n; i += 1)
    {
        Console.Write(array[n][i] + " ");
    }
}

Console.WriteLine("Введите кол-во необходимых строк");
int l = int.Parse(Console.ReadLine() ?? "0");

int[][] arrayz = new int[l][];

arrayz[0] = new int[] {1};
arrayz[1] = new int[] {1,1};

PrintArray(arrayz,0,l-1);
Console.WriteLine();
PrintArray(arrayz,1,l-1);

for (int j = 2; j < l; j++)
{
    Console.WriteLine();
    arrayz[j] = new int[j+1];
    FillArrayRow(arrayz,j);
    PrintArray(arrayz,j,l-1);
}