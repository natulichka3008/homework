//  Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

Console.Write( " введите значение  n ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write( " введите значение  m ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    if( n ==0 )
    {
        return Ackerman(m- 1,1);
    }
    else 
    {
        return Ackerman(m -1, Ackerman(m,n-1));
    }
    
}
Console.Write( $" функция Аккермана равно  { Ackerman(m,n)}");
Ackerman(m, n);