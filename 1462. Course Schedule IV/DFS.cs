public class Solution {
    public IList<bool> CheckIfPrerequisite(int n, int[][] prerequisites, int[][] queries) {
        IList<IList<int>> graph = new List<IList<int>>();
        IList<bool> res = new List<bool>();
        int len = prerequisites.Length;
        int[,] dict = new int[n,n];
        
        for(int i = 0; i < n; i++)
            graph.Add(new List<int>());
        foreach(var p in prerequisites)
            graph[p[0]].Add(p[1]);
        foreach(var q in queries){
            res.Add(DFS(graph, q[0], q[1], dict));
        }
        return res;
    }
    private bool DFS(IList<IList<int>> graph, int current, int target,int[,] dict){
        if (current == target || dict[current,target] == 1) return true;
        else if (dict[current,target] == -1) return false;
        
        foreach(var n in graph[current])
            if (DFS(graph, n, target,dict)) {
                dict[n,target] = 1;
                return true;
            }
            else dict[n,target] = -1;
        return false;
    }
}