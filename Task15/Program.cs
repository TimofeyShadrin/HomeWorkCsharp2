namespace HelloWorld 
{ class Program 
    { static void Main(string[] args) 
        { 
            try {
            Console.Clear(); 
            Console.Write("Enter a digit: ");
            string? digit = Console.ReadLine();
            Console.WriteLine();
            
            if (!string.IsNullOrEmpty(digit)) 
            {
                char number = Convert.ToChar(digit.ToString());
                if (number == '6' || number == '7')
                {
                    Console.WriteLine("This day is a day off");
                    Console.WriteLine();
                }
            else if (number == '1' || number == '2' || number == '3' || number == '4' || number == '5')
                {
                    Console.WriteLine("This day is a working day");
                    Console.WriteLine();
                }
            else
                {
                    Console.WriteLine("You entered an incorrect number!");
                    Console.WriteLine();
                }
            }
            
            }
            catch
            {
                Console.WriteLine("Error! Your input is incorrect!");
                Console.WriteLine();
            }
        } 
    } 
} 