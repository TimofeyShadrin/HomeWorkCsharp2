// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

namespace HelloWorld 
{ class Program 
    { static void Main(string[] args) 
        { 
            Console.Write("Enter number: ");
            string? number = Console.ReadLine();
            if (!string.IsNullOrEmpty(number))
            {
                if (number.Length >= 3)
                {
                    Console.WriteLine($"Your third digit is: {number[2]}");
                }
                else
                {
                    Console.WriteLine($"There is no third digit!");
                }
            }
        } 
    } 
} 