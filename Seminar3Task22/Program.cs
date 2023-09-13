//-------------------------------------------------------------------------------------------------------
//Задача №22
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//-------------------------------------------------------------------------------------------------------

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// string BuildLine(int num,int pow)
// {
//     string res = String.Empty;
//     for (int i = 1;i<=num;i++)
//     {
//         res = res + Math.Pow(i,pow) + " ";
//     }

//     return res;
// }

// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// int Num = ReadData("Enter N");
// int pow = ReadData("Enter pow");
// Console.WriteLine(BuildLine(Num,pow));

//------------------------------------------------------------------------------------------------------------

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

string BuildLine(int n, int pow)
{
    string res = string;
    for(int i = 1; i <= n; i++)
    {
        res = res + Math.Pow(i,pow)+ " ";
    }
    return res;
}


void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine(msg);
}

int n = ReadData("Введите число");
PrintResult(BuildLine(n, 1));
PrintResult(BuildLine(n, 2));

//----------------------------------------------------------------------------------------------------------------
// Вывод сообщения и вызов метода OutputSquares
// void Prompt(string message)
// {
//     Console.WriteLine(message);
//     string values = Console.ReadLine()??",";
//     int number = Convert.ToInt32(values);

//     OutputSquares(number);
// }

// // Расчёт квадратов и составление таблицы
// void OutputSquares(int number)
// {
//     Console.Clear();

//     int currentNumber = 0;
//     int currentNumberSquare;
//     int cursor = 0;

//     while (currentNumber <= number)
//     {
//         currentNumberSquare = (int)Math.Pow(currentNumber, 2);

//         Console.SetCursorPosition(cursor, 0);
//         Console.Write(currentNumber);

//         Console.SetCursorPosition(cursor, 1);
//         Console.Write(currentNumberSquare);

//         cursor = Console.CursorLeft + 3;

//         currentNumber++;
//     }
// }

// Prompt("Введите число: ");
//------------------------------------------------------------------

// Console.WriteLine("Enter a number");
// Task22 task = new Task22(int.Parse(Console.ReadLine()??"0"));
// task.printSolution();

// class Task22
// {
//     private int n;
//     public Task22(int n)
//     {

//         this.n = n;

        
//     }


//     public void printSolution()
//     {
//     int[] array = new int[n];
//     array = Solution(this.n);
//         for(int i = 0; i < n; i++){
//             Console.Write(array[i]+", ");
//         }
//     }
//     private int[] Solution(int n)
//     {
//             int[] array = new int[n];
//             for(int i = 1;i <= n; i++)
//             {
//                 array[i-1] = i*i;
//             }

//             return array;
//     }


// }

//--------------------------------------------------------------------

//вводим данные
// int ReadData(string msg)
// {
//     System.Console.WriteLine(msg);
//     int num = int.Parse(System.Console.ReadLine() ?? "0");
//     return num;
// }

// string BuildLine(int x)
// {
//     string res= string.Empty;
//     string res2= string.Empty;
    
//     for (int i = 1; i <= x; i++)
//     {
//         res = res + i + " ";
//         res2 = res2 + Math.Pow(i , 2) + " ";
//     }

//     return res + "\n" +res2 ;
// }

// // Печатаем результат
// void PrintRezult(string msg)
// {
//     System.Console.WriteLine(msg);
// }

// int num = ReadData("Введите номер: ");

// PrintRezult(BuildLine(num));