namespace ConsoleApp;

public class Solution
{

    public int SumWords(string words)
    {
        var sum = words.Split(" ").Sum(s => s.Length);
        return sum;
    }
    
}