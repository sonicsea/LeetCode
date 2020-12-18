public class Solution {
    public int NumberOfSubstrings(string s) {
        int left=0, right = 0, result = 0, len = s.Length;
        int[] count = new int[3];
        while(right<len){
            count[s[right++] - 'a']++;
            while(count[0] > 0 && count[1] > 0 && count[2] > 0)
                count[s[left++]-'a']--;
            result+=left;
        }
        return result;
    }
}