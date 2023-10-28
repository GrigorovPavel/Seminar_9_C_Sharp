// Задача 64
// Задайте значение N 
// Напишите программу которая выдает все натуральные числа
// в промежутке от 1 до N
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumbers(int num)
{
    if(num == 0) return; 
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}


Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0) 
{
    Console.Write($"{number} -> ");
    NaturalNumbers(number);
}
else Console.WriteLine("Некорректный ввод");
return;
