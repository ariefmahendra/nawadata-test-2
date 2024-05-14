namespace NawadataConsoleApp.Tests;

public class MaxCharacterTest: IDisposable
{
    private MaxCharacter _maxCharacter;

    public MaxCharacterTest()
    {
        _maxCharacter = new MaxCharacter("hello");
    }

    public void Dispose()
    {
        //
    }

    [Fact]
    public void TestMaxCharacterSuccess()
    {
        const string expected = "l";
        var result = _maxCharacter.MaxChar();
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TestMaxCharacterSuccess_1()
    {
        const string expected = "p";
        _maxCharacter.Word = "happy";
        var result = _maxCharacter.MaxChar();
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TestMaxCharacterSuccess_2()
    {
        const string expected = "e";
        _maxCharacter.Word = "eat";
        var result = _maxCharacter.MaxChar();
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TestMaxCharacterFailed()
    {
        const string expected = "a";
        _maxCharacter.Word = "eat";
        var result = _maxCharacter.MaxChar();
        Assert.NotEqual(expected, result);
    }
    
    [Fact]
    public void TestMaxCharacterFailed_1()
    {
        const string expected = "a";
        _maxCharacter.Word = "happy";
        var result = _maxCharacter.MaxChar();
        Assert.NotEqual(expected, result);
    }
    
    [Fact]
    public void TestMaxCharacterFailed_2()
    {
        const string expected = "h";
        _maxCharacter.Word = "hello";
        var result = _maxCharacter.MaxChar();
        Assert.NotEqual(expected, result);
    }
    
    [Fact]
    public void TestMaxCharacterFailed_3()
    {
        const string expected = "";
        _maxCharacter.Word = null;
        var result = _maxCharacter.MaxChar();
        Assert.Equal(expected, result);
    }
}