public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        int len = nums.Length, result = 0, odd = 0;
        int[] count = new int[len+1];
        count[0] = 1;
        for(int i = 0; i < len; i++){
            odd+= nums[i]&1;
            count[odd]++;
            if (odd>=k) result+=count[odd-k];
        }
        return result;
    }
}