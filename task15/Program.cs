/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Введите цифру дня недели (1-7): ");
    int day = Convert.ToInt32(Console.ReadLine());

    if (day == 6 || day == 7) {
      Console.WriteLine("Этот день выходной.");
    } else {
      Console.WriteLine("Этот день не является выходным.");
    }
  }
}
