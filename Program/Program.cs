void Print(string[] arr)
{
    int size = arr.Length;
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write($"[{arr[i]}]  ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

string[] arrRead()
{
    Console.Write("Введите количество строковых значений в массиве:\t");
    int n = int.Parse(Console.ReadLine()!);
    string[] arr = new string[n];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива:\t");
        arr[i] = Console.ReadLine()!;
    }

    return arr;


}

string[] NewArr(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    } 
    string[] arrnew = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrnew[j] = arr[i];
            j++;
        }
    }
    return arrnew;
}


string[] myArray = arrRead();
string[] FinalArr = NewArr(myArray);

Console.WriteLine();
Console.Write("Исходный массив: ");
Print(myArray);
Console.Write("Массив из строк менее или равными 3 символам: ");
Print(FinalArr);



