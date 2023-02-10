//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a<0)
    a=-a;
int b = a%2;   
if (b==1)
    Console.WriteLine("-> Нет");
else
    Console.WriteLine("-> Да");