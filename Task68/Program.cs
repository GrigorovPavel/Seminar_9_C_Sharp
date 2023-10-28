// Задача 68
// Напишите программу вычисления функции Аккермана с помощью Рекурсии 
// Даны два неотрицательных числа m и n 
// m =3, n =2 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int Akkerman(int numN, int numM)
{
    if(numN == 0) return numM +1;
    else if (numM == 0) return Akkerman(numN - 1, 1);
    return Akkerman(numN-1, Akkerman(numN, numM-1));
}


Console.WriteLine("Введите первое натуральное число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int numberB = Convert.ToInt32(Console.ReadLine());

int res = Akkerman(numberA, numberB);
Console.WriteLine($"Функция Аккермана для чисел {numberA} и {numberB} равен {res}");