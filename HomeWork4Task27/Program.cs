// // №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16
// //-----------------------------------------------------------------------------------------------------------------


// // Считываем два числа
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// //Печатаем результат
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// //возводим в степень
// long MyPow(int numA, int numB)
// {
//     long res = 1;
//     while (numB > 0)
//     {
//         res = res * numA;
//         numB = numB - 1;
//     }
//     return res;
// }

// int numA = ReadData("Введите число A: ");// Вводим число А
// int numB = ReadData("Введите число B: ");// Вводим Число В
// Console.WriteLine(MyPow(numA, numB));// вывод результата







// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Считываем число
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Считаем сумму цифр в чиле
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}

int num = ReadData("Введите число: ");// Вводим число
Console.WriteLine(SumDigit(num));// вывод  сумму чисел