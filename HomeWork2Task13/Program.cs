//--------------------------------------------------------------------------------------------------------------------
// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
//----------------------------------------------------------------------------------------------------------------------

int DesirdNumber(string msg)
{

Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = DesirdNumber("Введите число");

int thirdNumber(int number) // третья цифра номер пишем сюда
{
while (number > 999)
{
number /= 10;
}
return number % 10;
}

bool check(int number) // смотрим число трехзначное или нет
{
if (number < 100)
return false; // если число не трехзначное возвращаем ложь
else return true;// если трехзначное то выводим третью цифру
}

if (check(number) != true)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра числа {number} является {thirdNumber(number)}");