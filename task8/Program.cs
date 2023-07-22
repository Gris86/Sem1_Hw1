// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int calc=2;
while(calc<=number){
    Console.Write($"{calc} ");
    calc+=2;
}
