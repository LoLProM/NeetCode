public class Solution
{
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