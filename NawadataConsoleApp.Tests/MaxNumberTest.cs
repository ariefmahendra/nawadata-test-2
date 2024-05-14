namespace NawadataConsoleApp.Tests;

public class MaxNumberTest: IDisposable
{
    private MaxNumber _maxNumber;

    public MaxNumberTest()
    {
        _maxNumber = new MaxNumber();
    }

    public void Dispose()
    {
        //
    }

    [Fact]
    public void TestMaxNumberSuccess()
    {
        const int expected = 66;
        _maxNumber.ListNumber = [4, 5, 3, 4, 2, 6, 5, 4, 3, 7, 6, 8, 9, 1, 1, 11, 2, 3, 22, 5, 66];
        var result = _maxNumber.Max();
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TestMaxNumberSuccess_1()
    {
        const int expected = 9;
        _maxNumber.ListNumber = [7, 9, 2, 5, 1];
        var result = _maxNumber.Max();
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TestMaxNumberSuccess_2()
    {
        const int expected = 8;
        _maxNumber.ListNumber = [6, 3, 8, 4, 1];
        var result = _maxNumber.Max();
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TestMaxNumberFailed()
    {
        const int expected = 20;
        _maxNumber.ListNumber = [4, 5, 3, 4, 2, 6, 5, 4, 3, 7, 6, 8, 9, 1, 1, 11, 2, 3, 22, 5, 66];
        var result = _maxNumber.Max();
        
        Assert.NotEqual(expected, result);
    }
    
    [Fact]
    public void TestMaxNumberFailed_1()
    {
        const int expected = 1;
        _maxNumber.ListNumber = [7, 9, 2, 5, 1];
        var result = _maxNumber.Max();
        
        Assert.NotEqual(expected, result);
    }
    
    [Fact]
    public void TestMaxNumberFailed_2()
    {
        const int expected = 6;
        _maxNumber.ListNumber = [6, 3, 8, 4, 1];
        var result = _maxNumber.Max();
        
        Assert.NotEqual(expected, result);
    }
    
    [Fact]
    public void TestMaxNumberFailed_3()
    {
        const int expected = 0;
        _maxNumber.ListNumber = null;
        var result = _maxNumber.Max();
        
        Assert.Equal(expected, result);
    }
}