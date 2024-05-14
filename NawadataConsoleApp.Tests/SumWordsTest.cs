using Xunit.Abstractions;

namespace NawadataConsoleApp.Tests;

public class SumWordsTest: IDisposable
{
    private SumWords testCase;

    public SumWordsTest()
    {
        testCase = new SumWords();
    }

    public void Dispose()
    {
        //
    }

    [Fact]
    public void TestSumWordsSuccess()
    {
        const int expected = 5;

        testCase.Words = "Halo, nama saya adalah JoeDoe";
        var result = testCase.Sum();
        Assert.Equal(expected, result);
        
    }
    
    [Fact]
    public void TestSumWordsSuccess_1()
    {
        const int expected = 11;

        testCase.Words = "A new word is added to a dictionary every two hours";
        var result = testCase.Sum();
        Assert.Equal(expected, result);
        
    }
    
    [Fact]
    public void TestSumWordsSuccess_2()
    {
        const int expected = 10;

        testCase.Words = "Shakespeare introduced over 1000 new words to the English language";
        var result = testCase.Sum();
        Assert.Equal(expected, result);
        
    }
    
    [Fact]
    public void TestSumWordsFailed()
    {
        const int expected = 10;

        testCase.Words = "Halo, nama saya adalah JoeDoe";
        var result = testCase.Sum();
        Assert.NotEqual(expected, result);
        
    }
    
    [Fact]
    public void TestSumWordsFailed_1()
    {
        const int expected = 10;

        testCase.Words = "A new word is added to a dictionary every two hours";
        var result = testCase.Sum();
        Assert.NotEqual(expected, result);
        
    }
    
    [Fact]
    public void TestSumWordsFailed_2()
    {
        const int expected = 11;

        testCase.Words = "The average English speaker knows between 20000 and 30000 words";
        var result = testCase.Sum();
        Assert.NotEqual(expected, result);
        
    }
    
    [Fact]
    public void TestSumWordsFailed_3()
    {
        const int expected = 0;

        testCase.Words = null;
        var result = testCase.Sum();
        Assert.Equal(expected, result);
    }
    
}