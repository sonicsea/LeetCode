public class Solution {
    public int Calculate(string s) {
        int result = 0, n = 0;
        bool positive = true;
        for(int i = 0; i < s.Length; i++){
            if (s[i] == ' ' || s[i] == ')') continue;
            if (s[i] == '+') positive = true;
            else if (s[i] == '-') positive = false;
            else if (s[i] == '('){
                var start = ++i;
                n = 1;
                while(n != 0) {
                    if (s[i] == '(') n++;
                    else if (s[i] == ')') n--;
                    i++;
                }
                i--;
                n = Calculate(s.Substring(start, i - start));
                
            }
            else{
                n = 0;
                while (i<s.Length && Char.IsDigit(s[i]))
                   n = n*10 + s[i++] - '0';
                i--;
            }
            if(positive) result += n;
            else result -= n;
            n=0;
        }
        return result;
    }
}