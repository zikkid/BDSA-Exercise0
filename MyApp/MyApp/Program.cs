namespace MyApp;

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

        //this somehow prints "yay" when user inputs something not convertible to integer
        Console.WriteLine(YayOrNay(year));
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
        if (IsLeapYear(year).Equals(true))
        {
            return "yay";
        }
        else
        {
            return "nay";
        }
        
    }
}