/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a number:");
    int number = Convert.ToInt32(Console.ReadLine());

    int digits = 0;
    int temp = number;

    while (temp != 0) {
      digits++;
      temp /= 10;
    }

    if (digits < 3) {
      Console.WriteLine("There is no third digit.");
    } else {
      int result = (number / (int)Math.Pow(10, digits - 3)) % 10;
      Console.WriteLine($"The third digit of the given number is: {result}");
    }
  }
}
