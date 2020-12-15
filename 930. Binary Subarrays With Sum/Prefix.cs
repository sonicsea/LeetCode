public class Solution {
    public int NumSubarraysWithSum(int[] A, int S) {
        int ans = 0, len = A.Length,currentSum = 0;
        int[] count = new int[len+1];
        count[0] = 1;
        for(int i = 0; i < len; i++){
            currentSum+=A[i];
            if (currentSum>=S) ans+=count[currentSum-S];
            count[currentSum]++;
        }
        return ans; 
    }
}