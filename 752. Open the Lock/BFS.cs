public class Solution {
    char[] nextDigit = new char[]{'1','2','3','4','5','6','7','8','9','0'};
    char[] prevDigit = new char[]{'9','0','1','2','3','4','5','6','7','8'};
    public int OpenLock(string[] deadends, string target) {
        int res = 0, levelNodes = 1;
        var visited = new HashSet<string>();
        foreach(var s in deadends) visited.Add(s);
        if (visited.Contains("0000") || visited.Contains(target)) return -1;
        var q = new Queue<string>();
        q.Enqueue("0000");
        while(q.Any()){
            for(int i = 0; i < levelNodes; i++){
                var current = q.Dequeue();
                if (current == target) return res;
                if (!visited.Contains(current)){
                    visited.Add(current);
                    PopulateNextLevel(current, q);
                }
            }
            res++;
            levelNodes = q.Count;
        }
        return -1;
    }
    private void PopulateNextLevel(string s, Queue<string> q){
        var sb = new StringBuilder(s);
        for(var i = 0; i < 4; i++){
            sb[i] = nextDigit[s[i]-'0'];
            q.Enqueue(sb.ToString());
            sb[i] = prevDigit[s[i]-'0'];
            q.Enqueue(sb.ToString());
            sb[i] = s[i];
        }
    }
}