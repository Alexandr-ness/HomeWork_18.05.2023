// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число 1 - ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2 - ");
// int b = Convert.ToInt32(Console.ReadLine());
// int Sum = a;
// {
    
//     for (int i = 1; i < b; i++)
//     {
//         Sum *=a;
//     }
           
// }
// Console.WriteLine("A в степени B равно: " + Sum);









// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12




// Console.Write("Введите число - ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// {

// while (a > 0)
// {
    
//     int b = a % 10;
//     a = a / 10;
//     result = b + result;

// }
// }
// Console.WriteLine("Сумма чисел: " + result);





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// Console.Write("Введите длинну массива: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[number];
// for (int i = 0; i < number; i++)
// {
//     array[i] = new Random().Next(number + 1);
//     Console.Write(array[i] + "; ");
// }

Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());;
int[] array = new int[size];
Random myRandom = new Random();
Console.WriteLine("Вывод исходного мвссива ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 20);
    Console.Write("{0}; ", array[i]);
}

Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
Array.Sort(array);
 
foreach (var i in array)
{
    Console.Write("{0}; ", i);
}



