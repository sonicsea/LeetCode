public class Solution {
    public int LongestSubstring(string s, int k) {
        int left = 0, result = int.MinValue, len = s.Length;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int[] alpha = new int[26];
        foreach(var c in s) alpha[c-'a']++;
        for(int right = 0; right < len+1; right++){
            if (right == len || alpha[s[right]-'a'] < k){
                int currentLen = right - left;
                bool valid = true;
                for(int i = left; i < right; i++){
                    if (dict[s[i]] < k) {
                        valid = false;
                        break;
                    }
                }
                if (valid) result = Math.Max(result, currentLen);
                else result = Math.Max(result, LongestSubstring(s.Substring(left, currentLen), k));
                left = right + 1;
                dict.Clear();
            }
            else {
                if (dict.ContainsKey(s[right])) dict[s[right]]++;
                else dict.Add(s[right], 1);
            }
        }
        return result;
    }
}