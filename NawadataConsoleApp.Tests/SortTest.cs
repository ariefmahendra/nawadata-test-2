namespace NawadataConsoleApp.Tests;

public class SortTest: IDisposable
{
    private Sort _sort;

    public SortTest()
    {
        _sort = new Sort();
    }

    public void Dispose()
    {
        //
    }

    [Fact]
    public void TestAscSortSuccess()
    {
        var expected = new[] { 1, 2, 3, 4, 5 };

        _sort.ListNumber = [3, 1, 5, 2, 4];
        var result = _sort.SortInt();
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TestAscSortSuccess_1()
    {
        var expected = new[] { 3, 7, 8 };

        _sort.ListNumber = [7, 3, 8];
        var result = _sort.SortInt();
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TestAscSortSuccess_2()
    {
        var expected = new[] { 2, 5, 9};

        _sort.ListNumber = [9, 2, 5];
        var result = _sort.SortInt();
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TestAscSortFailed()
    {
        var expected = new[] { 3, 1, 5, 2, 4 };
        
        _sort.ListNumber = [3, 1, 5, 2, 4];
        var result = _sort.SortInt();
        
        Assert.NotEqual(expected, result);
    }
    
    [Fact]
    public void TestAscSortFailed_1()
    {
        var expected = new[] { 6, 4, 1 };
        
        _sort.ListNumber = [6, 1, 4];
        var result = _sort.SortInt();
        
        Assert.NotEqual(expected, result);
    }
    
    [Fact]
    public void TestAscSortFailed_2()
    {
        var expected = new[] { 9, 5, 2 };
        
        _sort.ListNumber = [9, 2, 5];
        var result = _sort.SortInt();
        
        Assert.NotEqual(expected, result);
    }
    
    [Fact]
    public void TestAscSortFailed_3()
    {
        var expected = Array.Empty<int>();
        
        _sort.ListNumber = null;
        var result = _sort.SortInt();
        
        Assert.Equal(expected, result);
    }
}