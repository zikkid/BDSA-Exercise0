namespace MyApp;

public class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Type a year (>=1582) and I will tell you whether it was a leap year or not");
        string input = Console.ReadLine();
        int year = TestInput(input);

        if (year != -1)
        {
            Console.WriteLine(YayOrNay(year));
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

    public static string YayOrNay(int year)
    {
        if (DateCheck(year))
        {
            if (IsLeapYear(year).Equals(true))
            {
                return "yay";
            }
            
            return "nay";
        }

        return "year has to be 1582 or above";
    }

    public static int TestInput(string input)
    {
        int year;
        
        if (!int.TryParse(input, out year))
        {
            Console.WriteLine("{0} is not an integer", input);
        }

        if (int.TryParse(input, out year))
        {
            return year;
        }

        return -1;
    }

    public static bool DateCheck(int input)
    {
        if (input >= 1582)
        {
            return true;
        }

        return false;
    }
}