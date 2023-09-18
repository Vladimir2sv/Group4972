// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 3, 2, 7, 13, 5, 3, 9  => [1, 3, 2, 7, 13, 5, 3, 9]

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
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

// Вычисляем факториал
int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(0, 9);
    }
    return arr;
}

int num = ReadData("Введите число: ");
int[] res = GenArr(num);
PrintArray(res);