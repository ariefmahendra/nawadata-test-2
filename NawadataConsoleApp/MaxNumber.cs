namespace NawadataConsoleApp;

public class MaxNumber
{
    public int[]? ListNumber { get; set; }

    public MaxNumber(int[] listNumber)
    {
        ListNumber = listNumber;
    }

    public MaxNumber()
    {
    }

    public int Max()
    {
        return ListNumber?.Max() ?? 0;
    }
}