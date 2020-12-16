public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        int len = nums.Length, currentSum = 0, result=len+1, left = 0, right = 0;
        while(right<len){
            currentSum+=nums[right];
            while (currentSum >= s){
                result = Math.Min(result, right - left + 1);
                currentSum-=nums[left++];
            }
            right++;
        }
        return result == len + 1 ? 0 : result;
    }
    
}