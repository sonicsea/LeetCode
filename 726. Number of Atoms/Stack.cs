public class Solution {
    public string CountOfAtoms(string formula) {
        SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
        Stack<string> stack = new Stack<string>();
        int len = formula.Length;
        int[] count = new int[len];
        int currentNum = 0;
        for(int i = 0; i < len; i++){
            count[i] = -1;
           if (Char.IsUpper(formula[i])){
              count[i] = 1;
              stack.Push(i.ToString()); 
           } 
            else if (Char.IsLower(formula[i])) count[i] = 0;
            else if (Char.IsDigit(formula[i])){
               currentNum = 0;
               while(i < len && Char.IsDigit(formula[i])) {
                    currentNum = currentNum*10 + (formula[i] - '0');
                    i++;
                }
                i--;
                if (stack.Count > 0 && stack.Peek() == ")"){
                    IList<string> temp = new List<string>();
                    stack.Pop(); //pop out the current ")"
                    while(stack.Count > 0 && stack.Peek() != "("){
                        int current = Convert.ToInt32(stack.Pop());
                        count[current] *= currentNum;
                        temp.Add(current.ToString());
                    }
                    stack.Pop(); //pop out the "("
                    foreach(var item in temp) stack.Push(item);
                }
                else {
                    int current = Convert.ToInt32(stack.Peek());
                    count[current] *= currentNum;
                }
            }
            else stack.Push(formula[i].ToString());
        }
        for(int i = 0; i < len; i++){
            if (count[i] > 0){
                string temp = formula[i].ToString();
                int currentCount = count[i];
                i++;
                while(i<len && count[i] == 0) temp += formula[i++];
                i--;
                if (dict.ContainsKey(temp)) dict[temp] += currentCount;
                else dict.Add(temp, currentCount);
            }
        }    
        StringBuilder sb = new StringBuilder();
        foreach(var key in dict.Keys){
            if (dict[key] == 1) sb.Append(key);
            else sb.Append(key+dict[key].ToString());
        }
        return sb.ToString();
    }
}