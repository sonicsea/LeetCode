class Solution {
    static string[] Expand(string s){
        IList<string> result = new List<string>();
        List<string> temp = new List<string>();
        StringBuilder sb = new StringBuilder();
        
        int len = s.Length;
        for(int i = 0; i < len; i++){
            if (s[i] == '{') {
                i++;
                while(s[i] != '}'){
                    if (s[i] == ',') {
                        i++;
                        continue;
                    }
                    sb.Append(s[i++]);
                }
                temp.Add(sb.ToString());
                sb.Clear();
            }
            else temp.Add(s[i].ToString());
        }
        DFS(temp, 0, new StringBuilder(), result);
        string[] finalResult = result.ToArray();
        Array.Sort(finalResult);
        return finalResult;
    }
    static private void DFS(IList<string> current, int pos, StringBuilder sb, IList<string> result){
        if (sb.Length == current.Count)
            result.Add(sb.ToString());
        else{
            foreach(var c in current[pos]){
                sb.Append(c);
                DFS(current, pos+1, sb, result);
                sb.Length--;
            }
        }
    }
    static void Main() {
        IList<string> input = new List<string>{
            "d{e,f}{a,b,c}",
            "{a,b}d{e,f}",
            "{a,b,c}",
            "bca",
            "{a,b,c}d{e,f,g,h,i,j}{x,y}{z}",
            "ab{e,f}{g}"
        };
        
        foreach(var s in input){
            string[] temp = Expand(s);
            System.Console.WriteLine(String.Join(',',temp));
        }
    }
}