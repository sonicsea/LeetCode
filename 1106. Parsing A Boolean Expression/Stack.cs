public class Solution {
    public bool ParseBoolExpr(string expression) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, bool> dict =  new Dictionary<char, bool>();
        dict.Add('t', true);
        dict.Add('f', false);
        for(int i = 0; i < expression.Length; i++){
            if (expression[i] == 't' || expression[i] =='f' || expression[i] == '!' || expression[i] == '&' || expression[i] == '|')
                stack.Push(expression[i]);
            if (expression[i]==')') {
                bool NotResult = dict[stack.Pop()];
                bool AndResult = NotResult;
                bool OrResult = NotResult;
                //keep popping until the top item is a boolean operator
                while(stack.Count > 0 && stack.Peek() != '!' && stack.Peek() != '&' && stack.Peek() != '|'){
                    bool temp = dict[stack.Pop()];
                    AndResult = AndResult && temp;
                    OrResult = OrResult || temp;
                }
                
                char boolOperator = stack.Pop(); //Get current boolean operator
                
                if (boolOperator == '&') NotResult = AndResult; //repurpose "NotResult" variable
                else if (boolOperator == '|') NotResult = OrResult; //same comment as above
                else NotResult = !NotResult;
                
                stack.Push(NotResult ? 't' : 'f');
            }
                
        }
        return dict[stack.Pop()];
    }
}