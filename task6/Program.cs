﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if(number%2==0) Console.WriteLine($"Число {number} четное.");
else Console.WriteLine($"Число {number} нечетное.");
