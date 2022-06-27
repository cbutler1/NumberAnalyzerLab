Console.WriteLine("Hello, what is your name?");
string name = Console.ReadLine();
string input;
do
{
    int n;
    Console.Write("Enter an integer between 1 and 100: ");
    n = Int32.Parse(Console.ReadLine());
    if (n % 2 != 0 && n <= 60)
    {
        Console.WriteLine(name + ", {0} is odd and less than 60.", n);
    }
    else if (n % 2 == 0 && n <= 24 && n >= 2)
    {
        Console.WriteLine(name + ", {0} is even and less than 25.", n);
    }
    else if (n % 2 == 0 && n <= 60 && n >= 26)
    {
        Console.WriteLine(name + ", {0} is even and between 26 and 60 inclusive.", n);
    }
    else if (n % 2 == 0 && n > 60 && n <= 100)
    {
        Console.WriteLine(name + ", {0} is even and greater than 60.", n);
    }
    else if (n % 2 != 0 && n > 60 && n <= 100)
    {
        Console.WriteLine(name + ", {0} is odd and greater than 60.", n);
    }
    else
    {
        Console.WriteLine(name + ", {0} is not in our range.", n);
    }
    Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
    input = Console.ReadLine().ToLower(); 
} while (input.Equals("yes") || input.Equals("y"));


