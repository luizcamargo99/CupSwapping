namespace CupSwapping.Tests;

public class CupTests
{
    [Theory]
    [InlineData(new string[] { "AB", "CA" }, "C")]
    [InlineData(new string[] { "AB", "CA", "AB" }, "C")]
    [InlineData(new string[] { "AC", "CA", "CA", "AC" }, "B")]
    [InlineData(new string[] { "BA", "AC", "CA", "BC" }, "A")]
    [InlineData(new string[] { "BC", "CB", "CA", "BA" }, "A")]
    [InlineData(new string[] { "BC" }, "C")]
    [InlineData(new string[] { "BA", "CA", "CB", "CA" }, "B")]
    [InlineData(new string[] {  }, "B")]
    public void TestSwapSuccess(string[] swaps, string resultExpected)
    {
        var result = new Cup().Swap(swaps);
        Assert.Equal(resultExpected, result);
    }
}