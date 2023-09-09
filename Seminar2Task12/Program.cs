// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе 
// число кратным первому.
//  Если второе число некратно первому, то программа выводит остаток от деления.



Console.WriteLine("1");
// Console.WriteLine("Введите 1-е число: ");
// int firstNum=int.Parse(Console.ReadLine()??"0");

// Console.WriteLine("Введите 2-е число: ");
// int secondNum=int.Parse(Console.ReadLine()??"0");

// if (secondNum%firstNum==0)
// {
//     Console.WriteLine(secondNum+" кратно "+firstNum);
// }
// else
// {
//     Console.WriteLine("Второе не кратно первому. Остаток от деления: "+secondNum%firstNum);
// }


Console.WriteLine("2");
// int first = int.Parse(Console.ReadLine() ?? "0");
// int second = int.Parse(Console.ReadLine() ?? "0");
// String result = (first%second == 0) ? "Второе кратно первому" : "Второе не кратно первому";
// System.Console.WriteLine(result + ". Остаток от деления: " + first%second);

Console.WriteLine("3");

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num2%num1==0?"Второе число кратно первому":"Остаток от деления: " + (num2%num1));