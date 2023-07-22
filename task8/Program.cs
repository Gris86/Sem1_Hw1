// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int calc=1;
while(calc<=number){
    if(calc%2==0) Console.Write($"{calc} ");
    calc++;
}
