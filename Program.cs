// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NToOne(int n)
// {
//     if (n >= 1)
//     {
//         System.Console.Write(n + " ");
//         NToOne(n - 1);
//     }
// }
// NToOne(8);


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumOfNaturalElements(int m, int n)
// {
//     if (m != n)
//     {
//         if(n > m)
//         {
//             return SumOfNaturalElements(n - 1, m)+ n;
//         }
//         else
//         {
//             return SumOfNaturalElements(n, m - 1) + m;
//         }
//     }
//     else return n;
// }
// System.Console.WriteLine(SumOfNaturalElements(10, 15));


// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

System.Console.WriteLine(Ackermann(2, 3));