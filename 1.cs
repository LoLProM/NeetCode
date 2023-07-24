public class Solution
{
    public int[] TwoSum(int[] nums, int target){
        
        var dictionary_Of_Nums = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diference = target - nums[i];
            if (dictionary_Of_Nums.ContainsKey(nums[i]))
            {
                return new int[] { dictionary_Of_Nums[nums[i]], i };
            }
            dictionary_Of_Nums.Add(diference,i);
        }
        throw new NotImplementedException("Pair not found");
    }
}