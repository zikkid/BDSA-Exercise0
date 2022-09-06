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
}