// Задача №5
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает 
// все целые числа в промежутке от -N до N.

// 1
// Console.WriteLine("Введите число:");
// int numPositive = int.Parse(Console.ReadLine()??"0");
// int numNegative = -1 * numPositive;

// for (int i = numNegative; i < numPositive; i++)
// {
//     Console.Write($"{i}, ");
// }
// Console.WriteLine($"{numPositive}.");

// 2
// Console.WriteLine("Enter number");
//     int num = int.Parse(Console.ReadLine());

//     for(int i = num * -1; i <= num; i++){
// 	Console.WriteLine(i);
//     }

// 3 Александр
// int a = int.Parse(Console.ReadLine());
// if (a < 0) a = -a;
// for(int i = -a; i <= a; i++){
//     Console.Write(i);
//     Console.Write(" ");
// }

// 4
// System.Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// for(int i = N * -1; i <= N; i++)
// {
// 	Console.WriteLine(i);
// }

// 5
// Console.WriteLine("Enter number);
// int num = int.Parse(Console.ReadLine());

// for(i = num * -1; i >= num; i++){
// 	Console.WriteLine(i);
// }

// 6 Иван
// int N = int.Parse(Console.ReadLine()??"0");
// int minusN = -N;
// for(int i = -N; i <= N; i++)
// {
//     Console.Write(i.ToString()+ " ");
// }

//7 Анна
int NumN = int.Parse(Console.ReadLine()??"0");
int evNumN = (-1)*NumN;

while (evNumN < NumN)
{
   Console.Write (evNumN + ", ");
   evNumN++;
}
  Console.WriteLine (NumN);