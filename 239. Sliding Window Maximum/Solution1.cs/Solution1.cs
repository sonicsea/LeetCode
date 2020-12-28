public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int len = nums.Length, max = int.MinValue;
        IList<int> window = new List<int>();
        IList<int> result = new List<int>();
        for(int i = 0; i < k; i++) {
            while (window.Count > 0 && nums[window.Last()] < nums[i]) window.RemoveAt(window.Count - 1);
            window.Add(i);
        }
        result.Add(nums[window[0]]);
        for(int i = k; i < len; i++){
            while(window.Count > 0 && window[0] <= i - k) window.RemoveAt(0);
            while(window.Count > 0 && nums[window.Last()] < nums[i]) window.RemoveAt(window.Count - 1);
            window.Add(i);
            result.Add(nums[window[0]]);
        }
        return result.ToArray();
    }
}