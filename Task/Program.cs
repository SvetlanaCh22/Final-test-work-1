void FillArray(int iCount, string[] array)
{
    for (int i = 0; i  < iCount; i++)
    {
        Console.WriteLine($"Введите строку {i+1}: ");
        array[i] = Console.ReadLine() ?? string.Empty;
    }
}

