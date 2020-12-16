public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        int len = nums.Length, result=int.MaxValue;
        int[] count = new int[len];
        int temp = 0;
        for(int i = 0; i < len; i++){
           if(i==0) count[i] = nums[i];
            else count[i] = count[i-1] + nums[i];
            if(count[i] >= s) {
                temp = BinarySearch(count, 0, i-1, count[i]-s); 
                result = Math.Min(result, i - temp);
            }
        }
        
        return result == int.MaxValue ? 0 : result;
    }
    
    private int BinarySearch(int[] nums, int start, int end, int target){
        int mid = 0;
       while(start<=end){
          mid = (start + end) / 2;
           if (nums[mid] == target) return mid;
           else if (nums[mid] > target) end = mid - 1;
           else start = mid + 1;
       } 
        return end;
    }
}