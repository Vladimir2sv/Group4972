﻿//----------------------------------------------------------------------------------------------------------------------------------------
// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
//---------------------------------------------------------------------------------------------------------------------------------------

int Num(string msg)
{

Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Num("Введите число");
string notDay = "Это не день недели";
string check(int number)
{
if (number >= 6 && number < 8) notDay = "Это выходной";
if (number >= 1 && number < 7) notDay = "Это будний день";
return notDay;
}
Console.WriteLine(check(number));