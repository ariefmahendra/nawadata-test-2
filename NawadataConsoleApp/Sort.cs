namespace NawadataConsoleApp;

public class Sort
{

    public int[]? ListNumber { get; set; }


    public Sort(int[] listNumber)
    {
        ListNumber = listNumber;
    }

    public Sort()
    {
    }

    public int[] SortInt()
    {
        if (ListNumber is null)
        {
            return [];
        }
        Array.Sort(ListNumber);
        return ListNumber;
    }
}