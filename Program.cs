// Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers(1,N));

// // ------Метод------------------------
// string PrintNumbers(int start, int end){
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }



//**Задача 65:** Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

// Console.Write("Введите значение M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers(M,N));

// //----------метод---------
// string PrintNumbers(int start, int end){
//     if(start == end)return start.ToString();
//     return( start + " " + PrintNumbers(start +1, end));
// }



//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintSumNumbers(N));

// //-----------метод----------
// int PrintSumNumbers(int nums){
//     if(nums == 0) return 0;
//     return(nums % 10 + PrintSumNumbers(nums / 10));
//}



//**Задача 69:** Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// Console.Write("Введите значение числа M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение степени N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintMultyNumbers(M,N));

// //-----------метод------------
// int PrintMultyNumbers (int a, int b){
//     if(b == 0) return 1;
//     if(b == 1) return a;
//     return (PrintMultyNumbers(a, b-1) * a);
// }

// // Факториал числа N.
// Console.Write("Введите значение степени N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(factorial(N));

// //--------метод--------
// int factorial(int N){
//     if(N <= 1) return 1;
//     return(factorial(N-1)*N);
// }

// // Фибоначчи первых чисел N.
// Console.Write("Введите значение степени N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Fibon(N));
// //-----------метод----------
// int Fibon(int N){
//     if(N == 0 || N == 1) return N;
//     return(Fibon(N-1) + Fibon(N-2));
// }