public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs){        
        var dictionary_Of_Anagrams = new Dictionary<string, IList<string>>();

        foreach (var word in strs){
            char[] alfabet = new char[26];
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                alfabet[c - 'a']++;
            }
            string key = new string(alfabet);
            if (!dictionary_Of_Anagrams.ContainsKey(key)){
                dictionary_Of_Anagrams[key] = new List<string>();
            }
            dictionary_Of_Anagrams[key].Add(word);
        }
        return dictionary_Of_Anagrams.Values.ToList();
    }
}