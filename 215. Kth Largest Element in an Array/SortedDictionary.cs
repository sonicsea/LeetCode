public class Solution {
    public int FindKthLargest(int[] nums, int k) {
       var sd = new SortedDictionary<int, int>();
        foreach(var n in nums){
            if (sd.ContainsKey(n)) sd[n]++;
            else sd.Add(n,1);
        }
        int i = 0, target = nums.Length-k+1;
        foreach(var key in sd.Keys){
            i+= sd[key];
            if (i>=target) return key;
        } 
        return -1; //never reach here since 1<=k<=nums.Length
    }
}