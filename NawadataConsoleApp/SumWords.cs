namespace NawadataConsoleApp;

public class SumWords
{
    public string? Words { get; set; }

    public SumWords(string words)
    {
        Words = words;
    }

    public SumWords()
    {
    }

    public int Sum()
    {
        return Words is null ? 0 : Words.Split(" ").Length;
    }
}