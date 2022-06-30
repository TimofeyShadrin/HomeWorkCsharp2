// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Enter the number of the day of the week: ");
                    string? digit = Console.ReadLine();
                    Console.WriteLine();

                    if (!string.IsNullOrEmpty(digit))
                    {
                        char number = Convert.ToChar(digit.ToString());
                        if (number == '6' || number == '7')
                        {
                            Console.WriteLine("This day is a day off");
                            Console.WriteLine();
                            break;
                        }
                        else if (number == '1' || number == '2' || number == '3' || number == '4' || number == '5')
                        {
                            Console.WriteLine("This day is a working day");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
                catch
                {
                    continue;
                }
            }
        }
    }
}