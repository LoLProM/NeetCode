public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var dictionary_Of_S = new Dictionary<char, int>();

        foreach (var letter in s)
        {
            if (dictionary_Of_S.ContainsKey(letter)){
                dictionary_Of_S[letter]++;
            }
            else {
                dictionary_Of_S.Add(letter, 1);
            }
        }

        foreach (var letter in t)
        {
            if (dictionary_Of_S.ContainsKey(letter)){
                dictionary_Of_S[letter]--;
                if (dictionary_Of_S[letter] == 0){
                    dictionary_Of_S.Remove(letter);
                }
            }
            else {
                return false;}
        }
        return dictionary_Of_S.Count == 0;
    }

}