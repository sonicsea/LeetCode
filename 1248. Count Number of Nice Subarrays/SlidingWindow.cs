public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        int len = nums.Length, result = 0;
        int left = 0,prev=0;
        for(int right = 0; right<len; right++){
            if ((nums[right]&1) == 1) k--;
            if(k==0) prev = left; //left pointer is about to change, update prev
            while(k==0){
                if ((nums[left++]&1)==1) k++;
            }
            int temp = left-prev;
            result+=temp; //add all the subarrays end with the current window
            if(k==0)
                // Add all the subarrays that start with the current window, and
                // have all even number only in the non-window sections
                while(right+1<len && (nums[++right]&1)==0) result+=temp; 
        }
        return result;
    }
}