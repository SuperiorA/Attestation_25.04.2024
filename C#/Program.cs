/*
1) Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/

// System.Console.WriteLine("Задайте значение М");        
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Задайте значение N");
// int N = Convert.ToInt32(Console.ReadLine());

// void SumBetweenMN(int M, int N)                         
// {   
//     if(M > N)
//     {
//         return;
//     }
//     else 
//     {   
//         Console.ForegroundColor = ConsoleColor.Green;
//         System.Console.WriteLine(M + " ");
//         SumBetweenMN(M + 1, N);
//     }
// }

// SumBetweenMN(M, N);

/*
2) Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/

// int n = 5;
// int m = 10;

// int AkkermanMethod(int n, int m)
// {
//     if (n == 0)
//     {
//         return (m + 1);
//     }
//     else if (m == 0)
//     {
//         return AkkermanMethod(n - 1, 1);
//     }
//     else
//     {   
//         // Console.ForegroundColor = ConsoleColor.Red;
//         // System.Console.WriteLine(n);
//         // Console.ForegroundColor = ConsoleColor.Green;
//         // System.Console.WriteLine(m);
//         return AkkermanMethod((n - 1), (m - 1));
//     }
// }

// int result = AkkermanMethod(n, m);
// Console.ForegroundColor = ConsoleColor.DarkCyan;
// System.Console.WriteLine(result);

/*
3) Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/

int[] array = {5, 10, 15, 20, 25, 30};                         

void PrintArray(int[] array, int i = 5)
{   
    if (i < 0)
    {
        return;
    }
    else
    {
        System.Console.Write(array[i] + " ");
        PrintArray(array, i - 1);
    }
}
 Console.ForegroundColor = ConsoleColor.DarkYellow;
PrintArray(array);
