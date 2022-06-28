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