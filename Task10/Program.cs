// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

namespace HelloWorld 
{ class Program 
    { static void Main(string[] args) 
        { 
            Console.Write("Enter a three-digit number: ");
            string? number = Console.ReadLine();
            if (!string.IsNullOrEmpty(number))
            {
                Console.WriteLine($"Your second digit is: {number[1]}");
            }
        } 
    } 
} 