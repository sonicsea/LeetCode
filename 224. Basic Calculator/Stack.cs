public class Solution {
    public int Calculate(string s) {
        Stack<string> stack = new Stack<string>();
        StringBuilder currentNum = new StringBuilder();
        
        int result = 0;
        for(int i = s.Length - 1; i >= 0; i--){
            char c = s[i];
            if (c==' ') continue;
            if (Char.IsDigit(c)){
                currentNum.Insert(0,c);
                continue;
            }
            if (currentNum.Length > 0) {
                stack.Push(currentNum.ToString());
                currentNum.Clear();
            }
            if (c=='('){
                while(stack.Peek() != ")"){
                    result = int.Parse(stack.Pop());
                    if (stack.Peek() == ")") break;
                    string mathOperator = stack.Pop();
                    int right = int.Parse(stack.Pop());
                    
                    if (mathOperator == "+") {
                        result += right;
                    }
                    else {
                        result -= right;
                    }
                    if (stack.Peek() != ")") stack.Push(result.ToString());
                }
                stack.Pop();
                stack.Push(result.ToString());
            }
            else stack.Push(c.ToString());
        }
        if (currentNum.Length > 0) {
                stack.Push(currentNum.ToString());
                result = int.Parse(currentNum.ToString());
                currentNum.Clear();
            }
        while(stack.Count > 2){
                   result = int.Parse(stack.Pop());
                   string mathOperator = stack.Pop();
                    int right = int.Parse(stack.Pop());
                    if (mathOperator == "+") {
                        result += right;
                    }
                    else {
                        result -= right;
                    }
            stack.Push(result.ToString());
                }
        return result;
    }
}