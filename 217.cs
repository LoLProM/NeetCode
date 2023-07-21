
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        Dictionary<int, bool> listOfNumbers = new Dictionary<int, bool>();
        foreach (var item in nums){
            if (listOfNumbers.ContainsKey(item)){
                return true;
            }
            listOfNumbers.Add(item, true);
        }
        return false;
    }
}