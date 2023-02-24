// Задача 19

// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// System.Console.WriteLine("Введите пятизначное число: ");
//  string number = Console.ReadLine();
//  int first = 0;
// int end = number.Length - 1;

//     if (end == 4)
//      {
//          while (first < end && Char.IsDigit(number[first]) && Char.IsDigit(number[end]))
//     {
//         if (number[first] == number[end])
//          {
//              first++;
//              end = end - 1;
//         }
//             else
//         {
//         System.Console.WriteLine($"{number[first]} != {number[end]} : число {number} не палиндром");
//         first = 5;
//          }
//         }
//          if (first == 2) 
//          System.Console.WriteLine($"число {number} - палиндром");
//          if (first != 2 && first != 5) 
//          System.Console.WriteLine($"{number} - не верный ввод");
//         }
//             else
//              System.Console.WriteLine("Значение не пятизначное");


// Задача 21

// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// int a1 = ReadInt("Введите координату X первой точки: "); // Задает первая точка координат
// int b1 = ReadInt("Введите координату Y первой точки: "); // Задает первая точка координат
// int c1 = ReadInt("Введите координату Z первой точки: "); // Задает первая точка координат
// int a2 = ReadInt("Введите координату X второй точки: "); // Задает вторая точка координат
// int b2 = ReadInt("Введите координату Y второй точки: "); // Задает вторая точка координат
// int c2 = ReadInt("Введите координату Z второй точки: "); // Задает вторая точка координат

// int A = a2 - a1;
// int B = b2 - b1;
// int C = c1 - c2;

// double length = Math.Sqrt(A * A + B * B + C * C); // Пришлось загуглить
// System.Console.WriteLine($"Длинна отрезка {length}");


// int ReadInt(string message)  // Здесь создаю функцию, это как то получилось спасибо справочнику
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int num = ReadInt("Введите число N: ");

for (int j = 1; j <= num; j++)
{ 
    System.Console.WriteLine($"{j*j*j} ");
}

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}