// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0

//Заполняем одномерный массив
int[] GenArray(int length, int lowBorder, int highBorder)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder+1);
    }

    return array;
}

// Печатаем результат
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Считаем сумму элементов массива, стоящих на нечетных позициях
int SumNegPos(int[] arr)
{
    int sum = 0;
    
    for (int i = 1; i < arr.Length; i=i+2)
    {
        sum = sum + arr[i];
    }

    return sum;
}    

// Выводим сообщение на консоль
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArray(7, 0, 100);
PrintArray(array);
int sum = SumNegPos(array);
PrintResult($"Сумма элементов, стоящих на нечётных позициях = {sum}");