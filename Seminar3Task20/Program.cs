//-----------------------------------------------------------------------------------------
// Задача №20
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

//----------------------------------------------------------------------------------------

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// double Distance(int x,int y)
// {
//     double distance = Math.Sqrt(x*x+y*y);
//     return distance;
// }

// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// int x1 = ReadData("Введите координату x1: ");
// int y1 = ReadData("Введите координату y1: ");
// int x2 = ReadData("Введите координату x2: ");
// int y2 = ReadData("Введите координату y2: ");
// double res = Distance((x2-x1),(y2-y1));// результат
// PrintResult("Расстояние равно " + $"{res}");// печатаем результат

//--------------------------------------------------------------------------------------

// // Вывод сообщения и вызов метода DistanceCalculation
// double Prompt(string message1, string message2)
// {
//     Console.WriteLine(message1);
//     string values = Console.ReadLine()??",";

//     values += ",";

//     Console.WriteLine(message2);
//     values += Console.ReadLine()??",";

//     string[] valuesArray = values.Split(",");
//     int xA = Convert.ToInt32(valuesArray[0]);
//     int yA = Convert.ToInt32(valuesArray[1]);
//     int xB = Convert.ToInt32(valuesArray[2]);
//     int yB = Convert.ToInt32(valuesArray[3]);

//     return DistanceCalculation(xA, yA, xB, yB);
// }

// // Расчёт расстояния
// double DistanceCalculation(int xA, int yA, int xB, int yB)
// {
//     return Math.Sqrt(Math.Pow(Math.Abs(xA - xB), 2) + Math.Pow(Math.Abs(yA - yB), 2));
// }

// Console.WriteLine(Prompt("Введите 2 числа через запятую (координаты первой точки): ", "Введите 2 числа через запятую (координаты второй точки): "));

//---------------------------------------------------------------------------------------------
//
// double findDistance(int x1,int y1,int x2,int y2)
// {
//     return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
// }

// int x1 = int.Parse(Console.ReadLine()??"0");
// int y1 = int.Parse(Console.ReadLine()??"0");
// int x2 = int.Parse(Console.ReadLine()??"0");
// int y2 = int.Parse(Console.ReadLine()??"0");

// Console.WriteLine(findDistance(x1,y1,x2,y2));

//-------------------------------------------------------------------------------------------------------

int getCoordinate(string x){
    Console.Write("Введите координату {0}: ", x);
    return Convert.ToInt32(Console.ReadLine());
}

double calcDistance(int pointX1, int pointY1, int pointX2, int pointY2){
    return Math.Sqrt(Math.Pow((pointX1 - pointX2), 2) + Math.Pow((pointY1 - pointY2), 2));
}

int pointX1 = getCoordinate("X1");
int pointY1 = getCoordinate("Y1");
int pointX2 = getCoordinate("X2");
int pointY2 = getCoordinate("Y2");

Console.WriteLine(calcDistance(pointX1, pointX2, pointY1, pointY2));
