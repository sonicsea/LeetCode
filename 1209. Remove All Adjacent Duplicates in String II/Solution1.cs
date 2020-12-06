public class Solution {
    public string RemoveDuplicates(string s, int k) {
        var stack = new Stack<int>();
        var chars = new List<char>();
        foreach(var c in s){
            if (chars.Count > 0 && chars.Last() == c){
               if (stack.Peek() == k - 1){
                   for(int i = 0; i < k-1; i++) {
                       chars.RemoveAt(chars.Count - 1);
                       stack.Pop();
                   }
               }
               else {
                   stack.Push(stack.Peek() + 1);
                   chars.Add(c);
               }
           }
           else{
                chars.Add(c);
                stack.Push(1);
           }
        }
        return new string(chars.ToArray());
    }
}