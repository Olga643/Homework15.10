//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine() ??""; 
int N = int.Parse(numberStr);

int i = 0;
while(i < (N - 1))
{
    i += 2;
    Console.WriteLine(i);
}
