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

void ShowArray(int iSize, string[] array)
{
    string s = "";
    Console.Write("Новый массив: [");
    if (iSize > 0)
    {
        for (int i = 0; i < iSize; i++)
        {
            s += $"{array[i]}, ";
        }
        s = s.Substring(0, s.Length-2);
    }
    Console.Write(s+"]");
}

Console.WriteLine("Сколько строк вы хотите задать?");
bool temp = int.TryParse(Console.ReadLine(), out int iCount);
if (!temp)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

// Заполняем массив
string[] arrayFirst = new string[iCount];
FillArray(iCount, arrayFirst);

// Создаем новый массив на максимальную длину
string[] arraySecond = new string[iCount];
// Заполняем строками до 3х символов и получаем его длину
int iCount2 = FillArrayLength3(iCount, arrayFirst, ref arraySecond);

// Выводим новый массив
// Можно iCount2 и не передавать, а получать в самой функции,
// но смысл это делать, если уже имеется данное значение
ShowArray(iCount2, arraySecond);

// Чтобы увидеть вывод и не закрывалась консоль
Console.ReadLine();