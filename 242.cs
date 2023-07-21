public class Solution {    
    public bool IsAnagram (string s, string t){
        if (s.Length != t.Length) return false;
        char[] lettersOf_S = s.ToCharArray();
        Array.Sort(lettersOf_S);
        char[] lettersOf_T = t.ToCharArray();
        Array.Sort(lettersOf_T);
        return IsAnagramVerified(lettersOf_S,lettersOf_T);
    }

    private bool IsAnagramVerified(char[] s, char[] t, int i = 0, int j = 0){
        if (i >= s.Length) return true;
        if (s[i] == t[j]) return IsAnagramVerified(s,t,i + 1, j + 1);
        else return false;
    }
}