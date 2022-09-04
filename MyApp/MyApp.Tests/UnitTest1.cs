using System.Reflection;
using Namespace;

namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void program_returns_is_leap_year_for_input_1600()
    {
        //arrange
        //using var writer = new StringWriter();
        var method = t.

        //act
        //var program = Assembly.Load(nameof(MyApp));
        //program.EntryPoint?.Invoke(null, new[] { "1600" });

        //assert
        //var output = writer.GetStringBuilder().ToString().TrimEnd();
        //output.Should().Be("Is leap year");
    }
    
    [Fact]
    public void program_returns_is_NOT_leap_year_for_input_1700()
    {
        //arrange
        using var writer = new StringWriter();

        //act
        var program = Assembly.Load(nameof(MyApp));
        program.EntryPoint?.Invoke(null, new[] { "1700" });

        //assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Is NOT leap year");
    }
}