public class Solution {
    public int Calculate(string s) {
        Stack<int> stack = new Stack<int>();
        int sign = 1, result = 0;
        for(int i = 0; i < s.Length; i++){
            if (s[i] == ' ') continue;
            if (s[i] == '+') sign = 1;
            else if (s[i] == '-') sign = -1;
            else if (s[i] == '*'){
                int left = stack.Pop();
                i++;
                int right = GetNextNumber(s, ref i);
                stack.Push(left*right);
            } 
            else if (s[i] == '/'){
                int left = stack.Pop();
                i++;
                int right = GetNextNumber(s, ref i);
                stack.Push(left/right);
            }
            else stack.Push(sign * GetNextNumber(s, ref i));
        }
        while(stack.Count > 0) result+= stack.Pop();
        return result;
    }
    private int GetNextNumber(string s, ref int start){
        int result = 0;
        while(start < s.Length){
           if (s[start] == ' ') start++;
           else if (Char.IsDigit(s[start])) result = result*10 + s[start++] -'0';
           else {
               start--;
               break;
           }
        } 
       return result;
    }
}