/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

using System;
class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
	Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = (number % 100) / 10;
    Console.WriteLine("Вторая цифра данного числа: " + result);
  }
}
