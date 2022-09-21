// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = new Random().Next(100, 1000);
// int num1 = number / 100;
// int num2 = (number /10) % 10;
// int num3 = number %10;

// Console.WriteLine(number);
// Console.WriteLine(num2);


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int number = new Random().Next(1, 1000000);
// if (number < 100)
// 	Console.WriteLine("третьей цифры нет");
// else
// {
//     Console.WriteLine(number);
//     while(number >= 1000)
//     {
//         number = number / 10;
//     }
    
//     Console.WriteLine(number % 10);
// }

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int day = new Random().Next(1,8);
if ((day == 6) || (day == 7))
{
    Console.WriteLine(day);
    Console.WriteLine("да");
}
else 
{
   Console.WriteLine(day); 
   Console.WriteLine("нет"); 
}