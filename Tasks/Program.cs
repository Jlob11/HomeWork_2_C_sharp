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

int number = new Random().Next(100, 1000000);
int number = int.Parse(Console.ReadLine());
if(number > 99)
{
    Console​.​WriteLine​(​(​n / 100) % 10);
}