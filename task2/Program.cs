// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число: ");
int first=int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second=int.Parse(Console.ReadLine()!);
if(first>second) Console.WriteLine($"Первое число {first} больше второго числа {second}.");
else if(first<second) Console.WriteLine($"Второе число {second} больше первого числа {first}.");
else if(first==second) Console.WriteLine($"Числа {second} и {first} равны.");