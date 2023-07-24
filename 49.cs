public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dictionary_Of_Anagrams = new Dictionary<string, IList<string>>();

        foreach (var word in strs)
        {
            var sortedWord = string.Concat(word.OrderBy(c => c));
            if (!dictionary_Of_Anagrams.ContainsKey(sortedWord))
            {
                dictionary_Of_Anagrams[sortedWord] = new List<string>();
            }
            dictionary_Of_Anagrams[sortedWord].Add(word);
        }
        return dictionary_Of_Anagrams.Values.ToList();
    }
}