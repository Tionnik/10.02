// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int a = 0;
while (a<(N-1))
{
    a=a+2;
    Console.Write( a + ", ");
}