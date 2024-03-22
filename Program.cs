// Console.Write("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 7 == 0 && a % 23 == 0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }



// Console.Write("Введите координаты точки X и Y через пробел: ");
// string[] coordinates = Console.ReadLine().Split(' ');

// int x = Convert.ToInt32(coordinates[0]);
// int y = Convert.ToInt32(coordinates[1]);

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Точка находится в квадранте I.");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Точка находится в квадранте II.");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в квадранте III.");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в квадранте IV.");
// }
// else
// {
//     Console.WriteLine("Точка находится на оси координат.");
// }


// Console.Write("Введите число из отрезка [10, 99]: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// int maxDigit;
// if (firstDigit > secondDigit)
// {
//     maxDigit = firstDigit;
// }
// else
// {
//     maxDigit = secondDigit;
// }
// Console.WriteLine(maxDigit);




// Console.Write("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 10)
// {
//     Console.WriteLine(N);
// }
// else
// {
//     while (N > 0)
//     {
//         int currentDigit = N % 10;
//         N /= 10;
//         if (N > 0)
//         {
//             Console.Write(currentDigit + ",");
//         }
//         else
//         {
//             Console.Write(currentDigit);
//         }
//     }
//     Console.WriteLine();
// }
