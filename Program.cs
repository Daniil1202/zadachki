﻿

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3 


// Console.WriteLine("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1<num2)
// {
//   Console.WriteLine("Большее число равно: " + num2);
//   Console.WriteLine("Меньшее число равно: " + num1);
// }
// else 
// {
//   Console.WriteLine("Большее число равно: " + num1);
//   Console.WriteLine("Меньшее число равно: " + num2);










// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if(num2>max) 
// {
//   max = num2;  
// }
// if (num3>max) 
// {
//     max = num3;
// }

    
// Console.WriteLine(max);




//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет




// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num%2==0)
// {
//     Console.WriteLine("четное");
// }
// else 
// {
//     Console.WriteLine("не четное");
// }





// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());


for (int i=1; i<=num; i++)
{
    if (i%2==0)

    Console.Write($"{i} ");
    
 

}







