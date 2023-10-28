// Задача 69
// Напишите программу, которая
// принимает на вход два числа A и B 
// и возводит число A в целую степень B с помощю рекурсии
// A = 3, B = 5 -> 243
// A = 2, B = 3 -> 8

int PowRecursive(int a, int b) // (3,5) (3,4) (3,3) (3,2) (3,1) (3,0)
{
    if(b == 0) return 1; 
    return a * PowRecursive(a, b-1); // (3,5) (3,4) (3,3) (3,2) (3,1)
}


Console.WriteLine("Введите первое натуральное число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int numberB = Convert.ToInt32(Console.ReadLine());

int res = PowRecursive(numberA, numberB); // Присваиваем результат РЕКУРСИВНОГО Метода переменной
System.Console.WriteLine($"{numberA} в степени {numberB} -> {res}"); // и выводим в Консоль