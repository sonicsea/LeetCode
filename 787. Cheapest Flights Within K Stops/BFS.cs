public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K) {
        IList<IList<int[]>> graph = new List<IList<int[]>>();
        int minCost = int.MaxValue;
        for(int i = 0; i < n; i++) graph.Add(new List<int[]>());
        foreach(var f in flights) graph[f[0]].Add(new int[]{f[1], f[2]});
        var q = new Queue<int[]>();
        q.Enqueue(new int[]{src, 0});
        while(q.Any() && K >= 0){
            var cnt = q.Count;
            for(int i = 0; i < cnt; i++){
                var currentCity = q.Dequeue();
                foreach(var d in graph[currentCity[0]]){
                    var dstCost = d[1] + currentCity[1];
                    if (dstCost > minCost) continue;
                    if (d[0] == dst) minCost = Math.Min(minCost, dstCost);
                    else q.Enqueue(new int[]{d[0], dstCost});
                }
            }
            K--;
        }
        return minCost == int.MaxValue ? -1 : minCost;
    }
}