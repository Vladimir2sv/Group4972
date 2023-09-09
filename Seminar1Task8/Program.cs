// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;// Складываем все в коробку

if (num % 2 != 0)
{
    num = num - 1;// Делаем число четным
}

while (count < num)
{
    count = count + 2; // Увеличиваем счетчик
    Console.Write(count + " ");
}