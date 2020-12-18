public class Solution {
    public int NumberOfSubstrings(string s) {
        int[] chars = new int[3];
        int left = 0, right = 0, len = s.Length, result=0;
        while(right < len){
            chars[s[right++]-'a']++;
            while(chars[0]>0 && chars[1]>0 && chars[2]>0) {
                result += len-right+1;
                chars[s[left++]-'a']--;
            }
        }
        return result;
    }
}