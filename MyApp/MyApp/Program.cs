namespace Namespace;

public class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Type a year and I will tell you whether it was a leap year or not");
        string input = Console.ReadLine();
        int year;
        
        if (!int.TryParse(input, out year))
        {
            Console.WriteLine("{0} is not an integer", input);
        }
        
        if (IsLeapYear(year).Equals(true))
        {
            Console.WriteLine("yay");
        }
        else
        {
            Console.WriteLine("nay");
        }
    }

    public static bool IsLeapYear(int year) 
    {
        if (year % 4 == 0) 
        {
            if (year % 100 == 0)
            {
                if (year % 400 != 0)
                {
                    return false;
                }
                return true;
            }
            return true;
        }

        return false;
    }
}