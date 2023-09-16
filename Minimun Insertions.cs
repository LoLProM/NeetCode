public class Solution
{
    public static int Palindromo(string s)
    {
        int i = 0;
        int j = s.Length - 1;
        int insertions = CalculateInsertions(s, i, j);
        return insertions;
    }

    private static int CalculateInsertions(string s, int i, int j)
    {
        if (i > j)
        {
            return 0;
        }
        if (s[i] != s[j])
        {
            return 1 + Math.Min(CalculateInsertions(s[j] + s, i, j - 1), CalculateInsertions(s + s[i], i + 1, j));
        }
        else
        {
            return CalculateInsertions(s, i + 1, j - 1);
        }
    }
}