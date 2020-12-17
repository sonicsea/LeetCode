public class Solution {
    public int LongestOnes(int[] A, int K) {
        int left = 0, right = 0, len = A.Length, result = int.MinValue;
        while(right < len){
            while(right<len && K>0){
               if (A[right++]==0) K--;
            }
            while(right<len && A[right]==1) right++;
            result = Math.Max(result, right - left);
            if (right==len) return result;
            while(left < len && K==0){
                if (A[left++] == 0) K++;
            }
        }
        return result;
    }
}