public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int len = s.Length, result = 0;
        for(int left = 0, right = 0; right < len; right++){
            if (dict.ContainsKey(s[right])){
                left = Math.Max(left, dict[s[right]]+1);
                dict[s[right]] = right;
            }
            else dict.Add(s[right], right);
            result = Math.Max(result, right-left+1);
        }
        return result;
    }
}