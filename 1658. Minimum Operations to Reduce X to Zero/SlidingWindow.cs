public class Solution {
    public int MinOperations(int[] nums, int x) {
        int len = nums.Length, sum = nums.Sum() - x;
        if (sum<0) return - 1;
        if (sum==0) return len;
        int count = -1, left = 0, current = 0;
        for(int right = 0; right < len; right++){
            current+=nums[right];
            while(current>sum) current-=nums[left++];
            if (current==sum) {
                count = Math.Max(count, right - left + 1);
                current-=nums[left++];
            }
        }
        return count == -1 ? count : len-count;
    }
}