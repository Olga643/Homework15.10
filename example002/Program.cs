// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число");
string numberAstr = Console.ReadLine() ??""; 
int numberA = int.Parse(numberAstr);

Console.WriteLine("Введите второе число");
string numberBstr = Console.ReadLine() ??""; 
int numberB = int.Parse(numberBstr);

Console.WriteLine("Введите третье число");
string numberCstr = Console.ReadLine() ??""; 
int numberC = int.Parse(numberCstr);
int max = numberA;
if(numberB > max )  max = numberB;
if(numberC > max )  max = numberC;
Console.WriteLine($"Максимальное число : {max}");