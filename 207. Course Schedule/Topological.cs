public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        IList<IList<int>> graph = new List<IList<int>>();
        for(int i = 0; i < numCourses; i++) graph.Add(new List<int>());
        foreach(var p in prerequisites) graph[p[0]].Add(p[1]);
        for(int i = 0; i < numCourses; i++)
            if (HasCycle(graph, i, new bool[numCourses])) return false;
        return true;
    }
    private bool HasCycle(IList<IList<int>> graph, int current, bool[] visiting){
        if (visiting[current]) return true;
        visiting[current] = true;
        foreach(var child in graph[current])
            if (HasCycle(graph, child, visiting)) return true;
        visiting[current] = false;
        return false;
    }
}