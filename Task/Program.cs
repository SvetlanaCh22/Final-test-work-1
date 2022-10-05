void FillArray(int iCount, string[] array)
{
    for (int i = 0; i  < iCount; i++)
    {
        Console.WriteLine($"Введите строку {i+1}: ");
        array[i] = Console.ReadLine() ?? string.Empty;
    }
}


int FillArrayLength3(int iCount, string[] array, ref string[] array2)
{
    int n = 0;
    for (int i = 0; i  < iCount; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[n] = array[i];
            n++;
        }
    }
    Array.Resize(ref array2, n);
    return n;
}
