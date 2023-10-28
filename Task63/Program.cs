// Задача 63
// Задайте значение N 
// Напишите программу которая выдает все натуральные числа
// в промежутке от 1 до N
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void NaturalNumbers(int num)
{
    if(num == 0) return; // Условие выхода из Метода
    // Console.Write($"{num} ");  // Если вывести в консоль перед рекурсивным Методом, 
    // то результат Метода не будет выводится, а вывод будет в обратном порядке.
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}


Console.WriteLine("Введите натуральное число:");
int numbers = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(numbers);