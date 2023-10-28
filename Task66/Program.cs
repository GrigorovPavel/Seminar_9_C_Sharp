// Задача 66
// Задайте значение M и N 
// Напишите программу которая найдет сумму всех натуральных элементов
// в промежутке от M до N Выполнить с помощю Рекурсии
// M=1, N = 15 -> 120
// M=4, N = 8 -> 30

int SumNumbers(int numM, int numN)
{
    if (numM > numN)
    {
        return numN + SumNumbers(numN + 1, numM);
    }
    else if (numM < numN)
    {
        return numM + SumNumbers(numM + 1, numN);
    }
    else
    {
        Console.WriteLine(numM);
    }
    return numM;
}


Console.WriteLine("Введите первое натуральное число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA < 1 || numberB < 1)
{
    Console.Write("Некорректный ввод");
    return;
}

int res = SumNumbers(numberA, numberB);
Console.WriteLine($"Сумма чисел от {numberA} до {numberB} -> {res}");