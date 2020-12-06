public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var ss = new SortedList<int, int>();
        foreach(var n in nums){
            if (ss.ContainsKey(n)) ss[n]++;
            else ss.Add(n,1);
        }
        for(int i = ss.Count - 1; i >= 0; i--){
            if (k>0) k-=ss.Values[i];
            if (k<=0) return ss.Keys[i];
        } 
        return -1; //never reaches here
    }
}