namespace CupSwapping;

public class Cup
{
    const string STAR_POSITION = "B";

    public string Swap(string[] swaps)
    {
        string position = STAR_POSITION; 

        for (int i = 0; i < swaps.Length; i++)
        {
            var newPosition = swaps[i].Replace(position, string.Empty);
            position = newPosition.Length == 1 ? newPosition : position;
        }

        return position;
    }
}