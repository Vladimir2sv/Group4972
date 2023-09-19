int[] GenArray(int length, int lowBorder, int highBorder)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write($"[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
    System.Console.WriteLine();
}

void InversArray(int [] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        arr[i]*=-1;
    }
}

int[] array=GenArray(12,-9,9);
PrintArray(array);//печать
InversArray(array);// инвертируеи
PrintArray(array);// Снова распечатываем

//---------------------------------------------------------------

int[] randomArray(int len, int lowBorder, int highBorder){
    int[] rA = new int[len];
    for(int i = 0; i < len; i++)
    {
        rA[i] = new Random().Next(lowBorder, highBorder+1);
    }
    return rA;
}

void outPutArray(int[] arr){
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine( arr[arr.Length - 1] +"]");
}

void AntiArray(int[] arr)
{
    for(int i = 0; i <arr.Length; i++)
    {
        arr[i]*=-1;
    }
}

int[] array = randomArray(12, -10, 10);
outPutArray(array);
AntiArray(array);
outPutArray(array);

//-----------------------------------------------------------------------


//------------------------------------------------------------------------------------------------------------------
//                                                  Задача 32
//   Напишите программу замену элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
int[] array = GenArray(12, -9, 9);
PrintArray(array);
InvertArr(array);
PrintArray(array);
//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Генерация массива
int[] GenArray(int len, int lowerBorder, int highBorder)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++) { array[i] = rnd.Next(lowerBorder, highBorder + 1); }
    return array;
}

// Вывод массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}

//Инверсия
void InvertArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) { arr[i] *= -1; }
}