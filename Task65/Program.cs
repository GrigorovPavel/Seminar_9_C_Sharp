// Задача 65
// Задайте значение M и N 
// Напишите программу которая выдает все натуральные числа
// в промежутке от M до N
// M=1, N = 5 -> "1, 2, 3, 4, 5"
// M=4, N = 8 -> "4, 5, 6, 7, 8"

void RangeNaturalNumbers(int numM, int numN)
{
    if(numM > numN)
    { 
        Console.Write($"{numM}, ");
        RangeNaturalNumbers(numM - 1, numN);
    }
    else if(numM < numN)
    {
        Console.Write($"{numM}, ");
        RangeNaturalNumbers(numM +1, numN);
    }
    else 
    {
        Console.WriteLine(numM);
    }
}


Console.WriteLine("Введите первое натуральное число:");
int numbersM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int numbersN = Convert.ToInt32(Console.ReadLine());

RangeNaturalNumbers(numbersM, numbersN);