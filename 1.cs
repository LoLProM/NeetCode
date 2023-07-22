public class Solution
{
    public int[] TwoSum(int[] nums, int target){
        Array.Sort(nums);
        int left = 0;
        int right = nums.Length - 1;
        while (left < right){
            int sum = nums[left] + nums[right];
            if (sum == target){
                return new int[] { left, right };
            }
            if (sum > target){
                right--;
            }
            if (sum < target){
                left++;
            }
        }
        throw new NotImplementedException("Pairs not found");
    }
}