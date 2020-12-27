public class Solution {
    public int SubarraysWithKDistinct(int[] A, int K) {
       return AtMostKDistinct(A, K) - AtMostKDistinct(A, K-1);
    }
    private int AtMostKDistinct(int[] A, int K){
        int len = A.Length, result = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int left = 0, right = 0; right < len; right++){
            if (dict.ContainsKey(A[right])) dict[A[right]]++;
            else dict.Add(A[right], 1);
            while(dict.Count > K){
                dict[A[left]]--;
                if (dict[A[left]] == 0) dict.Remove(A[left]);
                left++;
            }
            result += right - left + 1;
        }
        return result;
    }
}