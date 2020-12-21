public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int left = 0, len = s.Length, result = 0;
        for(int right = 0; right < len; right++){
            if (dict.ContainsKey(s[right])){
                while(left<dict[s[right]]) dict.Remove(s[left++]);
                left = dict[s[right]] + 1;
                
                dict[s[right]] = right;
            }
            else {
               result = Math.Max(result, right-left+1);
                dict.Add(s[right], right);
            }
        }
        return result;
    }
}