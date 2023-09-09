// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Console.WriteLine("Способ 1");

// Console.WriteLine("Чтобы выйти введите -1");
// Console.Write("Введите число: ");
// string stringNum = Console.ReadLine()??"0";
// int num = Convert.ToInt32(stringNum);

// if (num == -1) return;
// if (stringNum.Length != 3)
//     Console.WriteLine("Число не трёхзначное");
// else
// {
//     Console.WriteLine((num / 100) * 10 + (num % 10));
// }

// // Console.WriteLine(stringNum.Length != 3 ? "Число не трёхзначное" : (num / 100) * 10 + (num % 10));

// Console.WriteLine();


Console.WriteLine("Способ 2");
// System.Random numGen = new Random();
    
//     int a = numGen.Next(100,1000);
//     Console.WriteLine(a);
//     return (a/100*10+a%10);


Console.WriteLine("Способ 3");
// void var1()
// {
//     Console.WriteLine("Способ 1");
//     System.Random numberGenerator = new System.Random();
//     int number = numberGenerator.Next(100, 1000);

//     Console.WriteLine(number);

//     char[] digitChar = number.ToString().ToCharArray();
//     Console.WriteLine(digitChar[0].ToString()+digitChar[2].ToString());
// }

// var1();

Console.WriteLine("Способ 4");
System.Random numGen = new Random();
    
    int a = numGen.Next(100,1000);
    Console.WriteLine(a);
    return (a/100*10+a%10);



// using System;

// int getRandomNum(int min, int max)
// {
//     int randomNum = new Random().Next(min, max);
//     return randomNum;
// }

// int num = getRandomNum(99, 1000);

// int firstDigit = num / 100;
// int lastDigit = num % 10;

// Console.WriteLine(num);
// int resNumber = firstDigit*10 + lastDigit;
// Console.WriteLine(resNumber);


// Console.Write("Введите число: ");
// string stringNum = Console.ReadLine()??"0";
// int num = Convert.ToInt32(stringNum);

// if (stringNum.Length != 3)
//     Console.WriteLine("Число не трёхзначное");
// else
// {
//     Console.WriteLine((num / 100) % 10);
// }