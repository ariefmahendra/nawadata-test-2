namespace NawadataConsoleApp;

public class MaxCharacter
{
    public string? Word { get; set; }

    public MaxCharacter(string? word)
    {
        Word = word;
    }

    public MaxCharacter()
    {
    }

    public string MaxChar()
    {
        if (Word is null)
        {
            return string.Empty;
        }
        
        var dic = new Dictionary<char, int>();

        foreach (var c in Word)
        {
            if (dic.TryGetValue(c, out int value))
            {
                dic[c] = ++value;
            }
            else
            {
                dic[c] = 1;
            }
        }

        char result = new char();
        int max = 0;
        foreach (var item in dic.Where(item => item.Value > max))
        {
            max = item.Value;
            result = item.Key;
        }

        return result.ToString();
    }
}