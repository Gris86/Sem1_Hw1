// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int first=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int second=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int third=int.Parse(Console.ReadLine()!);
int max=first;
if(second > max) max = second;
if(third > max)  max = third;
if(max==second && max==third) {
     Console.WriteLine($"Числа {first}, {second} и {third} равны.");}
else if(max!=second || max!=third) {
Console.WriteLine($"Из чисел {first}, {second} и {third} максимальное {max}.");}
