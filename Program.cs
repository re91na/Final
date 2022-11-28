// из имеющегося массива строк формируется массив строк, длина которых меньше либо равна 3.
//Первоначальный массив вводится с клавиатуры, либо задается на старте выполнения алгоритма.

int ReadDataNumber(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string ReadDataString(string msg)
{
    Console.Write(msg);
    string userString = Console.ReadLine();
    if (userString != null)
    {
        return userString;
    }
    else
    {
        userString = ReadDataString("Введите строку заново: ");
        return userString;
    }
}

string[] FillArr(int len)
{
    string[] arr = new string[len];
    int i = 0;
    while (i < len)
    {
        arr[i] = ReadDataString("Введите новую строку массива: ");
        i++;
    }
    return arr;
}

void SortArray(string[] arr)
{
    Console.Write("[");
    int i = 0;
    while (i < arr.Length)
    {
        if (arr[i].Length <= 3)
        {
            Console.Write(arr[i]);
            i++;
            break;
        }
        else
        {
            i++;
        }
    }
    if (i < arr.Length)
    {
        while (i < arr.Length)
        {
            if (arr[i].Length <= 3)
            {
                Console.Write(", " + arr[i]);
                i++;
            }
            else
            {
                i++;
            }
        }
        Console.WriteLine("]");
    }
    else
    { Console.WriteLine("]"); }
}


int arrLen = ReadDataNumber("Укажите длину массива: ");
string[] array = FillArr(arrLen);
SortArray(array);
