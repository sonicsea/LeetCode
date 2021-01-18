public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        IList<IList<int[]>> graph = new List<IList<int[]>>();
        for(int i = 0; i < n; i++) graph.Add(new List<int[]>());
        foreach(var t in times) graph[t[0]-1].Add(new int[]{t[1], t[2]});
        var visited = new bool[n];
        var nodes = new Dictionary<int, int>();
        var list = new SortedSet<Tuple<int,int>>();
        nodes.Add(k, 0);
        int res = 0, current = k;
        while(true){
            foreach(var v in graph[current - 1]){
                if (visited[v[0] - 1]) continue;
                if (nodes.ContainsKey(v[0])) 
                    nodes[v[0]] = Math.Min(nodes[v[0]], nodes[current] + v[1]);
                else 
                    nodes.Add(v[0], nodes[current] + v[1]);
                list.RemoveWhere(element => element.Item2 == v[0]);
                list.Add(new Tuple<int,int>(nodes[v[0]], v[0]));
                res = list.Max.Item1;
            }
            visited[current - 1] = true;
            if (list.Any()) {
                current = list.Min.Item2;
                list.Remove(list.Min);
            }
            else break;
        }
        return nodes.Count == n ? res : -1;
    }
}