public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();
        StringBuilder sb = new StringBuilder();
        int start = 0; //track starting position in between each pair of "/"
        path += "/"; //Make sure the path ends with "/" so that the next for loop will exist correctly
        for(int i = 1; i < path.Length; i++){
            if (path[i]!='/') continue; //current portion continues
            
            string currentPortion = path.Substring(start+1, i - start-1);
            start = i;
            //ignore when multiple "/" next to each other or the current portion is "."
            if (string.IsNullOrEmpty(currentPortion) || currentPortion==".") continue; 
            
            if (currentPortion == ".."){
                if (stack.Count>0) stack.Pop();
            }
            else stack.Push("/"+currentPortion);
        }
        while(stack.Count>0) sb.Insert(0, stack.Pop());
        
        return sb.Length == 0 ? "/" : sb.ToString();
    }
}