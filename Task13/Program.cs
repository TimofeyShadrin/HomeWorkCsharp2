namespace HelloWorld 
{ class Program 
    { static void Main(string[] args) 
        { 
            Console.Write("Enter a three-digit number: ");
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