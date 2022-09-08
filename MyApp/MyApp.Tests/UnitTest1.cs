using System.Reflection;
using MyApp;

namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public static void method_IsLeapYear_returns_true_for_year_1600()
    {
        //arrange
        
        //act
        var result = Program.IsLeapYear(1600);

        //assert
        result.Should().Be(true);
    }
    
    [Fact]
    public void method_IsLeapYear_returns_false_for_year_1700()
    {
        //arrange
        
        //act
        var result = Program.IsLeapYear(1700);

        //assert
        result.Should().Be(false);
    }

    [Fact]
    public void method_YayOrNay_returns_yay_for_year_1600()
    {
        //arrange
        
        //act
        var result = Program.YayOrNay(1600);

        //assert
        result.Should().Be("yay");
    }
    
    [Fact]
    public void method_YayOrNay_returns_nay_for_year_1700()
    {
        //arrange
        
        
        //act
        var result = Program.YayOrNay(1700);

        //assert
        result.Should().Be("nay");
    }

    [Fact]
    public void method_TestInput_returns_negative_one_for_nonInteger_input()
    {
        //arrange

        
        //act
        var result = Program.TestInput("qwerty");
        
        //assert
        result.Should().Be(-1);
    }
    
    [Fact]
    public void method_TestInput_returns_int1600_for_str1600_input()
    {
        //arrange

        
        //act
        var result = Program.TestInput("1600");
        
        //assert
        result.Should().Be(1600);
    }

    [Fact]
    public void method_YearCheck_returns_true_for_1582_input()
    {
        //arrange
        
        
        //act
        var result = Program.YearCheck(1582);

        //assert
        result.Should().Be(true);
    }
    
    [Fact]
    public void method_YearCheck_returns_false_for_1482_input()
    {
        //arrange
        
        
        //act
        var result = Program.YearCheck(1482);

        //assert
        result.Should().Be(false);
    }

    [Fact]
    public void method_TestInput_handles_negative_1_input()
    {
        //arrange
        
        
        //act
        var result = Program.TestInput("-1");

        //assert
        result.Should().Be(-1);
    }
}