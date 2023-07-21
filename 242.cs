public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        char[] lettersOf_S = s.ToCharArray();
        Array.Sort(lettersOf_S);
        char[] lettersOf_T = t.ToCharArray();
        Array.Sort(lettersOf_T);

        for (int i = 0; i < lettersOf_S.Length; i++)
        {
            if (lettersOf_S[i] != lettersOf_T[i])
            {
                return false;
            }
        }
        return true;
    }

    public bool IsAnagram(string s, string t)//Another solution
    {
        if (s.Length != t.Length) return false;

        var hash_S = s.ToHashSet();

        foreach (var i in t){
            if (!hash_S.Contains(i)){
                return false;
            }
        }
        return true;
    }

}