﻿// Задача 67
// Напишите программу, которая
// будет принимать число и 
// возвращать сумму его цифр
// 453 -> 12
// 45 -> 9

int Factorial(int n)
{
    if(n == 1) return 1; // Заходим в метод, -> передаем число, -> проверяем условие выхода,
    //  когда num == 1 -> возвращаем return 1
    return n * Factorial(n - 1); // Если условие не выполняется, ПЕРВЫМ происходит РЕКУРСИВНЫЕ вызовы,
    // и только после выполнения условия происходит n*
}
Console.WriteLine(Factorial(5)); //120

// Решение задачи
int SumDigit(int num)
{
    if(num == 0) return 0; 
    return num % 10 + SumDigit(num / 10); // Сначала записываем в СТЕК num/10 пока не выполнится условие (453,45,4)
    // Затем складываем остатки от деления на 10 (num % 10) сохраненные в СТЕКЕ (4 % 10, 45 % 10, 453 % 10 + 0"return") = 12
}

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigit(number));