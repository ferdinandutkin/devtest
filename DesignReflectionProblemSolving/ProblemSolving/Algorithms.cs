namespace DRPS.ProblemSolving;

public class Algorithms
{
    public static string ReverseString(string s)
    {
        ArgumentNullException.ThrowIfNull(s);
        
        var charArray = s.ToCharArray();
        var length = charArray.Length;

        for (var i = 0; i < length / 2; i++)
        {
            (charArray[i], charArray[length - i - 1]) = (charArray[length - i - 1], charArray[i]);
        }

        return new string(charArray);
    }
    
    public static bool IsPalindrome(string s)
    {
        ArgumentNullException.ThrowIfNull(s);
        
        int length = s.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (s[i] != s[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
    
    public static IEnumerable<int> MissingElements(int[] arr)
    {
        int start = arr[0];
        int end = arr[^1];
        int index = 0;

        for (int i = start; i <= end; i++)
        {
            if (index < arr.Length && arr[index] == i)
            {
                index++;
            }
            else
            {
                yield return i;
            }
        }
    }
}