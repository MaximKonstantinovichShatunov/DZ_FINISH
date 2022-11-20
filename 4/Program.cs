// Задача 4: Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите число А ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число C ");
int C = int.Parse(Console.ReadLine());
int maxi = A;

while (B > maxi)
 
    maxi = B;
if (C > maxi)
    maxi = C;
Console.Write( "max = ");    
Console.WriteLine(maxi);