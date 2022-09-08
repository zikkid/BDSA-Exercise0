namespace MyApp;

public class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("type a year earlier than the gregorian calendar reform (>= 1582)");
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
        if (YearCheck(year))
        {
            if (IsLeapYear(year).Equals(true))
            {
                return "yay";
            }
            
            return "nay";
        }

        return "year has to be 1582 or greater";
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
            if (year == -1)
            {
                Console.WriteLine("year 1 BC is not greater than 1582.\n" +
                                  "however you would perhaps be delighted to know that according\n" +
                                  "to both the julian calendar and the gregorian calendar,\n" +
                                  "1 BC is indeed considered to have been a leap year.");
            }
        }

        if (int.TryParse(input, out year))
        {
            return year;
        }

        return -1;
    }

    public static bool YearCheck(int input)
    {
        if (input >= 1582)
        {
            return true;
        }

        return false;
    }
}