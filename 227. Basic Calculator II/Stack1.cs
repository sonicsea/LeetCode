public class Solution {
    public int Calculate(string s) {
        Stack<int> stack = new Stack<int>();
        int result = 0, n = 0;
        char mathOperator = '+';
        for(int i = 0; i < s.Length; i++){
            if (Char.IsDigit(s[i])) n = n * 10 + (s[i] - '0');
            if (s[i]=='+' || s[i] == '-' || s[i] == '*' || s[i] == '/' || i == s.Length - 1){
                if (mathOperator =='+') stack.Push(n);
                else if (mathOperator == '-') stack.Push(-n);
                else if (mathOperator == '*') stack.Push(stack.Pop() * n);
                else stack.Push(stack.Pop() / n);
                mathOperator = s[i];
                n = 0;
            }
        }
        while(stack.Count > 0) result+=stack.Pop();
        return result;
    }
}