public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dictionary_Of_Anagrams = new Dictionary<string, IList<string>>();

        foreach (var word in strs)
        {
            var sortedWord = SortWord(word);
            if (!dictionary_Of_Anagrams.ContainsKey(sortedWord))
            {
                dictionary_Of_Anagrams[sortedWord] = new List<string>();
            }
            dictionary_Of_Anagrams[sortedWord].Add(word);
        }
        return dictionary_Of_Anagrams.Values.ToList();
    }

    private string SortWord(string word)
    {
        char[] chars_In_Word = word.ToCharArray();
        Array.Sort(chars_In_Word);
        string result = "";
        foreach (char c in chars_In_Word)
        {
            result += c;
        }
        return result;
    }
}