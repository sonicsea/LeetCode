public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        IList<IList<int>> graph = new List<IList<int>>();
        for(int i = 0; i < numCourses; i++) graph.Add(new List<int>());
        foreach(var p in prerequisites) graph[p[0]].Add(p[1]);
        IList<int> result = new List<int>();
        for(int i = 0; i < numCourses; i++)
            if (HasCycle(graph, i, new bool[numCourses], result)) return new int[]{};
        return result.ToArray();
    }
    private bool HasCycle(IList<IList<int>> graph, int current, bool[] visiting, IList<int> result){
        if (visiting[current]) return true;
        if (result.Contains(current)) return false;
        visiting[current] = true;
        foreach(var n in graph[current])
            if (HasCycle(graph, n, visiting, result)) return true;
        visiting[current] = false;
        result.Add(current);
        return false;
    }
}