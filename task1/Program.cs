
// Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



void PrintNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        if (m == n ) return;
        Console.Write(m + " ");
        PrintNaturalNumbers(m + 1, n );
    }
    else
    if (n <= m)
    {
        if (n == m ) return;
        Console.Write(m + " ");
        PrintNaturalNumbers(m - 1, n );
    }
}

Console.WriteLine(" введите натуральное число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" введите натуральное число N ");
int n = Convert.ToInt32(Console.ReadLine());
if ( m > 0 || n > 0)
{
  PrintNaturalNumbers(m, n);  
}
else
Console.WriteLine($"ошибка ввода ");












